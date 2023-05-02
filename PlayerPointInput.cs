using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class PlayerPointInput : Form
    {
        int k = 0;
        List<Player> players = new List<Player>();
        public PlayerPointInput(List<Player> tmp)
        {
            InitializeComponent();
            players = tmp;
            NameBox.Text = players[k].Name;
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PointsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (k == players.Count)
                DoneButton_Click(sender, e);
            else
            {
                int points = int.Parse(PointsBox.Text);
                players[k].Points += points;
                k++;
                if (k == players.Count)
                    return;
                NameBox.Text = players[k].Name;
            }
        }
        public List<Player> GetPoints()
        {
            return players;
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
