using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitchLib.Api.Helix.Models.Users.GetUserFollows;

namespace Twitch_Stream_App
{
    public partial class FollowsForm : Form
    {
        Follow[] list;
        public FollowsForm(Follow[] _list)
        {
            InitializeComponent();
            list = _list;
            Fill();
        }

        private void Fill()
        {
            foreach (var item in list)
            {
                dataGridView.Rows.Add(item.FromUserName, item.FromUserId, item.FollowedAt, item.ToUserName, item.ToUserId);
            }
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowSelected = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    this.dataGridView.ClearSelection();
                    this.dataGridView.Rows[rowSelected].Selected = true;
                }
                // you now have the selected row with the context menu showing for the user to delete etc.
            }
        }
    }
}
