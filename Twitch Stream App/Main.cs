

using TwitchLib.Api.Helix.Models.Users.GetUsers;

namespace Twitch_Stream_App
{
    public partial class Main : Form
    {
        private string log = string.Empty;
        Bot bot;

        bool isBotRunning;

        public Main()
        {
            InitializeComponent();
            bot = new Bot(this);
            isBotRunning = false;
        }

        public void ChatBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(ChatBox), new object[] { value });
                return;
            }
            //txt_ChatBox.Text += value;
            tBox_Chat.AppendText(value);
        }

        public void ViewCounter(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(ViewCounter), new object[] { value });
                return;
            }
            lbl_ViewCounter.Text = value;
        }

        public void Log(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(Log), new object[] { value });
                return;
            }
            log += value + Environment.NewLine;
            Helper.Log(value);
        }

        public void AddViewer(string viewer)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AddViewer), new object[] { viewer });
                return;
            }
            lBox_Viewers.Items.Add(viewer);

        }

        public void DeleteViewer(string viewer)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(DeleteViewer), new object[] { viewer });
                return;
            }
            lBox_Viewers.Items.Remove(viewer);
        }

        public void ClearChat()
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(ClearChat), new object[] { null });
                return;
            }
            tBox_Chat.Clear();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if(tBox_Send.Text != string.Empty)
            {
                bot.SendMessage(tBox_Send.Text);
                tBox_Chat.AppendText("<<<<< Me: " + tBox_Send.Text + Environment.NewLine);
                tBox_Send.Text = "";
            }
        }

        private void tBox_Send_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_Send_Click(sender,e);
            }
        }

        private void btn_Block_Click(object sender, EventArgs e)
        {
            if(lBox_Viewers.Items.Count > 0)
            {
                string name = lBox_Viewers.Text;
                //bot.BlockViewer(name);

                var task = Task.Run(() => bot.BlockViewer(name));
                
            }
        }

        private void btn_User_ID_Click(object sender, EventArgs e)
        {
            if(lBox_Viewers.Items.Count > 0)
            {
                MessageBox.Show(GetUser(0));
            }
        }


        

        private string GetUser(int n)
        {
            List<string> userList = new List<string>();
            userList.Add(lBox_Viewers.Text);
            var user = bot.GetUser(userList).Result;
            switch (n)
            {
                case 0:
                    return user.Id;
                    break;
                case 1:
                    return user.Login;
                    break;
                case 2:
                    return user.DisplayName;
                    break;
                case 3:
                    return user.CreatedAt.ToString();
                    break;
                case 4:
                    return user.Type;
                    break;
                case 5:
                    return user.BroadcasterType;
                    break;
                case 6:
                    return user.Description;
                    break;
                case 7:
                    return user.ProfileImageUrl;
                    break;
                case 8:
                    return user.OfflineImageUrl;
                    break;
                case 9:
                    return user.ViewCount.ToString();
                    break;
                case 10:
                    return user.Email;
                    break;

                default:
                    return "";
                    break;
            }
            
            
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bot.Connect();
            this.Text = "Connected as: " + bot.BotName;
            isBotRunning = true;
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bot.Disconnect();
            this.Text = "Disconnected";
            lbl_ViewCounter.Text = "0";
            lBox_Viewers.Items.Clear();
            isBotRunning=false;
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetUser(0));
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void followingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var list = new List<string>();
            list.Add(bot.BotName);

            var follow = bot.FollowUsersRespone(list).Result;

            new FollowsForm(follow).Show();

        }

        private void menuStripViewer_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(lBox_Viewers.SelectedIndex < 0)
            {
                menuStripViewer.Enabled = false;
            }
            else
            {
                menuStripViewer.Enabled = true;
            }
        }

        private void menuStripBot_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(!isBotRunning)
            {
                toolStripMenuItemBotStart.Enabled = true;
                toolStripMenuItemBotStop.Enabled = false;
                followingToolStripMenuItem.Enabled = false;
            }
            else
            {
                toolStripMenuItemBotStart.Enabled = false;
                toolStripMenuItemBotStop.Enabled = true;
                followingToolStripMenuItem.Enabled = true;
            }
        }

        private void tsmItem_Follow_Click(object sender, EventArgs e)
        {
            var id = GetUser(0);
            Task.Run(() => bot.FollowViewer(id));
        }

        private void unfollowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var id = GetUser(0);
            Task.Run(() => bot.UnFollowViewer(id));
        }

        private void tsmItem_Block_Click(object sender, EventArgs e)
        {
            var id = GetUser(0);
            Task.Run(() => bot.BlockViewer(id));
        }
    }


}