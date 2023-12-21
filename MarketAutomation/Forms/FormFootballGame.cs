using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketAutomation.Forms
{
    public partial class FormFootballGame : Form
    {
        public FormFootballGame()
        {
            InitializeComponent();
        }

        public static int ftblDiscount;
        private void button1_Click(object sender, EventArgs e)
        {
            List<Classes.FootballGame> Team = new List<Classes.FootballGame>();
            Team.Add(new Classes.Goalkeeper(1));
            Team.Add(new Classes.Defender(2));
            Team.Add(new Classes.Defender(3));
            Team.Add(new Classes.Defender(4));
            Team.Add(new Classes.Defender(5));
            Team.Add(new Classes.Midfielder(6));
            Team.Add(new Classes.Midfielder(7));
            Team.Add(new Classes.Midfielder(8));
            Team.Add(new Classes.Midfielder(9));
            Team.Add(new Classes.Forward(10));
            Team.Add(new Classes.Forward(11));
            Random RandomPlayer = new Random();
            int JerseyNumber;
            Boolean MayScore = true;
            JerseyNumber = RandomPlayer.Next(1, 12);
            int j =Convert.ToInt32(textBox1.Text);
            for (int i = 0; i <= j; i++)
            {
                JerseyNumber = RandomPlayer.Next(1, 12);
                if (!Team[JerseyNumber - 1].Pass())
                {
                    listBox1.Items.Add("Pass from player number " + JerseyNumber + " fails, Try again another time");
                    MayScore = false;
                    break;
                }
                else
                {
                    listBox1.Items.Add("The pass of player number " + JerseyNumber + " is successful");
                }
            }
            if (MayScore == true)
            {
                if (!Team[JerseyNumber - 1].Goll())
                {
                    label2.Text= ("GOLLLL  You won " + j + "TL discount");
                    ftblDiscount = j;
                }
                else
                {
                    listBox1.Items.Add("Missed  Try again another time ");
                }
            }

        }
    }
}
