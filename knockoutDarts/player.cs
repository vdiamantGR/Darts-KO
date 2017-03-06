using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knockoutDarts
{
    
    class player
    {
        string name;
        int points;


        public player(string n)
        {
            this.name = n;
            this.points = 0;

        }

        public string getName()
        {
            return name;
        }

        public int getPoints()
        {
            return points;
        }

        public void setPoints(int x)
        {
            this.points = x;
        }

        public void addPoints(int x)
        {
            points += x;
        }

    }
}
