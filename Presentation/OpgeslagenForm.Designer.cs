namespace Presentation
{
    partial class OpgeslagenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpgeslagenForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.returnButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.verwijderButton = new System.Windows.Forms.Button();
            this.wijzigButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.opgeslagenListBox = new System.Windows.Forms.ListBox();
            this.infoButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.returnButton);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 52);
            this.panel2.TabIndex = 15;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.Controls.Add(this.verwijderButton);
            this.panel3.Controls.Add(this.wijzigButton);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(-3, 423);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(675, 52);
            this.panel3.TabIndex = 17;
            // 
            // verwijderButton
            // 
            this.verwijderButton.Location = new System.Drawing.Point(241, 9);
            this.verwijderButton.Name = "verwijderButton";
            this.verwijderButton.Size = new System.Drawing.Size(89, 32);
            this.verwijderButton.TabIndex = 5;
            this.verwijderButton.Text = "Verwijder";
            this.verwijderButton.UseVisualStyleBackColor = true;
            this.verwijderButton.Visible = false;
            this.verwijderButton.Click += new System.EventHandler(this.verwijderButton_Click);
            // 
            // wijzigButton
            // 
            this.wijzigButton.Location = new System.Drawing.Point(80, 9);
            this.wijzigButton.Name = "wijzigButton";
            this.wijzigButton.Size = new System.Drawing.Size(89, 32);
            this.wijzigButton.TabIndex = 4;
            this.wijzigButton.Text = "Werk bij";
            this.wijzigButton.UseVisualStyleBackColor = true;
            this.wijzigButton.Visible = false;
            this.wijzigButton.Click += new System.EventHandler(this.wijzigButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel4.Location = new System.Drawing.Point(8, 52);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(489, 52);
            this.panel4.TabIndex = 3;
            // 
            // opgeslagenListBox
            // 
            this.opgeslagenListBox.FormattingEnabled = true;
            this.opgeslagenListBox.ItemHeight = 16;
            this.opgeslagenListBox.Location = new System.Drawing.Point(12, 69);
            this.opgeslagenListBox.Name = "opgeslagenListBox";
            this.opgeslagenListBox.Size = new System.Drawing.Size(408, 308);
            this.opgeslagenListBox.TabIndex = 18;
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(50, 382);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(313, 37);
            this.infoButton.TabIndex = 19;
            this.infoButton.Text = "Info";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // OpgeslagenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 509);
            this.ControlBox = false;
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.opgeslagenListBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OpgeslagenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Opgeslagen";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button verwijderButton;
        private System.Windows.Forms.Button wijzigButton;
        private System.Windows.Forms.ListBox opgeslagenListBox;
        private System.Windows.Forms.Button infoButton;
    }
}