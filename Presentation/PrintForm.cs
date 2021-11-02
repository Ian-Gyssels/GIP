using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DataAccess;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using MySql.Data.MySqlClient;


namespace Presentation
{
    public partial class PrintForm : Form
    {

        #region velden
        private GebruikersDA _gebruikersDA;
        private DienstregelingDA _dienstregelingDA;

        private List<String> _filterRoutes;
        private List<String> _alleFilterRoutes;
        #endregion

        #region constructor
        public PrintForm()
        {
            InitializeComponent();

            // zet beide pannels op de juiste plaats bij opstarten
            gebruikerPannel.Location = new Point(0, 28);
            stationPanel.Location = new Point(0, 28);

            // items initialiseren
            _gebruikersDA = new GebruikersDA();
            _dienstregelingDA = new DienstregelingDA();
            _alleFilterRoutes = new List<String>();
            _filterRoutes = new List<String>();

            // routeFilter instellen
            _alleFilterRoutes = _dienstregelingDA.ReadUniekeStations();
            alleStationsListBox.DataSource = null;
            alleStationsListBox.DataSource = _alleFilterRoutes;

            // adminComboBox default waarde
            adminComboBox.Text = "Nee";
        }
        #endregion

        #region toolstrip
        /// <summary>
        /// sluit deze form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // gebruikersToolstrip
        private void alleGebruikersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gebruikerPannel.Visible = true;
            stationPanel.Visible = false;
           
            // alle checkboxes activeren
            gebruikersnaamCheckBox.Checked = true;
            emailCheckBox.Checked = true;
            adminCheckBox.Checked = true;
            geboortedatumCheckBox.Checked = true;
        }

        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gebruikerPannel.Visible = true;
            stationPanel.Visible = false;

