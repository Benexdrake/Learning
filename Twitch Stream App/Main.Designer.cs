namespace Twitch_Stream_App
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_Viewer = new System.Windows.Forms.Panel();
            this.lBox_Viewers = new System.Windows.Forms.ListBox();
            this.menuStripViewer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.IDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItem_Viewers_Profile = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItem_Follow = new System.Windows.Forms.ToolStripMenuItem();
            this.unfollowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItem_Block = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tBox_Send = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.tBox_Chat = new System.Windows.Forms.TextBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.menuStripBot = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemBot = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBotStart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBotStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBotLog = new System.Windows.Forms.ToolStripMenuItem();
            this.followsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.followingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_ViewCounter = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Viewer.SuspendLayout();
            this.menuStripViewer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.menuStripBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Viewer
            // 
            this.panel_Viewer.Controls.Add(this.lBox_Viewers);
            this.panel_Viewer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Viewer.Location = new System.Drawing.Point(0, 0);
            this.panel_Viewer.Name = "panel_Viewer";
            this.panel_Viewer.Size = new System.Drawing.Size(200, 570);
            this.panel_Viewer.TabIndex = 1;
            // 
            // lBox_Viewers
            // 
            this.lBox_Viewers.ContextMenuStrip = this.menuStripViewer;
            this.lBox_Viewers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBox_Viewers.FormattingEnabled = true;
            this.lBox_Viewers.ItemHeight = 15;
            this.lBox_Viewers.Location = new System.Drawing.Point(0, 0);
            this.lBox_Viewers.Name = "lBox_Viewers";
            this.lBox_Viewers.Size = new System.Drawing.Size(200, 570);
            this.lBox_Viewers.TabIndex = 5;
            // 
            // menuStripViewer
            // 
            this.menuStripViewer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IDToolStripMenuItem,
            this.tsmItem_Follow,
            this.unfollowToolStripMenuItem,
            this.tsmItem_Block});
            this.menuStripViewer.Name = "contextMenuStrip";
            this.menuStripViewer.Size = new System.Drawing.Size(123, 92);
            this.menuStripViewer.Opening += new System.ComponentModel.CancelEventHandler(this.menuStripViewer_Opening);
            // 
            // IDToolStripMenuItem
            // 
            this.IDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmItem_Viewers_Profile,
            this.onlineProfileToolStripMenuItem});
            this.IDToolStripMenuItem.Image = global::Twitch_Stream_App.Properties.Resources.user_location_32px;
            this.IDToolStripMenuItem.Name = "IDToolStripMenuItem";
            this.IDToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.IDToolStripMenuItem.Text = "Viewers";
            // 
            // tsmItem_Viewers_Profile
            // 
            this.tsmItem_Viewers_Profile.Name = "tsmItem_Viewers_Profile";
            this.tsmItem_Viewers_Profile.Size = new System.Drawing.Size(150, 22);
            this.tsmItem_Viewers_Profile.Text = "Show Profile";
            // 
            // onlineProfileToolStripMenuItem
            // 
            this.onlineProfileToolStripMenuItem.Name = "onlineProfileToolStripMenuItem";
            this.onlineProfileToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.onlineProfileToolStripMenuItem.Text = "Show Channel";
            // 
            // tsmItem_Follow
            // 
            this.tsmItem_Follow.Image = global::Twitch_Stream_App.Properties.Resources.filled_heart_32px;
            this.tsmItem_Follow.Name = "tsmItem_Follow";
            this.tsmItem_Follow.Size = new System.Drawing.Size(122, 22);
            this.tsmItem_Follow.Text = "Follow";
            this.tsmItem_Follow.Click += new System.EventHandler(this.tsmItem_Follow_Click);
            // 
            // unfollowToolStripMenuItem
            // 
            this.unfollowToolStripMenuItem.Name = "unfollowToolStripMenuItem";
            this.unfollowToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.unfollowToolStripMenuItem.Text = "Unfollow";
            this.unfollowToolStripMenuItem.Click += new System.EventHandler(this.unfollowToolStripMenuItem_Click);
            // 
            // tsmItem_Block
            // 
            this.tsmItem_Block.Image = global::Twitch_Stream_App.Properties.Resources.security_block_32px;
            this.tsmItem_Block.Name = "tsmItem_Block";
            this.tsmItem_Block.Size = new System.Drawing.Size(122, 22);
            this.tsmItem_Block.Text = "Block";
            this.tsmItem_Block.Click += new System.EventHandler(this.tsmItem_Block_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tBox_Send);
            this.panel1.Controls.Add(this.btn_Send);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(200, 530);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 40);
            this.panel1.TabIndex = 2;
            // 
            // tBox_Send
            // 
            this.tBox_Send.Dock = System.Windows.Forms.DockStyle.Top;
            this.tBox_Send.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox_Send.Location = new System.Drawing.Point(0, 0);
            this.tBox_Send.Name = "tBox_Send";
            this.tBox_Send.Size = new System.Drawing.Size(773, 35);
            this.tBox_Send.TabIndex = 1;
            this.tBox_Send.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBox_Send_KeyDown);
            // 
            // btn_Send
            // 
            this.btn_Send.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Send.Location = new System.Drawing.Point(773, 0);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 40);
            this.btn_Send.TabIndex = 0;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // tBox_Chat
            // 
            this.tBox_Chat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBox_Chat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox_Chat.Location = new System.Drawing.Point(200, 41);
            this.tBox_Chat.Multiline = true;
            this.tBox_Chat.Name = "tBox_Chat";
            this.tBox_Chat.ReadOnly = true;
            this.tBox_Chat.Size = new System.Drawing.Size(848, 489);
            this.tBox_Chat.TabIndex = 3;
            // 
            // panelHeader
            // 
            this.panelHeader.ContextMenuStrip = this.menuStripBot;
            this.panelHeader.Controls.Add(this.lbl_ViewCounter);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(200, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(848, 41);
            this.panelHeader.TabIndex = 4;
            // 
            // menuStripBot
            // 
            this.menuStripBot.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemBot,
            this.followsToolStripMenuItem});
            this.menuStripBot.Name = "contextMenuStrip";
            this.menuStripBot.Size = new System.Drawing.Size(115, 48);
            this.menuStripBot.Opening += new System.ComponentModel.CancelEventHandler(this.menuStripBot_Opening);
            // 
            // toolStripMenuItemBot
            // 
            this.toolStripMenuItemBot.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemBotStart,
            this.toolStripMenuItemBotStop,
            this.toolStripMenuItemBotLog});
            this.toolStripMenuItemBot.Image = global::Twitch_Stream_App.Properties.Resources.minecraft_sword_32px;
            this.toolStripMenuItemBot.Name = "toolStripMenuItemBot";
            this.toolStripMenuItemBot.Size = new System.Drawing.Size(114, 22);
            this.toolStripMenuItemBot.Text = "Bot";
            // 
            // toolStripMenuItemBotStart
            // 
            this.toolStripMenuItemBotStart.Name = "toolStripMenuItemBotStart";
            this.toolStripMenuItemBotStart.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItemBotStart.Text = "Start";
            this.toolStripMenuItemBotStart.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // toolStripMenuItemBotStop
            // 
            this.toolStripMenuItemBotStop.Name = "toolStripMenuItemBotStop";
            this.toolStripMenuItemBotStop.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItemBotStop.Text = "Stop";
            this.toolStripMenuItemBotStop.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // toolStripMenuItemBotLog
            // 
            this.toolStripMenuItemBotLog.Name = "toolStripMenuItemBotLog";
            this.toolStripMenuItemBotLog.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItemBotLog.Text = "Log";
            this.toolStripMenuItemBotLog.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // followsToolStripMenuItem
            // 
            this.followsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.followingToolStripMenuItem});
            this.followsToolStripMenuItem.Name = "followsToolStripMenuItem";
            this.followsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.followsToolStripMenuItem.Text = "Follows";
            // 
            // followingToolStripMenuItem
            // 
            this.followingToolStripMenuItem.Name = "followingToolStripMenuItem";
            this.followingToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.followingToolStripMenuItem.Text = "Following";
            this.followingToolStripMenuItem.Click += new System.EventHandler(this.followingToolStripMenuItem_Click);
            // 
            // lbl_ViewCounter
            // 
            this.lbl_ViewCounter.AutoSize = true;
            this.lbl_ViewCounter.Location = new System.Drawing.Point(43, 9);
            this.lbl_ViewCounter.Name = "lbl_ViewCounter";
            this.lbl_ViewCounter.Size = new System.Drawing.Size(13, 15);
            this.lbl_ViewCounter.TabIndex = 1;
            this.lbl_ViewCounter.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Twitch_Stream_App.Properties.Resources.eye_32px;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 33);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 570);
            this.ContextMenuStrip = this.menuStripViewer;
            this.Controls.Add(this.tBox_Chat);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Viewer);
            this.Name = "Main";
            this.Text = "Form1";
            this.panel_Viewer.ResumeLayout(false);
            this.menuStripViewer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.menuStripBot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel_Viewer;
        private Panel panel1;
        private TextBox tBox_Send;
        private Button btn_Send;
        private TextBox tBox_Chat;
        private ListBox lBox_Viewers;
        private ContextMenuStrip menuStripViewer;
        private ToolStripMenuItem IDToolStripMenuItem;
        private Panel panelHeader;
        private PictureBox pictureBox1;
        public Label lbl_ViewCounter;
        private ToolStripMenuItem tsmItem_Follow;
        private ToolStripMenuItem tsmItem_Block;
        private ContextMenuStrip menuStripBot;
        private ToolStripMenuItem toolStripMenuItemBot;
        private ToolStripMenuItem toolStripMenuItemBotStart;
        private ToolStripMenuItem toolStripMenuItemBotStop;
        private ToolStripMenuItem toolStripMenuItemBotLog;
        private ToolStripMenuItem tsmItem_Viewers_Profile;
        private ToolStripMenuItem followsToolStripMenuItem;
        private ToolStripMenuItem onlineProfileToolStripMenuItem;
        private ToolStripMenuItem followingToolStripMenuItem;
        private ToolStripMenuItem unfollowToolStripMenuItem;
    }
}