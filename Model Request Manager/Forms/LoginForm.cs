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
    public partial class LoginForm : Form
    {
        MainForm main;
        SqlDB sql;
        public LoginForm()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            login();

            if(sql.isLoginOk)
            {
            main = new MainForm();
            main.Show();
            this.Visible = false;
            }
            else
            {
                MessageBox.Show("Error!!!");
            }
        }

        private void pBox_Config_Click(object sender, EventArgs e)
        {
            // Öffnet ein Config Fenster um IP des Servers, so wie port usw zu speichern
        }

        private void login()
        {
            //Speichert den Username und das Password in einer Static um darauf später nochmal zugreifen zu können, das Password wird als SHA256 gespeichert.
            Save.UserName = tBox_Username.Text;
            string sha256 = SHA256Password.Compute256(tBox_Password.Text);
            Save.Password = sha256;
            sql = new SqlDB();
            string sqlStr = "select * from users where UserName = '" + Save.UserName + "' and Userpassword = '" + sha256 + "';";
            sql.sqlLogin(sqlStr);
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

        private void tBox_Password_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Enter)
            {
                btn_Login_Click(sender, e);
            }
        }
    }
}
