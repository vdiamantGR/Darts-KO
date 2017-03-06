using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knockoutDarts
{
    public partial class showPlayer : UserControl
    {
        player myPlayer;
        public showPlayer(Object play)
        {
            player pla = (player)play;
            InitializeComponent();
            myPlayer = pla;
            Lname.Text = myPlayer.getName().ToString();
            Lpoints.Text = myPlayer.getPoints().ToString();
        }

        public object getPlayer()
        {
            return myPlayer;
        }

        public void setPoints(string p)
        {
            Lpoints.Text = p;
        }
    }
}
