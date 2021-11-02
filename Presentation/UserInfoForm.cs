using System;
using System.Windows.Forms;
using Business;

namespace Presentation
{
    public partial class UserInfoForm : Form
    {
        #region velden
        private User _user;
        private StartForm _menuForm;
        #endregion

        #region constructor
        public UserInfoForm(User user, StartForm menuForm)
        {
            InitializeComponent();
            _user = user;
            _menuForm = menuForm;

            gebruikersnaamTextBox.Text = _user.Username;
            EmailTextBox.Text = _user.Email;
            geboortedatumDateTimePicker.Value = _user.GeboorteDatum;

            if (_user.IsAdmin)
            {
                administratorButton.Visible = true;
                opgeslagenButton.Visible = false;
            } else
            {
                administratorButton.Visible = false;
                opgeslagenButton.Visible = true;
            }

            returnButton.FlatStyle = FlatStyle.Flat;
            returnButton.FlatAppearance.BorderSize = 0;

            if (_user.IsAdmin)
            {
                administratorButton.Visible = true;
            } else
            {
                administratorButton.Visible = false;
            }
        }
        #endregion

        #region buttons
        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// opend een controle voordat je wachtwoord kan veranderen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wijzigWachtwoordbutton_Click(object sender, EventArgs e)
        {
            EmailControleForm emailControleForm = new EmailControleForm(_user);
            this.Hide();
            emailControleForm.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// zorgt de gebruiker uitlogt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutButton_Click(object sender, EventArgs e)
        {
            _menuForm.GebruikerInstellen(null);
            this.Close();
        }

        /// <summary>
        /// opend het administrator window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void administratorButton_Click(object sender, EventArgs e)
        {
            AdminSchermForm admin = new AdminSchermForm(_user);
            this.Hide();
            admin.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// toont de opgeslagen routes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void opgeslagenButton_Click(object sender, EventArgs e)
        {
            OpgeslagenForm opgeslagen = new OpgeslagenForm(_user);
            this.Hide();
            opgeslagen.ShowDialog();
            this.Show();
        }
        #endregion
    }
}
