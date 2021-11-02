namespace Presentation
{
    partial class VerwijderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerwijderForm));
            this.vraagLabel = new System.Windows.Forms.Label();
            this.jaButton = new System.Windows.Forms.Button();
            this.neeButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vraagLabel
            // 
            this.vraagLabel.AutoSize = true;
            this.vraagLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vraagLabel.Location = new System.Drawing.Point(25, 50);
            this.vraagLabel.Name = "vraagLabel";
            this.vraagLabel.Size = new System.Drawing.Size(52, 17);
            this.vraagLabel.TabIndex = 0;
            this.vraagLabel.Text = "label1";
            // 
            // jaButton
            // 
            this.jaButton.Location = new System.Drawing.Point(125, 138);
            this.jaButton.Name = "jaButton";
            this.jaButton.Size = new System.Drawing.Size(108, 43);
            this.jaButton.TabIndex = 1;
            this.jaButton.Text = "JA";
            this.jaButton.UseVisualStyleBackColor = true;
            this.jaButton.Click += new System.EventHandler(this.jaButton_Click);
            // 
            // neeButton
            // 
            this.neeButton.Location = new System.Drawing.Point(357, 138);
            this.neeButton.Name = "neeButton";
            this.neeButton.Size = new System.Drawing.Size(108, 43);
            this.neeButton.TabIndex = 2;
            this.neeButton.Text = "NEE";
            this.neeButton.UseVisualStyleBackColor = true;
            this.neeButton.Click += new System.EventHandler(this.neeButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.errorLabel.Location = new System.Drawing.Point(25, 95);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(46, 17);
            this.errorLabel.TabIndex = 32;
            this.errorLabel.Text = "label5";
            this.errorLabel.Visible = false;
            // 
            // VerwijderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 219);
            this.ControlBox = false;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.neeButton);
            this.Controls.Add(this.jaButton);
            this.Controls.Add(this.vraagLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerwijderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Verwijder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vraagLabel;
        private System.Windows.Forms.Button jaButton;
        private System.Windows.Forms.Button neeButton;
        private System.Windows.Forms.Label errorLabel;
    }
}