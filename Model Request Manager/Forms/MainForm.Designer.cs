namespace Model_Request_Manager.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelSide = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Downloads = new System.Windows.Forms.Button();
            this.btn_RequestList = new System.Windows.Forms.Button();
            this.btn_AllRequests = new System.Windows.Forms.Button();
            this.btn_Requests = new System.Windows.Forms.Button();
            this.btn_NewRequest = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rBtn_ASC = new System.Windows.Forms.RadioButton();
            this.rBtn_DESC = new System.Windows.Forms.RadioButton();
            this.tBox_Note = new System.Windows.Forms.TextBox();
            this.childPanel = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.check_Texture = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.check_High = new System.Windows.Forms.CheckBox();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.check_Low = new System.Windows.Forms.CheckBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.check_White = new System.Windows.Forms.CheckBox();
            this.tBox_Username = new System.Windows.Forms.TextBox();
            this.cBox_Category = new System.Windows.Forms.ComboBox();
            this.panelSide.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelSide.Controls.Add(this.panel1);
            this.panelSide.Controls.Add(this.panelLogo);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(217, 625);
            this.panelSide.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.btn_Downloads);
            this.panel1.Controls.Add(this.btn_RequestList);
            this.panel1.Controls.Add(this.btn_AllRequests);
            this.panel1.Controls.Add(this.btn_Requests);
            this.panel1.Controls.Add(this.btn_NewRequest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 483);
            this.panel1.TabIndex = 1;
            // 
            // btn_Close
            // 
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Close.Location = new System.Drawing.Point(0, 436);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(217, 47);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "Exit";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Downloads
            // 
            this.btn_Downloads.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Downloads.Location = new System.Drawing.Point(0, 216);
            this.btn_Downloads.Name = "btn_Downloads";
            this.btn_Downloads.Size = new System.Drawing.Size(217, 54);
            this.btn_Downloads.TabIndex = 4;
            this.btn_Downloads.Text = "Download";
            this.btn_Downloads.UseVisualStyleBackColor = true;
            this.btn_Downloads.Click += new System.EventHandler(this.btn_Downloads_Click);
            // 
            // btn_RequestList
            // 
            this.btn_RequestList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_RequestList.Location = new System.Drawing.Point(0, 162);
            this.btn_RequestList.Name = "btn_RequestList";
            this.btn_RequestList.Size = new System.Drawing.Size(217, 54);
            this.btn_RequestList.TabIndex = 3;
            this.btn_RequestList.Text = "Favorites";
            this.btn_RequestList.UseVisualStyleBackColor = true;
            this.btn_RequestList.Click += new System.EventHandler(this.btn_RequestList_Click);
            // 
            // btn_AllRequests
            // 
            this.btn_AllRequests.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AllRequests.Location = new System.Drawing.Point(0, 108);
            this.btn_AllRequests.Name = "btn_AllRequests";
            this.btn_AllRequests.Size = new System.Drawing.Size(217, 54);
            this.btn_AllRequests.TabIndex = 2;
            this.btn_AllRequests.Text = "All Requests";
            this.btn_AllRequests.UseVisualStyleBackColor = true;
            this.btn_AllRequests.Click += new System.EventHandler(this.btn_AllRequests_Click);
            // 
            // btn_Requests
            // 
            this.btn_Requests.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Requests.Location = new System.Drawing.Point(0, 54);
            this.btn_Requests.Name = "btn_Requests";
            this.btn_Requests.Size = new System.Drawing.Size(217, 54);
            this.btn_Requests.TabIndex = 1;
            this.btn_Requests.Text = "My Requests";
            this.btn_Requests.UseVisualStyleBackColor = true;
            this.btn_Requests.Click += new System.EventHandler(this.btn_Requests_Click);
            // 
            // btn_NewRequest
            // 
            this.btn_NewRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_NewRequest.Location = new System.Drawing.Point(0, 0);
            this.btn_NewRequest.Name = "btn_NewRequest";
            this.btn_NewRequest.Size = new System.Drawing.Size(217, 54);
            this.btn_NewRequest.TabIndex = 5;
            this.btn_NewRequest.Text = "New Request";
            this.btn_NewRequest.UseVisualStyleBackColor = true;
            this.btn_NewRequest.Click += new System.EventHandler(this.btn_NewRequest_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(217, 142);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // rBtn_ASC
            // 
            this.rBtn_ASC.AutoSize = true;
            this.rBtn_ASC.Checked = true;
            this.rBtn_ASC.Location = new System.Drawing.Point(6, 3);
            this.rBtn_ASC.Name = "rBtn_ASC";
            this.rBtn_ASC.Size = new System.Drawing.Size(47, 19);
            this.rBtn_ASC.TabIndex = 3;
            this.rBtn_ASC.TabStop = true;
            this.rBtn_ASC.Text = "ASC";
            this.rBtn_ASC.UseVisualStyleBackColor = true;
            this.rBtn_ASC.CheckedChanged += new System.EventHandler(this.rBtn_ASC_CheckedChanged);
            // 
            // rBtn_DESC
            // 
            this.rBtn_DESC.AutoSize = true;
            this.rBtn_DESC.Location = new System.Drawing.Point(6, 25);
            this.rBtn_DESC.Name = "rBtn_DESC";
            this.rBtn_DESC.Size = new System.Drawing.Size(53, 19);
            this.rBtn_DESC.TabIndex = 2;
            this.rBtn_DESC.Text = "DESC";
            this.rBtn_DESC.UseVisualStyleBackColor = true;
            this.rBtn_DESC.CheckedChanged += new System.EventHandler(this.rBtn_DESC_CheckedChanged);
            // 
            // tBox_Note
            // 
            this.tBox_Note.Location = new System.Drawing.Point(431, 18);
            this.tBox_Note.Name = "tBox_Note";
            this.tBox_Note.Size = new System.Drawing.Size(175, 23);
            this.tBox_Note.TabIndex = 1;
            this.tBox_Note.Click += new System.EventHandler(this.tBox_Note_Click);
            this.tBox_Note.TextChanged += new System.EventHandler(this.tBox_Search_TextChanged);
            // 
            // childPanel
            // 
            this.childPanel.AutoScroll = true;
            this.childPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childPanel.Location = new System.Drawing.Point(217, 47);
            this.childPanel.Name = "childPanel";
            this.childPanel.Size = new System.Drawing.Size(667, 578);
            this.childPanel.TabIndex = 2;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelSearch.Controls.Add(this.btn_Clear);
            this.panelSearch.Controls.Add(this.check_Texture);
            this.panelSearch.Controls.Add(this.label7);
            this.panelSearch.Controls.Add(this.check_High);
            this.panelSearch.Controls.Add(this.lbl_Note);
            this.panelSearch.Controls.Add(this.check_Low);
            this.panelSearch.Controls.Add(this.lbl_Username);
            this.panelSearch.Controls.Add(this.check_White);
            this.panelSearch.Controls.Add(this.tBox_Username);
            this.panelSearch.Controls.Add(this.rBtn_ASC);
            this.panelSearch.Controls.Add(this.cBox_Category);
            this.panelSearch.Controls.Add(this.tBox_Note);
            this.panelSearch.Controls.Add(this.rBtn_DESC);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(217, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(667, 47);
            this.panelSearch.TabIndex = 4;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Clear.Location = new System.Drawing.Point(612, 0);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(55, 47);
            this.btn_Clear.TabIndex = 0;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // check_Texture
            // 
            this.check_Texture.AutoSize = true;
            this.check_Texture.Location = new System.Drawing.Point(104, 25);
            this.check_Texture.Name = "check_Texture";
            this.check_Texture.Size = new System.Drawing.Size(32, 19);
            this.check_Texture.TabIndex = 18;
            this.check_Texture.Text = "T";
            this.check_Texture.UseVisualStyleBackColor = true;
            this.check_Texture.CheckedChanged += new System.EventHandler(this.check_Texture_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Category:";
            // 
            // check_High
            // 
            this.check_High.AutoSize = true;
            this.check_High.Location = new System.Drawing.Point(104, 3);
            this.check_High.Name = "check_High";
            this.check_High.Size = new System.Drawing.Size(42, 19);
            this.check_High.TabIndex = 17;
            this.check_High.Text = "HP";
            this.check_High.UseVisualStyleBackColor = true;
            this.check_High.CheckedChanged += new System.EventHandler(this.check_High_CheckedChanged);
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Location = new System.Drawing.Point(431, 1);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(36, 15);
            this.lbl_Note.TabIndex = 6;
            this.lbl_Note.Text = "Note:";
            // 
            // check_Low
            // 
            this.check_Low.AutoSize = true;
            this.check_Low.Location = new System.Drawing.Point(59, 25);
            this.check_Low.Name = "check_Low";
            this.check_Low.Size = new System.Drawing.Size(39, 19);
            this.check_Low.TabIndex = 16;
            this.check_Low.Text = "LP";
            this.check_Low.UseVisualStyleBackColor = true;
            this.check_Low.CheckedChanged += new System.EventHandler(this.check_Low_CheckedChanged);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(250, 1);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(63, 15);
            this.lbl_Username.TabIndex = 5;
            this.lbl_Username.Text = "Username:";
            // 
            // check_White
            // 
            this.check_White.AutoSize = true;
            this.check_White.Location = new System.Drawing.Point(59, 3);
            this.check_White.Name = "check_White";
            this.check_White.Size = new System.Drawing.Size(44, 19);
            this.check_White.TabIndex = 15;
            this.check_White.Text = "WB";
            this.check_White.UseVisualStyleBackColor = true;
            this.check_White.CheckedChanged += new System.EventHandler(this.check_White_CheckedChanged);
            // 
            // tBox_Username
            // 
            this.tBox_Username.Location = new System.Drawing.Point(250, 18);
            this.tBox_Username.Name = "tBox_Username";
            this.tBox_Username.Size = new System.Drawing.Size(175, 23);
            this.tBox_Username.TabIndex = 4;
            this.tBox_Username.Click += new System.EventHandler(this.tBox_Username_Click);
            this.tBox_Username.TextChanged += new System.EventHandler(this.tBox_Username_TextChanged);
            // 
            // cBox_Category
            // 
            this.cBox_Category.FormattingEnabled = true;
            this.cBox_Category.Items.AddRange(new object[] {
            "Item1",
            "Item2",
            "Item3"});
            this.cBox_Category.Location = new System.Drawing.Point(152, 20);
            this.cBox_Category.Name = "cBox_Category";
            this.cBox_Category.Size = new System.Drawing.Size(92, 23);
            this.cBox_Category.TabIndex = 14;
            this.cBox_Category.SelectedIndexChanged += new System.EventHandler(this.cBox_Category_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 625);
            this.Controls.Add(this.childPanel);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelSide);
            this.MaximumSize = new System.Drawing.Size(900, 1080);
            this.MinimumSize = new System.Drawing.Size(900, 664);
            this.Name = "MainForm";
            this.Text = "Main";
            this.panelSide.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelSide;
        private Button btn_Downloads;
        private Button btn_RequestList;
        private Button btn_AllRequests;
        private Button btn_Requests;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private RadioButton rBtn_ASC;
        private RadioButton rBtn_DESC;
        private TextBox tBox_Note;
        private Panel childPanel;
        private Button btn_NewRequest;
        private Panel panel1;
        private Button btn_Close;
        private Panel panelSearch;
        private Label lbl_Username;
        private TextBox tBox_Username;
        private Label lbl_Note;
        private CheckBox check_Texture;
        private Label label7;
        private CheckBox check_High;
        private CheckBox check_Low;
        private CheckBox check_White;
        private ComboBox cBox_Category;
        private Button btn_Clear;
    }
}