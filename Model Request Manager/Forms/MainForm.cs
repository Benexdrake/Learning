using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model_Request_Manager.Classes;

namespace Model_Request_Manager.Forms
{
    public partial class MainForm : Form
    {
        public static MainForm instance;
        RequestListForm request;
        List<Classes.Request> requestList;
        int variant;
        bool isLiked;
        public MainForm()
        {
            InitializeComponent();
            instance = this;
            cBox_Category.SelectedIndex = 0;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void btn_NewRequest_Click(object sender, EventArgs e)
        {
            var formCloseRequest = Application.OpenForms.OfType<RequestForm>().FirstOrDefault();

            if (formCloseRequest != null)
            {
                formCloseRequest.Close();
            }
            formCloseRequest = Application.OpenForms.OfType<RequestForm>().FirstOrDefault();

            RequestForm request = new RequestForm();
            request.Name = "New Request";
            childPanel.Controls.Clear();
            request.variant = 99;
            request.Show();
        }
        public void btn_Requests_Click(object sender, EventArgs e)
        {
            // select * from Request where userid = X;
            ClearSearch();
            LoadList(false,0,false);
        }

        public void btn_AllRequests_Click(object sender, EventArgs e)
        {
            // select * from request;
            ClearSearch();
            LoadList(false, 1,false);
        }

        public void btn_RequestList_Click(object sender, EventArgs e)
        {
            // Zeigt die Favoriten des Users
            ClearSearch();
            LoadList(true,2,false);
        }

        private void btn_Downloads_Click(object sender, EventArgs e)
        {

        }

        private void ClearSearch()
        {
            tBox_Username.Text = string.Empty;
            tBox_Note.Text = string.Empty;
            rBtn_ASC.Checked = true;
            rBtn_DESC.Checked = false;
            check_White.Checked = false;
            check_Low.Checked = false;
            check_High.Checked = false;
            check_Texture.Checked = false;
            cBox_Category.SelectedIndex = 0;
        }

        private string AscDesc()
        {
            string sql = "";
            if(rBtn_ASC.Checked == true)
            {
                sql = "desc";
            }
            else if(rBtn_DESC.Checked == true)
            {
                sql = "asc";
            }
            return sql;
        }

        private void LoadList(bool isLiked, int variant, bool searchbar)
        {
            string sql = SqlQuere(variant,searchbar); 
            childPanel.Controls.Clear();
            SqlDB sqldb = new SqlDB();
            sqldb.sqlRead(sql, isLiked);
            this.variant = variant;
            this.isLiked = isLiked;
            requestList = sqldb.requestList;
            // Verbindet mit der SQL Datenbank und fragt nach meinen Request einträgen ab
            for (int i = 0; i < requestList.Count; i++)
            {
                request = new RequestListForm();
                request.variant = variant;
                request.request = requestList[i];
                request.fillRequestList();
                childPanel.Controls.Add(request);
                request.Dock = DockStyle.Top;
                request.Show();
            }
            
        }

        private string SqlQuere(int variant, bool searchbar)
        {
            switch(variant)
            {
                case 0:
                    // My Requests
                    if(searchbar == true)
                    {
                    return $"select * from requests join users on requests.requserid = users.userid where ReqUserId = {Save.UserID} and ReqNote like '%{tBox_Note.Text}%' and Users.Username like '%{tBox_Username.Text}%' and ReqWhiteBox = {check_White.Checked} and ReqLow = {check_Low.Checked} and ReqHigh = {check_High.Checked} and ReqTexture = {check_Texture.Checked} and ReqCategory = {cBox_Category.SelectedIndex} order by ReqNote {AscDesc()};";
                    }
                    else
                    {
                        return $"select * from requests join users on requests.requserid = users.userid where ReqUserId = {Save.UserID} and ReqNote like '%{tBox_Note.Text}%' and Users.Username like '%{tBox_Username.Text}%' order by ReqNote {AscDesc()};";
                    }
                case 1:
                    // All Requests
                    if(searchbar == true)
                    {
                        return $"select * from requests join users on requests.requserid = users.userid where not ReqUserId = {Save.UserID} and ReqNote like '%{tBox_Note.Text}%' and Users.Username like '%{tBox_Username.Text}%' and ReqWhiteBox = {check_White.Checked} and ReqLow = {check_Low.Checked} and ReqHigh = {check_High.Checked} and ReqTexture = {check_Texture.Checked} and ReqCategory = {cBox_Category.SelectedIndex} and available = true order by ReqNote {AscDesc()};";
                    }
                    else
                    {
                    return $"select * from requests join users on requests.requserid = users.userid where not ReqUserId = {Save.UserID} and ReqNote like '%{tBox_Note.Text}%' and Users.Username like '%{tBox_Username.Text}%' and available = true order by ReqNote {AscDesc()};";
                    }
                case 2:
                    // My Favorit Requests
                    if(searchbar == true)
                    {
                        return "select requests.reqid, requests.requserid, requests.reqnote, requests.reqtext, requests.reqcategory, requests.reqfile, requests.reqwhitebox, requests.reqlow, requests.reqhigh, requests.reqtexture, requests.reqdatetime, users.userid, users.UserAvailable, users.userguidid, users.username,  requests.available from requests"
                             + " join users on requests.requserid = users.userid"
                             + " join saverequests on requests.reqid = saverequests.srreqid"
                             + $" where saverequests.saveuserid = {Classes.Save.UserID}"
                             + $" and ReqNote like '%{tBox_Note.Text}%' and Users.Username like '%{tBox_Username.Text}%' and available = true order by ReqNote {AscDesc()};";
                    }
                    else
                    {
                        return "select requests.reqid, requests.requserid, requests.reqnote, requests.reqtext, requests.reqcategory, requests.reqfile, requests.reqwhitebox, requests.reqlow, requests.reqhigh, requests.reqtexture, requests.reqdatetime, users.userid, users.UserAvailable, users.userguidid, users.username,  requests.available from requests"
                             + " join users on requests.requserid = users.userid"
                             + " join saverequests on requests.reqid = saverequests.srreqid"
                             + $" where saverequests.saveuserid = {Classes.Save.UserID}";
                    }
                case 4:
                    return "";
                default:
                    return "";
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            WindowMove.ReleaseCapture();
            WindowMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void rBtn_ASC_CheckedChanged(object sender, EventArgs e)
        {
            LoadList(isLiked,variant,true);
        }

        private void rBtn_DESC_CheckedChanged(object sender, EventArgs e)
        {
            LoadList(isLiked, variant, true);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            LoadList(isLiked, variant, true);
        }

        private void tBox_Search_TextChanged(object sender, EventArgs e)
        {
            LoadList(isLiked, variant, true);
        }

        private void tBox_Username_TextChanged(object sender, EventArgs e)
        {
            LoadList(isLiked, variant, true);
        }

        private void cBox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadList(isLiked, variant, true);
        }

        private void check_Low_CheckedChanged(object sender, EventArgs e)
        {
            LoadList(isLiked, variant, true);
        }

        private void check_White_CheckedChanged(object sender, EventArgs e)
        {
            LoadList(isLiked, variant, true);
        }

        private void check_High_CheckedChanged(object sender, EventArgs e)
        {
            LoadList(isLiked, variant, true);
        }

        private void check_Texture_CheckedChanged(object sender, EventArgs e)
        {
            LoadList(isLiked, variant, true);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearSearch();
        }

        private void tBox_Username_Click(object sender, EventArgs e)
        {
            tBox_Username.Text = "";
        }

        private void tBox_Note_Click(object sender, EventArgs e)
        {
            tBox_Username.Text = "";
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            WindowMove.ReleaseCapture();
            WindowMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
