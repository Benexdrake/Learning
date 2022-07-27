namespace Twitch_Stream_App
{
    partial class FollowsForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.FromUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FollowedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineTwitchProfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unFollowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FromUsername,
            this.FromUserID,
            this.FollowedAt,
            this.ToUsername,
            this.ToUserID});
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(800, 450);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
            this.dataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDown);
            // 
            // FromUsername
            // 
            this.FromUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FromUsername.HeaderText = "From Username";
            this.FromUsername.Name = "FromUsername";
            this.FromUsername.ReadOnly = true;
            // 
            // FromUserID
            // 
            this.FromUserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FromUserID.HeaderText = "From UserID";
            this.FromUserID.Name = "FromUserID";
            this.FromUserID.ReadOnly = true;
            // 
            // FollowedAt
            // 
            this.FollowedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FollowedAt.HeaderText = "Followed At";
            this.FollowedAt.Name = "FollowedAt";
            this.FollowedAt.ReadOnly = true;
            // 
            // ToUsername
            // 
            this.ToUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ToUsername.HeaderText = "To Username";
            this.ToUsername.Name = "ToUsername";
            this.ToUsername.ReadOnly = true;
            // 
            // ToUserID
            // 
            this.ToUserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ToUserID.HeaderText = "To UserID";
            this.ToUserID.Name = "ToUserID";
            this.ToUserID.ReadOnly = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showProfileToolStripMenuItem,
            this.onlineTwitchProfilToolStripMenuItem,
            this.unFollowToolStripMenuItem,
            this.blockToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(178, 92);
            // 
            // showProfileToolStripMenuItem
            // 
            this.showProfileToolStripMenuItem.Name = "showProfileToolStripMenuItem";
            this.showProfileToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.showProfileToolStripMenuItem.Text = "Show Profile";
            // 
            // onlineTwitchProfilToolStripMenuItem
            // 
            this.onlineTwitchProfilToolStripMenuItem.Name = "onlineTwitchProfilToolStripMenuItem";
            this.onlineTwitchProfilToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.onlineTwitchProfilToolStripMenuItem.Text = "Online Twitch Profil";
            // 
            // unFollowToolStripMenuItem
            // 
            this.unFollowToolStripMenuItem.Name = "unFollowToolStripMenuItem";
            this.unFollowToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.unFollowToolStripMenuItem.Text = "UnFollow";
            // 
            // blockToolStripMenuItem
            // 
            this.blockToolStripMenuItem.Name = "blockToolStripMenuItem";
            this.blockToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.blockToolStripMenuItem.Text = "Block";
            // 
            // FollowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Name = "FollowsForm";
            this.Text = "FollowsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn FromUsername;
        private DataGridViewTextBoxColumn FromUserID;
        private DataGridViewTextBoxColumn FollowedAt;
        private DataGridViewTextBoxColumn ToUsername;
        private DataGridViewTextBoxColumn ToUserID;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem showProfileToolStripMenuItem;
        private ToolStripMenuItem onlineTwitchProfilToolStripMenuItem;
        private ToolStripMenuItem unFollowToolStripMenuItem;
        private ToolStripMenuItem blockToolStripMenuItem;
    }
}