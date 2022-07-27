namespace Model_Request_Manager.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btn_Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pBox_Avatar = new System.Windows.Forms.PictureBox();
            this.tBox_Username = new System.Windows.Forms.TextBox();
            this.tBox_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pBox_Config = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Config)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(258, 369);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // pBox_Avatar
            // 
            this.pBox_Avatar.Image = ((System.Drawing.Image)(resources.GetObject("pBox_Avatar.Image")));
            this.pBox_Avatar.Location = new System.Drawing.Point(34, 62);
            this.pBox_Avatar.Name = "pBox_Avatar";
            this.pBox_Avatar.Size = new System.Drawing.Size(299, 200);
            this.pBox_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox_Avatar.TabIndex = 2;
            this.pBox_Avatar.TabStop = false;
            // 
            // tBox_Username
            // 
            this.tBox_Username.Location = new System.Drawing.Point(34, 296);
            this.tBox_Username.Name = "tBox_Username";
            this.tBox_Username.Size = new System.Drawing.Size(299, 23);
            this.tBox_Username.TabIndex = 3;
            // 
            // tBox_Password
            // 
            this.tBox_Password.Location = new System.Drawing.Point(34, 340);
            this.tBox_Password.Name = "tBox_Password";
            this.tBox_Password.PasswordChar = '*';
            this.tBox_Password.Size = new System.Drawing.Size(299, 23);
            this.tBox_Password.TabIndex = 5;
            this.tBox_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBox_Password_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // pBox_Config
            // 
            this.pBox_Config.Image = ((System.Drawing.Image)(resources.GetObject("pBox_Config.Image")));
            this.pBox_Config.Location = new System.Drawing.Point(224, 369);
            this.pBox_Config.Name = "pBox_Config";
            this.pBox_Config.Size = new System.Drawing.Size(28, 23);
            this.pBox_Config.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox_Config.TabIndex = 6;
            this.pBox_Config.TabStop = false;
            this.pBox_Config.Click += new System.EventHandler(this.pBox_Config_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHeader.Controls.Add(this.btn_Close);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(364, 47);
            this.panelHeader.TabIndex = 7;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // btn_Close
            // 
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Close.Location = new System.Drawing.Point(311, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(53, 47);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 406);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.pBox_Config);
            this.Controls.Add(this.tBox_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBox_Username);
            this.Controls.Add(this.pBox_Avatar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Login);
            this.Name = "LoginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Config)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Login;
        private Label label1;
        private PictureBox pBox_Avatar;
        private TextBox tBox_Username;
        private TextBox tBox_Password;
        private Label label2;
        private PictureBox pBox_Config;
        private Panel panelHeader;
        private Button btn_Close;
    }
}