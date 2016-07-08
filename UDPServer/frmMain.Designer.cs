namespace UDPServer {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStartStopListening = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangePort = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(624, 24);
            this.mnuMenu.TabIndex = 0;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStartStopListening,
            this.mnuChangePort,
            this.mnuClear,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuStartStopListening
            // 
            this.mnuStartStopListening.Name = "mnuStartStopListening";
            this.mnuStartStopListening.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnuStartStopListening.Size = new System.Drawing.Size(165, 22);
            this.mnuStartStopListening.Tag = "0";
            this.mnuStartStopListening.Text = "&Start listening";
            this.mnuStartStopListening.Click += new System.EventHandler(this.mnuStartStopListening_Click);
            // 
            // mnuChangePort
            // 
            this.mnuChangePort.Name = "mnuChangePort";
            this.mnuChangePort.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mnuChangePort.Size = new System.Drawing.Size(165, 22);
            this.mnuChangePort.Text = "Change &port";
            this.mnuChangePort.Click += new System.EventHandler(this.mnuChangePort_Click);
            // 
            // mnuClear
            // 
            this.mnuClear.Name = "mnuClear";
            this.mnuClear.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mnuClear.Size = new System.Drawing.Size(165, 22);
            this.mnuClear.Text = "&Clear";
            this.mnuClear.Click += new System.EventHandler(this.mnuClear_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(162, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(165, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(0, 24);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(624, 418);
            this.txtLog.TabIndex = 1;
            this.txtLog.WordWrap = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.mnuMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMenu;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "frmMain";
            this.Text = "UDP Server";
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuStartStopListening;
        private System.Windows.Forms.ToolStripMenuItem mnuChangePort;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ToolStripMenuItem mnuClear;
    }
}

