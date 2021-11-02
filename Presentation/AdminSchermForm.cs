using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using Business;
using DataAccess;

namespace Presentation
{
    public partial class AdminSchermForm : Form
    {
        #region velden
        private User _admin; // ingelogde gebruiker
        private User _selectedUser; // gebruiker die aan het linkerdeel word getoont
        private GebruikersDA _gebruikersDA;
        private WachtwoordBeveiliging _wachtwoordBeveiliging;
        #endregion

        #region constructor
        public AdminSchermForm(User user)
        {
            InitializeComponent();

            _admin = user;
            _selectedUser = user;
            _gebruikersDA = new GebruikersDA();
            _wachtwoordBeveiliging = new WachtwoordBeveiliging();


            VulGegevensIn(_selectedUser);

            gebruikersListBox.DataSource = null;
            gebruikersListBox.DataSource = _gebruikersDA.ReadTable();

            // rand van knop uitzetten
            returnButton.FlatStyle = FlatStyle.Flat;
            returnButton.FlatAppearance.BorderSize = 0;
        }
        #endregion

        #region automatiche gegevens invullen
        /// <summary>
        /// Vult de gegevens in van de geselecteerde gebruiker
        /// </summary>
        /// <param name="user"></param>
        public void VulGegevensIn(User user)
        {
            if(user != null)
            {
                gebruikersnaamTextBox.Text = user.Username;
                emailTextBox.Text = user.Email;
                geboortedatumDateTimePicker.Value = user.GeboorteDatum;

                if (_admin.Username == user.Username)
                {
                    isAdminCheckBox.Visible = false;
                    adminLabel.Visible = false;
                    verwijderButton.Enabled = false;
                    isAdminCheckBox.Checked = user.IsAdmin;

                    wijzigWachtwoordbutton.Visible = true;
                    resetCheckBox.Visible = false;
                }
                else
                {
                    isAdminCheckBox.Visible = true;
                    adminLabel.Visible = true;
                    verwijderButton.Enabled = true;
                    isAdminCheckBox.Checked = user.IsAdmin;

                    wijzigWachtwoordbutton.Visible = false;
                    resetCheckBox.Visible = true;
                }
            }
        }

        /// <summary>
        /// veranderd de gegevens naar de gegevens van de geselecteerde gebruiker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gebruikersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(gebruikersListBox.DataSource != null && gebruikersListBox.Items.Count != 0)
            {
                _selectedUser = _gebruikersDA.FilterTableUserName(gebruikersListBox.SelectedItem.ToString());
                
                if (_selectedUser != null)
                {
                    VulGegevensIn(_selectedUser);
                }
            }
        }
        #endregion

