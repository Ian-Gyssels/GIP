using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Business;
using DataAccess;

namespace Presentation
{
    public partial class MainMenuForm : Form
    {
        #region velden
        private List<Route> _route;
        private DienstregelingDA _dienstregelingDA;
        private User _user;
        #endregion

        #region constructor
        public MainMenuForm()
        {
            InitializeComponent();

            datumLabel.Text = DatumToString(DateTime.Today);
            datumLabel.Location = new Point(108, 269);
            datumLabel.Left = (this.Width - datumLabel.Width) / 2;

            _route = new List<Route>();
            _dienstregelingDA = new DienstregelingDA();
            _user = null; //Niemand is ingelogd --> null

            Startdatum:;
            try
            {
                routesListBox.DataSource = _dienstregelingDA.ReadTable(IsWeekend(DateTime.Today));
            } catch (Exception)
            {
                SqlErrorForm sql = new SqlErrorForm();
                this.Hide();
                sql.ShowDialog();
                this.Show();
                goto Startdatum;
            }


            

        }
        #endregion

        #region buttons
        /// <summary>
        /// Opent de route in InfoForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void infoButton_Click(object sender, EventArgs e)
        {
        // route doorgeven aan infoForm
        InfoStart:;
            Route route = null;
            try
            {
                route = (Route)routesListBox.SelectedItem;
            } catch (Exception)
            {
                SqlErrorForm sql = new SqlErrorForm();
                this.Hide();
                sql.ShowDialog();
                this.Show();
                goto InfoStart;
            }
            
            InfoForm info = new InfoForm(route, _user);
            // huidige venster verbergen wanneer nieuw venster toont
            this.Hide();
            info.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Opent de route in UpdateForm voor aanpassingen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {
        EditStart:;
            Route route = null;
            try
            {
                route = (Route)routesListBox.SelectedItem;
            }
            catch (Exception)
            {
                SqlErrorForm sql = new SqlErrorForm();
                this.Hide();
                sql.ShowDialog();
                this.Show();
                goto EditStart;
            }

            UpdateForm update = new UpdateForm(route);
            // huidige venster verbergen wanneer nieuw venster toont
            this.Hide();
            update.ShowDialog();
            this.Show();
            zoekButton_Click(sender, e);
        }

        /// <summary>
        /// opent nieuwForm om een nieuwe route toe te voegen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nieuwButton_Click(object sender, EventArgs e)
        {
            NieuwForm nieuw = new NieuwForm(this);
            this.Hide();
            nieuw.ShowDialog();
            this.Show();
            zoekButton_Click(sender, e);
        }

        /// <summary>
        /// opent verwijderform om zeker te zijn dat je de route wil verwijderen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void verwijderButton_Click(object sender, EventArgs e)
        {
        VerwijderStart:;
            Route route = null;
            try
            {
                route = (Route)routesListBox.SelectedItem;
            }
            catch (Exception)
            {
                SqlErrorForm sql = new SqlErrorForm();
                this.Hide();
                sql.ShowDialog();
                this.Show();
                goto VerwijderStart;
            }

            VerwijderForm verwijder = new VerwijderForm(route);
            verwijder.ShowDialog();
            zoekButton_Click(sender, e);
        }

        /// <summary>
        /// Past de filters toe om de gevraagde routes te tonen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zoekButton_Click(object sender, EventArgs e)
        {

            // variabelen
            DateTime datum = datumkiezerMonthCalender.SelectionRange.Start;
            int uur = 0;
            int min = 0;
            String aankomst = naarTextBox.Text; ;
            int schema = SchemaInstellen(IsWeekend(datum));
            String sql = "";

            // datumLabel juist instellen
            datumLabel.Text = DatumToString(datum);
            datumLabel.Left = (this.Width - datumLabel.Width) / 2;

            // uur instellen
            if (tijdFilterCheckBox.Checked)
            {
                if (vertrekRadioButton.Checked)
                {
                    uur = (int)vertrekUurNumericUpDown.Value;
                    min = (int)vertrekMinutenNumericUpDown.Value;
                }
                else
                {
                    uur = (int)aankomstUurNumericUpDown.Value;
                    min = (int)aankomstMinuutNumericUpDown.Value;
                }
            }

        ZoekStart:;
            //code voor filter instellen
            if (naamCheckBox.Checked) // zoeken op naam
            {
                if (tijdFilterCheckBox.Checked) // zoeken op naam en uur
                {
                    if (vertrekRadioButton.Checked) // naam en vertrekuur
                    {
                        if (aankomst != "")
                        {
                            sql = $"select * from tbldienstregeling where `Schema`={schema} AND (`VertrekUur` = {uur}) AND `AankomstStation` LIKE '%{aankomst.ToUpper()}%' AND (`VertrekMinuut` BETWEEN {min - 20} And {min + 20}) order by `VertrekUur`;";
                            routesListBox.DataSource = null;
                            try
                            {
                                routesListBox.DataSource = _dienstregelingDA.FilterTable(sql);
                            }
                            catch (Exception)
                            {
                                SqlErrorForm sqlForm = new SqlErrorForm();
                                this.Hide();
                                sqlForm.ShowDialog();
                                this.Show();
                                goto ZoekStart;
                            }
                        }
                    }
                    else // naam en aankomstuur
                    {
                        if (aankomst != "")
                        {
                            sql = $"select * from tbldienstregeling where `Schema`={schema} AND (`AankomstUur` = {uur}) AND `AankomstStation` LIKE '%{aankomst.ToUpper()}%' AND (`AankomstMinuut` BETWEEN {min - 20} And {min + 20}) order by `VertrekUur`;";
                            routesListBox.DataSource = null;
                            try
                            {
                                routesListBox.DataSource = _dienstregelingDA.FilterTable(sql);
                            }
                            catch (Exception)
                            {
                                SqlErrorForm sqlForm = new SqlErrorForm();
                                this.Hide();
                                sqlForm.ShowDialog();
                                this.Show();
                                goto ZoekStart;
                            }
                        }
                    }
                }
                else // zoeken enkel op naam
                {
                    sql = $"select * from tbldienstregeling where `Schema`={schema} AND `AankomstStation` LIKE '%{aankomst.ToUpper()}%' order by `VertrekUur`;";
                    routesListBox.DataSource = null;
                    try
                    {
                        routesListBox.DataSource = _dienstregelingDA.FilterTable(sql);
                    }
                    catch (Exception)
                    {
                        SqlErrorForm sqlForm = new SqlErrorForm();
                        this.Hide();
                        sqlForm.ShowDialog();
                        this.Show();
                        goto ZoekStart;
                    }
                }
            }
            else // zoeken zonder naam
            {
                if (tijdFilterCheckBox.Checked) // zoeken enkel uur
                {
                    if (vertrekRadioButton.Checked) // vertrekuur
                    {
                        sql = $"select * from tbldienstregeling where `Schema`={schema} AND (`VertrekUur` = {uur}) AND (`VertrekMinuut` BETWEEN {min - 20} And {min + 20}) order by `VertrekUur`;";
                        routesListBox.DataSource = null;
                    ZoekStartVertrek:;
                        try
                        {
                            routesListBox.DataSource = _dienstregelingDA.FilterTable(sql);
                        }
                        catch (Exception)
                        {
                            SqlErrorForm sqlForm = new SqlErrorForm();
                            this.Hide();
                            sqlForm.ShowDialog();
                            this.Show();
                            goto ZoekStartVertrek;
                        }
                    }
                    else // aankomstuur
                    {
                        sql = $"select * from tbldienstregeling where `Schema`={schema} AND (`AankomstUur` = {uur}) AND (`AankomstMinuut` BETWEEN {min - 20} And {min + 20}) order by `VertrekUur`;";
                        routesListBox.DataSource = null;
                    ZoekStartAankomst:;
                        try
                        {
                            routesListBox.DataSource = _dienstregelingDA.FilterTable(sql);
                        }
                        catch (Exception)
                        {
                            SqlErrorForm sqlForm = new SqlErrorForm();
                            this.Hide();
                            sqlForm.ShowDialog();
                            this.Show();
                            goto ZoekStartAankomst;
                        }
                    }
                }
                else // niets actief --> startwaarde opnieuw
                {
                    routesListBox.DataSource = null;
                    try
                    {
                        routesListBox.DataSource = _dienstregelingDA.ReadTable(IsWeekend(datum));
                    }
                    catch (Exception)
                    {
                        SqlErrorForm sqlForm = new SqlErrorForm();
                        this.Hide();
                        sqlForm.ShowDialog();
                        this.Show();
                        goto ZoekStart;
                    }
                }

            }
            // einde van de IF
        }

        /// <summary>
        /// Open LoginForm als niemand is ingelogd
        /// opent UserInfoForm als er een gebruiker is ingelogd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userPictureBox_Click(object sender, EventArgs e)
        {
            if (_user == null)
            {
                LoginForm login = new LoginForm(this);
                login.ShowDialog();
            }
            else
            {
                UserInfoForm userInfo = new UserInfoForm(_user, this);
                userInfo.ShowDialog();
                zoekButton_Click(sender, e);
            }
        }
        #endregion

        #region radioButtons
        private void vertrekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (vertrekRadioButton.Checked)
            {
                aankomstRadioButton.Checked = false;

                vertrekUurNumericUpDown.Enabled = true;
                vertrekMinutenNumericUpDown.Enabled = true;
                aankomstUurNumericUpDown.Enabled = false;
                aankomstMinuutNumericUpDown.Enabled = false;

            }
        }

#pragma warning disable IDE1006 // Naming Styles
        private void aankomstRadioButton_CheckedChanged(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            if (aankomstRadioButton.Checked)
            {
                vertrekRadioButton.Checked = false;


                vertrekUurNumericUpDown.Enabled = false;
                vertrekMinutenNumericUpDown.Enabled = false;
                aankomstUurNumericUpDown.Enabled = true;
                aankomstMinuutNumericUpDown.Enabled = true;
            }
        }

#pragma warning disable IDE1006 // Naming Styles
        /// <summary>
        /// Enabled of Disabled de tijdsfilter aan de hand van de status van de checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tijdFilterCheckBox_CheckedChanged(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            if (tijdFilterCheckBox.Checked)
            {
                vertrekRadioButton.Enabled = true;
                aankomstRadioButton.Enabled = true;

                if (vertrekRadioButton.Checked)
                {
                    vertrekUurNumericUpDown.Enabled = true;
                    vertrekMinutenNumericUpDown.Enabled = true;
                }
                else
                {
                    aankomstUurNumericUpDown.Enabled = true;
                    aankomstMinuutNumericUpDown.Enabled = true;
                }
            }
            else
            {
                vertrekRadioButton.Enabled = false;
                aankomstRadioButton.Enabled = false;
                vertrekUurNumericUpDown.Enabled = false;
                vertrekMinutenNumericUpDown.Enabled = false;
                aankomstUurNumericUpDown.Enabled = false;
                aankomstMinuutNumericUpDown.Enabled = false;
            }
        }

