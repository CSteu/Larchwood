using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ActivationForm : Form
    {
        public ActivationForm()
        {
            InitializeComponent();
        }

        private void ActivationForm_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activation act = new activation();
            act.activateSoftware(txtKey.Text);
            if(act.Activated == true)
            {
                LarchwoodTournament form = new LarchwoodTournament(txtKey.Text);
                form.Show();
                this.Hide();
            }
        }
    }
}
