namespace Model_Request_Manager.Forms
{
    partial class RequestListForm
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_note = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.cBox_Category = new System.Windows.Forms.ComboBox();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.tBox_Category = new System.Windows.Forms.TextBox();
            this.btn_Open = new System.Windows.Forms.Button();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.check_Texture = new System.Windows.Forms.CheckBox();
            this.check_High = new System.Windows.Forms.CheckBox();
            this.check_Low = new System.Windows.Forms.CheckBox();
            this.check_White = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbl_note
            // 
            this.lbl_note.AutoSize = true;
            this.lbl_note.Location = new System.Drawing.Point(16, 37);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(36, 15);
            this.lbl_note.TabIndex = 0;
            this.lbl_note.Text = "Note:";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Location = new System.Drawing.Point(297, 37);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(58, 15);
            this.lbl_Category.TabIndex = 16;
            this.lbl_Category.Text = "Category:";
            // 
            // cBox_Category
            // 
            this.cBox_Category.FormattingEnabled = true;
            this.cBox_Category.Items.AddRange(new object[] {
            "Item1",
            "Item2",
            "Item3"});
            this.cBox_Category.Location = new System.Drawing.Point(361, 63);
            this.cBox_Category.Name = "cBox_Category";
            this.cBox_Category.Size = new System.Drawing.Size(121, 23);
            this.cBox_Category.TabIndex = 15;
            this.cBox_Category.Visible = false;
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(58, 34);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.ReadOnly = true;
            this.txt_Note.Size = new System.Drawing.Size(233, 23);
            this.txt_Note.TabIndex = 14;
            // 
            // tBox_Category
            // 
            this.tBox_Category.Location = new System.Drawing.Point(361, 34);
            this.tBox_Category.Name = "tBox_Category";
            this.tBox_Category.ReadOnly = true;
            this.tBox_Category.Size = new System.Drawing.Size(121, 23);
            this.tBox_Category.TabIndex = 17;
            // 
            // btn_Open
            // 
            this.btn_Open.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Open.Location = new System.Drawing.Point(584, 0);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(63, 94);
            this.btn_Open.TabIndex = 18;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(16, 11);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(60, 15);
            this.lbl_Username.TabIndex = 27;
            this.lbl_Username.Text = "Username";
            // 
            // check_Texture
            // 
            this.check_Texture.AutoSize = true;
            this.check_Texture.Location = new System.Drawing.Point(283, 65);
            this.check_Texture.Name = "check_Texture";
            this.check_Texture.Size = new System.Drawing.Size(64, 19);
            this.check_Texture.TabIndex = 31;
            this.check_Texture.Text = "Texture";
            this.check_Texture.UseVisualStyleBackColor = true;
            // 
            // check_High
            // 
            this.check_High.AutoSize = true;
            this.check_High.Location = new System.Drawing.Point(194, 65);
            this.check_High.Name = "check_High";
            this.check_High.Size = new System.Drawing.Size(75, 19);
            this.check_High.TabIndex = 30;
            this.check_High.Text = "Highpoly";
            this.check_High.UseVisualStyleBackColor = true;
            // 
            // check_Low
            // 
            this.check_Low.AutoSize = true;
            this.check_Low.Location = new System.Drawing.Point(105, 65);
            this.check_Low.Name = "check_Low";
            this.check_Low.Size = new System.Drawing.Size(71, 19);
            this.check_Low.TabIndex = 29;
            this.check_Low.Text = "Lowpoly";
            this.check_Low.UseVisualStyleBackColor = true;
            // 
            // check_White
            // 
            this.check_White.AutoSize = true;
            this.check_White.Location = new System.Drawing.Point(16, 65);
            this.check_White.Name = "check_White";
            this.check_White.Size = new System.Drawing.Size(77, 19);
            this.check_White.TabIndex = 28;
            this.check_White.Text = "Whitebox";
            this.check_White.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 5);
            this.panel1.TabIndex = 32;
            // 
            // RequestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.check_Texture);
            this.Controls.Add(this.check_High);
            this.Controls.Add(this.check_Low);
            this.Controls.Add(this.check_White);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.tBox_Category);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.cBox_Category);
            this.Controls.Add(this.txt_Note);
            this.Controls.Add(this.lbl_note);
            this.Controls.Add(this.panel1);
            this.Name = "RequestList";
            this.Size = new System.Drawing.Size(647, 99);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_note;
        private Label lbl_Category;
        private ComboBox cBox_Category;
        private TextBox txt_Note;
        private TextBox tBox_Category;
        private Button btn_Open;
        private Label lbl_Username;
        private CheckBox check_Texture;
        private CheckBox check_High;
        private CheckBox check_Low;
        private CheckBox check_White;
        private Panel panel1;
    }
}
