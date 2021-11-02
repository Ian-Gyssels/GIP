using System;
using System.Windows.Forms;
using Business;
using DataAccess;

namespace Presentation
{
    public partial class NieuwForm : Form
    {
        #region velden
        private StartForm _mainMenuForm;
        private DienstregelingDA _dienstregelingDA;
        #endregion

        #region constructor
        public NieuwForm(StartForm mainMenuForm)
        {
            InitializeComponent();
            _mainMenuForm = mainMenuForm;

            _dienstregelingDA = new DienstregelingDA();

            vertrekTextBox.Text = "IEPER";

            VullLijst();

            aankomstTextBox.Text = "";
            afstandNumericUpDown.Value = 0;

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
        /// slaat de route op
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void opslaanButton_Click(object sender, EventArgs e)
        {
            String vertrekStation = vertrekTextBox.Text;
            int vertrekUur = (int)vertrekUurNumericUpDown.Value;
            int vertrekMinuut = (int)vertrekMinuutNumericUpDown.Value;
            String aankomst = aankomstTextBox.Text.ToUpper();
            int aankomstUur = (int)AankomstUurNumericUpDown.Value;
            int aankomstMinuut = (int)AankomstMinuutNumericUpDown.Value;
            int afstand = (int)afstandNumericUpDown.Value;
            String schemaString = "";
            int schema = -1;


            if (schemaComboBox.SelectedItem == null)
            {
                errorLabel.Text = "Gelieve een schema aan te duiden";
                errorLabel.Visible = true;
                return;
            }
            else
            {
                schemaString = schemaComboBox.SelectedItem.ToString();
            }

            if (schemaString == "Week")
            {
                schema = 1;
            }
            else if (schemaString == "Weekend")
            {
                schema = 0;
            }


            if (aankomst == "")
            {
                errorLabel.Text = "Aankomst kan niet leeg zijn";
                errorLabel.Visible = true;
                return;
            }
            if (afstand == 0)
            {
                errorLabel.Text = "Afstand mag niet 0 zijn";
                errorLabel.Visible = true;
                return;
            }

            Route nieuwRoute = new Route(0, vertrekUur, vertrekMinuut, aankomst, aankomstUur, aankomstMinuut, afstand, schema);

        Maak:;
            try
            {
                _dienstregelingDA.CreateRecord(nieuwRoute);
            }
            catch (Exception)
            {
                SqlErrorForm errorForm = new SqlErrorForm();
                this.Hide();
                errorForm.ShowDialog();
                this.Show();
                goto Maak;
            }


            this.Close();
        }
        #endregion

        /// <summary>
        /// toont alle stationsnamen
        /// </summary>
        private void VullLijst()
        {
        Uniek:;
            try
            {
                uniekeStationsListBox.DataSource = null;
                uniekeStationsListBox.DataSource = _dienstregelingDA.ReadUniekeStations();
            }
            catch (Exception)
            {
                SqlErrorForm errorForm = new SqlErrorForm();
                this.Hide();
                errorForm.ShowDialog();
                this.Show();
                goto Uniek;
            }
        }

        /// <summary>
        /// vult afstand en naam in van geselecteerde station
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uniekeStationsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(uniekeStationsListBox.SelectedItem != null)
            {
                aankomstTextBox.Text = uniekeStationsListBox.SelectedItem.ToString();
                try
                {
                    afstandNumericUpDown.Value = _dienstregelingDA.GetStationAfstand(aankomstTextBox.Text);
                }
                catch (Exception)
                {
                    SqlErrorForm errorForm = new SqlErrorForm();
                    this.Hide();
                    errorForm.ShowDialog();
                    VullLijst();
                    this.Show();
                }
            }
                
        }

        /// <summary>
        /// verwijderd de verbannen tekens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aankomstTextBox_TextChanged(object sender, EventArgs e)
        {
            String nieuw = aankomstTextBox.Text.Replace('"', '\0');

            String nieuw2 = nieuw.Replace('\'', '\0');

            String nieuw3 = nieuw2.Replace('`', '\0');

            aankomstTextBox.Text = nieuw3;
        }
    }
}
