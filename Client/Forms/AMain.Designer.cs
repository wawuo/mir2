using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;
using System.Drawing;

namespace Launcher
{
    partial class AMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AMain));
            ActionLabel = new Label();
            SpeedLabel = new Label();
            InterfaceTimer = new System.Windows.Forms.Timer(components);
            Close_pb = new PictureBox();
            Config_pb = new PictureBox();
            Name_label = new Label();
            Version_label = new Label();
            CurrentFile_label = new Label();
            CurrentPercent_label = new Label();
            TotalPercent_label = new Label();
            Credit_label = new Label();
            ProgTotalEnd_pb = new PictureBox();
            ProgEnd_pb = new PictureBox();
            ProgressCurrent_pb = new PictureBox();
            TotalProg_pb = new PictureBox();
            Launch_pb = new PictureBox();
            Main_browser = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)Close_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Config_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProgTotalEnd_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProgEnd_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProgressCurrent_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TotalProg_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Launch_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Main_browser).BeginInit();
            SuspendLayout();
            // 
            // ActionLabel
            // 
            ActionLabel.Anchor = AnchorStyles.Bottom;
            ActionLabel.BackColor = Color.Transparent;
            ActionLabel.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ActionLabel.ForeColor = Color.Gray;
            ActionLabel.Location = new Point(665, 456);
            ActionLabel.Margin = new Padding(5, 0, 5, 0);
            ActionLabel.Name = "ActionLabel";
            ActionLabel.Size = new Size(162, 28);
            ActionLabel.TabIndex = 4;
            ActionLabel.Text = "1423MB/2000MB";
            ActionLabel.TextAlign = ContentAlignment.MiddleRight;
            ActionLabel.Visible = false;
            ActionLabel.Click += ActionLabel_Click;
            // 
            // SpeedLabel
            // 
            SpeedLabel.Anchor = AnchorStyles.Bottom;
            SpeedLabel.BackColor = Color.Transparent;
            SpeedLabel.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            SpeedLabel.ForeColor = Color.Gray;
            SpeedLabel.Location = new Point(611, 565);
            SpeedLabel.Margin = new Padding(5, 0, 5, 0);
            SpeedLabel.Name = "SpeedLabel";
            SpeedLabel.RightToLeft = RightToLeft.No;
            SpeedLabel.Size = new Size(86, 24);
            SpeedLabel.TabIndex = 13;
            SpeedLabel.Text = "Speed";
            SpeedLabel.TextAlign = ContentAlignment.TopRight;
            SpeedLabel.Visible = false;
            // 
            // InterfaceTimer
            // 
            InterfaceTimer.Enabled = true;
            InterfaceTimer.Interval = 50;
            InterfaceTimer.Tick += InterfaceTimer_Tick;
            // 
            // Close_pb
            // 
            Close_pb.BackColor = Color.Transparent;
            Close_pb.BackgroundImageLayout = ImageLayout.Center;
            Close_pb.Image = Client.Resources.Images.Cross_Base;
            Close_pb.Location = new Point(883, 112);
            Close_pb.Margin = new Padding(5, 4, 5, 4);
            Close_pb.Name = "Close_pb";
            Close_pb.Size = new Size(28, 31);
            Close_pb.TabIndex = 20;
            Close_pb.TabStop = false;
            Close_pb.Click += Close_pb_Click;
            Close_pb.MouseDown += Close_pb_MouseDown;
            Close_pb.MouseEnter += Close_pb_MouseEnter;
            Close_pb.MouseLeave += Close_pb_MouseLeave;
            Close_pb.MouseUp += Close_pb_MouseUp;
            // 
            // Config_pb
            // 
            Config_pb.BackColor = Color.Transparent;
            Config_pb.BackgroundImageLayout = ImageLayout.Center;
            Config_pb.Image = Client.Resources.Images.Config_Base;
            Config_pb.Location = new Point(855, 112);
            Config_pb.Margin = new Padding(5, 4, 5, 4);
            Config_pb.Name = "Config_pb";
            Config_pb.Size = new Size(28, 31);
            Config_pb.TabIndex = 32;
            Config_pb.TabStop = false;
            Config_pb.Click += Config_pb_Click;
            Config_pb.MouseDown += Config_pb_MouseDown;
            Config_pb.MouseEnter += Config_pb_MouseEnter;
            Config_pb.MouseLeave += Config_pb_MouseLeave;
            Config_pb.MouseUp += Config_pb_MouseUp;
            // 
            // Name_label
            // 
            Name_label.BackColor = Color.Transparent;
            Name_label.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name_label.ForeColor = Color.White;
            Name_label.Image = Client.Resources.Images.server_base;
            Name_label.Location = new Point(344, 114);
            Name_label.Margin = new Padding(5, 0, 5, 0);
            Name_label.Name = "Name_label";
            Name_label.Size = new Size(279, 33);
            Name_label.TabIndex = 0;
            Name_label.Text = "Crystal Mir 2";
            Name_label.TextAlign = ContentAlignment.MiddleCenter;
            Name_label.Visible = false;
            Name_label.Click += Name_label_Click;
            // 
            // Version_label
            // 
            Version_label.Anchor = AnchorStyles.Bottom;
            Version_label.BackColor = Color.Transparent;
            Version_label.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Version_label.ForeColor = Color.Gray;
            Version_label.Location = new Point(309, 623);
            Version_label.Margin = new Padding(5, 0, 5, 0);
            Version_label.Name = "Version_label";
            Version_label.Size = new Size(184, 20);
            Version_label.TabIndex = 31;
            Version_label.Text = "Version 1.0.0.0";
            Version_label.TextAlign = ContentAlignment.TopRight;
            // 
            // CurrentFile_label
            // 
            CurrentFile_label.Anchor = AnchorStyles.Bottom;
            CurrentFile_label.BackColor = Color.Transparent;
            CurrentFile_label.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentFile_label.ForeColor = Color.Gray;
            CurrentFile_label.Location = new Point(172, 561);
            CurrentFile_label.Margin = new Padding(5, 0, 5, 0);
            CurrentFile_label.Name = "CurrentFile_label";
            CurrentFile_label.Size = new Size(543, 24);
            CurrentFile_label.TabIndex = 27;
            CurrentFile_label.Text = "Checking Files.";
            CurrentFile_label.TextAlign = ContentAlignment.MiddleLeft;
            CurrentFile_label.Visible = false;
            // 
            // CurrentPercent_label
            // 
            CurrentPercent_label.Anchor = AnchorStyles.Bottom;
            CurrentPercent_label.BackColor = Color.Transparent;
            CurrentPercent_label.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentPercent_label.ForeColor = Color.Gray;
            CurrentPercent_label.Location = new Point(736, 602);
            CurrentPercent_label.Margin = new Padding(5, 0, 5, 0);
            CurrentPercent_label.Name = "CurrentPercent_label";
            CurrentPercent_label.Size = new Size(45, 31);
            CurrentPercent_label.TabIndex = 28;
            CurrentPercent_label.Text = "100%";
            CurrentPercent_label.TextAlign = ContentAlignment.MiddleCenter;
            CurrentPercent_label.Visible = false;
            // 
            // TotalPercent_label
            // 
            TotalPercent_label.Anchor = AnchorStyles.Bottom;
            TotalPercent_label.BackColor = Color.Transparent;
            TotalPercent_label.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            TotalPercent_label.ForeColor = Color.Gray;
            TotalPercent_label.Location = new Point(728, 576);
            TotalPercent_label.Margin = new Padding(5, 0, 5, 0);
            TotalPercent_label.Name = "TotalPercent_label";
            TotalPercent_label.Size = new Size(53, 31);
            TotalPercent_label.TabIndex = 29;
            TotalPercent_label.Text = "100%";
            TotalPercent_label.TextAlign = ContentAlignment.MiddleCenter;
            TotalPercent_label.Visible = false;
            // 
            // Credit_label
            // 
            Credit_label.Anchor = AnchorStyles.Bottom;
            Credit_label.AutoSize = true;
            Credit_label.BackColor = Color.Transparent;
            Credit_label.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Credit_label.ForeColor = Color.Gray;
            Credit_label.Location = new Point(144, 626);
            Credit_label.Margin = new Padding(5, 0, 5, 0);
            Credit_label.Name = "Credit_label";
            Credit_label.Size = new Size(137, 17);
            Credit_label.TabIndex = 30;
            Credit_label.Text = "Powered by Crystal M2";
            Credit_label.Click += Credit_label_Click;
            // 
            // ProgTotalEnd_pb
            // 
            ProgTotalEnd_pb.Anchor = AnchorStyles.None;
            ProgTotalEnd_pb.BackColor = Color.Transparent;
            ProgTotalEnd_pb.BackgroundImageLayout = ImageLayout.Center;
            ProgTotalEnd_pb.Image = Client.Resources.Images.NEW_Progress_End__Blue_;
            ProgTotalEnd_pb.Location = new Point(721, 606);
            ProgTotalEnd_pb.Margin = new Padding(5, 4, 5, 4);
            ProgTotalEnd_pb.Name = "ProgTotalEnd_pb";
            ProgTotalEnd_pb.Size = new Size(27, 22);
            ProgTotalEnd_pb.TabIndex = 26;
            ProgTotalEnd_pb.TabStop = false;
            // 
            // ProgEnd_pb
            // 
            ProgEnd_pb.Anchor = AnchorStyles.None;
            ProgEnd_pb.BackColor = Color.Transparent;
            ProgEnd_pb.BackgroundImageLayout = ImageLayout.Center;
            ProgEnd_pb.Image = Client.Resources.Images.NEW_Progress_End__Green_;
            ProgEnd_pb.Location = new Point(728, 584);
            ProgEnd_pb.Margin = new Padding(5, 4, 5, 4);
            ProgEnd_pb.Name = "ProgEnd_pb";
            ProgEnd_pb.Size = new Size(6, 22);
            ProgEnd_pb.TabIndex = 25;
            ProgEnd_pb.TabStop = false;
            // 
            // ProgressCurrent_pb
            // 
            ProgressCurrent_pb.Anchor = AnchorStyles.None;
            ProgressCurrent_pb.BackColor = Color.Transparent;
            ProgressCurrent_pb.BackgroundImageLayout = ImageLayout.Center;
            ProgressCurrent_pb.Image = Client.Resources.Images.Green_Progress;
            ProgressCurrent_pb.Location = new Point(171, 586);
            ProgressCurrent_pb.Margin = new Padding(5, 4, 5, 4);
            ProgressCurrent_pb.Name = "ProgressCurrent_pb";
            ProgressCurrent_pb.Size = new Size(562, 16);
            ProgressCurrent_pb.TabIndex = 23;
            ProgressCurrent_pb.TabStop = false;
            ProgressCurrent_pb.SizeChanged += ProgressCurrent_pb_SizeChanged;
            // 
            // TotalProg_pb
            // 
            TotalProg_pb.Anchor = AnchorStyles.None;
            TotalProg_pb.BackColor = Color.Transparent;
            TotalProg_pb.BackgroundImageLayout = ImageLayout.Center;
            TotalProg_pb.Image = Client.Resources.Images.Blue_Progress;
            TotalProg_pb.Location = new Point(170, 606);
            TotalProg_pb.Margin = new Padding(5, 4, 5, 4);
            TotalProg_pb.Name = "TotalProg_pb";
            TotalProg_pb.Size = new Size(564, 13);
            TotalProg_pb.TabIndex = 22;
            TotalProg_pb.TabStop = false;
            TotalProg_pb.SizeChanged += TotalProg_pb_SizeChanged;
            TotalProg_pb.Click += TotalProg_pb_Click;
            // 
            // Launch_pb
            // 
            Launch_pb.Anchor = AnchorStyles.Bottom;
            Launch_pb.BackColor = Color.Transparent;
            Launch_pb.BackgroundImageLayout = ImageLayout.Stretch;
            Launch_pb.Cursor = Cursors.Hand;
            Launch_pb.Image = Client.Resources.Images.Launch_Base1;
            Launch_pb.Location = new Point(772, 568);
            Launch_pb.Margin = new Padding(5, 4, 5, 4);
            Launch_pb.Name = "Launch_pb";
            Launch_pb.Size = new Size(130, 68);
            Launch_pb.TabIndex = 19;
            Launch_pb.TabStop = false;
            Launch_pb.Click += Launch_pb_Click;
            Launch_pb.MouseDown += Launch_pb_MouseDown;
            Launch_pb.MouseEnter += Launch_pb_MouseEnter;
            Launch_pb.MouseLeave += Launch_pb_MouseLeave;
            Launch_pb.MouseUp += Launch_pb_MouseUp;
            // 
            // Main_browser
            // 
            Main_browser.AllowExternalDrop = true;
            Main_browser.CausesValidation = false;
            Main_browser.CreationProperties = null;
            Main_browser.DefaultBackgroundColor = Color.White;
            Main_browser.Location = new Point(133, 151);
            Main_browser.Margin = new Padding(5, 4, 5, 4);
            Main_browser.MaximumSize = new Size(1005, 538);
            Main_browser.Name = "Main_browser";
            Main_browser.Size = new Size(768, 396);
            Main_browser.TabIndex = 32;
            Main_browser.Visible = false;
            Main_browser.ZoomFactor = 1D;
            Main_browser.Click += Main_browser_Click;
            // 
            // AMain
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            BackgroundImage = Client.Resources.Images.pfffft;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1034, 744);
            Controls.Add(Close_pb);
            Controls.Add(Main_browser);
            Controls.Add(Config_pb);
            Controls.Add(Name_label);
            Controls.Add(SpeedLabel);
            Controls.Add(TotalPercent_label);
            Controls.Add(CurrentPercent_label);
            Controls.Add(ProgTotalEnd_pb);
            Controls.Add(ProgEnd_pb);
            Controls.Add(Launch_pb);
            Controls.Add(CurrentFile_label);
            Controls.Add(ProgressCurrent_pb);
            Controls.Add(Credit_label);
            Controls.Add(Version_label);
            Controls.Add(TotalProg_pb);
            Controls.Add(ActionLabel);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Launcher";
            TransparencyKey = Color.Black;
            FormClosed += AMain_FormClosed;
            Load += AMain_Load;
            Click += AMain_Click;
            ((System.ComponentModel.ISupportInitialize)Close_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)Config_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProgTotalEnd_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProgEnd_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProgressCurrent_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)TotalProg_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)Launch_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)Main_browser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label ActionLabel;
        private System.Windows.Forms.Label SpeedLabel;
        public System.Windows.Forms.Timer InterfaceTimer;
        public System.Windows.Forms.PictureBox Launch_pb;
        private System.Windows.Forms.PictureBox Close_pb;
        private System.Windows.Forms.PictureBox TotalProg_pb;
        private System.Windows.Forms.PictureBox ProgressCurrent_pb;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.PictureBox ProgEnd_pb;
        private System.Windows.Forms.PictureBox ProgTotalEnd_pb;
        private System.Windows.Forms.Label CurrentFile_label;
        private System.Windows.Forms.Label CurrentPercent_label;
        private System.Windows.Forms.Label TotalPercent_label;
        private System.Windows.Forms.Label Credit_label;
        private System.Windows.Forms.Label Version_label;
        private System.Windows.Forms.PictureBox Config_pb;
        private Microsoft.Web.WebView2.WinForms.WebView2 Main_browser;
    }
}

