using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class SqlErrorForm : Form
    {
        #region constructor
        public SqlErrorForm()
        {
            InitializeComponent();
        }
        #endregion

        #region buttons
        /// <summary>
        /// probeert opnieuw
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doorgaanButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// sluit het hele programma
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void afsluitenButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion
    }
}
