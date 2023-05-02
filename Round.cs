using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Round
    {
        public Round()
        {

        }
        public int AmtRound
        {
            get; 
            set; 
        }
        public List<Player> RoundSummary(List<Player> players)
        {
            PlayerPointInput ppi = new PlayerPointInput(players); 
            ppi.Activate();
            if(ppi.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                players = ppi.GetPoints();
            return players;
        }
    }
}
