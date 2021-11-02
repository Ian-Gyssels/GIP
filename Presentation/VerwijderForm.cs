using System;
using System.Windows.Forms;
using Business;
using DataAccess;

namespace Presentation
{
    public partial class VerwijderForm : Form
    {
        #region velden
        Route _route;
        User _user;
        DienstregelingDA _dienstregelingDA;
        GebruikersDA _gebruikersDA;
        OpgeslagenDA _opgeslagenDA;
        #endregion

        #region constructor
        public VerwijderForm(Route route)
        {
            InitializeComponent();

            _route = route;
            _user = null;
            _opgeslagenDA = new OpgeslagenDA();

            _dienstregelingDA = new DienstregelingDA();

            vraagLabel.Text = $"Weet je zeker dat je '{_route.ToString()}' Wilt verwijderen";
            vraagLabel.Left = (this.Width - vraagLabel.Width) / 2;
        }

        public VerwijderForm(User user)
        {
            InitializeComponent();

            _route = null;
            _user = user;

            _gebruikersDA = new GebruikersDA();

            vraagLabel.Text = $"Weet je zeker dat je '{_user.Username}' Wilt verwijderen";
            vraagLabel.Left = (this.Width - vraagLabel.Width) / 2;
        }
        #endregion

        #region buttons
        /// <summary>
        /// verwijderd de route of gebruiker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void jaButton_Click(object sender, EventArgs e)
        {
            jaButton.Enabled = false;
            if(_user == null)
            {
            DeleteR:;
                try
                {
                    _opgeslagenDA.DeleteRecord(_route.RitId);
                
                }
                catch (Exception)
                {
                    SqlErrorForm errorForm = new SqlErrorForm();
                    this.Hide();
                    errorForm.ShowDialog();
                    this.Show();
                    goto DeleteR;
                }
                _dienstregelingDA.DeleteRecord(_route.RitId);
            }
            else
            {
                MailService mailService = new MailService();
                try
                {
                    mailService.StuurVerwijderd(_user.Email, _user.Username);
                }
                catch
                {
                    errorLabel.Visible = true;
                    errorLabel.Text = "Kon de gegevens niet aanpassen \n omdat wa de gebruiker niet kunnen contacteren. \n Verbind met wifi en probeer opnieuw";
                    goto End;
                }

                DeleteG:;
                try
                {
                    _gebruikersDA.DeleteRecord(_user.GebruikersID);
                }
                catch (Exception)
                {
                    SqlErrorForm errorForm = new SqlErrorForm();
                    this.Hide();
                    errorForm.ShowDialog();
                    this.Show();
                    goto DeleteG;
                }
                
            }
            
            this.Close();
            End:;
        }

        private void neeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
