using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knockoutDarts
{
    public partial class StartForm : Form
    {
        
        FlowLayoutPanel myP;
        List<player> myListofPlayers = new List<player>();
        public StartForm()
        {
            InitializeComponent();
            myP = new FlowLayoutPanel();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                return;
            }
            
            player pl = new player(textBox1.Text.ToString());
            addPlayer myAddp = new addPlayer(pl, myP);
            myListofPlayers.Add(pl);
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Darts dartsForm = new Darts(myListofPlayers,Int32.Parse(textBox2.Text));
            this.Hide();
            dartsForm.Show();
        }
    }
}
