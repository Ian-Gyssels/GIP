using System;
using System.Drawing;
using System.Windows.Forms;
using Business;
using DataAccess;

namespace Presentation
{
    public partial class InfoForm : Form
    {
        #region velden
        private OpgeslagenDA _opgeslagenDA;
        private Route _route;
        private User _user = null;

        private Bitmap _toevoegen;
        private Bitmap _verwijder;
        private bool _toegevoegd;
        #endregion

        #region constructor
        public InfoForm(Route route, User user)
        {
            InitializeComponent();

            _opgeslagenDA = new OpgeslagenDA();
            _route = route;
            _user = user;

            _toevoegen = Properties.Resources.toevoegen;
            _verwijder = Properties.Resources.verwijder;
            if(_user != null)
            {
                int id = _opgeslagenDA.ReadOpgeslagenID(_user.GebruikersID, _route.RitId);
                _toegevoegd = id != (-1);
            }
            

            if (!_toegevoegd)
            {
                favoPictureBox.Image = _toevoegen;
                opslaanToolTip.SetToolTip(favoPictureBox, "Opslaan");
            }else
            {
                favoPictureBox.Image = _verwijder;
                opslaanToolTip.SetToolTip(favoPictureBox, "Niet meer opslaan");
            }


            if (_user != null)
            {
                favoPictureBox.Visible = true;
            }

            vertrekTextBox.Text = "IEPER";
            vertrekUurTextBox.Text = UurNotatie(_route.VertrekUur, _route.VertrekMinuut);
            aankomstTextBox.Text = _route.AankomstStation;
            AankomstUurTextBox.Text = UurNotatie(_route.AankomstUur, _route.AankomstMinuut);
            schemaTextBox.Text = SchemaNotatie(_route.EnkelWeek);

            returnButton.FlatStyle = FlatStyle.Flat;
            returnButton.FlatAppearance.BorderSize = 0;
        }
        #endregion

        #region buttons
#pragma warning disable IDE1006 // Naming Styles
        private void returnButton_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            this.Close();
        }

        /// <summary>
        /// slaat een route op of verwijderd hem bij de opgeslagen routes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void favoPictureBox_Click(object sender, EventArgs e)
        {

            if (!_toegevoegd)
            {
                _opgeslagenDA.CreateRecord(_user.GebruikersID, _route.RitId);
                favoPictureBox.Image = _verwijder;
                _toegevoegd = true;
                opslaanToolTip.SetToolTip(favoPictureBox, "Niet meer opslaan");
            }
            else
            {
                int id = _opgeslagenDA.ReadOpgeslagenID(_user.GebruikersID, _route.RitId);
                _opgeslagenDA.DeleteRecord(id);
                favoPictureBox.Image = _toevoegen;
                _toegevoegd = false;
                opslaanToolTip.SetToolTip(favoPictureBox, "Opslaan");
            }
        }
        #endregion

        /// <summary>
        /// zet uur en minuut om in UU:MM
        /// </summary>
        /// <param name="uur">uur</param>
        /// <param name="minuut">minuut</param>
        /// <returns>uur in formaat UU:MM</returns>
        private String UurNotatie(int uur, int minuut)
        {
            return $"{uur} : {minuut}";
        }

        private String SchemaNotatie(int enkelweek) {
            if (enkelweek == 1)
            {
                return "week";
            }
            else {
                return "weekend";
            }
        }
    }
}
