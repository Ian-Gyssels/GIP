namespace Presentation
{
    partial class UserInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfoForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.returnButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gebruikersnaamTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.wijzigWachtwoordbutton = new System.Windows.Forms.Button();
            this.geboortedatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.opgeslagenButton = new System.Windows.Forms.Button();
            this.administratorButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.returnButton);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(-4, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 52);
            this.panel2.TabIndex = 2;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(8, 6);
            this.returnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(55, 33);
            this.returnButton.TabIndex = 12;
            this.returnButton.Text = "<--";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Location = new System.Drawing.Point(8, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 52);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gebruikersnaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wachtwoord";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "GeboorteDatum";
            // 
            // gebruikersnaamTextBox
            // 
            this.gebruikersnaamTextBox.Enabled = false;
            this.gebruikersnaamTextBox.Location = new System.Drawing.Point(18, 106);
            this.gebruikersnaamTextBox.Name = "gebruikersnaamTextBox";
            this.gebruikersnaamTextBox.ReadOnly = true;
            this.gebruikersnaamTextBox.Size = new System.Drawing.Size(270, 22);
            this.gebruikersnaamTextBox.TabIndex = 8;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Enabled = false;
            this.EmailTextBox.Location = new System.Drawing.Point(18, 170);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.ReadOnly = true;
            this.EmailTextBox.Size = new System.Drawing.Size(270, 22);
            this.EmailTextBox.TabIndex = 9;
            // 
            // wijzigWachtwoordbutton
            // 
            this.wijzigWachtwoordbutton.Location = new System.Drawing.Point(18, 243);
            this.wijzigWachtwoordbutton.Name = "wijzigWachtwoordbutton";
            this.wijzigWachtwoordbutton.Size = new System.Drawing.Size(145, 28);
            this.wijzigWachtwoordbutton.TabIndex = 10;
            this.wijzigWachtwoordbutton.Text = "Wijzig wachtwoord";
            this.wijzigWachtwoordbutton.UseVisualStyleBackColor = true;
            this.wijzigWachtwoordbutton.Click += new System.EventHandler(this.wijzigWachtwoordbutton_Click);
            // 
            // geboortedatumDateTimePicker
            // 
            this.geboortedatumDateTimePicker.Enabled = false;
            this.geboortedatumDateTimePicker.Location = new System.Drawing.Point(18, 318);
            this.geboortedatumDateTimePicker.Name = "geboortedatumDateTimePicker";
            this.geboortedatumDateTimePicker.Size = new System.Drawing.Size(217, 22);
            this.geboortedatumDateTimePicker.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.Controls.Add(this.opgeslagenButton);
            this.panel3.Controls.Add(this.administratorButton);
            this.panel3.Location = new System.Drawing.Point(-4, 395);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(386, 47);
            this.panel3.TabIndex = 12;
            // 
            // opgeslagenButton
            // 
            this.opgeslagenButton.Location = new System.Drawing.Point(54, 8);
            this.opgeslagenButton.Name = "opgeslagenButton";
            this.opgeslagenButton.Size = new System.Drawing.Size(287, 33);
            this.opgeslagenButton.TabIndex = 14;
            this.opgeslagenButton.Text = "Opgeslagen";
            this.opgeslagenButton.UseVisualStyleBackColor = true;
            this.opgeslagenButton.Click += new System.EventHandler(this.opgeslagenButton_Click);
            // 
            // administratorButton
            // 
            this.administratorButton.Location = new System.Drawing.Point(54, 8);
            this.administratorButton.Name = "administratorButton";
            this.administratorButton.Size = new System.Drawing.Size(287, 33);
            this.administratorButton.TabIndex = 0;
            this.administratorButton.Text = "Admin window";
            this.administratorButton.UseVisualStyleBackColor = true;
            this.administratorButton.Click += new System.EventHandler(this.administratorButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(18, 355);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(106, 31);
            this.logoutButton.TabIndex = 13;
            this.logoutButton.Text = "Log uit";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 476);
            this.ControlBox = false;
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.geboortedatumDateTimePicker);
            this.Controls.Add(this.wijzigWachtwoordbutton);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.gebruikersnaamTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gebruikersinfo";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gebruikersnaamTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Button wijzigWachtwoordbutton;
        private System.Windows.Forms.DateTimePicker geboortedatumDateTimePicker;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button administratorButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button opgeslagenButton;
    }
}