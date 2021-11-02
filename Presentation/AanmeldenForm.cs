using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;
using Business;
using DataAccess;

namespace Presentation
{
    public partial class AanmeldenForm : Form
    {
        #region velden
        private GebruikersDA _gebruikerDA;
        private WachtwoordBeveiliging _wachtwoordBeveiliging;
        private StartForm _startForm;
        private AdminSchermForm _admin;
        private bool _inloggen;
        #endregion

        #region constructor
        /// <summary>
        /// constructor vanuit MainMenu
        /// </summary>
        /// <param name="main">MainMenuForm</param>
        /// <param name="inloggen">Gaat het om inloggen of registreren</param>
        public AanmeldenForm(StartForm main, bool inloggen)
        {
            InitializeComponent();
            _gebruikerDA = new GebruikersDA();
            _wachtwoordBeveiliging = new WachtwoordBeveiliging();
            _startForm = main;
            _inloggen = inloggen;

            geboorteDatumDateTimePicker.MaxDate = DateTime.Today;

            returnButton.FlatStyle = FlatStyle.Flat;
            returnButton.FlatAppearance.BorderSize = 0;
        }

        /// <summary>
        /// Constructor vanuit AdminWindow
        /// </summary>
        /// <param name="admin">AdminWindowForm</param>
        /// <param name="inloggen">Gaat het om inloggen of registreren</param>
        public AanmeldenForm(AdminSchermForm admin, bool inloggen)
        {
            InitializeComponent();
            _gebruikerDA = new GebruikersDA();
            _wachtwoordBeveiliging = new WachtwoordBeveiliging();
            _admin = admin;
            _inloggen = inloggen;

            geboorteDatumDateTimePicker.MaxDate = DateTime.Today;

            returnButton.FlatStyle = FlatStyle.Flat;
            returnButton.FlatAppearance.BorderSize = 0;
        }
        #endregion

        #region toonWachtwoord
        /// <summary>
        /// toont het wachtwoord in gewone tekst als je over deze control hoverd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zienPictureBox_MouseHover(object sender, EventArgs e)
        {
            wachtwoordTextBox.UseSystemPasswordChar = false;
        }
        /// <summary>
        /// zet gewone tekst om in PasswordChars
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zienPictureBox_MouseLeave(object sender, EventArgs e)
        {
            wachtwoordTextBox.UseSystemPasswordChar = true;
        }
        #endregion

        #region verboden tekst
        /// <summary>
        /// verwijderd automatisch verbannen characters die programma zouden laten crashen
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
        /// verwijderd automatisch verbannen characters die programma zouden laten crashen
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

        #region buttons
        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Maakt een nieuwe gebruiker aan, controlleerd of dat gebruikersnaam al bestaat of niet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aanmeldenButton_Click(object sender, EventArgs e)
        {
            List<String> lijst = null;
        Start:;
            try
            {
                lijst = _gebruikerDA.ReadUsername();
            }
            catch (Exception)
            {
                SqlErrorForm error = new SqlErrorForm();
                this.Hide();
                error.ShowDialog();
                goto Start;
            }
            
            bool bestaat = false; //controlleerd of de username al bestaat

            //Controlles
            if(gebruikersnaamTextBox.Text == "")
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Gebruikersnaam mag niet leeg zijn";
                return;
            }
            if(wachtwoordTextBox.Text.Length < 7)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Wachtwoord moet minstens 6 tekens lang zijn";
                return;
            }
            if(!IsGeldigeEmail(emailTextBox.Text))
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Vul een geldig emailadress in";
                return;
            }
            if(geboorteDatumDateTimePicker.Value == DateTime.Today)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Selecteer een datum";
                return;
            }


            String username = gebruikersnaamTextBox.Text.ToLower();
            String email = emailTextBox.Text;
            DateTime geboorte = geboorteDatumDateTimePicker.Value;


            // controle of username al bestaat
            for (int i = 0; i < lijst.Count && !bestaat; i++)
            {
                if(lijst.ElementAt(i) == username)
                {
                    bestaat = true;
                }
            }

            String salt = _wachtwoordBeveiliging.MaakSalt(10);
            String wachtwoord = _wachtwoordBeveiliging.MaakSHA256Hash(wachtwoordTextBox.Text, salt);

            if (!bestaat) // voegt gebruiker toe aan database en logt automatisch in met dit account
            {
               User user = new User(0, username, wachtwoord, salt, email, false, geboorte);
                SQL:;
                try{
                    _gebruikerDA.CreateRecord(user);
                    if (_inloggen)
                    {
                        _startForm.GebruikerInstellen(user);
                    }
                } catch (Exception)
                {
                    SqlErrorForm error = new SqlErrorForm();
                    this.Hide();
                    error.ShowDialog();
                    goto SQL;
                }
              
               this.Close();
            }
            else
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Gebruikersnaam bestaat al, kies een andere gebruikersnaam";
            }
        }
        #endregion

        /// <summary>
        /// Controlleerd of het emailadress van een geldig formaat is
        /// </summary>
        /// <param name="email">email dat gecontrolleerd word</param>
        /// <returns></returns>
        private bool IsGeldigeEmail(string email)
        {
            EmailAddressAttribute addr = new EmailAddressAttribute();
            return addr.IsValid(email);
        }

       
    }
}
