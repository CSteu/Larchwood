using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public class Results
    {
        string first;
        string second;
        string third;
        string fourth;
        int firstpoints;
        int secondpoints;
        int thirdpoints;
        int fourthpoints;
        public Results()
        {

        }

        public void ShowResults(List<Player> players)
        {
            List<Player> rplayers = players.OrderByDescending(p => p.Points).ToList();
            first = rplayers[0].Name;
            firstpoints = rplayers[0].Points;
            second = rplayers[1].Name;
            secondpoints = rplayers[1].Points;
            third = rplayers[2].Name;
            thirdpoints = rplayers[2].Points;
            fourth = rplayers[3].Name;
            fourthpoints = rplayers[3].Points;
            MessageBox.Show("FINAL RANKINGS:\n" +
                            "1st: " + first + " " + firstpoints + "\n" +
                            "2nd: " + second + " " + secondpoints + "\n" +
                            "3rd: " + third + " " + thirdpoints + "\n" +
                            "4th: " + fourth + " " + fourthpoints + "\n");
        }
    }
}
