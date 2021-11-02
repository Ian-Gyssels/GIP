using System;
using System.Windows.Forms;
using Business;
using DataAccess;

namespace Presentation
{
    public partial class WachtwoordHerstelForm : Form
    {
        #region velden
        User _user;
        WachtwoordBeveiliging _passwordProtection;
        GebruikersDA _gebruikersDA;
        #endregion

        #region constructor
        public WachtwoordHerstelForm(User user)
        {
            InitializeComponent();

            _user = user;
            _gebruikersDA = new GebruikersDA();
            _passwordProtection = new WachtwoordBeveiliging();


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
        /// stelt je nieuwe wachtwoord in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wijzigButton_Click(object sender, EventArgs e)
        {
            if(nieuwTextBox.Text == bevestigTextBox.Text)
            {
                _user.Salt = _passwordProtection.MaakSalt(10);
                _user.Wachtwoord = _passwordProtection.MaakSHA256Hash(nieuwTextBox.Text, _user.Salt);
            WWVerander:;
                try
                {
                    _gebruikersDA.UpdateRecord(_user);
                } catch (Exception)
                {
                    SqlErrorForm errorForm = new SqlErrorForm();
                    this.Hide();
                    errorForm.ShowDialog();
                    this.Show();
                    goto WWVerander;
                }
                

                this.Close();
            }
        }
        #endregion

        #region wachtwoord zien
        //wachtwoordtekens verbergen
        private void zienWPictureBox_MouseHover(object sender, EventArgs e)
        {
            nieuwTextBox.UseSystemPasswordChar = false;
        }
        private void zienBevestigPictureBox_MouseHover(object sender, EventArgs e)
        {
            bevestigTextBox.UseSystemPasswordChar = false;
        }

        // wachtwoordtekens tonen
        private void zienWPictureBox_MouseLeave(object sender, EventArgs e)
        {
            nieuwTextBox.UseSystemPasswordChar = true;
        }
        private void zienBevestigPictureBox_MouseLeave(object sender, EventArgs e)
        {
            bevestigTextBox.UseSystemPasswordChar = true;
        }
        #endregion

        #region verwijderen verboden char
        private void nieuwTextBox_TextChanged(object sender, EventArgs e)
        {
            String nieuw = nieuwTextBox.Text.Replace('"', '\0');

            String nieuw2 = nieuw.Replace('\'', '\0');

            String nieuw3 = nieuw2.Replace('`', '\0');

            nieuwTextBox.Text = nieuw3;
        }

        private void bevestigTextBox_TextChanged(object sender, EventArgs e)
        {
            String nieuw = bevestigTextBox.Text.Replace('"', '\0');

            String nieuw2 = nieuw.Replace('\'', '\0');

            String nieuw3 = nieuw2.Replace('`', '\0');

            bevestigTextBox.Text = nieuw3;
        }
        #endregion
    }
}
