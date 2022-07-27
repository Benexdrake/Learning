namespace Twitch_Forms
{
    public partial class Form1 : Form
    {
        Bot bot;
        string log = string.Empty;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Disconnected";
            bot = new Bot(this);
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            this.Text = "Connected...";
            bot.Connect();
            btn_Start.Enabled = false;
            btn_Stop.Enabled = true;
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            this.Text = "Disconnected...";
            bot.Disconnect();
            btn_Start.Enabled = true;
            btn_Stop.Enabled = false;
            lBox_Viewer.Items.Clear();
        }

        private void btn_Block_Click(object sender, EventArgs e)
        {

        }

        public void ChatBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(ChatBox), new object[] { value });
                return;
            }
            //txt_ChatBox.Text += value;
            txt_ChatBox.AppendText(value);
        }
        public void Log(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(Log), new object[] { value });
                return;
            }
            log += value;
        }

        public void AddViewer(string viewer)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AddViewer), new object[] { viewer });
                return;
            }
            lBox_Viewer.Items.Add(viewer);
            
        }

        public void DeleteViewer(string viewer)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(DeleteViewer), new object[] { viewer });
                return;
            }
            lBox_Viewer.Items.Remove(viewer);
        }

        public void ClearLog()
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(ClearLog), new object[] { null});
                return;
            }
            txt_ChatBox.Clear();
        }
    }
}