            // alle checkboxes deactiveren zodat je leeg begint
            gebruikersnaamCheckBox.Checked = false;
            emailCheckBox.Checked = false;
            adminCheckBox.Checked = false;
            geboortedatumCheckBox.Checked = false;
        }
        // stationsToolstrip
        private void alleStationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stationPanel.Visible = true;
            gebruikerPannel.Visible = false;

            vertrekuurCheckBox.Checked = true;
            aankomststationCheckBox.Checked = true;
            aankomstuurCheckBox.Checked = true;
            schemaCheckBox.Checked = true;
            afstandCheckBox.Checked = true;
        }

        private void filterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            stationPanel.Visible = true;
            gebruikerPannel.Visible = false;

            vertrekuurCheckBox.Checked = false;
            aankomststationCheckBox.Checked = false;
            aankomstuurCheckBox.Checked = false;
            schemaCheckBox.Checked = false;
            afstandCheckBox.Checked = false; 
        }
        #endregion

        #region gebruiker
        private void gebrfilterCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (gebrfilterCheckbox.Checked) { gebruikersnaamTextBox.Enabled = true; }
            else { gebruikersnaamTextBox.Enabled = false; }
        }

        private void geboorteFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (geboorteFilterCheckBox.Checked)
            {
                vanafDateTimePicker.Enabled = true;
                totDateTimePicker.Enabled = true;
            }
            else
            {
                vanafDateTimePicker.Enabled = false;
                totDateTimePicker.Enabled = false;
            }
        }

        private void adminFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (adminFilterCheckBox.Checked)
            {
                adminComboBox.Enabled = true;
            }
            else
            {
                adminComboBox.Enabled = false;
            }
        }

        /// <summary>
        /// controlleerd welke velden er moeten getoond worden en welke filters die er 
        /// toegepast worden om zo een pdf document te maken
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gebruikerPDFButton_Click(object sender, EventArgs e)
        {
            gebErrorLabel.Visible = false;

            // controle of datums in juiste volgorde staan om filter toe te passen
            if (geboorteFilterCheckBox.Checked)
            {
                DateTime t1 = vanafDateTimePicker.Value;
                DateTime t2 = totDateTimePicker.Value;
                if (t2 < t1)
                {
                    gebErrorLabel.Visible = true;
                    gebErrorLabel.Text = "'Tot datum' is later dan 'van datum'.";
                    return;
                }
            }


            int aantal = 0;

            // pad om op te slaan 
            String path = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF document (*.pdf)|*.pdf";
            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
            {
                path = sfd.FileName;
            }
            else
            {
                return;
            }


            Document doc = new Document(PageSize.A4); // nieuw doc maken

            //breedte van de cellen en titels (waarden)
            List<float> br = new List<float>();
            List<String> ttl = new List<string>();
            // controlleren welke checkboxes zijn aangevinkt
            if (gebruikersnaamCheckBox.Checked) { aantal++; br.Add(2.5f); ttl.Add("Gebruikersnaam"); }
            if (emailCheckBox.Checked) { aantal++; br.Add(3f); ttl.Add("Email"); }
            if (adminCheckBox.Checked) { aantal++; br.Add(1f); ttl.Add("Is Admin"); }
            if (geboortedatumCheckBox.Checked) { aantal++; br.Add(2.5f); ttl.Add("Geboortedatum"); }
            float[] widths = br.ToArray();

            if (aantal > 0)
            {
                PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
            }
            else
            {
                gebErrorLabel.Visible = true;
                gebErrorLabel.Text = "Kies minstens 1 veld om een pdf te kunnen maken";
                return;
            }
            doc.Open();

            // titel en subtitel
            Chunk titel = new Chunk("Gebruikers", FontFactory.GetFont("Arial", 40));

            String gebr = gebruikersnaamTextBox.Text;
            String dt1 = vanafDateTimePicker.Value.ToString("yyyy-MM-dd");
            String dt2 = totDateTimePicker.Value.ToString("yyyy-MM-dd");
            String subttl = "\n Filters: ";
            if (gebrfilterCheckbox.Checked)
            {
                subttl += $"gebruikersnaam = '{gebr}',\n ";
            }
            if (geboorteFilterCheckBox.Checked)
            {
                subttl += $"geboortedatum tussen {dt1} en {dt2},\n ";
            }
            if (adminFilterCheckBox.Checked)
            {
                subttl += $"gebruiker is administrator: {adminComboBox.Text}\n ";
            }
            if (!gebrfilterCheckbox.Checked && !geboorteFilterCheckBox.Checked && !adminFilterCheckBox.Checked)
            {
                subttl += "'geen'";
            }
            Chunk subtitel = new Chunk(subttl, FontFactory.GetFont("Verdana", 15));
            Paragraph p = new Paragraph();
            p.Add(titel);
            p.Add(subtitel);
            doc.Add(p);

            // tabel
            PdfPTable table = new PdfPTable(aantal);
            // breedte van de cellen
            table.SetWidths(widths);
            table.HorizontalAlignment = 1; //centreren
            table.SpacingBefore = 30;

            // titelcellen
            foreach (String t in ttl)
            {
                Phrase ph = (new Phrase(t));
                ph.Font.SetStyle("bold");
                PdfPCell cell = new PdfPCell(ph);
                cell.HorizontalAlignment = 1;

                table.AddCell(cell);
            }

            // informatie uit database
            String connString = "server=localhost;user id=root;database=gip2";
            MySqlConnection mySqlConnection = new MySqlConnection(connString);
            String sql = "";

            int admInt = adminComboBox.Text == "Ja" ? 1 : 0;
            // alle soorten mogelijkheden met filters
            if (!gebrfilterCheckbox.Checked && !geboorteFilterCheckBox.Checked && !adminFilterCheckBox.Checked)
            {
                sql = $"select * from tblgebruikers;";
            }
            else
            {
                if (gebrfilterCheckbox.Checked)
                {
                    if (geboorteFilterCheckBox.Checked && adminFilterCheckBox.Checked)
                    {
                        sql = $"select * from tblgebruikers where `Username` like '%{gebr}%'" +
                            $" and `GeboorteDatum` between '{dt1}' and '{dt2}' and `IsAdmin` = {admInt};";
                    }
                    else if (geboorteFilterCheckBox.Checked)
                    {
                        sql = $"select * from tblgebruikers where `Username` like '%{gebr}%' " +
                            $"and `GeboorteDatum` between '{dt1}' and '{dt2}';";

                    }
                    else if (adminFilterCheckBox.Checked)
                    {
                        sql = $"select * from tblgebruikers where `Username` like '%{gebr}%' " +
                            $"and `IsAdmin` = {admInt};";
                    }
                    else
                    {
                        sql = $"select * from tblgebruikers where `Username` like '%{gebr}%';";
                    }
                }
                else if (geboorteFilterCheckBox.Checked)
                {
                    if (adminFilterCheckBox.Checked)
                    {
                        // gebo adm
                        sql = $"select * from tblgebruikers where `GeboorteDatum` " +
                            $"between '{dt1}' and '{dt2}' and `IsAdmin` = {admInt};";
                    }
                    else
                    {
                        sql = $"select * from tblgebruikers where `GeboorteDatum` between '{dt1}' and '{dt2}' ;";
                        // gebo
                    }
                }
                else if (adminFilterCheckBox.Checked)
                {
                    sql = $"select * from tblgebruikers where `IsAdmin` = {admInt};";
                    // adm
                }
            }


            MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);

            mySqlConnection.Open();

            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read() == true)
            {
                if (gebruikersnaamCheckBox.Checked) { table.AddCell(mySqlDataReader["Username"].ToString()); }
                if (emailCheckBox.Checked) { table.AddCell(mySqlDataReader["Emai"].ToString()); }
                if (adminCheckBox.Checked)
                {
                    bool b = Convert.ToBoolean(mySqlDataReader["IsAdmin"]); // probleem
                    string ad = b ? "X" : "";
                    Phrase adm = (new Phrase(ad));
                    PdfPCell cellAdm = new PdfPCell(adm);
                    cellAdm.HorizontalAlignment = 1;

                    table.AddCell(cellAdm);

                }
                if (geboortedatumCheckBox.Checked) { table.AddCell(mySqlDataReader["GeboorteDatum"].ToString()); }
            }

            doc.Add(table);
            doc.Close();

            MessageBox.Show("Uw pdf is klaar");
        }
        #endregion

        #region routes
        private void filterNaamCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (filterNaamCheckBox.Checked)
            {
                alleStationsListBox.Enabled = true;
                FilterStationListBox.Enabled = true;
                verwijderButton.Enabled = true;
                toevoegenButton.Enabled = true;
            }
            else
            {
                alleStationsListBox.Enabled = false;
                FilterStationListBox.Enabled = false;
                verwijderButton.Enabled = false;
                toevoegenButton.Enabled = false;
            }
        }

        private void toevoegenButton_Click(object sender, EventArgs e)
        {
            if (_alleFilterRoutes.Count > 0)
            {
                try
                {
                    _filterRoutes.Add(alleStationsListBox.SelectedItem.ToString());
                    _alleFilterRoutes.Remove(alleStationsListBox.SelectedItem.ToString());
                }
                catch
                {

                }

            }

            alleStationsListBox.DataSource = null;
            FilterStationListBox.DataSource = null;
            alleStationsListBox.DataSource = _alleFilterRoutes;
            FilterStationListBox.DataSource = _filterRoutes;
        }

        private void verwijderButton_Click(object sender, EventArgs e)
        {
            if (_filterRoutes.Count > 0)
            {
                try
                {
                    _alleFilterRoutes.Add(FilterStationListBox.SelectedItem.ToString());
                    _filterRoutes.Remove(FilterStationListBox.SelectedItem.ToString());
                }
                catch
                {

                }
            }

            _alleFilterRoutes.Sort();
            _filterRoutes.Sort();

            alleStationsListBox.DataSource = null;
            FilterStationListBox.DataSource = null;
            alleStationsListBox.DataSource = _alleFilterRoutes;
            FilterStationListBox.DataSource = _filterRoutes;
        }

        /// <summary>
        /// controlleerd welke velden er moeten getoond worden 
        /// en welke stations moeten getoond worden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stationPDFButton_Click(object sender, EventArgs e)
        {
            int aantal = 0;
            stErrorLabel.Visible = false;

            // pad om op te slaan
            String path = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF document (*.pdf)|*.pdf";
            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
            {
                path = sfd.FileName;
            }
            else
            {
                return;
            }


            //breedte van de cellen en titels (waarden)
            List<float> br = new List<float>();
            List<String> ttl = new List<string>();
            // controlleren welke checkboxes zijn aangevinkt
            if (vertrekuurCheckBox.Checked) { aantal++; br.Add(2f); ttl.Add("Vertrekuur"); }
            if (aankomststationCheckBox.Checked) { aantal++; br.Add(3f); ttl.Add("Aankomst"); }
            if (aankomstuurCheckBox.Checked) { aantal++; br.Add(2f); ttl.Add("Aankomstuur"); }
            if (afstandCheckBox.Checked) { aantal++; br.Add(1f); ttl.Add("#km"); }
            if (schemaCheckBox.Checked) { aantal++; br.Add(1.5f); ttl.Add("schema"); }
            float[] widths = br.ToArray();


            Document doc = new Document(PageSize.A4); // nieuw doc maken

            if (aantal > 0)
            {
                PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
            }
            else
            {
                stErrorLabel.Visible = true;
                stErrorLabel.Text = "Kies minstens 1 veld om een pdf te kunnen maken";
                return;
            }

            doc.Open();

            Chunk titel = new Chunk("Dienstregeling vanuit Ieper", FontFactory.GetFont("Arial", 40));

            // stations toevoegen in filter paragraaf
            String stations = "";
            if (filterNaamCheckBox.Checked && FilterStationListBox.Items.Count != 0)
            {

                int aant = 0;

                foreach (String s in FilterStationListBox.Items)
                {
                    if (aant == 0)
                    {
                        stations += $"'{s}'";
                        aant++;
                    }
                    else
                    {
                        stations += $", '{s}'";
                    }

                }

                Chunk subtitel = new Chunk($"  \n \n filter station op: {stations}", FontFactory.GetFont("Verdana", 13));
                Paragraph p = new Paragraph();
                p.Add(titel);
                p.Add(subtitel);
                doc.Add(p);
            }
            else
            {
                Chunk subtitel = new Chunk(" \n filter station op:  'geen'", FontFactory.GetFont("Verdana", 15));
                Paragraph p = new Paragraph();
                p.Add(titel);
                p.Add(subtitel);
                doc.Add(p);
            }



            PdfPTable table = new PdfPTable(aantal);
            // breedte van de cellen
            table.SetWidths(widths);
            table.HorizontalAlignment = 1; //centreren
            table.SpacingBefore = 30;

            // titelcellen
            foreach (String t in ttl)
            {
                Phrase ph = (new Phrase(t));
                ph.Font.SetStyle("bold");
                PdfPCell cell = new PdfPCell(ph);
                cell.HorizontalAlignment = 1;

                table.AddCell(cell);
            }

            // informatie uit database
            String connString = "server=localhost;user id=root;database=gip2";
            MySqlConnection mySqlConnection = new MySqlConnection(connString);

            String sql = "";

            if (filterNaamCheckBox.Checked && FilterStationListBox.Items.Count != 0)
            {

                sql = $"select * from tbldienstregeling where `AankomstStation` in({stations});";
            }
            else
            {
                sql = $"select * from tbldienstregeling;";
            }

            MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);

            mySqlConnection.Open();

            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read() == true)
            {
                if (vertrekuurCheckBox.Checked)
                {
                    int vm = (int)mySqlDataReader["VertrekMinuut"];
                    int vu = (int)mySqlDataReader["VertrekUur"];
                    string vertrekmin = vm < 10 ? "0" + vm.ToString() : vm.ToString();
                    string vertrekuur = vu < 10 ? "0" + vu.ToString() : vu.ToString();
                    table.AddCell($"{vertrekuur}:{vertrekmin}");
                }
                if (aankomststationCheckBox.Checked) { table.AddCell(mySqlDataReader["AankomstStation"].ToString()); }
                if (aankomstuurCheckBox.Checked)
                {
                    int am = (int)mySqlDataReader["AankomstMinuut"];
                    int au = (int)mySqlDataReader["AankomstUur"];
                    string aankomstmin = am < 10 ? "0" + am.ToString() : am.ToString();
                    string aankomstuur = au < 10 ? "0" + au.ToString() : au.ToString();
                    table.AddCell($"{aankomstuur}:{aankomstmin}");
                }
                if (afstandCheckBox.Checked) { table.AddCell(mySqlDataReader["Afstand"].ToString()); }
                if (schemaCheckBox.Checked)
                {
                    int schema = (int)mySqlDataReader["Schema"];
                    String sc = schema == 1 ? "Week" : "Weekend";
                    table.AddCell(sc);
                }

            }
            mySqlConnection.Close();
            doc.Add(table);
            doc.Close();


         
            MessageBox.Show("Uw pdf is klaar");
        }
        #endregion

    }
}
