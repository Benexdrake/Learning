using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model_Request_Manager.Forms
{
    public partial class RequestForm : Form
    {
        public Classes.Request request;
        Classes.SqlDB sqlDB;
        bool isLiked;
        public int variant;
        public RequestForm()
        {
            InitializeComponent();
            sqlDB = new Classes.SqlDB();
            btn_Like.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
        }
        public void fillRequest()
        {
            txt_Note.Text = request.note;
            tbox_Text.Text = request.text;
            check_White.Checked = request.whiteBox;
            check_Low.Checked = request.lowPoly;
            check_High.Checked = request.highPoly;
            check_Texture.Checked = request.texture;
            cBox_Category.SelectedIndex = request.category;
            cBox_Available.Checked = request.available;
            lbl_FileName.Text = request.fileName;
            isLiked = request.like;
            
        }

        public void checkLike()
        {
            switch(variant)
            {
                case 0:
                    // my
                    btn_Like.Visible = false;
                    btn_Download.Visible = false;
                    btn_Upload.Visible = true;
                    btn_NewUpload.Visible = false;
                    break;
                case 1: case 2:
                    // All
                    btn_Like.Visible = true;
                    btn_Send.Visible = false;
                    cBox_Available.Visible = false;
                    btn_NewUpload.Location = btn_Send.Location;
                    btn_NewUpload.Visible = true;
                    btn_Send.Visible = false;
                    btn_Download.Location = btn_Upload.Location;
                    btn_Download.Visible = true;
                    break;
                
            }

            if (isLiked == true)
            {
                btn_Like.Image = Properties.Resources.Heart_Like;
                btn_Like.Refresh();

                // SQL Eintrag
                
            }
            else
            {
                btn_Like.Image = Properties.Resources.Heart_NoLike;
                btn_Like.Refresh();
                // SQL Eintrag löschen
                
                //sqlDB.sqlWrite(sql);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            checkReturn(sender,e);
            this.Close();
        }

        private void checkReturn(object sender, EventArgs e)
        {
            switch(variant)
            {
                case 0:
                    MainForm.instance.btn_Requests_Click(sender, e);
                    break;
                case 1:
                    MainForm.instance.btn_AllRequests_Click(sender, e);
                    break;
                case 2:
                    MainForm.instance.btn_RequestList_Click(sender, e);
                    break;
            }
        }


        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            Classes.WindowMove.ReleaseCapture();
            Classes.WindowMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            switch(variant)
            {
                case 0:
                    SendRequest(sender,e);
                    break;
                case 99:
                    if (txt_Note.Text != String.Empty && tbox_Text.Text != String.Empty)
                    {
                        SendRequest(sender,e);
                    }
                    else
                    {
                        MessageBox.Show("Note und Information ausfüllen!");
                    }
                    break;
            }
            

        }

        private void SendRequest(object sender, EventArgs e)
        {
            request.note = txt_Note.Text;
            request.text = tbox_Text.Text;
            request.whiteBox = check_White.Checked;
            request.lowPoly = check_Low.Checked;
            request.highPoly = check_High.Checked;
            request.texture = check_Texture.Checked;
            request.category = cBox_Category.SelectedIndex;
            request.fileName = $"{request.username}{request.requestId}.rar";
            request.available = cBox_Available.Checked;
            string sql = $"update requests set reqnote = '{request.note}', reqcategory = {request.category}, reqtext = '{request.text}', reqfile = '{request.fileName}', reqwhitebox = {request.whiteBox}, reqlow = {request.lowPoly}, reqhigh = {request.highPoly}, reqtexture = {request.texture}, available = {request.available} where reqid = {request.requestId} and requserid = {Classes.Save.UserID};";
            sqlDB.sqlWrite(sql);
            MainForm.instance.btn_Requests_Click(sender, e);
            this.Close();
        }

        private void btn_DownUpload_Click(object sender, EventArgs e)
        {
            // Upload or Download File, Only .rar
        }

        private void btn_Like_Click(object sender, EventArgs e)
        {
            isLiked = !isLiked;
            checkLike();
            if(isLiked)
            {
                sqlDB.sqlWrite($"insert into saverequests(SaveUserId,SRReqID) values ({Classes.Save.UserID}, {request.requestId}); ");
            }
            else
            {
                sqlDB.sqlWrite($"delete from SaveRequests where SaveUserId = {Classes.Save.UserID} and SRReqID = {request.requestId};");
            }
        }

        private void btn_NewUpload_Click(object sender, EventArgs e)
        {
            RequestForm request = new RequestForm();
            request.variant = variant;
            request.request = this.request;
            request.btn_Upload.Visible = true;
            request.btn_Download.Location = request.btn_Upload.Location;
            this.Close();
            request.Show();
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {



        }
    }
}
