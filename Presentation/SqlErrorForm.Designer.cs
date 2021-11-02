namespace Presentation
{
    partial class SqlErrorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlErrorForm));
            this.label1 = new System.Windows.Forms.Label();
            this.doorgaanButton = new System.Windows.Forms.Button();
            this.afsluitenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(759, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gelieve Localhost op te starten om gebruik te kunnen maken van de database";
            // 
            // doorgaanButton
            // 
            this.doorgaanButton.Location = new System.Drawing.Point(66, 153);
            this.doorgaanButton.Name = "doorgaanButton";
            this.doorgaanButton.Size = new System.Drawing.Size(231, 55);
            this.doorgaanButton.TabIndex = 1;
            this.doorgaanButton.Text = "Doorgaan";
            this.doorgaanButton.UseVisualStyleBackColor = true;
            this.doorgaanButton.Click += new System.EventHandler(this.doorgaanButton_Click);
            // 
            // afsluitenButton
            // 
            this.afsluitenButton.Location = new System.Drawing.Point(479, 153);
            this.afsluitenButton.Name = "afsluitenButton";
            this.afsluitenButton.Size = new System.Drawing.Size(231, 55);
            this.afsluitenButton.TabIndex = 2;
            this.afsluitenButton.Text = "Afsluiten";
            this.afsluitenButton.UseVisualStyleBackColor = true;
            this.afsluitenButton.Click += new System.EventHandler(this.afsluitenButton_Click);
            // 
            // SqlErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 285);
            this.ControlBox = false;
            this.Controls.Add(this.afsluitenButton);
            this.Controls.Add(this.doorgaanButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SqlErrorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SqlError";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button doorgaanButton;
        private System.Windows.Forms.Button afsluitenButton;
    }
}