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

        private void btn_Ablage_DownloadOrdner_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                txt_Ablage_DownloadOrdner.Text = fbd.SelectedPath;
            }
        }

        private void btn_Ablage_Zielordner_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txt_Ablage_ZielOrdner.Text = fbd.SelectedPath;
            }
        }

        private void btn_Entpacken_ZielOrdner_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txt_Entpacken_ZielOrdner.Text = fbd.SelectedPath;
            }
        }
    }
}