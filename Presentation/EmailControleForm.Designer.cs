namespace Presentation
{
    partial class EmailControleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailControleForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.controleButton = new System.Windows.Forms.Button();
            this.codeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.doorgaanButton = new System.Windows.Forms.Button();
            this.foutLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Controle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(65, 54);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(248, 22);
            this.emailTextBox.TabIndex = 2;
            // 
            // controleButton
            // 
            this.controleButton.Location = new System.Drawing.Point(184, 82);
            this.controleButton.Name = "controleButton";
            this.controleButton.Size = new System.Drawing.Size(129, 23);
            this.controleButton.TabIndex = 3;
            this.controleButton.Text = "Controleren";
            this.controleButton.UseVisualStyleBackColor = true;
            this.controleButton.Click += new System.EventHandler(this.controleButton_Click);
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.BackColor = System.Drawing.Color.Transparent;
            this.codeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeLabel.ForeColor = System.Drawing.Color.Crimson;
            this.codeLabel.Location = new System.Drawing.Point(12, 118);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(100, 15);
            this.codeLabel.TabIndex = 4;
            this.codeLabel.Text = "verstuurd naar: ...";
            this.codeLabel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Geheime code:";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(115, 147);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(113, 22);
            this.codeTextBox.TabIndex = 6;
            // 
            // doorgaanButton
            // 
            this.doorgaanButton.Location = new System.Drawing.Point(99, 209);
            this.doorgaanButton.Name = "doorgaanButton";
            this.doorgaanButton.Size = new System.Drawing.Size(129, 33);
            this.doorgaanButton.TabIndex = 7;
            this.doorgaanButton.Text = "Doorgaan";
            this.doorgaanButton.UseVisualStyleBackColor = true;
            this.doorgaanButton.Click += new System.EventHandler(this.doorgaanButton_Click);
            // 
            // foutLabel
            // 
            this.foutLabel.AutoSize = true;
            this.foutLabel.BackColor = System.Drawing.Color.Transparent;
            this.foutLabel.ForeColor = System.Drawing.Color.Crimson;
            this.foutLabel.Location = new System.Drawing.Point(16, 180);
            this.foutLabel.Name = "foutLabel";
            this.foutLabel.Size = new System.Drawing.Size(114, 17);
            this.foutLabel.TabIndex = 8;
            this.foutLabel.Text = "Code is incorrect";
            this.foutLabel.Visible = false;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Transparent;
            this.returnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.ForeColor = System.Drawing.Color.Black;
            this.returnButton.Location = new System.Drawing.Point(9, 9);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(41, 34);
            this.returnButton.TabIndex = 29;
            this.returnButton.Text = "<";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // EmailControleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 278);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.foutLabel);
            this.Controls.Add(this.doorgaanButton);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.controleButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmailControleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Controle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button controleButton;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Button doorgaanButton;
        private System.Windows.Forms.Label foutLabel;
        private System.Windows.Forms.Button returnButton;
    }
}