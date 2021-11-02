namespace Presentation
{
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.returnButton = new System.Windows.Forms.Button();
            this.aankomstTextBox = new System.Windows.Forms.TextBox();
            this.vertrekTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.opslaanButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.vertrekUurNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.vertrekMinuutNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AankomstUurNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AankomstMinuutNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.afstandNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.schemaComboBox = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vertrekUurNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertrekMinuutNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AankomstUurNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AankomstMinuutNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afstandNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.returnButton);
            this.panel2.Location = new System.Drawing.Point(-3, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 60);
            this.panel2.TabIndex = 3;
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
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click_1);
            // 
            // aankomstTextBox
            // 
            this.aankomstTextBox.Location = new System.Drawing.Point(145, 193);
            this.aankomstTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aankomstTextBox.Name = "aankomstTextBox";
            this.aankomstTextBox.Size = new System.Drawing.Size(135, 22);
            this.aankomstTextBox.TabIndex = 20;
            this.aankomstTextBox.TextChanged += new System.EventHandler(this.aankomstTextBox_TextChanged);
            // 
            // vertrekTextBox
            // 
            this.vertrekTextBox.Enabled = false;
            this.vertrekTextBox.Location = new System.Drawing.Point(145, 98);
            this.vertrekTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vertrekTextBox.Name = "vertrekTextBox";
            this.vertrekTextBox.ReadOnly = true;
            this.vertrekTextBox.Size = new System.Drawing.Size(135, 22);
            this.vertrekTextBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Week/Weekend:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "AankomstUur:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "AankostStation:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "VertrekUur:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "VertrekStation:";
            // 
            // opslaanButton
            // 
            this.opslaanButton.Location = new System.Drawing.Point(97, 356);
            this.opslaanButton.Name = "opslaanButton";
            this.opslaanButton.Size = new System.Drawing.Size(143, 33);
            this.opslaanButton.TabIndex = 23;
            this.opslaanButton.Text = "Opslaan";
            this.opslaanButton.UseVisualStyleBackColor = true;
            this.opslaanButton.Click += new System.EventHandler(this.opslaanButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = ":";
            // 
            // vertrekUurNumericUpDown
            // 
            this.vertrekUurNumericUpDown.Location = new System.Drawing.Point(145, 149);
            this.vertrekUurNumericUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.vertrekUurNumericUpDown.Name = "vertrekUurNumericUpDown";
            this.vertrekUurNumericUpDown.Size = new System.Drawing.Size(44, 22);
            this.vertrekUurNumericUpDown.TabIndex = 28;
            // 
            // vertrekMinuutNumericUpDown
            // 
            this.vertrekMinuutNumericUpDown.Location = new System.Drawing.Point(210, 149);
            this.vertrekMinuutNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.vertrekMinuutNumericUpDown.Name = "vertrekMinuutNumericUpDown";
            this.vertrekMinuutNumericUpDown.Size = new System.Drawing.Size(44, 22);
            this.vertrekMinuutNumericUpDown.TabIndex = 29;
            // 
            // AankomstUurNumericUpDown
            // 
            this.AankomstUurNumericUpDown.Location = new System.Drawing.Point(145, 238);
            this.AankomstUurNumericUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.AankomstUurNumericUpDown.Name = "AankomstUurNumericUpDown";
            this.AankomstUurNumericUpDown.Size = new System.Drawing.Size(44, 22);
            this.AankomstUurNumericUpDown.TabIndex = 30;
            // 
            // AankomstMinuutNumericUpDown
            // 
            this.AankomstMinuutNumericUpDown.Location = new System.Drawing.Point(206, 238);
            this.AankomstMinuutNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.AankomstMinuutNumericUpDown.Name = "AankomstMinuutNumericUpDown";
            this.AankomstMinuutNumericUpDown.Size = new System.Drawing.Size(44, 22);
            this.AankomstMinuutNumericUpDown.TabIndex = 31;
            // 
            // afstandNumericUpDown
            // 
            this.afstandNumericUpDown.Location = new System.Drawing.Point(145, 274);
            this.afstandNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.afstandNumericUpDown.Name = "afstandNumericUpDown";
            this.afstandNumericUpDown.Size = new System.Drawing.Size(95, 22);
            this.afstandNumericUpDown.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Afstand";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(246, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 17);
            this.label10.TabIndex = 36;
            this.label10.Text = "km";
            // 
            // schemaComboBox
            // 
            this.schemaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schemaComboBox.FormattingEnabled = true;
            this.schemaComboBox.Items.AddRange(new object[] {
            "Week",
            "Weekend"});
            this.schemaComboBox.Location = new System.Drawing.Point(145, 310);
            this.schemaComboBox.Name = "schemaComboBox";
            this.schemaComboBox.Size = new System.Drawing.Size(95, 24);
            this.schemaComboBox.TabIndex = 59;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 464);
            this.ControlBox = false;
            this.Controls.Add(this.schemaComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.afstandNumericUpDown);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AankomstMinuutNumericUpDown);
            this.Controls.Add(this.AankomstUurNumericUpDown);
            this.Controls.Add(this.vertrekMinuutNumericUpDown);
            this.Controls.Add(this.vertrekUurNumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.opslaanButton);
            this.Controls.Add(this.aankomstTextBox);
            this.Controls.Add(this.vertrekTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vertrekUurNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertrekMinuutNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AankomstUurNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AankomstMinuutNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afstandNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.TextBox aankomstTextBox;
        private System.Windows.Forms.TextBox vertrekTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button opslaanButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown vertrekUurNumericUpDown;
        private System.Windows.Forms.NumericUpDown vertrekMinuutNumericUpDown;
        private System.Windows.Forms.NumericUpDown AankomstUurNumericUpDown;
        private System.Windows.Forms.NumericUpDown AankomstMinuutNumericUpDown;
        private System.Windows.Forms.NumericUpDown afstandNumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox schemaComboBox;
    }
}