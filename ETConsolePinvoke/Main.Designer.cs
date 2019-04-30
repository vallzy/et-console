namespace ETConsolePinvoke
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupConsole = new System.Windows.Forms.GroupBox();
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.cmbCmd = new System.Windows.Forms.ComboBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.radioRaw = new System.Windows.Forms.RadioButton();
            this.radioChat = new System.Windows.Forms.RadioButton();
            this.ChatRefresh = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupConsole.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.programToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // groupConsole
            // 
            this.groupConsole.Controls.Add(this.txtConsole);
            this.groupConsole.Controls.Add(this.cmbCmd);
            this.groupConsole.Controls.Add(this.btnGet);
            this.groupConsole.Controls.Add(this.btnSet);
            this.groupConsole.Controls.Add(this.txtCommand);
            this.groupConsole.Controls.Add(this.radioRaw);
            this.groupConsole.Controls.Add(this.radioChat);
            this.groupConsole.Location = new System.Drawing.Point(12, 36);
            this.groupConsole.Name = "groupConsole";
            this.groupConsole.Size = new System.Drawing.Size(409, 333);
            this.groupConsole.TabIndex = 4;
            this.groupConsole.TabStop = false;
            this.groupConsole.Text = "Console - Chat";
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.SystemColors.ControlText;
            this.txtConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsole.ForeColor = System.Drawing.Color.Yellow;
            this.txtConsole.Location = new System.Drawing.Point(6, 59);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(397, 245);
            this.txtConsole.TabIndex = 10;
            this.txtConsole.Text = "";
            // 
            // cmbCmd
            // 
            this.cmbCmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCmd.FormattingEnabled = true;
            this.cmbCmd.Items.AddRange(new object[] {
            "Command",
            "Say"});
            this.cmbCmd.Location = new System.Drawing.Point(6, 29);
            this.cmbCmd.Name = "cmbCmd";
            this.cmbCmd.Size = new System.Drawing.Size(97, 24);
            this.cmbCmd.TabIndex = 9;
            this.cmbCmd.Text = "Command";
            this.cmbCmd.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(328, 29);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 24);
            this.btnGet.TabIndex = 8;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(247, 27);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 26);
            this.btnSet.TabIndex = 7;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommand.Location = new System.Drawing.Point(109, 29);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(132, 22);
            this.txtCommand.TabIndex = 6;
            // 
            // radioRaw
            // 
            this.radioRaw.AutoSize = true;
            this.radioRaw.Location = new System.Drawing.Point(85, 310);
            this.radioRaw.Name = "radioRaw";
            this.radioRaw.Size = new System.Drawing.Size(47, 17);
            this.radioRaw.TabIndex = 4;
            this.radioRaw.Text = "Raw";
            this.radioRaw.UseVisualStyleBackColor = true;
            this.radioRaw.CheckedChanged += new System.EventHandler(this.radioRaw_CheckedChanged);
            // 
            // radioChat
            // 
            this.radioChat.AutoSize = true;
            this.radioChat.Checked = true;
            this.radioChat.Location = new System.Drawing.Point(6, 310);
            this.radioChat.Name = "radioChat";
            this.radioChat.Size = new System.Drawing.Size(47, 17);
            this.radioChat.TabIndex = 3;
            this.radioChat.TabStop = true;
            this.radioChat.Text = "Chat";
            this.radioChat.UseVisualStyleBackColor = true;
            this.radioChat.CheckedChanged += new System.EventHandler(this.radioChat_CheckedChanged);
            // 
            // ChatRefresh
            // 
            this.ChatRefresh.Enabled = true;
            this.ChatRefresh.Interval = 500;
            this.ChatRefresh.Tick += new System.EventHandler(this.ChatRefresh_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 372);
            this.Controls.Add(this.groupConsole);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ET Console Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupConsole.ResumeLayout(false);
            this.groupConsole.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupConsole;
        private System.Windows.Forms.RadioButton radioRaw;
        private System.Windows.Forms.RadioButton radioChat;
        private System.Windows.Forms.Timer ChatRefresh;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.ComboBox cmbCmd;
        private System.Windows.Forms.RichTextBox txtConsole;
    }
}