        #region buttons
        /// <summary>
        /// opend de form met opgeslagen routes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void opgeslagenButton_Click(object sender, EventArgs e)
        {
            OpgeslagenForm opgeslagen = new OpgeslagenForm(_admin);
            this.Hide();
            opgeslagen.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// opend de form die het mogelijk maakt om de printen naar pdf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printButton_Click(object sender, EventArgs e)
        {
            PrintForm print = new PrintForm();
            this.Hide();
            print.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// laat de administrator een nieuwe gebruiker aanmaken zonder automatisch in to loggen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toevoegenButton_Click(object sender, EventArgs e)
        {
            AanmeldenForm aanmelden = new AanmeldenForm(this, false);
            this.Hide();
            aanmelden.ShowDialog();
            this.Show();

            gebruikersListBox.DataSource = null;
        Read:;
            try
            {
                gebruikersListBox.DataSource = _gebruikersDA.FilterDeelVanUsername(gebruikerFilterTextBox.Text);
            }
            catch (Exception)
            {
                SqlErrorForm errorForm = new SqlErrorForm();
                this.Hide();
                errorForm.ShowDialog();
                this.Show();
                goto Read;
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Opent de mogelijkheid om een gebruiker te verwijderen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void verwijderButton_Click(object sender, EventArgs e)
        {
            VerwijderForm verwijder = new VerwijderForm(_selectedUser);
            verwijder.ShowDialog();

            gebruikerFilterTextBox.Text = "";
            gebruikersListBox.DataSource = null;
        Read:;
            try
            {
                gebruikersListBox.DataSource = _gebruikersDA.ReadTable();
            }
            catch (Exception)
            {
                {
                    SqlErrorForm errorForm = new SqlErrorForm();
                    this.Hide();
                    errorForm.ShowDialog();
                    this.Show();
                    goto Read;
                }
            }

            VulGegevensIn((User)gebruikersListBox.SelectedItem);
        }

        /// <summary>
        /// Wijzigd de gegevens van een gebruiker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wijzigButton_Click(object sender, EventArgs e)
        {
            List<String> lijst = null;
        Read:;
            try
            {
                lijst = _gebruikersDA.ReadUsername();// lijst an alle gebruikersnamen
            }
            catch (Exception)
            {
                SqlErrorForm errorForm = new SqlErrorForm();
                this.Hide();
                errorForm.ShowDialog();
                this.Show();
                goto Read;
            }

            bool bestaat = false;
            bool wachtwoordVeranderd = false;

            // gegevens voor in de mail
            String wachtwoord = ""; // nieuw wachtwoord in textvorm
            String oudEmail = _selectedUser.Email; // 'oud' emailadres voor als gegevens worden veranderd
            String oudUsername = _selectedUser.Username; // 'oude' username van de gebruiker

            //Controlles
            if (gebruikersnaamTextBox.Text == "")
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Gebruikersnaam mag niet leeg zijn";
                return;
            }

            if (!IsGeldigeEmail(emailTextBox.Text))
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Vul een geldig emailadress in";
                return;
            }
            if (geboortedatumDateTimePicker.Value == DateTime.Today)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Selecteer een datum";
                return;
            }


            String username = gebruikersnaamTextBox.Text.ToLower();
            String email = emailTextBox.Text;
            DateTime geboorte = geboortedatumDateTimePicker.Value;

            // controlleerd of de gebruikersnaam al bestaat buiten de geselecteerde gebruiker
            if (_gebruikersDA.FilterTableUserName(gebruikersnaamTextBox.Text.ToLower()) != null)
            {
                if (username != _selectedUser.Username)
                {
                    bestaat = true;
                }
            }

            // maakt nieuw Wachtwoord aan || wachtwoord nog te veranderen met auto gen code
            // voeg !bestaat test toe
            if (_admin.Username != _selectedUser.Username && resetCheckBox.Checked)
            {
                wachtwoord = _wachtwoordBeveiliging.MaakSalt(5); // maakt nieuw wachtwoord aan 
                _selectedUser.Salt = _wachtwoordBeveiliging.MaakSalt(10); // maakt salt
                _selectedUser.Wachtwoord = _wachtwoordBeveiliging.MaakSHA256Hash(wachtwoord, _selectedUser.Salt);
                wachtwoordVeranderd = true;
            }

            // als alles in orde is om te veranderen --> gegevens veranderen van gebruiker
            if (!bestaat)
            {
                _selectedUser.Username = username;
                _selectedUser.Email = email;
                _selectedUser.IsAdmin = isAdminCheckBox.Checked;
                _selectedUser.GeboorteDatum = geboorte;

                MailService mail = new MailService();
                try
                {
                    mail.StuurGegevens(oudUsername, oudEmail, wachtwoord, _selectedUser, wachtwoordVeranderd);
                }
                catch (Exception)
                {
                    errorLabel.Visible = true;
                    errorLabel.Text = "Kon de gegevens niet aanpassen \n omdat wa de gebruiker niet kunnen contacteren. \n Verbind met wifi en probeer opnieuw";
                    _selectedUser = _gebruikersDA.FilterTableUserName(oudUsername);
                    VulGegevensIn(_selectedUser);
                    goto End;
                }

                _gebruikersDA.UpdateRecord(_selectedUser);

                gebruikersListBox.DataSource = null;
                gebruikersListBox.DataSource = _gebruikersDA.ReadTable();

                VulGegevensIn(_selectedUser);


                errorLabel.Visible = false;
            }
            else
            {
                VulGegevensIn(_selectedUser);
                errorLabel.Visible = true;
                errorLabel.Text = "Gebruikersnaam bestaat al, kies een andere gebruikersnaam";
            }
        End:;
        }
        #endregion

        /// <summary>
        /// Controlleerd of het emailadres binnen het geldige formaat is
        /// </summary>
        /// <param name="email">emailadres</param>
        /// <returns></returns>
        private bool IsGeldigeEmail(string email)
        {
            EmailAddressAttribute addr = new EmailAddressAttribute();
            return addr.IsValid(email);
        }

        /// <summary>
        /// filtert in gebruikersListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gebruikerTextBox_TextChanged(object sender, EventArgs e)
        {
            String nieuws = gebruikerFilterTextBox.Text.Replace('"', '\0');

            String nieuws2 = nieuws.Replace('\'', '\0');

            String nieuws3 = nieuws2.Replace('`', '\0');

            gebruikerFilterTextBox.Text = nieuws3;

            gebruikersListBox.DataSource = null;
        Read:;
            try
            {
                gebruikersListBox.DataSource = _gebruikersDA.FilterDeelVanUsername(gebruikerFilterTextBox.Text);
            }
            catch (Exception)
            {
                SqlErrorForm errorForm = new SqlErrorForm();
                this.Hide();
                errorForm.ShowDialog();
                this.Show();
                goto Read;
            }
            
            if(gebruikersListBox.Items.Count != 0)
            {
                User nieuw = _gebruikersDA.FilterTableUserName(gebruikersListBox.SelectedItem.ToString());
                if(nieuw != null)
                {
                    VulGegevensIn(nieuw);
                }
            }
        }

        /// <summary>
        /// verwijderd automatisch de verbannen tekens
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


    }
}
