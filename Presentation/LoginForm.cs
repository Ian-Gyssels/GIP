using System;
using System.Windows.Forms;
using Business;
using DataAccess;

namespace Presentation
{
    public partial class LoginForm : Form
    {
        #region velden
        private GebruikersDA _gebruikersDA;
        private StartForm _mainMenuForm;
        private WachtwoordBeveiliging _passwordProtection;
        #endregion

        #region constructor
        public LoginForm(StartForm main)
        {
            InitializeComponent();

            _gebruikersDA = new GebruikersDA();
            _mainMenuForm = main;
            _passwordProtection = new WachtwoordBeveiliging();

            returnButton.FlatStyle = FlatStyle.Flat;
            returnButton.FlatAppearance.BorderSize = 0;
        }
        #endregion

        #region linked lable
        /// <summary>
        /// maakt het mogelijk om een nieuwe gebruiker aan te maken en direct in te loggen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aanmeldenLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AanmeldenForm aanmelden = new AanmeldenForm(_mainMenuForm, true);
            this.Hide();
            aanmelden.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// als gebruikersnaam bestaat opend de mogelijkheid om wachtwoord opnieuw in te stellen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wachtwoordVergetenLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User user = null;
        WWVergeet:;
            try
            {
                user = _gebruikersDA.FilterTableUserName(gebruikersnaamTextBox.Text.ToLower());
            }
            catch (Exception)
            {
                SqlErrorForm errorForm = new SqlErrorForm();
                this.Hide();
                errorForm.ShowDialog();
                this.Show();
                goto WWVergeet;
            }

            if (user != null)
            {
                EmailControleForm controleForm = new EmailControleForm(user);
                this.Hide();
                errorLabel.Visible = false;
                controleForm.ShowDialog();
                this.Show();
            }
            else
            {
                errorLabel.Visible = true;
                errorLabel.Text = $"Er is geen account met gebruikersnaam: {gebruikersnaamTextBox.Text}";
            }
        }
        #endregion

        #region buttons
        /// <summary>
        /// controlleerd gegevens en logt de gebruiker in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            String username = gebruikersnaamTextBox.Text.ToLower();
            User user = null;
        LoginError:;
            try
            {
                user = _gebruikersDA.FilterTableUserName(username);
            }
            catch (Exception)
            {
                SqlErrorForm errorForm = new SqlErrorForm();
                this.Hide();
                errorForm.ShowDialog();
                this.Show();
                goto LoginError;
            }


            if (user != null) // als gebruikernaam bestaat
            {
                if (_passwordProtection.MaakSHA256Hash(wachtwoordTextBox.Text, user.Salt) == user.Wachtwoord)
                {
                    _mainMenuForm.GebruikerInstellen(user);
                    this.Close();
                }
                else
                {
                    errorLabel.Visible = true;
                    errorLabel.Text = "Gebruikersnaam of wachtwoord is niet correct";
                }

            }
            else // als gebruikersnaam niet bestaat
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Gebruikersnaam of wachtwoord is niet correct";
            }

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region wachtwoord zien
        /// <summary>
        /// laat het wachtwoord zichtbaar zien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zienPictureBox_MouseHover(object sender, EventArgs e)
        {
            wachtwoordTextBox.UseSystemPasswordChar = false;
        }

        /// <summary>
        /// maakt het wachtwoord onzichtbaar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zienPictureBox_MouseLeave(object sender, EventArgs e)
        {
            wachtwoordTextBox.UseSystemPasswordChar = true;
        }
        #endregion

        #region verboden chars
        /// <summary>
        /// verwijderd de verbannen tekens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gebruikersnaamTextBox_TextChanged(object sender, EventArgs e)
        {
            String nieuw = gebruikersnaamTextBox.Text.Replace('"', '\0');

            String nieuw2 = nieuw.Replace('\'', '\0');

            String nieuw3 = nieuw2.Replace('`', '\0');

            gebruikersnaamTextBox.Text = nieuw3;
        }

        /// <summary>
        /// verwijderd de verbannen tekens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wachtwoordTextBox_TextChanged(object sender, EventArgs e)
        {
            String nieuw = wachtwoordTextBox.Text.Replace('"', '\0');

            String nieuw2 = nieuw.Replace('\'', '\0');

            String nieuw3 = nieuw2.Replace('`', '\0');

            wachtwoordTextBox.Text = nieuw3;
        }
        #endregion

        
    }
}
