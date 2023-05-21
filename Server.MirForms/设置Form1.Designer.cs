namespace Server
{
    partial class myForm1
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
            切换穿怪cb = new CheckBox();
            SuspendLayout();
            // 
            // 切换穿怪cb
            // 
            切换穿怪cb.AutoSize = true;
            切换穿怪cb.Location = new Point(12, 12);
            切换穿怪cb.Name = "切换穿怪cb";
            切换穿怪cb.Size = new Size(91, 24);
            切换穿怪cb.TabIndex = 0;
            切换穿怪cb.Text = "切换穿怪";
            切换穿怪cb.UseVisualStyleBackColor = true;
            切换穿怪cb.CheckedChanged += 切换穿怪cb_CheckedChanged;
            // 
            // myForm1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 459);
            Controls.Add(切换穿怪cb);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "myForm1";
            Text = "管理配置";
            Load += 设置Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox 切换穿怪cb;
    }
}