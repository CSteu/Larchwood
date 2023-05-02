using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public class Board
    {
        public Board() 
        { 
        
        }
        public string Player1h
        {
            get;
            set;
        }
        public string Player1l
        {
            get;
            set;
        }
        public string Player2h
        {
            get;
            set;
        }
        public string Player2l
        {
            get;
            set;
        }
        public string Player3h
        {
            get;
            set;
        }
        public string Player3l
        {
            get;
            set;
        }
        public string Player4h
        {
            get;
            set;
        }
        public string Player4l
        {
            get;
            set;
        }
        public string DrawBoard(int x)
        {
            string send = "Board " + x + 1 + "\n" + Player1h + "|" + Player1l + "\n"
                                                + Player2h + "|" + Player2l + "\n"
                                                + Player3h + "|" + Player3l + "\n"
                                                + Player4h + "|" + Player4l + "\n\n\n";
            return send;
        }
    }
}
