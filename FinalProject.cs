using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class LarchwoodTournament : Form
    {
        List<Player> playerlist = new List<Player>();
        public LarchwoodTournament()
        {
            InitializeComponent();
            defaultPanel.Show();
            EditPlayer.Hide();
            BoardPanel.Hide();
        }

        private void LarchwoodTournament_Load(object sender, EventArgs e)
        {
            using (IsolatedStorageFile isolatedStorageFile = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null))
            {
                try
                {
                    using (IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream("settings.txt", System.IO.FileMode.Open, isolatedStorageFile))
                    {
                        using (System.IO.StreamReader sr = new System.IO.StreamReader(isolatedStorageFileStream))
                        {
                            var activated = activation.isActivated(sr.ReadLine());
                            if (!activated)
                            {
                                MessageBox.Show("not activated");
                                //goto activation form
                            }
                            else
                            {
                                MessageBox.Show("activated");
                                //goto main program
                            }
                        }
                    }
                }
                catch { }
            }
        }

        private void NBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PpBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenderBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PPDBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void rNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rGenderBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rNumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rPPDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RSTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoundCountBox_TextChanged(object sender, EventArgs e)
        {

        } 
        private void RenameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegenderBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RenumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RePPDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(int.Parse(SearchNameBox.Text) > playerlist.Last().Number || int.Parse(SearchNameBox.Text) < 1)
            {
                MessageBox.Show("Number not found");
                return;
            }
            Player searched = playerlist.Where(p => p.Number.ToString() == SearchNameBox.Text).First();
            SearchNameBox.Clear();
            RenameBox.Text = searched.Name;
            RegenderBox.Text = searched.Gender;
            RenumberBox.Text = searched.Number.ToString();
            RePPDBox.Text = searched.PPD.ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Player updated = playerlist.Where(p => p.Number.ToString() == RenumberBox.Text).First();
            updated.Name = RenameBox.Text;
            updated.Gender = RegenderBox.Text;
            updated.PPD = float.Parse(RePPDBox.Text);
            RenameBox.Clear();
            RegenderBox.Clear();
            RenumberBox.Clear();
            RePPDBox.Clear();
            MessageBox.Show("Update Complete");
            rNameBox.Text = updated.Name;
            rGenderBox.Text = updated.Gender;
            rNumberBox.Text = updated.Number.ToString();
            rPPDBox.Text = updated.PPD.ToString();
        }
        private void EditPlayerButton_Click(object sender, EventArgs e)
        {
            EditPlayer.Show();
            BoardPanel.Hide();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            defaultPanel.Show();
            EditPlayer.Hide();
            BoardPanel.Hide();
        }
        private void APButton_Click(object sender, EventArgs e)
        {
            Player tmp = new Player();
            if (NameBox.Text.Length == 0 || PPDBox.Text.Length == 0)
            {
                MessageBox.Show("Needs more input");
                return;
            }
            tmp.Name = NameBox.Text;
            tmp.Gender = GenderBox.Text;
            tmp.Number = int.Parse(NumberBox.Text);
            int tnum = tmp.Number + 1;
            tmp.PPD = float.Parse(PPDBox.Text);
            tmp.Points = 0;
            playerlist.Add(tmp);
            NameBox.Clear();
            NumberBox.Text = tnum.ToString();
            PPDBox.Clear();
            tmp = playerlist.Last();
            rNameBox.Text = tmp.Name;
            rGenderBox.Text = tmp.Gender;
            rNumberBox.Text = tmp.Number.ToString();
            rPPDBox.Text = tmp.PPD.ToString();
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            BoardsBox.Clear();
            int k, r, a;
            int tnum = int.Parse(NumberBox.Text) - 1;
            if (tnum % 8 != 0)
            {
                tnum = 8 - (tnum % 8);
                MessageBox.Show("Need " + tnum + " more players");
                return;
            }
            defaultPanel.Show();
            EditPlayer.Show();
            BoardPanel.Show();
            Round rounds = new Round();
            rounds.AmtRound = int.Parse(RoundCountBox.Text);
            List<Player> tlist = playerlist;
            Random rand = new Random();
            int bnum = tnum / 8;
            Board board = new Board();
            List<Board> boards = new List<Board>();
            for (r = 0; r < rounds.AmtRound; r++)
            {
                int ro = r + 1;
                BoardsBox.Text += "Round " + ro + "\n";
                for(k = tlist.Count-1; k>=1; k--)
                {
                    a = rand.Next(k + 1);
                    Player tmp = tlist[a];
                    tlist[a] = tlist[k];
                    tlist[k] = tmp;
                }
                int i = 0;
                for (k = 0; k < bnum; k++)
                {
                    board.Player1h = tlist[i].Name;
                    i++;
                    board.Player1l = tlist[i].Name;
                    i++;
                    board.Player2h = tlist[i].Name;
                    i++;
                    board.Player2l = tlist[i].Name;
                    i++;
                    board.Player3h = tlist[i].Name;
                    i++;
                    board.Player3l = tlist[i].Name;
                    i++;
                    board.Player4h = tlist[i].Name;
                    i++;
                    board.Player4l = tlist[i].Name;
                    i++;
                    string paste = board.DrawBoard(k);
                    BoardsBox.Text += paste;
                    boards.Add(board);
                }
                playerlist = rounds.RoundSummary(tlist);
                tlist = playerlist.OrderByDescending(p => p.Points).ToList();
                for (k = 0; k < tlist.Count; k++)
                    BoardsBox.Text += tlist[k].Name + " " + tlist[k].Points.ToString() + "\n";
                BoardsBox.Text += "\n\n\n";
            }
            Results results = new Results();
            results.ShowResults(playerlist);
        }
        private void BoardPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void defaultPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditPlayer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BoardsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            activation act = new activation();
            act.activateSoftware(txtKey.Text);
        }
    }
}
