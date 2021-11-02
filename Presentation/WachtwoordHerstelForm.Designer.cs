namespace Presentation
{
    partial class WachtwoordHerstelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WachtwoordHerstelForm));
            this.label1 = new System.Windows.Forms.Label();
            this.nieuwTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bevestigTextBox = new System.Windows.Forms.TextBox();
            this.zienWPictureBox = new System.Windows.Forms.PictureBox();
            this.zienBevestigPictureBox = new System.Windows.Forms.PictureBox();
            this.wijzigButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zienWPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zienBevestigPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nieuw wachtwoord";
            // 
            // nieuwTextBox
            // 
            this.nieuwTextBox.Location = new System.Drawing.Point(16, 79);
            this.nieuwTextBox.Name = "nieuwTextBox";
            this.nieuwTextBox.Size = new System.Drawing.Size(227, 22);
            this.nieuwTextBox.TabIndex = 1;
            this.nieuwTextBox.UseSystemPasswordChar = true;
            this.nieuwTextBox.TextChanged += new System.EventHandler(this.nieuwTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bevestig wachtwoord";
            // 
            // bevestigTextBox
            // 
            this.bevestigTextBox.Location = new System.Drawing.Point(16, 164);
            this.bevestigTextBox.Name = "bevestigTextBox";
            this.bevestigTextBox.Size = new System.Drawing.Size(227, 22);
            this.bevestigTextBox.TabIndex = 3;
            this.bevestigTextBox.UseSystemPasswordChar = true;
            this.bevestigTextBox.TextChanged += new System.EventHandler(this.bevestigTextBox_TextChanged);
            // 
            // zienWPictureBox
            // 
            this.zienWPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.zienWPictureBox.Image = global::Presentation.Properties.Resources.passwordView;
            this.zienWPictureBox.Location = new System.Drawing.Point(244, 79);
            this.zienWPictureBox.Name = "zienWPictureBox";
            this.zienWPictureBox.Size = new System.Drawing.Size(30, 25);
            this.zienWPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zienWPictureBox.TabIndex = 25;
            this.zienWPictureBox.TabStop = false;
            this.zienWPictureBox.MouseLeave += new System.EventHandler(this.zienWPictureBox_MouseLeave);
            this.zienWPictureBox.MouseHover += new System.EventHandler(this.zienWPictureBox_MouseHover);
            // 
            // zienBevestigPictureBox
            // 
            this.zienBevestigPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.zienBevestigPictureBox.Image = global::Presentation.Properties.Resources.passwordView;
            this.zienBevestigPictureBox.Location = new System.Drawing.Point(244, 164);
            this.zienBevestigPictureBox.Name = "zienBevestigPictureBox";
            this.zienBevestigPictureBox.Size = new System.Drawing.Size(30, 25);
            this.zienBevestigPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zienBevestigPictureBox.TabIndex = 26;
            this.zienBevestigPictureBox.TabStop = false;
            this.zienBevestigPictureBox.MouseLeave += new System.EventHandler(this.zienBevestigPictureBox_MouseLeave);
            this.zienBevestigPictureBox.MouseHover += new System.EventHandler(this.zienBevestigPictureBox_MouseHover);
            // 
            // wijzigButton
            // 
            this.wijzigButton.Location = new System.Drawing.Point(63, 218);
            this.wijzigButton.Name = "wijzigButton";
            this.wijzigButton.Size = new System.Drawing.Size(167, 29);
            this.wijzigButton.TabIndex = 27;
            this.wijzigButton.Text = "Verander wachtwoord";
            this.wijzigButton.UseVisualStyleBackColor = true;
            this.wijzigButton.Click += new System.EventHandler(this.wijzigButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Transparent;
            this.returnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.ForeColor = System.Drawing.Color.Black;
            this.returnButton.Location = new System.Drawing.Point(9, 4);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(41, 34);
            this.returnButton.TabIndex = 28;
            this.returnButton.Text = "<";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // WachtwoordHerstelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 303);
            this.ControlBox = false;
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.wijzigButton);
            this.Controls.Add(this.zienBevestigPictureBox);
            this.Controls.Add(this.zienWPictureBox);
            this.Controls.Add(this.bevestigTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nieuwTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WachtwoordHerstelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Herstel wachtwoord";
            ((System.ComponentModel.ISupportInitialize)(this.zienWPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zienBevestigPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nieuwTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bevestigTextBox;
        private System.Windows.Forms.PictureBox zienWPictureBox;
        private System.Windows.Forms.PictureBox zienBevestigPictureBox;
        private System.Windows.Forms.Button wijzigButton;
        private System.Windows.Forms.Button returnButton;
    }
}