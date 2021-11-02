namespace Presentation
{
    partial class AanmeldenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AanmeldenForm));
            this.label1 = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wachtwoordTextBox = new System.Windows.Forms.TextBox();
            this.gebruikersnaamTextBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.geboorteDatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.aanmeldenButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.zienPictureBox = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zienPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 71);
            this.label1.TabIndex = 6;
            this.label1.Text = "AANMELDEN";
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Transparent;
            this.returnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.ForeColor = System.Drawing.Color.Black;
            this.returnButton.Location = new System.Drawing.Point(12, 24);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(41, 34);
            this.returnButton.TabIndex = 5;
            this.returnButton.Text = "<";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(14, 296);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 1);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(0, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(206, 1);
            this.panel4.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(14, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 1);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 1);
            this.panel2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Wachtwoord";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Gebruikersnaam";
            // 
            // wachtwoordTextBox
            // 
            this.wachtwoordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wachtwoordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wachtwoordTextBox.Location = new System.Drawing.Point(14, 272);
            this.wachtwoordTextBox.Name = "wachtwoordTextBox";
            this.wachtwoordTextBox.Size = new System.Drawing.Size(388, 20);
            this.wachtwoordTextBox.TabIndex = 10;
            this.wachtwoordTextBox.UseSystemPasswordChar = true;
            this.wachtwoordTextBox.TextChanged += new System.EventHandler(this.wachtwoordTextBox_TextChanged);
            // 
            // gebruikersnaamTextBox
            // 
            this.gebruikersnaamTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gebruikersnaamTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gebruikersnaamTextBox.Location = new System.Drawing.Point(14, 203);
            this.gebruikersnaamTextBox.Name = "gebruikersnaamTextBox";
            this.gebruikersnaamTextBox.Size = new System.Drawing.Size(388, 20);
            this.gebruikersnaamTextBox.TabIndex = 9;
            this.gebruikersnaamTextBox.TextChanged += new System.EventHandler(this.gebruikersnaamTextBox_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(14, 370);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(391, 1);
            this.panel5.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(0, 36);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(206, 1);
            this.panel6.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "E-mail";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(14, 345);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(388, 20);
            this.emailTextBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Geboortedatum";
            // 
            // geboorteDatumDateTimePicker
            // 
            this.geboorteDatumDateTimePicker.Location = new System.Drawing.Point(14, 422);
            this.geboorteDatumDateTimePicker.Name = "geboorteDatumDateTimePicker";
            this.geboorteDatumDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.geboorteDatumDateTimePicker.Size = new System.Drawing.Size(391, 22);
            this.geboorteDatumDateTimePicker.TabIndex = 19;
            // 
            // aanmeldenButton
            // 
            this.aanmeldenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aanmeldenButton.Location = new System.Drawing.Point(327, 561);
            this.aanmeldenButton.Name = "aanmeldenButton";
            this.aanmeldenButton.Size = new System.Drawing.Size(194, 59);
            this.aanmeldenButton.TabIndex = 20;
            this.aanmeldenButton.Text = "AANMELDEN";
            this.aanmeldenButton.UseVisualStyleBackColor = true;
            this.aanmeldenButton.Click += new System.EventHandler(this.aanmeldenButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(16, 460);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(49, 17);
            this.errorLabel.TabIndex = 21;
            this.errorLabel.Text = "*error*";
            this.errorLabel.Visible = false;
            // 
            // zienPictureBox
            // 
            this.zienPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.zienPictureBox.Image = global::Presentation.Properties.Resources.passwordView;
            this.zienPictureBox.Location = new System.Drawing.Point(408, 272);
            this.zienPictureBox.Name = "zienPictureBox";
            this.zienPictureBox.Size = new System.Drawing.Size(30, 25);
            this.zienPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zienPictureBox.TabIndex = 24;
            this.zienPictureBox.TabStop = false;
            this.zienPictureBox.MouseLeave += new System.EventHandler(this.zienPictureBox_MouseLeave);
            this.zienPictureBox.MouseHover += new System.EventHandler(this.zienPictureBox_MouseHover);
            // 
            // AanmeldenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentation.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 742);
            this.ControlBox = false;
            this.Controls.Add(this.zienPictureBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.aanmeldenButton);
            this.Controls.Add(this.geboorteDatumDateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wachtwoordTextBox);
            this.Controls.Add(this.gebruikersnaamTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AanmeldenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Aanmelden";
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zienPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox wachtwoordTextBox;
        private System.Windows.Forms.TextBox gebruikersnaamTextBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker geboorteDatumDateTimePicker;
        private System.Windows.Forms.Button aanmeldenButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.PictureBox zienPictureBox;
    }
}