namespace Model_Request_Manager.Forms
{
    partial class RequestForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.cBox_Category = new System.Windows.Forms.ComboBox();
            this.check_White = new System.Windows.Forms.CheckBox();
            this.check_Low = new System.Windows.Forms.CheckBox();
            this.check_High = new System.Windows.Forms.CheckBox();
            this.check_Texture = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_Text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btn_Like = new System.Windows.Forms.PictureBox();
            this.cBox_Available = new System.Windows.Forms.CheckBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.btn_Download = new System.Windows.Forms.Button();
            this.btn_NewUpload = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Like)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Note:";
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(12, 78);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(233, 23);
            this.txt_Note.TabIndex = 1;
            // 
            // cBox_Category
            // 
            this.cBox_Category.FormattingEnabled = true;
            this.cBox_Category.Items.AddRange(new object[] {
            "Item1",
            "Item2",
            "Item3"});
            this.cBox_Category.Location = new System.Drawing.Point(332, 78);
            this.cBox_Category.Name = "cBox_Category";
            this.cBox_Category.Size = new System.Drawing.Size(121, 23);
            this.cBox_Category.TabIndex = 2;
            // 
            // check_White
            // 
            this.check_White.AutoSize = true;
            this.check_White.Location = new System.Drawing.Point(119, 126);
            this.check_White.Name = "check_White";
            this.check_White.Size = new System.Drawing.Size(77, 19);
            this.check_White.TabIndex = 3;
            this.check_White.Text = "Whitebox";
            this.check_White.UseVisualStyleBackColor = true;
            // 
            // check_Low
            // 
            this.check_Low.AutoSize = true;
            this.check_Low.Location = new System.Drawing.Point(208, 126);
            this.check_Low.Name = "check_Low";
            this.check_Low.Size = new System.Drawing.Size(71, 19);
            this.check_Low.TabIndex = 4;
            this.check_Low.Text = "Lowpoly";
            this.check_Low.UseVisualStyleBackColor = true;
            // 
            // check_High
            // 
            this.check_High.AutoSize = true;
            this.check_High.Location = new System.Drawing.Point(297, 126);
            this.check_High.Name = "check_High";
            this.check_High.Size = new System.Drawing.Size(75, 19);
            this.check_High.TabIndex = 5;
            this.check_High.Text = "Highpoly";
            this.check_High.UseVisualStyleBackColor = true;
            // 
            // check_Texture
            // 
            this.check_Texture.AutoSize = true;
            this.check_Texture.Location = new System.Drawing.Point(386, 126);
            this.check_Texture.Name = "check_Texture";
            this.check_Texture.Size = new System.Drawing.Size(64, 19);
            this.check_Texture.TabIndex = 6;
            this.check_Texture.Text = "Texture";
            this.check_Texture.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Information:";
            // 
            // tbox_Text
            // 
            this.tbox_Text.Location = new System.Drawing.Point(12, 144);
            this.tbox_Text.Multiline = true;
            this.tbox_Text.Name = "tbox_Text";
            this.tbox_Text.Size = new System.Drawing.Size(441, 213);
            this.tbox_Text.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Category:";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHeader.Controls.Add(this.btn_Like);
            this.panelHeader.Controls.Add(this.cBox_Available);
            this.panelHeader.Controls.Add(this.btn_Close);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(460, 47);
            this.panelHeader.TabIndex = 14;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // btn_Like
            // 
            this.btn_Like.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Like.Image = global::Model_Request_Manager.Properties.Resources.Heart_NoLike;
            this.btn_Like.Location = new System.Drawing.Point(359, 0);
            this.btn_Like.Name = "btn_Like";
            this.btn_Like.Size = new System.Drawing.Size(48, 47);
            this.btn_Like.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Like.TabIndex = 17;
            this.btn_Like.TabStop = false;
            this.btn_Like.Click += new System.EventHandler(this.btn_Like_Click);
            // 
            // cBox_Available
            // 
            this.cBox_Available.AutoSize = true;
            this.cBox_Available.Checked = true;
            this.cBox_Available.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBox_Available.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBox_Available.Location = new System.Drawing.Point(12, 8);
            this.cBox_Available.Name = "cBox_Available";
            this.cBox_Available.Size = new System.Drawing.Size(129, 36);
            this.cBox_Available.TabIndex = 16;
            this.cBox_Available.Text = "Available";
            this.cBox_Available.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Close.Location = new System.Drawing.Point(407, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(53, 47);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(360, 368);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(93, 33);
            this.btn_Send.TabIndex = 15;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_Upload
            // 
            this.btn_Upload.Location = new System.Drawing.Point(10, 378);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(75, 23);
            this.btn_Upload.TabIndex = 16;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_DownUpload_Click);
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.AutoSize = true;
            this.lbl_FileName.Location = new System.Drawing.Point(12, 360);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(57, 15);
            this.lbl_FileName.TabIndex = 17;
            this.lbl_FileName.Text = "FileName";
            // 
            // btn_Download
            // 
            this.btn_Download.Location = new System.Drawing.Point(91, 378);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(75, 23);
            this.btn_Download.TabIndex = 18;
            this.btn_Download.Text = "Download";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Visible = false;
            // 
            // btn_NewUpload
            // 
            this.btn_NewUpload.Location = new System.Drawing.Point(261, 368);
            this.btn_NewUpload.Name = "btn_NewUpload";
            this.btn_NewUpload.Size = new System.Drawing.Size(93, 33);
            this.btn_NewUpload.TabIndex = 19;
            this.btn_NewUpload.Text = "New Upload";
            this.btn_NewUpload.UseVisualStyleBackColor = true;
            this.btn_NewUpload.Visible = false;
            this.btn_NewUpload.Click += new System.EventHandler(this.btn_NewUpload_Click);
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 408);
            this.Controls.Add(this.btn_NewUpload);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.lbl_FileName);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbox_Text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.check_Texture);
            this.Controls.Add(this.check_High);
            this.Controls.Add(this.check_Low);
            this.Controls.Add(this.check_White);
            this.Controls.Add(this.cBox_Category);
            this.Controls.Add(this.txt_Note);
            this.Controls.Add(this.label1);
            this.Name = "RequestForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.RequestForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Like)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_Note;
        private ComboBox cBox_Category;
        private CheckBox check_White;
        private CheckBox check_Low;
        private CheckBox check_High;
        private CheckBox check_Texture;
        private Label label2;
        private TextBox tbox_Text;
        private Label label7;
        private Panel panelHeader;
        private Button btn_Close;
        private CheckBox cBox_Available;
        private Button btn_Upload;
        private Label lbl_FileName;
        private PictureBox btn_Like;
        public Button btn_Send;
        public Button btn_NewUpload;
        public Button btn_Download;
    }
}