        private void naamCheckBox_CheckedChanged(object sender, EventArgs e)

        {
            if (naamCheckBox.Checked)
            {
                naarTextBox.Enabled = true;
            }
            else
            {
                naarTextBox.Enabled = false;
            }
        }
        #endregion

        /// <summary>
        /// Zet de datum om naar String 
        /// bv. Maandag 1 Januari
        /// </summary>
        /// <param name="datum"></param>
        /// <returns>dag nummer maand in String</returns>
        private String DatumToString(DateTime datum)
        {
            String dag = datum.ToString("dddd");
            String dagNummer = datum.Day.ToString();
            String maand = datum.ToString("MMMM");
            return $"{dag} {dagNummer} {maand}";
        }

        /// <summary>
        /// Conntroleerd als de datum zich in het weekend bevind
        /// </summary>
        /// <param name="datum"></param>
        /// <returns></returns>
        public bool IsWeekend(DateTime datum)
        {
            if (datum.DayOfWeek == DayOfWeek.Saturday || datum.DayOfWeek == DayOfWeek.Sunday)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int SchemaInstellen(bool schema)
        {
            if (schema)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }

        /// <summary>
        /// stelt de gebruiker in na het inloggen
        /// </summary>
        /// <param name="user"></param>
        public void GebruikerInstellen(User user)
        {
            _user = user;
            if(_user != null) // als er iemand ingelogd is
            {
                if (_user.IsAdmin) // als de gebruiker een admin is
                {
                    verwijderButton.Visible = true;
                    nieuwButton.Visible = true;
                    EditButton.Visible = true;
                }
                else // als de gebruiker geen admin is
                {
                    verwijderButton.Visible = false;
                    nieuwButton.Visible = false;
                    EditButton.Visible = false;
                }
                
            }
            else // niemand ingelogd
            {
                verwijderButton.Visible = false;
                nieuwButton.Visible = false;
                EditButton.Visible = false;
            }
        }

        private void naarTextBox_TextChanged(object sender, EventArgs e)
        {
            String nieuw = naarTextBox.Text.Replace('"', '\0');

            String nieuw2 = nieuw.Replace('\'', '\0');

            String nieuw3 = nieuw2.Replace('`', '\0');

            naarTextBox.Text = nieuw3;
           
        }
    }
}
