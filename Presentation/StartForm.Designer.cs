namespace Presentation
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.routesListBox = new System.Windows.Forms.ListBox();
            this.naarTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vertrekRadioButton = new System.Windows.Forms.RadioButton();
            this.aankomstRadioButton = new System.Windows.Forms.RadioButton();
            this.VanTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.zoekButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nieuwButton = new System.Windows.Forms.Button();
            this.verwijderButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datumkiezerMonthCalender = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.datumLabel = new System.Windows.Forms.Label();
            this.vertrekUurNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.aankomstUurNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.vertrekMinutenNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.aankomstMinuutNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tijdFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.naamCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertrekUurNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aankomstUurNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertrekMinutenNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aankomstMinuutNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // routesListBox
            // 
            this.routesListBox.FormattingEnabled = true;
            resources.ApplyResources(this.routesListBox, "routesListBox");
            this.routesListBox.Name = "routesListBox";
            // 
            // naarTextBox
            // 
            resources.ApplyResources(this.naarTextBox, "naarTextBox");
            this.naarTextBox.Name = "naarTextBox";
            this.naarTextBox.TextChanged += new System.EventHandler(this.naarTextBox_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // vertrekRadioButton
            // 
            resources.ApplyResources(this.vertrekRadioButton, "vertrekRadioButton");
            this.vertrekRadioButton.Checked = true;
            this.vertrekRadioButton.Name = "vertrekRadioButton";
            this.vertrekRadioButton.TabStop = true;
            this.vertrekRadioButton.UseVisualStyleBackColor = true;
            this.vertrekRadioButton.CheckedChanged += new System.EventHandler(this.vertrekRadioButton_CheckedChanged);
            // 
            // aankomstRadioButton
            // 
            resources.ApplyResources(this.aankomstRadioButton, "aankomstRadioButton");
            this.aankomstRadioButton.Name = "aankomstRadioButton";
            this.aankomstRadioButton.UseVisualStyleBackColor = true;
            this.aankomstRadioButton.CheckedChanged += new System.EventHandler(this.aankomstRadioButton_CheckedChanged);
            // 
            // VanTextBox
            // 
            resources.ApplyResources(this.VanTextBox, "VanTextBox");
            this.VanTextBox.Name = "VanTextBox";
            this.VanTextBox.ReadOnly = true;
            this.VanTextBox.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // zoekButton
            // 
            this.zoekButton.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.zoekButton, "zoekButton");
            this.zoekButton.Name = "zoekButton";
            this.zoekButton.UseVisualStyleBackColor = false;
            this.zoekButton.Click += new System.EventHandler(this.zoekButton_Click);
            // 
            // infoButton
            // 
            resources.ApplyResources(this.infoButton, "infoButton");
            this.infoButton.Name = "infoButton";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.nieuwButton);
            this.panel1.Controls.Add(this.verwijderButton);
            this.panel1.Controls.Add(this.EditButton);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // nieuwButton
            // 
            resources.ApplyResources(this.nieuwButton, "nieuwButton");
            this.nieuwButton.Name = "nieuwButton";
            this.nieuwButton.UseVisualStyleBackColor = true;
            this.nieuwButton.Click += new System.EventHandler(this.nieuwButton_Click);
            // 
            // verwijderButton
            // 
            resources.ApplyResources(this.verwijderButton, "verwijderButton");
            this.verwijderButton.Name = "verwijderButton";
            this.verwijderButton.UseVisualStyleBackColor = true;
            this.verwijderButton.Click += new System.EventHandler(this.verwijderButton_Click);
            // 
            // EditButton
            // 
            resources.ApplyResources(this.EditButton, "EditButton");
            this.EditButton.Name = "EditButton";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.userPictureBox);
            this.panel2.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // userPictureBox
            // 
            this.userPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userPictureBox.Image = global::Presentation.Properties.Resources.user;
            resources.ApplyResources(this.userPictureBox, "userPictureBox");
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.TabStop = false;
            this.userPictureBox.Click += new System.EventHandler(this.userPictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation.Properties.Resources.LOGOp;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // datumkiezerMonthCalender
            // 
            resources.ApplyResources(this.datumkiezerMonthCalender, "datumkiezerMonthCalender");
            this.datumkiezerMonthCalender.MaxSelectionCount = 1;
            this.datumkiezerMonthCalender.Name = "datumkiezerMonthCalender";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // datumLabel
            // 
            resources.ApplyResources(this.datumLabel, "datumLabel");
            this.datumLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.datumLabel.Name = "datumLabel";
            // 
            // vertrekUurNumericUpDown
            // 
            resources.ApplyResources(this.vertrekUurNumericUpDown, "vertrekUurNumericUpDown");
            this.vertrekUurNumericUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.vertrekUurNumericUpDown.Name = "vertrekUurNumericUpDown";
            // 
            // aankomstUurNumericUpDown
            // 
            resources.ApplyResources(this.aankomstUurNumericUpDown, "aankomstUurNumericUpDown");
            this.aankomstUurNumericUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.aankomstUurNumericUpDown.Name = "aankomstUurNumericUpDown";
            // 
            // vertrekMinutenNumericUpDown
            // 
            resources.ApplyResources(this.vertrekMinutenNumericUpDown, "vertrekMinutenNumericUpDown");
            this.vertrekMinutenNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.vertrekMinutenNumericUpDown.Name = "vertrekMinutenNumericUpDown";
            // 
            // aankomstMinuutNumericUpDown
            // 
            resources.ApplyResources(this.aankomstMinuutNumericUpDown, "aankomstMinuutNumericUpDown");
            this.aankomstMinuutNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.aankomstMinuutNumericUpDown.Name = "aankomstMinuutNumericUpDown";
            // 
            // tijdFilterCheckBox
            // 
            resources.ApplyResources(this.tijdFilterCheckBox, "tijdFilterCheckBox");
            this.tijdFilterCheckBox.Name = "tijdFilterCheckBox";
            this.tijdFilterCheckBox.UseVisualStyleBackColor = true;
            this.tijdFilterCheckBox.CheckedChanged += new System.EventHandler(this.tijdFilterCheckBox_CheckedChanged);
            // 
            // naamCheckBox
            // 
            resources.ApplyResources(this.naamCheckBox, "naamCheckBox");
            this.naamCheckBox.Name = "naamCheckBox";
            this.naamCheckBox.UseVisualStyleBackColor = true;
            this.naamCheckBox.CheckedChanged += new System.EventHandler(this.naamCheckBox_CheckedChanged);
            // 
            // MainMenuForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.naamCheckBox);
            this.Controls.Add(this.tijdFilterCheckBox);
            this.Controls.Add(this.aankomstMinuutNumericUpDown);
            this.Controls.Add(this.vertrekMinutenNumericUpDown);
            this.Controls.Add(this.aankomstUurNumericUpDown);
            this.Controls.Add(this.vertrekUurNumericUpDown);
            this.Controls.Add(this.datumLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datumkiezerMonthCalender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.zoekButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VanTextBox);
            this.Controls.Add(this.aankomstRadioButton);
            this.Controls.Add(this.vertrekRadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.naarTextBox);
            this.Controls.Add(this.routesListBox);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenuForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertrekUurNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aankomstUurNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertrekMinutenNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aankomstMinuutNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox routesListBox;
        private System.Windows.Forms.TextBox naarTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton vertrekRadioButton;
        private System.Windows.Forms.RadioButton aankomstRadioButton;
        private System.Windows.Forms.TextBox VanTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button zoekButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar datumkiezerMonthCalender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label datumLabel;
        private System.Windows.Forms.NumericUpDown vertrekUurNumericUpDown;
        private System.Windows.Forms.NumericUpDown aankomstUurNumericUpDown;
        private System.Windows.Forms.NumericUpDown vertrekMinutenNumericUpDown;
        private System.Windows.Forms.NumericUpDown aankomstMinuutNumericUpDown;
        private System.Windows.Forms.CheckBox tijdFilterCheckBox;
        private System.Windows.Forms.CheckBox naamCheckBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button nieuwButton;
        private System.Windows.Forms.Button verwijderButton;
        private System.Windows.Forms.PictureBox userPictureBox;
    }
}

