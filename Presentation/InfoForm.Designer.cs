namespace Presentation
{
    partial class InfoForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.favoPictureBox = new System.Windows.Forms.PictureBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vertrekTextBox = new System.Windows.Forms.TextBox();
            this.vertrekUurTextBox = new System.Windows.Forms.TextBox();
            this.aankomstTextBox = new System.Windows.Forms.TextBox();
            this.AankomstUurTextBox = new System.Windows.Forms.TextBox();
            this.schemaTextBox = new System.Windows.Forms.TextBox();
            this.opslaanToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.favoPictureBox);
            this.panel2.Controls.Add(this.returnButton);
            this.panel2.Location = new System.Drawing.Point(-3, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 60);
            this.panel2.TabIndex = 2;
            // 
            // favoPictureBox
            // 
            this.favoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.favoPictureBox.Image = global::Presentation.Properties.Resources.toevoegen;
            this.favoPictureBox.Location = new System.Drawing.Point(305, 14);
            this.favoPictureBox.Name = "favoPictureBox";
            this.favoPictureBox.Size = new System.Drawing.Size(34, 33);
            this.favoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.favoPictureBox.TabIndex = 1;
            this.favoPictureBox.TabStop = false;
            this.opslaanToolTip.SetToolTip(this.favoPictureBox, "Opslaan");
            this.favoPictureBox.Visible = false;
            this.favoPictureBox.Click += new System.EventHandler(this.favoPictureBox_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(16, 14);
            this.returnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(55, 33);
            this.returnButton.TabIndex = 0;
            this.returnButton.Text = "<--";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "VertrekStation:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "VertrekUur:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "AankostStation:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "AankomstUur:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Week/Weekend:";
            // 
            // vertrekTextBox
            // 
            this.vertrekTextBox.Location = new System.Drawing.Point(145, 98);
            this.vertrekTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vertrekTextBox.Name = "vertrekTextBox";
            this.vertrekTextBox.ReadOnly = true;
            this.vertrekTextBox.Size = new System.Drawing.Size(135, 22);
            this.vertrekTextBox.TabIndex = 8;
            // 
            // vertrekUurTextBox
            // 
            this.vertrekUurTextBox.Location = new System.Drawing.Point(145, 146);
            this.vertrekUurTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vertrekUurTextBox.Name = "vertrekUurTextBox";
            this.vertrekUurTextBox.ReadOnly = true;
            this.vertrekUurTextBox.Size = new System.Drawing.Size(135, 22);
            this.vertrekUurTextBox.TabIndex = 9;
            // 
            // aankomstTextBox
            // 
            this.aankomstTextBox.Location = new System.Drawing.Point(145, 193);
            this.aankomstTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aankomstTextBox.Name = "aankomstTextBox";
            this.aankomstTextBox.ReadOnly = true;
            this.aankomstTextBox.Size = new System.Drawing.Size(135, 22);
            this.aankomstTextBox.TabIndex = 10;
            // 
            // AankomstUurTextBox
            // 
            this.AankomstUurTextBox.Location = new System.Drawing.Point(145, 240);
            this.AankomstUurTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AankomstUurTextBox.Name = "AankomstUurTextBox";
            this.AankomstUurTextBox.ReadOnly = true;
            this.AankomstUurTextBox.Size = new System.Drawing.Size(135, 22);
            this.AankomstUurTextBox.TabIndex = 11;
            // 
            // schemaTextBox
            // 
            this.schemaTextBox.Location = new System.Drawing.Point(145, 287);
            this.schemaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.schemaTextBox.Name = "schemaTextBox";
            this.schemaTextBox.ReadOnly = true;
            this.schemaTextBox.Size = new System.Drawing.Size(135, 22);
            this.schemaTextBox.TabIndex = 12;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 366);
            this.ControlBox = false;
            this.Controls.Add(this.schemaTextBox);
            this.Controls.Add(this.AankomstUurTextBox);
            this.Controls.Add(this.aankomstTextBox);
            this.Controls.Add(this.vertrekUurTextBox);
            this.Controls.Add(this.vertrekTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "info";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.favoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vertrekTextBox;
        private System.Windows.Forms.TextBox vertrekUurTextBox;
        private System.Windows.Forms.TextBox aankomstTextBox;
        private System.Windows.Forms.TextBox AankomstUurTextBox;
        private System.Windows.Forms.TextBox schemaTextBox;
        private System.Windows.Forms.PictureBox favoPictureBox;
        private System.Windows.Forms.ToolTip opslaanToolTip;
    }
}