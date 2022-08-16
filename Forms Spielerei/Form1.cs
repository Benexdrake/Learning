using MySql.Data.MySqlClient;
using System.Data;

namespace Forms_Spielerei
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            ((Panel)e.Data.GetData(typeof(Panel))).Parent = (Panel)sender;

            var tlp = (Panel)e.Data.GetData(typeof(Panel));
            
            tlp.BringToFront();
        }

        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            Panel panel = sender as Panel;
            panel.DoDragDrop(panel, DragDropEffects.Move);
            
           
        }

        private Panel Front(Panel panel)
        {
           return panel.BringToFront();
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            panel.BackColor = Color.Green;
            panel.Height = 100;
            panel.Dock = DockStyle.Top;
            panel.MouseUp += panel_MouseUp;
            panel.MouseDown += panel_MouseDown;
            panel1.Controls.Add(panel);
        }
    }
}