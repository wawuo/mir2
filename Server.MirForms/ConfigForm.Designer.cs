﻿namespace Server
{
    partial class ConfigForm
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
            SaveButton = new Button();
            configTabs = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            label11 = new Label();
            DBVersionLabel = new Label();
            ServerVersionLabel = new Label();
            label10 = new Label();
            RelogDelayTextBox = new TextBox();
            label7 = new Label();
            VersionCheckBox = new CheckBox();
            VPathBrowseButton = new Button();
            VPathTextBox = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            StartHTTPCheckBox = new CheckBox();
            label15 = new Label();
            HTTPTrustedIPAddressTextBox = new TextBox();
            label14 = new Label();
            HTTPIPAddressTextBox = new TextBox();
            label13 = new Label();
            MaxUserTextBox = new TextBox();
            label5 = new Label();
            TimeOutTextBox = new TextBox();
            label4 = new Label();
            PortTextBox = new TextBox();
            label3 = new Label();
            IPAddressTextBox = new TextBox();
            label2 = new Label();
            tabPage3 = new TabPage();
            label9 = new Label();
            label8 = new Label();
            Resolution_textbox = new TextBox();
            AllowArcherCheckBox = new CheckBox();
            AllowAssassinCheckBox = new CheckBox();
            StartGameCheckBox = new CheckBox();
            DCharacterCheckBox = new CheckBox();
            NCharacterCheckBox = new CheckBox();
            LoginCheckBox = new CheckBox();
            PasswordCheckBox = new CheckBox();
            AccountCheckBox = new CheckBox();
            tabPage4 = new TabPage();
            label12 = new Label();
            SaveDelayTextBox = new TextBox();
            label6 = new Label();
            tabPage5 = new TabPage();
            label16 = new Label();
            lineMessageTimeTextBox = new TextBox();
            label17 = new Label();
            gameMasterEffect_CheckBox = new CheckBox();
            SafeZoneHealingCheckBox = new CheckBox();
            SafeZoneBorderCheckBox = new CheckBox();
            VPathDialog = new OpenFileDialog();
            configTabs.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveButton.Location = new Point(528, 531);
            SaveButton.Margin = new Padding(4, 5, 4, 5);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(112, 35);
            SaveButton.TabIndex = 6;
            SaveButton.Text = "Close";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // configTabs
            // 
            configTabs.Controls.Add(tabPage1);
            configTabs.Controls.Add(tabPage2);
            configTabs.Controls.Add(tabPage3);
            configTabs.Controls.Add(tabPage4);
            configTabs.Controls.Add(tabPage5);
            configTabs.Location = new Point(18, 18);
            configTabs.Margin = new Padding(4, 5, 4, 5);
            configTabs.Name = "configTabs";
            configTabs.SelectedIndex = 0;
            configTabs.Size = new Size(622, 502);
            configTabs.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(RelogDelayTextBox);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(VersionCheckBox);
            tabPage1.Controls.Add(VPathBrowseButton);
            tabPage1.Controls.Add(VPathTextBox);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(4, 5, 4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 5, 4, 5);
            tabPage1.Size = new Size(614, 469);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Version";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(DBVersionLabel);
            groupBox1.Controls.Add(ServerVersionLabel);
            groupBox1.Controls.Add(label10);
            groupBox1.Location = new Point(9, 354);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(592, 98);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Version Info";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 65);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(76, 20);
            label11.TabIndex = 23;
            label11.Text = "Database";
            // 
            // DBVersionLabel
            // 
            DBVersionLabel.AutoSize = true;
            DBVersionLabel.Location = new Point(114, 65);
            DBVersionLabel.Margin = new Padding(4, 0, 4, 0);
            DBVersionLabel.Name = "DBVersionLabel";
            DBVersionLabel.Size = new Size(64, 20);
            DBVersionLabel.TabIndex = 24;
            DBVersionLabel.Text = "Version";
            // 
            // ServerVersionLabel
            // 
            ServerVersionLabel.AutoSize = true;
            ServerVersionLabel.Location = new Point(114, 31);
            ServerVersionLabel.Margin = new Padding(4, 0, 4, 0);
            ServerVersionLabel.Name = "ServerVersionLabel";
            ServerVersionLabel.Size = new Size(64, 20);
            ServerVersionLabel.TabIndex = 7;
            ServerVersionLabel.Text = "Version";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 31);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(56, 20);
            label10.TabIndex = 22;
            label10.Text = "Server";
            // 
            // RelogDelayTextBox
            // 
            RelogDelayTextBox.Location = new Point(134, 100);
            RelogDelayTextBox.Margin = new Padding(4, 5, 4, 5);
            RelogDelayTextBox.MaxLength = 5;
            RelogDelayTextBox.Name = "RelogDelayTextBox";
            RelogDelayTextBox.Size = new Size(138, 27);
            RelogDelayTextBox.TabIndex = 21;
            RelogDelayTextBox.TextChanged += CheckUShort;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 105);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 20;
            label7.Text = "Relog Delay:";
            // 
            // VersionCheckBox
            // 
            VersionCheckBox.AutoSize = true;
            VersionCheckBox.Location = new Point(134, 65);
            VersionCheckBox.Margin = new Padding(4, 5, 4, 5);
            VersionCheckBox.Name = "VersionCheckBox";
            VersionCheckBox.Size = new Size(201, 24);
            VersionCheckBox.TabIndex = 3;
            VersionCheckBox.Text = "Check for client version";
            VersionCheckBox.UseVisualStyleBackColor = true;
            VersionCheckBox.CheckedChanged += VersionCheckBox_CheckedChanged;
            // 
            // VPathBrowseButton
            // 
            VPathBrowseButton.Location = new Point(560, 22);
            VPathBrowseButton.Margin = new Padding(4, 5, 4, 5);
            VPathBrowseButton.Name = "VPathBrowseButton";
            VPathBrowseButton.Size = new Size(42, 35);
            VPathBrowseButton.TabIndex = 2;
            VPathBrowseButton.Text = "...";
            VPathBrowseButton.UseVisualStyleBackColor = true;
            VPathBrowseButton.Click += VPathBrowseButton_Click;
            // 
            // VPathTextBox
            // 
            VPathTextBox.Location = new Point(134, 25);
            VPathTextBox.Margin = new Padding(4, 5, 4, 5);
            VPathTextBox.Name = "VPathTextBox";
            VPathTextBox.ReadOnly = true;
            VPathTextBox.Size = new Size(415, 27);
            VPathTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Version Path:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(StartHTTPCheckBox);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(HTTPTrustedIPAddressTextBox);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(HTTPIPAddressTextBox);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(MaxUserTextBox);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(TimeOutTextBox);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(PortTextBox);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(IPAddressTextBox);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(4, 5, 4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 5, 4, 5);
            tabPage2.Size = new Size(614, 469);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Network";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // StartHTTPCheckBox
            // 
            StartHTTPCheckBox.AutoSize = true;
            StartHTTPCheckBox.Location = new Point(36, 240);
            StartHTTPCheckBox.Margin = new Padding(4, 5, 4, 5);
            StartHTTPCheckBox.Name = "StartHTTPCheckBox";
            StartHTTPCheckBox.Size = new Size(166, 24);
            StartHTTPCheckBox.TabIndex = 23;
            StartHTTPCheckBox.Text = "Start HTTP Service";
            StartHTTPCheckBox.UseVisualStyleBackColor = true;
            StartHTTPCheckBox.CheckedChanged += StartHTTPCheckBox_CheckedChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(33, 380);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(309, 20);
            label15.TabIndex = 22;
            label15.Text = "(http service only allow trusted IP to visit)";
            // 
            // HTTPTrustedIPAddressTextBox
            // 
            HTTPTrustedIPAddressTextBox.Location = new Point(266, 331);
            HTTPTrustedIPAddressTextBox.Margin = new Padding(4, 5, 4, 5);
            HTTPTrustedIPAddressTextBox.MaxLength = 30;
            HTTPTrustedIPAddressTextBox.Name = "HTTPTrustedIPAddressTextBox";
            HTTPTrustedIPAddressTextBox.Size = new Size(253, 27);
            HTTPTrustedIPAddressTextBox.TabIndex = 21;
            HTTPTrustedIPAddressTextBox.TextChanged += HTTPTrustedIPAddressTextBox_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(33, 335);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(193, 20);
            label14.TabIndex = 20;
            label14.Text = "HTTP Trusted IP Address:";
            // 
            // HTTPIPAddressTextBox
            // 
            HTTPIPAddressTextBox.Location = new Point(194, 282);
            HTTPIPAddressTextBox.Margin = new Padding(4, 5, 4, 5);
            HTTPIPAddressTextBox.MaxLength = 30;
            HTTPIPAddressTextBox.Name = "HTTPIPAddressTextBox";
            HTTPIPAddressTextBox.Size = new Size(253, 27);
            HTTPIPAddressTextBox.TabIndex = 19;
            HTTPIPAddressTextBox.TextChanged += HTTPIPAddressTextBox_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(33, 286);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(133, 20);
            label13.TabIndex = 18;
            label13.Text = "HTTP IP Address:";
            // 
            // MaxUserTextBox
            // 
            MaxUserTextBox.Location = new Point(134, 145);
            MaxUserTextBox.Margin = new Padding(4, 5, 4, 5);
            MaxUserTextBox.MaxLength = 5;
            MaxUserTextBox.Name = "MaxUserTextBox";
            MaxUserTextBox.Size = new Size(61, 27);
            MaxUserTextBox.TabIndex = 17;
            MaxUserTextBox.TextChanged += CheckUShort;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 151);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 16;
            label5.Text = "Max User:";
            // 
            // TimeOutTextBox
            // 
            TimeOutTextBox.Location = new Point(134, 105);
            TimeOutTextBox.Margin = new Padding(4, 5, 4, 5);
            TimeOutTextBox.MaxLength = 5;
            TimeOutTextBox.Name = "TimeOutTextBox";
            TimeOutTextBox.Size = new Size(138, 27);
            TimeOutTextBox.TabIndex = 15;
            TimeOutTextBox.TextChanged += CheckUShort;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 111);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 14;
            label4.Text = "TimeOut:";
            // 
            // PortTextBox
            // 
            PortTextBox.Location = new Point(134, 65);
            PortTextBox.Margin = new Padding(4, 5, 4, 5);
            PortTextBox.MaxLength = 5;
            PortTextBox.Name = "PortTextBox";
            PortTextBox.Size = new Size(61, 27);
            PortTextBox.TabIndex = 13;
            PortTextBox.TextChanged += CheckUShort;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 71);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 12;
            label3.Text = "Port:";
            // 
            // IPAddressTextBox
            // 
            IPAddressTextBox.Location = new Point(134, 25);
            IPAddressTextBox.Margin = new Padding(4, 5, 4, 5);
            IPAddressTextBox.MaxLength = 15;
            IPAddressTextBox.Name = "IPAddressTextBox";
            IPAddressTextBox.Size = new Size(138, 27);
            IPAddressTextBox.TabIndex = 11;
            IPAddressTextBox.TextChanged += IPAddressCheck;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 31);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 10;
            label2.Text = "IP Address:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(Resolution_textbox);
            tabPage3.Controls.Add(AllowArcherCheckBox);
            tabPage3.Controls.Add(AllowAssassinCheckBox);
            tabPage3.Controls.Add(StartGameCheckBox);
            tabPage3.Controls.Add(DCharacterCheckBox);
            tabPage3.Controls.Add(NCharacterCheckBox);
            tabPage3.Controls.Add(LoginCheckBox);
            tabPage3.Controls.Add(PasswordCheckBox);
            tabPage3.Controls.Add(AccountCheckBox);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(4, 5, 4, 5);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4, 5, 4, 5);
            tabPage3.Size = new Size(614, 469);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Permissions";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 358);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(186, 20);
            label9.TabIndex = 16;
            label9.Text = "Max Resolution Allowed";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 0);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 15;
            label8.Text = "label8";
            // 
            // Resolution_textbox
            // 
            Resolution_textbox.Location = new Point(220, 354);
            Resolution_textbox.Margin = new Padding(4, 5, 4, 5);
            Resolution_textbox.Name = "Resolution_textbox";
            Resolution_textbox.Size = new Size(118, 27);
            Resolution_textbox.TabIndex = 14;
            Resolution_textbox.TextChanged += Resolution_textbox_TextChanged;
            // 
            // AllowArcherCheckBox
            // 
            AllowArcherCheckBox.AutoSize = true;
            AllowArcherCheckBox.Location = new Point(36, 303);
            AllowArcherCheckBox.Margin = new Padding(4, 5, 4, 5);
            AllowArcherCheckBox.Name = "AllowArcherCheckBox";
            AllowArcherCheckBox.Size = new Size(278, 24);
            AllowArcherCheckBox.TabIndex = 13;
            AllowArcherCheckBox.Text = "Allow Creation of the Archer Class";
            AllowArcherCheckBox.UseVisualStyleBackColor = true;
            // 
            // AllowAssassinCheckBox
            // 
            AllowAssassinCheckBox.AutoSize = true;
            AllowAssassinCheckBox.Location = new Point(36, 266);
            AllowAssassinCheckBox.Margin = new Padding(4, 5, 4, 5);
            AllowAssassinCheckBox.Name = "AllowAssassinCheckBox";
            AllowAssassinCheckBox.Size = new Size(289, 24);
            AllowAssassinCheckBox.TabIndex = 12;
            AllowAssassinCheckBox.Text = "Allow Creation of the Assassin Class";
            AllowAssassinCheckBox.UseVisualStyleBackColor = true;
            // 
            // StartGameCheckBox
            // 
            StartGameCheckBox.AutoSize = true;
            StartGameCheckBox.Location = new Point(36, 208);
            StartGameCheckBox.Margin = new Padding(4, 5, 4, 5);
            StartGameCheckBox.Name = "StartGameCheckBox";
            StartGameCheckBox.Size = new Size(333, 24);
            StartGameCheckBox.TabIndex = 11;
            StartGameCheckBox.Text = "Allow Characters to Login to Game World";
            StartGameCheckBox.UseVisualStyleBackColor = true;
            // 
            // DCharacterCheckBox
            // 
            DCharacterCheckBox.AutoSize = true;
            DCharacterCheckBox.Location = new Point(36, 172);
            DCharacterCheckBox.Margin = new Padding(4, 5, 4, 5);
            DCharacterCheckBox.Name = "DCharacterCheckBox";
            DCharacterCheckBox.Size = new Size(212, 24);
            DCharacterCheckBox.TabIndex = 10;
            DCharacterCheckBox.Text = "Allow Character Deletion";
            DCharacterCheckBox.UseVisualStyleBackColor = true;
            // 
            // NCharacterCheckBox
            // 
            NCharacterCheckBox.AutoSize = true;
            NCharacterCheckBox.Location = new Point(36, 137);
            NCharacterCheckBox.Margin = new Padding(4, 5, 4, 5);
            NCharacterCheckBox.Name = "NCharacterCheckBox";
            NCharacterCheckBox.Size = new Size(249, 24);
            NCharacterCheckBox.TabIndex = 9;
            NCharacterCheckBox.Text = "Allow New Character Creation";
            NCharacterCheckBox.UseVisualStyleBackColor = true;
            // 
            // LoginCheckBox
            // 
            LoginCheckBox.AutoSize = true;
            LoginCheckBox.Location = new Point(36, 102);
            LoginCheckBox.Margin = new Padding(4, 5, 4, 5);
            LoginCheckBox.Name = "LoginCheckBox";
            LoginCheckBox.Size = new Size(212, 24);
            LoginCheckBox.TabIndex = 8;
            LoginCheckBox.Text = "Allow Accounts To Login";
            LoginCheckBox.UseVisualStyleBackColor = true;
            // 
            // PasswordCheckBox
            // 
            PasswordCheckBox.AutoSize = true;
            PasswordCheckBox.Location = new Point(36, 66);
            PasswordCheckBox.Margin = new Padding(4, 5, 4, 5);
            PasswordCheckBox.Name = "PasswordCheckBox";
            PasswordCheckBox.Size = new Size(312, 24);
            PasswordCheckBox.TabIndex = 7;
            PasswordCheckBox.Text = "Allow Users To Change Their Password";
            PasswordCheckBox.UseVisualStyleBackColor = true;
            // 
            // AccountCheckBox
            // 
            AccountCheckBox.AutoSize = true;
            AccountCheckBox.Location = new Point(36, 31);
            AccountCheckBox.Margin = new Padding(4, 5, 4, 5);
            AccountCheckBox.Name = "AccountCheckBox";
            AccountCheckBox.Size = new Size(240, 24);
            AccountCheckBox.TabIndex = 6;
            AccountCheckBox.Text = "Allow New Account Creation";
            AccountCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label12);
            tabPage4.Controls.Add(SaveDelayTextBox);
            tabPage4.Controls.Add(label6);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(4, 5, 4, 5);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(4, 5, 4, 5);
            tabPage4.Size = new Size(614, 469);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Database";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(282, 31);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(67, 20);
            label12.TabIndex = 26;
            label12.Text = "minutes";
            // 
            // SaveDelayTextBox
            // 
            SaveDelayTextBox.Location = new Point(134, 25);
            SaveDelayTextBox.Margin = new Padding(4, 5, 4, 5);
            SaveDelayTextBox.MaxLength = 5;
            SaveDelayTextBox.Name = "SaveDelayTextBox";
            SaveDelayTextBox.Size = new Size(138, 27);
            SaveDelayTextBox.TabIndex = 25;
            SaveDelayTextBox.TextChanged += CheckUShort;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 31);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 24;
            label6.Text = "Save Delay:";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(label16);
            tabPage5.Controls.Add(lineMessageTimeTextBox);
            tabPage5.Controls.Add(label17);
            tabPage5.Controls.Add(gameMasterEffect_CheckBox);
            tabPage5.Controls.Add(SafeZoneHealingCheckBox);
            tabPage5.Controls.Add(SafeZoneBorderCheckBox);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Margin = new Padding(4, 5, 4, 5);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(4, 5, 4, 5);
            tabPage5.Size = new Size(614, 469);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Optional";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(295, 140);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(67, 20);
            label16.TabIndex = 29;
            label16.Text = "minutes";
            // 
            // lineMessageTimeTextBox
            // 
            lineMessageTimeTextBox.Location = new Point(235, 137);
            lineMessageTimeTextBox.Margin = new Padding(4, 5, 4, 5);
            lineMessageTimeTextBox.MaxLength = 5;
            lineMessageTimeTextBox.Name = "lineMessageTimeTextBox";
            lineMessageTimeTextBox.Size = new Size(52, 27);
            lineMessageTimeTextBox.TabIndex = 28;
            lineMessageTimeTextBox.Text = "10";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(32, 140);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(196, 20);
            label17.TabIndex = 27;
            label17.Text = "Line Message Frequency :";
            // 
            // gameMasterEffect_CheckBox
            // 
            gameMasterEffect_CheckBox.AutoSize = true;
            gameMasterEffect_CheckBox.Location = new Point(36, 102);
            gameMasterEffect_CheckBox.Margin = new Padding(4, 5, 4, 5);
            gameMasterEffect_CheckBox.Name = "gameMasterEffect_CheckBox";
            gameMasterEffect_CheckBox.Size = new Size(173, 24);
            gameMasterEffect_CheckBox.TabIndex = 2;
            gameMasterEffect_CheckBox.Text = "Game Master Effect";
            gameMasterEffect_CheckBox.UseVisualStyleBackColor = true;
            // 
            // SafeZoneHealingCheckBox
            // 
            SafeZoneHealingCheckBox.AutoSize = true;
            SafeZoneHealingCheckBox.Location = new Point(36, 66);
            SafeZoneHealingCheckBox.Margin = new Padding(4, 5, 4, 5);
            SafeZoneHealingCheckBox.Name = "SafeZoneHealingCheckBox";
            SafeZoneHealingCheckBox.Size = new Size(264, 24);
            SafeZoneHealingCheckBox.TabIndex = 1;
            SafeZoneHealingCheckBox.Text = "Enable auto-healing in SafeZone";
            SafeZoneHealingCheckBox.UseVisualStyleBackColor = true;
            SafeZoneHealingCheckBox.CheckedChanged += SafeZoneHealingCheckBox_CheckedChanged;
            // 
            // SafeZoneBorderCheckBox
            // 
            SafeZoneBorderCheckBox.AutoSize = true;
            SafeZoneBorderCheckBox.Location = new Point(36, 31);
            SafeZoneBorderCheckBox.Margin = new Padding(4, 5, 4, 5);
            SafeZoneBorderCheckBox.Name = "SafeZoneBorderCheckBox";
            SafeZoneBorderCheckBox.Size = new Size(204, 24);
            SafeZoneBorderCheckBox.TabIndex = 0;
            SafeZoneBorderCheckBox.Text = "Show SafeZone Borders";
            SafeZoneBorderCheckBox.UseVisualStyleBackColor = true;
            SafeZoneBorderCheckBox.CheckedChanged += SafeZoneBorderCheckBox_CheckedChanged;
            // 
            // VPathDialog
            // 
            VPathDialog.FileName = "Mir2.Exe";
            VPathDialog.Filter = "Executable Files (*.exe)|*.exe";
            VPathDialog.Multiselect = true;
            // 
            // ConfigForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 574);
            Controls.Add(SaveButton);
            Controls.Add(configTabs);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ConfigForm";
            Text = "Server Config Form";
            FormClosed += ConfigForm_FormClosed;
            configTabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TabControl configTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox RelogDelayTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox VersionCheckBox;
        private System.Windows.Forms.Button VPathBrowseButton;
        private System.Windows.Forms.TextBox VPathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox MaxUserTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TimeOutTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IPAddressTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog VPathDialog;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox StartGameCheckBox;
        private System.Windows.Forms.CheckBox DCharacterCheckBox;
        private System.Windows.Forms.CheckBox NCharacterCheckBox;
        private System.Windows.Forms.CheckBox LoginCheckBox;
        private System.Windows.Forms.CheckBox PasswordCheckBox;
        private System.Windows.Forms.CheckBox AccountCheckBox;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox SaveDelayTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox SafeZoneBorderCheckBox;
        private System.Windows.Forms.CheckBox SafeZoneHealingCheckBox;
        private System.Windows.Forms.CheckBox AllowArcherCheckBox;
        private System.Windows.Forms.CheckBox AllowAssassinCheckBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Resolution_textbox;
        private System.Windows.Forms.Label ServerVersionLabel;
        private System.Windows.Forms.Label DBVersionLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox gameMasterEffect_CheckBox;
        private System.Windows.Forms.TextBox HTTPIPAddressTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox HTTPTrustedIPAddressTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox StartHTTPCheckBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox lineMessageTimeTextBox;
        private System.Windows.Forms.Label label17;
    }
}