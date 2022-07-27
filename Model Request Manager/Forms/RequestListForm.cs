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
    public partial class RequestListForm : UserControl
    {
        public Classes.Request request;
        public int variant;
        public RequestListForm()
        {
            InitializeComponent(); 
        }

        public void fillRequestList()
        {
            check_White.AutoCheck = false;
            check_Low.AutoCheck = false;
            check_High.AutoCheck = false;
            check_Texture.AutoCheck = false;
            txt_Note.Text = request.note;
            check_White.Checked = request.whiteBox;
            check_Low.Checked = request.lowPoly;
            check_High.Checked = request.highPoly;
            check_Texture.Checked = request.texture;
            cBox_Category.SelectedIndex = request.category;
            tBox_Category.Text = cBox_Category.Text;
            lbl_Username.Text = request.username;

        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            RequestForm request = new RequestForm();
            request.variant = variant;
            request.request = this.request;
            request.checkLike();
            request.fillRequest();
            request.Show();
        }
    }
}
