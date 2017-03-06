using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knockoutDarts
{
    class addPlayer
    {
        public addPlayer(player p,FlowLayoutPanel pan)
        {
            showPlayer sPlayer = new showPlayer(p);
            pan.Controls.Add(sPlayer);
            
            

        }


    }
}
