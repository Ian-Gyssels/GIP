using System;
using System.Windows.Forms;
using DataAccess;
using Business;

namespace Presentation
{
    public partial class OpgeslagenForm : Form
    {
        #region velden
        private OpgeslagenDA _opgeslagenDA;
        private User _user;
        #endregion

        #region constructor
        public OpgeslagenForm(User user)
        {
            InitializeComponent();

            _opgeslagenDA = new OpgeslagenDA();
            _user = user;

            // toont wijzig en verwijder als gebruiker admin is
            if (_user.IsAdmin)
            {
                wijzigButton.Visible = true;
                verwijderButton.Visible = true;
            }


            opgeslagenListBox.DataSource = null;
        Read:;
            try
            {
                opgeslagenListBox.DataSource = _opgeslagenDA.ReadTable(_user.GebruikersID);
            }
            catch (Exception)
            {
                SqlErrorForm sql = new SqlErrorForm();
                this.Hide();
                sql.ShowDialog();
                this.Show();
                goto Read;
            }


            returnButton.FlatStyle = FlatStyle.Flat;
            returnButton.FlatAppearance.BorderSize = 0;
        }
        #endregion

        #region buttons
        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// opent infoform voor geselecteerde opgeslagen route
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void infoButton_Click(object sender, EventArgs e)
        {
            if(opgeslagenListBox.Items.Count != 0)
            {
            InfoStart:;
                Route route = null;
                try
                {
                    route = (Route)opgeslagenListBox.SelectedItem;
                }
                catch (Exception)
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

            opgeslagenListBox.DataSource = null;
        Read:;
            try
            {
                opgeslagenListBox.DataSource = _opgeslagenDA.ReadTable(_user.GebruikersID);
            }
            catch (Exception)
            {
                SqlErrorForm sql = new SqlErrorForm();
                this.Hide();
                sql.ShowDialog();
                this.Show();
                goto Read;
            }
        }

        /// <summary>
        /// opend wijzigForm voor geselecteerde opgeslagen route
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wijzigButton_Click(object sender, EventArgs e)
        {
            if (opgeslagenListBox.Items.Count != 0)
            {
            EditStart:;
                Route route = null;
                try
                {
                    route = (Route)opgeslagenListBox.SelectedItem;
                }
                catch (Exception)
                {
                    SqlErrorForm sql = new SqlErrorForm();
                    this.Hide();
                    sql.ShowDialog();
                    this.Show();
                    goto EditStart;
                }
                AanpassenForm update = new AanpassenForm(route);
                // huidige venster verbergen wanneer nieuw venster toont
                this.Hide();
                update.ShowDialog();
                this.Show();

                opgeslagenListBox.DataSource = null;
            Read:;
                try
                {
                    opgeslagenListBox.DataSource = _opgeslagenDA.ReadTable(_user.GebruikersID);
                }
                catch (Exception)
                {
                    SqlErrorForm sql = new SqlErrorForm();
                    this.Hide();
                    sql.ShowDialog();
                    this.Show();
                    goto Read;
                }
            }
        }

        /// <summary>
        /// verwijderd opgeslagen route
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void verwijderButton_Click(object sender, EventArgs e)
        {
            if (opgeslagenListBox.Items.Count != 0)
            {
            VerwijderStart:;
                Route route = null;
                try
                {
                    route = (Route)opgeslagenListBox.SelectedItem;
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

                opgeslagenListBox.DataSource = null;
            Read:;
                try
                {
                    opgeslagenListBox.DataSource = _opgeslagenDA.ReadTable(_user.GebruikersID);
                }
                catch (Exception)
                {
                    SqlErrorForm sql = new SqlErrorForm();
                    this.Hide();
                    sql.ShowDialog();
                    this.Show();
                    goto Read;
                }
            } 
        }
        #endregion
    }
}
