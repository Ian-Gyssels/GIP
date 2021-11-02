namespace Presentation
{
    partial class AdminSchermForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSchermForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.printButton = new System.Windows.Forms.Button();
            this.opgeslagenButton = new System.Windows.Forms.Button();
            this.verwijderButton = new System.Windows.Forms.Button();
            this.wijzigButton = new System.Windows.Forms.Button();
            this.geboortedatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.wijzigWachtwoordbutton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.gebruikersnaamTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.returnButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gebruikersListBox = new System.Windows.Forms.ListBox();
            this.isAdminCheckBox = new System.Windows.Forms.CheckBox();
            this.adminLabel = new System.Windows.Forms.Label();
            this.gebruikerFilterTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.resetCheckBox = new System.Windows.Forms.CheckBox();
            this.toevoegenButton = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.Controls.Add(this.printButton);
            this.panel3.Controls.Add(this.opgeslagenButton);
            this.panel3.Controls.Add(this.verwijderButton);
            this.panel3.Controls.Add(this.wijzigButton);
            this.panel3.Location = new System.Drawing.Point(-5, 424);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(675, 47);
            this.panel3.TabIndex = 23;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(521, 9);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(115, 33);
            this.printButton.TabIndex = 3;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // opgeslagenButton
            // 
            this.opgeslagenButton.Location = new System.Drawing.Point(365, 9);
            this.opgeslagenButton.Name = "opgeslagenButton";
            this.opgeslagenButton.Size = new System.Drawing.Size(115, 33);
            this.opgeslagenButton.TabIndex = 2;
            this.opgeslagenButton.Text = "Opgeslagen";
            this.opgeslagenButton.UseVisualStyleBackColor = true;
            this.opgeslagenButton.Click += new System.EventHandler(this.opgeslagenButton_Click);
            // 
            // verwijderButton
            // 
            this.verwijderButton.Location = new System.Drawing.Point(193, 9);
            this.verwijderButton.Name = "verwijderButton";
            this.verwijderButton.Size = new System.Drawing.Size(115, 33);
            this.verwijderButton.TabIndex = 1;
            this.verwijderButton.Text = "Verwijder";
            this.verwijderButton.UseVisualStyleBackColor = true;
            this.verwijderButton.Click += new System.EventHandler(this.verwijderButton_Click);
            // 
            // wijzigButton
            // 
            this.wijzigButton.Location = new System.Drawing.Point(35, 9);
            this.wijzigButton.Name = "wijzigButton";
            this.wijzigButton.Size = new System.Drawing.Size(115, 33);
            this.wijzigButton.TabIndex = 0;
            this.wijzigButton.Text = "Werk Bij";
            this.wijzigButton.UseVisualStyleBackColor = true;
            this.wijzigButton.Click += new System.EventHandler(this.wijzigButton_Click);
            // 
            // geboortedatumDateTimePicker
            // 
            this.geboortedatumDateTimePicker.Location = new System.Drawing.Point(17, 269);
            this.geboortedatumDateTimePicker.Name = "geboortedatumDateTimePicker";
            this.geboortedatumDateTimePicker.Size = new System.Drawing.Size(217, 22);
            this.geboortedatumDateTimePicker.TabIndex = 22;
            // 
            // wijzigWachtwoordbutton
            // 
            this.wijzigWachtwoordbutton.Location = new System.Drawing.Point(17, 205);
            this.wijzigWachtwoordbutton.Name = "wijzigWachtwoordbutton";
            this.wijzigWachtwoordbutton.Size = new System.Drawing.Size(145, 28);
            this.wijzigWachtwoordbutton.TabIndex = 21;
            this.wijzigWachtwoordbutton.Text = "Wijzig wachtwoord";
            this.wijzigWachtwoordbutton.UseVisualStyleBackColor = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(17, 146);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(270, 22);
            this.emailTextBox.TabIndex = 20;
            // 
            // gebruikersnaamTextBox
            // 
            this.gebruikersnaamTextBox.Location = new System.Drawing.Point(17, 82);
            this.gebruikersnaamTextBox.Name = "gebruikersnaamTextBox";
            this.gebruikersnaamTextBox.Size = new System.Drawing.Size(270, 22);
            this.gebruikersnaamTextBox.TabIndex = 19;
            this.gebruikersnaamTextBox.TextChanged += new System.EventHandler(this.gebruikersnaamTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "GeboorteDatum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Wachtwoord";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Gebruikersnaam";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.returnButton);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(-5, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 52);
            this.panel2.TabIndex = 14;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(371, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 376);
            this.panel4.TabIndex = 24;
            // 
            // gebruikersListBox
            // 
            this.gebruikersListBox.FormattingEnabled = true;
            this.gebruikersListBox.ItemHeight = 16;
            this.gebruikersListBox.Location = new System.Drawing.Point(397, 111);
            this.gebruikersListBox.Name = "gebruikersListBox";
            this.gebruikersListBox.Size = new System.Drawing.Size(261, 276);
            this.gebruikersListBox.TabIndex = 25;
            this.gebruikersListBox.SelectedIndexChanged += new System.EventHandler(this.gebruikersListBox_SelectedIndexChanged);
            // 
            // isAdminCheckBox
            // 
            this.isAdminCheckBox.AutoSize = true;
            this.isAdminCheckBox.Location = new System.Drawing.Point(17, 322);
            this.isAdminCheckBox.Name = "isAdminCheckBox";
            this.isAdminCheckBox.Size = new System.Drawing.Size(69, 21);
            this.isAdminCheckBox.TabIndex = 27;
            this.isAdminCheckBox.Text = "Admin";
            this.isAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Location = new System.Drawing.Point(17, 303);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(91, 17);
            this.adminLabel.TabIndex = 28;
            this.adminLabel.Text = "Administrator";
            // 
            // gebruikerFilterTextBox
            // 
            this.gebruikerFilterTextBox.Location = new System.Drawing.Point(397, 83);
            this.gebruikerFilterTextBox.Name = "gebruikerFilterTextBox";
            this.gebruikerFilterTextBox.Size = new System.Drawing.Size(261, 22);
            this.gebruikerFilterTextBox.TabIndex = 29;
            this.gebruikerFilterTextBox.TextChanged += new System.EventHandler(this.gebruikerTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Gebruikers";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.errorLabel.Location = new System.Drawing.Point(11, 350);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(46, 17);
            this.errorLabel.TabIndex = 31;
            this.errorLabel.Text = "label5";
            this.errorLabel.Visible = false;
            // 
            // resetCheckBox
            // 
            this.resetCheckBox.AutoSize = true;
            this.resetCheckBox.Location = new System.Drawing.Point(20, 210);
            this.resetCheckBox.Name = "resetCheckBox";
            this.resetCheckBox.Size = new System.Drawing.Size(145, 21);
            this.resetCheckBox.TabIndex = 32;
            this.resetCheckBox.Text = "Reset wachtwoord";
            this.resetCheckBox.UseVisualStyleBackColor = true;
            // 
            // toevoegenButton
            // 
            this.toevoegenButton.Location = new System.Drawing.Point(397, 390);
            this.toevoegenButton.Name = "toevoegenButton";
            this.toevoegenButton.Size = new System.Drawing.Size(261, 30);
            this.toevoegenButton.TabIndex = 33;
            this.toevoegenButton.Text = "Gebruiker toevoegen";
            this.toevoegenButton.UseVisualStyleBackColor = true;
            this.toevoegenButton.Click += new System.EventHandler(this.toevoegenButton_Click);
            // 
            // AdminWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 471);
            this.Controls.Add(this.toevoegenButton);
            this.Controls.Add(this.resetCheckBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gebruikerFilterTextBox);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.isAdminCheckBox);
            this.Controls.Add(this.wijzigWachtwoordbutton);
            this.Controls.Add(this.gebruikersListBox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.geboortedatumDateTimePicker);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.gebruikersnaamTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminWindowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker geboortedatumDateTimePicker;
        private System.Windows.Forms.Button wijzigWachtwoordbutton;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox gebruikersnaamTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox gebruikersListBox;
        private System.Windows.Forms.CheckBox isAdminCheckBox;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.TextBox gebruikerFilterTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button wijzigButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.CheckBox resetCheckBox;
        private System.Windows.Forms.Button verwijderButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button opgeslagenButton;
        private System.Windows.Forms.Button toevoegenButton;
    }
}