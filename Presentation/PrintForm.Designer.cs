namespace Presentation
{
    partial class PrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
            this.printenMenuStrip = new System.Windows.Forms.MenuStrip();
            this.gebruikersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alleGebruikersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alleStationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gebruikerPannel = new System.Windows.Forms.Panel();
            this.gebErrorLabel = new System.Windows.Forms.Label();
            this.adminComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.totDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vanafDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.adminFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.geboorteFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gebruikerPDFButton = new System.Windows.Forms.Button();
            this.gebruikersnaamTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gebrfilterCheckbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.geboortedatumCheckBox = new System.Windows.Forms.CheckBox();
            this.adminCheckBox = new System.Windows.Forms.CheckBox();
            this.emailCheckBox = new System.Windows.Forms.CheckBox();
            this.gebruikersnaamCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stationPanel = new System.Windows.Forms.Panel();
            this.stErrorLabel = new System.Windows.Forms.Label();
            this.filterNaamCheckBox = new System.Windows.Forms.CheckBox();
            this.verwijderButton = new System.Windows.Forms.Button();
            this.toevoegenButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.alleStationsListBox = new System.Windows.Forms.ListBox();
            this.FilterStationListBox = new System.Windows.Forms.ListBox();
            this.schemaCheckBox = new System.Windows.Forms.CheckBox();
            this.stationPDFButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.afstandCheckBox = new System.Windows.Forms.CheckBox();
            this.aankomststationCheckBox = new System.Windows.Forms.CheckBox();
            this.aankomstuurCheckBox = new System.Windows.Forms.CheckBox();
            this.vertrekuurCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.printenMenuStrip.SuspendLayout();
            this.gebruikerPannel.SuspendLayout();
            this.stationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // printenMenuStrip
            // 
            this.printenMenuStrip.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.printenMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.printenMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gebruikersToolStripMenuItem,
            this.stationsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.printenMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.printenMenuStrip.Name = "printenMenuStrip";
            this.printenMenuStrip.Size = new System.Drawing.Size(657, 28);
            this.printenMenuStrip.TabIndex = 17;
            this.printenMenuStrip.Text = "printenMenuStrip";
            // 
            // gebruikersToolStripMenuItem
            // 
            this.gebruikersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alleGebruikersToolStripMenuItem,
            this.filterToolStripMenuItem});
            this.gebruikersToolStripMenuItem.Name = "gebruikersToolStripMenuItem";
            this.gebruikersToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.gebruikersToolStripMenuItem.Text = "Gebruikers";
            // 
            // alleGebruikersToolStripMenuItem
            // 
            this.alleGebruikersToolStripMenuItem.Name = "alleGebruikersToolStripMenuItem";
            this.alleGebruikersToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.alleGebruikersToolStripMenuItem.Text = "Alle gebruikers";
            this.alleGebruikersToolStripMenuItem.Click += new System.EventHandler(this.alleGebruikersToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.filterToolStripMenuItem.Text = "Filter";
            this.filterToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click);
            // 
            // stationsToolStripMenuItem
            // 
            this.stationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alleStationsToolStripMenuItem,
            this.filterToolStripMenuItem1});
            this.stationsToolStripMenuItem.Name = "stationsToolStripMenuItem";
            this.stationsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.stationsToolStripMenuItem.Text = "Stations";
            // 
            // alleStationsToolStripMenuItem
            // 
            this.alleStationsToolStripMenuItem.Name = "alleStationsToolStripMenuItem";
            this.alleStationsToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.alleStationsToolStripMenuItem.Text = "Alle Stations";
            this.alleStationsToolStripMenuItem.Click += new System.EventHandler(this.alleStationsToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem1
            // 
            this.filterToolStripMenuItem1.Name = "filterToolStripMenuItem1";
            this.filterToolStripMenuItem1.Size = new System.Drawing.Size(167, 26);
            this.filterToolStripMenuItem1.Text = "Filter";
            this.filterToolStripMenuItem1.Click += new System.EventHandler(this.filterToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // gebruikerPannel
            // 
            this.gebruikerPannel.BackColor = System.Drawing.Color.Transparent;
            this.gebruikerPannel.Controls.Add(this.gebErrorLabel);
            this.gebruikerPannel.Controls.Add(this.adminComboBox);
            this.gebruikerPannel.Controls.Add(this.panel1);
            this.gebruikerPannel.Controls.Add(this.label11);
            this.gebruikerPannel.Controls.Add(this.totDateTimePicker);
            this.gebruikerPannel.Controls.Add(this.vanafDateTimePicker);
            this.gebruikerPannel.Controls.Add(this.label10);
            this.gebruikerPannel.Controls.Add(this.adminFilterCheckBox);
            this.gebruikerPannel.Controls.Add(this.label9);
            this.gebruikerPannel.Controls.Add(this.geboorteFilterCheckBox);
            this.gebruikerPannel.Controls.Add(this.label8);
            this.gebruikerPannel.Controls.Add(this.gebruikerPDFButton);
            this.gebruikerPannel.Controls.Add(this.gebruikersnaamTextBox);
            this.gebruikerPannel.Controls.Add(this.label3);
            this.gebruikerPannel.Controls.Add(this.gebrfilterCheckbox);
            this.gebruikerPannel.Controls.Add(this.label2);
            this.gebruikerPannel.Controls.Add(this.geboortedatumCheckBox);
            this.gebruikerPannel.Controls.Add(this.adminCheckBox);
            this.gebruikerPannel.Controls.Add(this.emailCheckBox);
            this.gebruikerPannel.Controls.Add(this.gebruikersnaamCheckBox);
            this.gebruikerPannel.Controls.Add(this.label1);
            this.gebruikerPannel.Location = new System.Drawing.Point(0, 24);
            this.gebruikerPannel.Name = "gebruikerPannel";
            this.gebruikerPannel.Size = new System.Drawing.Size(640, 469);
            this.gebruikerPannel.TabIndex = 18;
            this.gebruikerPannel.Visible = false;
            // 
            // gebErrorLabel
            // 
            this.gebErrorLabel.AutoSize = true;
            this.gebErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.gebErrorLabel.Location = new System.Drawing.Point(26, 415);
            this.gebErrorLabel.Name = "gebErrorLabel";
            this.gebErrorLabel.Size = new System.Drawing.Size(49, 17);
            this.gebErrorLabel.TabIndex = 22;
            this.gebErrorLabel.Text = "*error*";
            this.gebErrorLabel.Visible = false;
            // 
            // adminComboBox
            // 
            this.adminComboBox.Enabled = false;
            this.adminComboBox.FormattingEnabled = true;
            this.adminComboBox.Items.AddRange(new object[] {
            "Ja",
            "Nee"});
            this.adminComboBox.Location = new System.Drawing.Point(93, 349);
            this.adminComboBox.Name = "adminComboBox";
            this.adminComboBox.Size = new System.Drawing.Size(121, 24);
            this.adminComboBox.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(207, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 76);
            this.panel1.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(394, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "en";
            // 
            // totDateTimePicker
            // 
            this.totDateTimePicker.Enabled = false;
            this.totDateTimePicker.Location = new System.Drawing.Point(420, 297);
            this.totDateTimePicker.Name = "totDateTimePicker";
            this.totDateTimePicker.Size = new System.Drawing.Size(208, 22);
            this.totDateTimePicker.TabIndex = 18;
            // 
            // vanafDateTimePicker
            // 
            this.vanafDateTimePicker.Enabled = false;
            this.vanafDateTimePicker.Location = new System.Drawing.Point(183, 297);
            this.vanafDateTimePicker.Name = "vanafDateTimePicker";
            this.vanafDateTimePicker.Size = new System.Drawing.Size(208, 22);
            this.vanafDateTimePicker.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 349);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Is admin:";
            // 
            // adminFilterCheckBox
            // 
            this.adminFilterCheckBox.AutoSize = true;
            this.adminFilterCheckBox.Location = new System.Drawing.Point(31, 325);
            this.adminFilterCheckBox.Name = "adminFilterCheckBox";
            this.adminFilterCheckBox.Size = new System.Drawing.Size(139, 21);
            this.adminFilterCheckBox.TabIndex = 14;
            this.adminFilterCheckBox.Text = "Filteren op admin";
            this.adminFilterCheckBox.UseVisualStyleBackColor = true;
            this.adminFilterCheckBox.CheckedChanged += new System.EventHandler(this.adminFilterCheckBox_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "geboortedatum tussen:";
            // 
            // geboorteFilterCheckBox
            // 
            this.geboorteFilterCheckBox.AutoSize = true;
            this.geboorteFilterCheckBox.Location = new System.Drawing.Point(31, 273);
            this.geboorteFilterCheckBox.Name = "geboorteFilterCheckBox";
            this.geboorteFilterCheckBox.Size = new System.Drawing.Size(197, 21);
            this.geboorteFilterCheckBox.TabIndex = 11;
            this.geboorteFilterCheckBox.Text = "Filteren op geboortedatum";
            this.geboorteFilterCheckBox.UseVisualStyleBackColor = true;
            this.geboorteFilterCheckBox.CheckedChanged += new System.EventHandler(this.geboorteFilterCheckBox_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Filters";
            // 
            // gebruikerPDFButton
            // 
            this.gebruikerPDFButton.Location = new System.Drawing.Point(491, 393);
            this.gebruikerPDFButton.Name = "gebruikerPDFButton";
            this.gebruikerPDFButton.Size = new System.Drawing.Size(123, 53);
            this.gebruikerPDFButton.TabIndex = 9;
            this.gebruikerPDFButton.Text = "Naar PDF";
            this.gebruikerPDFButton.UseVisualStyleBackColor = true;
            this.gebruikerPDFButton.Click += new System.EventHandler(this.gebruikerPDFButton_Click);
            // 
            // gebruikersnaamTextBox
            // 
            this.gebruikersnaamTextBox.Enabled = false;
            this.gebruikersnaamTextBox.Location = new System.Drawing.Point(189, 245);
            this.gebruikersnaamTextBox.Name = "gebruikersnaamTextBox";
            this.gebruikersnaamTextBox.Size = new System.Drawing.Size(205, 22);
            this.gebruikersnaamTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gebruikersnaam bevat:";
            // 
            // gebrfilterCheckbox
            // 
            this.gebrfilterCheckbox.AutoSize = true;
            this.gebrfilterCheckbox.Location = new System.Drawing.Point(31, 221);
            this.gebrfilterCheckbox.Name = "gebrfilterCheckbox";
            this.gebrfilterCheckbox.Size = new System.Drawing.Size(203, 21);
            this.gebrfilterCheckbox.TabIndex = 6;
            this.gebrfilterCheckbox.Text = "Filteren op gebruikersnaam";
            this.gebrfilterCheckbox.UseVisualStyleBackColor = true;
            this.gebrfilterCheckbox.CheckedChanged += new System.EventHandler(this.gebrfilterCheckbox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Velden";
            // 
            // geboortedatumCheckBox
            // 
            this.geboortedatumCheckBox.AutoSize = true;
            this.geboortedatumCheckBox.Location = new System.Drawing.Point(246, 139);
            this.geboortedatumCheckBox.Name = "geboortedatumCheckBox";
            this.geboortedatumCheckBox.Size = new System.Drawing.Size(129, 21);
            this.geboortedatumCheckBox.TabIndex = 4;
            this.geboortedatumCheckBox.Text = "Geboortedatum";
            this.geboortedatumCheckBox.UseVisualStyleBackColor = true;
            // 
            // adminCheckBox
            // 
            this.adminCheckBox.AutoSize = true;
            this.adminCheckBox.Location = new System.Drawing.Point(246, 97);
            this.adminCheckBox.Name = "adminCheckBox";
            this.adminCheckBox.Size = new System.Drawing.Size(69, 21);
            this.adminCheckBox.TabIndex = 3;
            this.adminCheckBox.Text = "Admin";
            this.adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // emailCheckBox
            // 
            this.emailCheckBox.AutoSize = true;
            this.emailCheckBox.Location = new System.Drawing.Point(33, 139);
            this.emailCheckBox.Name = "emailCheckBox";
            this.emailCheckBox.Size = new System.Drawing.Size(64, 21);
            this.emailCheckBox.TabIndex = 2;
            this.emailCheckBox.Text = "Email";
            this.emailCheckBox.UseVisualStyleBackColor = true;
            // 
            // gebruikersnaamCheckBox
            // 
            this.gebruikersnaamCheckBox.AutoSize = true;
            this.gebruikersnaamCheckBox.Location = new System.Drawing.Point(32, 97);
            this.gebruikersnaamCheckBox.Name = "gebruikersnaamCheckBox";
            this.gebruikersnaamCheckBox.Size = new System.Drawing.Size(135, 21);
            this.gebruikersnaamCheckBox.TabIndex = 1;
            this.gebruikersnaamCheckBox.Text = "Gebruikersnaam";
            this.gebruikersnaamCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(196, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gebruikers";
            // 
            // stationPanel
            // 
            this.stationPanel.BackColor = System.Drawing.Color.Transparent;
            this.stationPanel.Controls.Add(this.stErrorLabel);
            this.stationPanel.Controls.Add(this.filterNaamCheckBox);
            this.stationPanel.Controls.Add(this.verwijderButton);
            this.stationPanel.Controls.Add(this.toevoegenButton);
            this.stationPanel.Controls.Add(this.label7);
            this.stationPanel.Controls.Add(this.label6);
            this.stationPanel.Controls.Add(this.alleStationsListBox);
            this.stationPanel.Controls.Add(this.FilterStationListBox);
            this.stationPanel.Controls.Add(this.schemaCheckBox);
            this.stationPanel.Controls.Add(this.stationPDFButton);
            this.stationPanel.Controls.Add(this.label5);
            this.stationPanel.Controls.Add(this.afstandCheckBox);
            this.stationPanel.Controls.Add(this.aankomststationCheckBox);
            this.stationPanel.Controls.Add(this.aankomstuurCheckBox);
            this.stationPanel.Controls.Add(this.vertrekuurCheckBox);
            this.stationPanel.Controls.Add(this.label4);
            this.stationPanel.Location = new System.Drawing.Point(0, 47);
            this.stationPanel.Name = "stationPanel";
            this.stationPanel.Size = new System.Drawing.Size(643, 470);
            this.stationPanel.TabIndex = 19;
            this.stationPanel.Visible = false;
            // 
            // stErrorLabel
            // 
            this.stErrorLabel.AutoSize = true;
            this.stErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.stErrorLabel.Location = new System.Drawing.Point(31, 393);
            this.stErrorLabel.Name = "stErrorLabel";
            this.stErrorLabel.Size = new System.Drawing.Size(49, 17);
            this.stErrorLabel.TabIndex = 20;
            this.stErrorLabel.Text = "*error*";
            this.stErrorLabel.Visible = false;
            // 
            // filterNaamCheckBox
            // 
            this.filterNaamCheckBox.AutoSize = true;
            this.filterNaamCheckBox.Location = new System.Drawing.Point(30, 317);
            this.filterNaamCheckBox.Name = "filterNaamCheckBox";
            this.filterNaamCheckBox.Size = new System.Drawing.Size(120, 21);
            this.filterNaamCheckBox.TabIndex = 19;
            this.filterNaamCheckBox.Text = "Filter op naam";
            this.filterNaamCheckBox.UseVisualStyleBackColor = true;
            this.filterNaamCheckBox.CheckedChanged += new System.EventHandler(this.filterNaamCheckBox_CheckedChanged);
            // 
            // verwijderButton
            // 
            this.verwijderButton.Enabled = false;
            this.verwijderButton.Location = new System.Drawing.Point(220, 317);
            this.verwijderButton.Name = "verwijderButton";
            this.verwijderButton.Size = new System.Drawing.Size(196, 25);
            this.verwijderButton.TabIndex = 18;
            this.verwijderButton.Text = "Verwijder";
            this.verwijderButton.UseVisualStyleBackColor = true;
            this.verwijderButton.Click += new System.EventHandler(this.verwijderButton_Click);
            // 
            // toevoegenButton
            // 
            this.toevoegenButton.Enabled = false;
            this.toevoegenButton.Location = new System.Drawing.Point(435, 317);
            this.toevoegenButton.Name = "toevoegenButton";
            this.toevoegenButton.Size = new System.Drawing.Size(196, 25);
            this.toevoegenButton.TabIndex = 17;
            this.toevoegenButton.Text = "Toevoegen";
            this.toevoegenButton.UseVisualStyleBackColor = true;
            this.toevoegenButton.Click += new System.EventHandler(this.toevoegenButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(492, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Stations";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(282, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "In PDF";
            // 
            // alleStationsListBox
            // 
            this.alleStationsListBox.Enabled = false;
            this.alleStationsListBox.FormattingEnabled = true;
            this.alleStationsListBox.ItemHeight = 16;
            this.alleStationsListBox.Location = new System.Drawing.Point(435, 131);
            this.alleStationsListBox.Name = "alleStationsListBox";
            this.alleStationsListBox.Size = new System.Drawing.Size(196, 180);
            this.alleStationsListBox.TabIndex = 14;
            // 
            // FilterStationListBox
            // 
            this.FilterStationListBox.Enabled = false;
            this.FilterStationListBox.FormattingEnabled = true;
            this.FilterStationListBox.ItemHeight = 16;
            this.FilterStationListBox.Location = new System.Drawing.Point(220, 131);
            this.FilterStationListBox.Name = "FilterStationListBox";
            this.FilterStationListBox.Size = new System.Drawing.Size(196, 180);
            this.FilterStationListBox.TabIndex = 13;
            // 
            // schemaCheckBox
            // 
            this.schemaCheckBox.AutoSize = true;
            this.schemaCheckBox.Location = new System.Drawing.Point(30, 244);
            this.schemaCheckBox.Name = "schemaCheckBox";
            this.schemaCheckBox.Size = new System.Drawing.Size(81, 21);
            this.schemaCheckBox.TabIndex = 12;
            this.schemaCheckBox.Text = "Schema";
            this.schemaCheckBox.UseVisualStyleBackColor = true;
            // 
            // stationPDFButton
            // 
            this.stationPDFButton.Location = new System.Drawing.Point(491, 393);
            this.stationPDFButton.Name = "stationPDFButton";
            this.stationPDFButton.Size = new System.Drawing.Size(123, 53);
            this.stationPDFButton.TabIndex = 11;
            this.stationPDFButton.Text = "Naar PDF";
            this.stationPDFButton.UseVisualStyleBackColor = true;
            this.stationPDFButton.Click += new System.EventHandler(this.stationPDFButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Velden";
            // 
            // afstandCheckBox
            // 
            this.afstandCheckBox.AutoSize = true;
            this.afstandCheckBox.Location = new System.Drawing.Point(30, 217);
            this.afstandCheckBox.Name = "afstandCheckBox";
            this.afstandCheckBox.Size = new System.Drawing.Size(78, 21);
            this.afstandCheckBox.TabIndex = 9;
            this.afstandCheckBox.Text = "Afstand";
            this.afstandCheckBox.UseVisualStyleBackColor = true;
            // 
            // aankomststationCheckBox
            // 
            this.aankomststationCheckBox.AutoSize = true;
            this.aankomststationCheckBox.Location = new System.Drawing.Point(30, 190);
            this.aankomststationCheckBox.Name = "aankomststationCheckBox";
            this.aankomststationCheckBox.Size = new System.Drawing.Size(134, 21);
            this.aankomststationCheckBox.TabIndex = 8;
            this.aankomststationCheckBox.Text = "Aankomststation";
            this.aankomststationCheckBox.UseVisualStyleBackColor = true;
            // 
            // aankomstuurCheckBox
            // 
            this.aankomstuurCheckBox.AutoSize = true;
            this.aankomstuurCheckBox.Location = new System.Drawing.Point(30, 163);
            this.aankomstuurCheckBox.Name = "aankomstuurCheckBox";
            this.aankomstuurCheckBox.Size = new System.Drawing.Size(113, 21);
            this.aankomstuurCheckBox.TabIndex = 7;
            this.aankomstuurCheckBox.Text = "Aankomstuur";
            this.aankomstuurCheckBox.UseVisualStyleBackColor = true;
            // 
            // vertrekuurCheckBox
            // 
            this.vertrekuurCheckBox.AutoSize = true;
            this.vertrekuurCheckBox.Location = new System.Drawing.Point(30, 136);
            this.vertrekuurCheckBox.Name = "vertrekuurCheckBox";
            this.vertrekuurCheckBox.Size = new System.Drawing.Size(97, 21);
            this.vertrekuurCheckBox.TabIndex = 6;
            this.vertrekuurCheckBox.Text = "Vertrekuur";
            this.vertrekuurCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(215, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 51);
            this.label4.TabIndex = 1;
            this.label4.Text = "Stations";
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 529);
            this.ControlBox = false;
            this.Controls.Add(this.gebruikerPannel);
            this.Controls.Add(this.stationPanel);
            this.Controls.Add(this.printenMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.printenMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Printen";
            this.printenMenuStrip.ResumeLayout(false);
            this.printenMenuStrip.PerformLayout();
            this.gebruikerPannel.ResumeLayout(false);
            this.gebruikerPannel.PerformLayout();
            this.stationPanel.ResumeLayout(false);
            this.stationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip printenMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem gebruikersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alleGebruikersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alleStationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel gebruikerPannel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox geboortedatumCheckBox;
        private System.Windows.Forms.CheckBox adminCheckBox;
        private System.Windows.Forms.CheckBox emailCheckBox;
        private System.Windows.Forms.CheckBox gebruikersnaamCheckBox;
        private System.Windows.Forms.TextBox gebruikersnaamTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox gebrfilterCheckbox;
        private System.Windows.Forms.Button gebruikerPDFButton;
        private System.Windows.Forms.Panel stationPanel;
        private System.Windows.Forms.CheckBox schemaCheckBox;
        private System.Windows.Forms.Button stationPDFButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox afstandCheckBox;
        private System.Windows.Forms.CheckBox aankomststationCheckBox;
        private System.Windows.Forms.CheckBox aankomstuurCheckBox;
        private System.Windows.Forms.CheckBox vertrekuurCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox alleStationsListBox;
        private System.Windows.Forms.ListBox FilterStationListBox;
        private System.Windows.Forms.CheckBox filterNaamCheckBox;
        private System.Windows.Forms.Button verwijderButton;
        private System.Windows.Forms.Button toevoegenButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker totDateTimePicker;
        private System.Windows.Forms.DateTimePicker vanafDateTimePicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox adminFilterCheckBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox geboorteFilterCheckBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox adminComboBox;
        private System.Windows.Forms.Label gebErrorLabel;
        private System.Windows.Forms.Label stErrorLabel;
    }
}