using System;
using System.Windows.Forms;
using Business;
using DataAccess;

namespace Presentation
{
    public partial class AanpassenForm : Form
    {
        #region velden
        private Route _route;
        private DienstregelingDA _dienstregelingDA;
        #endregion

        #region constructor
        public AanpassenForm(Route route)
        {
            InitializeComponent();

            _dienstregelingDA = new DienstregelingDA();

            _route = route;

            vertrekTextBox.Text = "IEPER";
            vertrekUurNumericUpDown.Value = _route.VertrekUur;
            vertrekMinuutNumericUpDown.Value = _route.VertrekMinuut;
            aankomstTextBox.Text = _route.AankomstStation;
            AankomstUurNumericUpDown.Value = _route.AankomstUur; 
            AankomstMinuutNumericUpDown.Value = _route.AankomstMinuut;
            afstandNumericUpDown.Value = _route.Afstand;
            SchemaInstellen();

            returnButton.FlatStyle = FlatStyle.Flat;
            returnButton.FlatAppearance.BorderSize = 0;
        }
        #endregion

        #region buttons
        #pragma warning disable IDE1006 // Naming Styles
        private void returnButton_Click_1(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            this.Close();
        }

        /// <summary>
        /// staat de gewijzige gegevens op
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #pragma warning disable IDE1006 // Naming Styles
        private void opslaanButton_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            int id = _route.RitId;
            String vertrekStation = vertrekTextBox.Text;
            int vertrekUur = (int)vertrekUurNumericUpDown.Value;
            int vertrekMinuut = (int)vertrekMinuutNumericUpDown.Value;
            String aankomst = aankomstTextBox.Text;
            int aankomstUur = (int)AankomstUurNumericUpDown.Value;
            int aankomstMinuut = (int)AankomstMinuutNumericUpDown.Value;
            int afstand = (int)afstandNumericUpDown.Value;
            int schema = SchemaOmzetting();

            Route nieuwRoute = new Route(id, vertrekUur, vertrekMinuut, aankomst, aankomstUur, aankomstMinuut, afstand, schema);

        Opslaan:;
            try
            {
                _dienstregelingDA.UpdateRecord(nieuwRoute);
            } catch (Exception)
            {
                SqlErrorForm errorForm = new SqlErrorForm();
                this.Hide();
                errorForm.ShowDialog();
                this.Show();
                goto Opslaan;
            }
            

            this.Close();
        }
        #endregion

        #region schema
        private int SchemaOmzetting()
        {
            String schemaString = schemaComboBox.SelectedItem.ToString();
            int schema = -1;

            if (schemaString == "Week")
            {
                schema = 1;
            }
            else if (schemaString == "Weekend")
            {
                schema = 0;
            }
            return schema;
        }
    
        private void SchemaInstellen()
        {
            int route = _route.EnkelWeek;
            if(route == 1)
            {
                schemaComboBox.Text = "Week";
            }
            else
            {
                schemaComboBox.Text = "Weekend";
            }
        }
        #endregion

        /// <summary>
        /// wist verbannen tekens
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
