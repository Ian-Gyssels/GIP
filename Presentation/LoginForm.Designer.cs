namespace Presentation
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.returnButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.gebruikersnaamTextBox = new System.Windows.Forms.TextBox();
            this.wachtwoordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.aanmeldenLinkLabel = new System.Windows.Forms.LinkLabel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.zienPictureBox = new System.Windows.Forms.PictureBox();
            this.wachtwoordVergetenLinkLabel = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zienPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Transparent;
            this.returnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.ForeColor = System.Drawing.Color.Black;
            this.returnButton.Location = new System.Drawing.Point(12, 21);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(41, 34);
            this.returnButton.TabIndex = 0;
            this.returnButton.Text = "<";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(318, 509);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(194, 59);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // gebruikersnaamTextBox
            // 
            this.gebruikersnaamTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gebruikersnaamTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gebruikersnaamTextBox.Location = new System.Drawing.Point(12, 234);
            this.gebruikersnaamTextBox.Name = "gebruikersnaamTextBox";
            this.gebruikersnaamTextBox.Size = new System.Drawing.Size(388, 20);
            this.gebruikersnaamTextBox.TabIndex = 2;
            this.gebruikersnaamTextBox.TextChanged += new System.EventHandler(this.gebruikersnaamTextBox_TextChanged);
            // 
            // wachtwoordTextBox
            // 
            this.wachtwoordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wachtwoordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wachtwoordTextBox.Location = new System.Drawing.Point(12, 307);
            this.wachtwoordTextBox.Name = "wachtwoordTextBox";
            this.wachtwoordTextBox.Size = new System.Drawing.Size(388, 20);
            this.wachtwoordTextBox.TabIndex = 3;
            this.wachtwoordTextBox.UseSystemPasswordChar = true;
            this.wachtwoordTextBox.TextChanged += new System.EventHandler(this.wachtwoordTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 85);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gebruikersnaam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wachtwoord";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 1);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 1);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(12, 331);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 1);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(0, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(206, 1);
            this.panel4.TabIndex = 8;
            // 
            // aanmeldenLinkLabel
            // 
            this.aanmeldenLinkLabel.AutoSize = true;
            this.aanmeldenLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.aanmeldenLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aanmeldenLinkLabel.Location = new System.Drawing.Point(326, 571);
            this.aanmeldenLinkLabel.Name = "aanmeldenLinkLabel";
            this.aanmeldenLinkLabel.Size = new System.Drawing.Size(182, 15);
            this.aanmeldenLinkLabel.TabIndex = 9;
            this.aanmeldenLinkLabel.TabStop = true;
            this.aanmeldenLinkLabel.Text = "Nog geen account? Meld je aan";
            this.aanmeldenLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aanmeldenLinkLabel_LinkClicked);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(12, 416);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(49, 17);
            this.errorLabel.TabIndex = 22;
            this.errorLabel.Text = "*error*";
            this.errorLabel.Visible = false;
            // 
            // zienPictureBox
            // 
            this.zienPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.zienPictureBox.Image = global::Presentation.Properties.Resources.passwordView;
            this.zienPictureBox.Location = new System.Drawing.Point(406, 307);
            this.zienPictureBox.Name = "zienPictureBox";
            this.zienPictureBox.Size = new System.Drawing.Size(30, 25);
            this.zienPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zienPictureBox.TabIndex = 23;
            this.zienPictureBox.TabStop = false;
            this.zienPictureBox.MouseLeave += new System.EventHandler(this.zienPictureBox_MouseLeave);
            this.zienPictureBox.MouseHover += new System.EventHandler(this.zienPictureBox_MouseHover);
            // 
            // wachtwoordVergetenLinkLabel
            // 
            this.wachtwoordVergetenLinkLabel.AutoSize = true;
            this.wachtwoordVergetenLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.wachtwoordVergetenLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wachtwoordVergetenLinkLabel.Location = new System.Drawing.Point(12, 335);
            this.wachtwoordVergetenLinkLabel.Name = "wachtwoordVergetenLinkLabel";
            this.wachtwoordVergetenLinkLabel.Size = new System.Drawing.Size(132, 15);
            this.wachtwoordVergetenLinkLabel.TabIndex = 24;
            this.wachtwoordVergetenLinkLabel.TabStop = true;
            this.wachtwoordVergetenLinkLabel.Text = "Wachtwoord vergeten?";
            this.wachtwoordVergetenLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.wachtwoordVergetenLinkLabel_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentation.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 742);
            this.ControlBox = false;
            this.Controls.Add(this.wachtwoordVergetenLinkLabel);
            this.Controls.Add(this.zienPictureBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.aanmeldenLinkLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wachtwoordTextBox);
            this.Controls.Add(this.gebruikersnaamTextBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.returnButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zienPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox gebruikersnaamTextBox;
        private System.Windows.Forms.TextBox wachtwoordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel aanmeldenLinkLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.PictureBox zienPictureBox;
        private System.Windows.Forms.LinkLabel wachtwoordVergetenLinkLabel;
    }
}