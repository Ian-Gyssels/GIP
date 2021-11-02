using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using Business;

namespace Presentation
{
    public partial class EmailControleForm : Form
    {
        #region velden
        private User _user;
        private String code = null;
        #endregion

        #region constructor
        public EmailControleForm(User user)
        {
            InitializeComponent();

            _user = user;

            returnButton.FlatStyle = FlatStyle.Flat;
            returnButton.FlatAppearance.BorderSize = 0;
        }
        #endregion

        #region buttons
        /// <summary>
        /// controlleerd of het ingevulde emailadress gelijk is aan het email van de gebruiker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void controleButton_Click(object sender, EventArgs e)
        {
            if(_user.Email == emailTextBox.Text)
            {
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                byte[] buff = new byte[5];
                rng.GetBytes(buff);

                code = Convert.ToBase64String(buff);

                MailService mail = new MailService();
                try
                {
                    mail.StuurCode(emailTextBox.Text, _user.Username, code);
                    codeLabel.Visible = true;
                    codeLabel.Text = $"Je geheime code is verstuurd naar: {emailTextBox.Text}";
                }
                catch (Exception)
                {
                    codeLabel.Visible = true;
                    codeLabel.Text = "Geen WIFI connectie. \n verbind met WIFI en probeer opnieuw";
                }
                
                
                
            }
            else
            {
                codeLabel.Visible = true;
                codeLabel.Text = "Het email adres komt niet overeen";
            }
        }

        /// <summary>
        /// controlleerd of de ingegeven code overeenkomt met de code die meegegeven word in de mail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doorgaanButton_Click(object sender, EventArgs e)
        {
            if(codeTextBox.Text == code)
            {
                WachtwoordHerstelForm wachtwoordHerstelForm = new WachtwoordHerstelForm(_user);
                this.Hide();
                wachtwoordHerstelForm.ShowDialog();
                this.Close();
            }
            else
            {
                foutLabel.Visible = true;
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
