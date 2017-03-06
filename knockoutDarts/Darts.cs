using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knockoutDarts
{
    public partial class Darts : Form
    {
        int position = 0;
        int darts = 0;
        int multiply = 1;
        int finishPoints = 300;
        List<player> myLplayers;
        public Darts(object myListofPlayers,int fpoints)
        {
            InitializeComponent();
            finishPoints = fpoints;
            List<player> myListplayers = (List<player>)myListofPlayers;
            myLplayers = (List < player >)myListofPlayers;
            foreach(player pla in myListplayers)
            {
                addPlayer newpl = new addPlayer(pla, this.flowLayoutPanel1);
            }
            focusPosition();
            Update();
        }

        public FlowLayoutPanel getFPanel()
        {
            return flowLayoutPanel1;
        }


        public void setWhoIsPlaying()
        {
            label1.Text = myLplayers.ElementAt(position).getName();
            /*if (position == myLplayers.Count)
            {
                position = 0;
            }
            else
            {
                position++;
            }*/
        }

        private void addPointsFromB(object sender, MouseEventArgs e)
        {
            updateContol(sender);
            label2.Text = "";
            CheckForMath(myLplayers.ElementAt(position));
        }

        private void updateContol(object sender)
        {
            foreach (Control myControl in flowLayoutPanel1.Controls)
            {
                showPlayer sp = (showPlayer)myControl;
                player tmpPlayer = (player)sp.getPlayer();
                Button tmltBtn = (Button)sender;
                if (tmpPlayer.getName()== myLplayers.ElementAt(position).getName())
                {
                    myLplayers.ElementAt(position).addPoints(Int32.Parse(tmltBtn.Text.ToString())*multiply);
                    multiply = 1;
                    foreach (player victim in myLplayers) {
                        if ((victim.getName().Equals(tmpPlayer.getName()) == false)&&(victim.getPoints()==tmpPlayer.getPoints() == true))
                        {
                            victim.setPoints(0);
                            victimAnimation(victim);
                            
                        }
                    }
                    sp.setPoints(myLplayers.ElementAt(position).getPoints().ToString());
                    Update();
                    if (myLplayers.ElementAt(position).getPoints()>finishPoints)
                    {

                        for (int i = 0; i < 3; i++)
                        {
                            sp.BackColor = Color.Gold;
                            Update();
                            Thread.Sleep(150);
                            sp.BackColor = Color.PaleTurquoise;
                            Update();
                            Thread.Sleep(150);

                        }
                        sp.BackColor = Color.Gold;
                        return;
                    }
                }
                //CheckForMath(tmpPlayer);
            }
            darts++;
            
            if (darts == 3)
            {
                position++;
                darts = 0;
                if (position >= myLplayers.Count)
                {
                    position = 0;
                }
            }
            focusPosition();
            Update();
        }

        private void CheckForMath(object p)
        {
            player myHero = (player)p;
            label1.Text = "";
            bool first = true;
            foreach (player player in myLplayers)
            {
                
                if ((player.getName().Equals(myHero.getName()) == false))
                {
                    
                    if ((player.getPoints() > myHero.getPoints()))
                    {
                        int diff = player.getPoints() - myHero.getPoints();
                        label1.Text += "| " + diff + " for " + player.getName() + " | ";
                        first = false;
                        Update();
                    }
                }
                

            }
            if (first)
            {
                label1.Text = myHero.getName() + " is 1st!";
            }
        }

        private void victimAnimation(player victim)
        {
            int ar = 0;
            foreach (Control myControl in flowLayoutPanel1.Controls)
            {
                showPlayer sp = (showPlayer)myControl;
                player tmpP = (player)sp.getPlayer();
                if (tmpP.getName().Equals(victim.getName()))
                {
                    for(int i = 0; i < 3; i++) { 
                        myControl.BackColor = Color.Red;
                        Update();
                        Thread.Sleep(150);
                        myControl.BackColor = Color.PaleTurquoise;
                        Update();
                        Thread.Sleep(150);

                    }
                    showPlayer tmpC = (showPlayer)myControl;
                    tmpC.setPoints("0");
                }
                ar++;

            }
        }

        public void focusPosition()
        {
            int ar = 0;
            foreach (Control myControl in flowLayoutPanel1.Controls)
            {
                showPlayer sp = (showPlayer)myControl;
                if (ar==position)
                {
                    label1.Text = myLplayers.ElementAt(position).getName();
                    myControl.BackColor = Color.Green;
                }else
                {
                    myControl.BackColor = Color.PaleTurquoise;
                }
                ar++;

            }
            CheckForMath(myLplayers.ElementAt(position));
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { return; }
            Button tmpB = new Button();
            tmpB.Text = textBox1.Text;
            updateContol(tmpB);
            textBox1.Text = "";
            label2.Text = "";
            CheckForMath(myLplayers.ElementAt(position));
        }
        
        private void button25_Click(object sender, EventArgs e)
        {
            if (multiply != 2)
            { 
            multiply = 2;
                label2.Text = "X 2";
            }
            else
            {
                multiply = 1;
                label2.Text = "";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {

            if (multiply != 3)
            {
                multiply = 3;
                label2.Text = "X 3";
            }
            else
            {
                multiply = 1;
                label2.Text = "";
            }
        }
    }
}
