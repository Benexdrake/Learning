namespace Twitch_Forms
{
    partial class Form1
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
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.txt_ChatBox = new System.Windows.Forms.TextBox();
            this.btn_Block = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lBox_Viewer = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Start.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Start.FlatAppearance.BorderSize = 0;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Start.Location = new System.Drawing.Point(12, 12);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(112, 40);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Stop.BackColor = System.Drawing.Color.Red;
            this.btn_Stop.FlatAppearance.BorderSize = 0;
            this.btn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stop.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Stop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Stop.Location = new System.Drawing.Point(12, 58);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(112, 40);
            this.btn_Stop.TabIndex = 1;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Stop.UseVisualStyleBackColor = false;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // txt_ChatBox
            // 
            this.txt_ChatBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ChatBox.Location = new System.Drawing.Point(0, 0);
            this.txt_ChatBox.Multiline = true;
            this.txt_ChatBox.Name = "txt_ChatBox";
            this.txt_ChatBox.ReadOnly = true;
            this.txt_ChatBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ChatBox.Size = new System.Drawing.Size(785, 573);
            this.txt_ChatBox.TabIndex = 2;
            // 
            // btn_Block
            // 
            this.btn_Block.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Block.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Block.Location = new System.Drawing.Point(12, 521);
            this.btn_Block.Name = "btn_Block";
            this.btn_Block.Size = new System.Drawing.Size(111, 40);
            this.btn_Block.TabIndex = 4;
            this.btn_Block.Text = "Block";
            this.btn_Block.UseVisualStyleBackColor = true;
            this.btn_Block.Click += new System.EventHandler(this.btn_Block_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_ChatBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 573);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lBox_Viewer);
            this.panel2.Controls.Add(this.btn_Start);
            this.panel2.Controls.Add(this.btn_Block);
            this.panel2.Controls.Add(this.btn_Stop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(785, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 573);
            this.panel2.TabIndex = 6;
            // 
            // lBox_Viewer
            // 
            this.lBox_Viewer.FormattingEnabled = true;
            this.lBox_Viewer.ItemHeight = 15;
            this.lBox_Viewer.Location = new System.Drawing.Point(12, 104);
            this.lBox_Viewer.Name = "lBox_Viewer";
            this.lBox_Viewer.Size = new System.Drawing.Size(120, 409);
            this.lBox_Viewer.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 573);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Start;
        private Button btn_Stop;
        private Button btn_Block;
        public TextBox txt_ChatBox;
        private Panel panel1;
        private Panel panel2;
        private ListBox lBox_Viewer;
    }
}