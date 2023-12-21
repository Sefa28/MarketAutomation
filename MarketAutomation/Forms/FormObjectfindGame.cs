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
    public partial class FormObjectfindGame : Form
    {
        public FormObjectfindGame()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter == 100)
            {
                timer1.Stop();
            }
            progressBar1.Value = counter;
            label2.Text = (100 - counter).ToString();
            counter++;
        }
        public static int objdiscount;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            objdiscount = Convert.ToInt32(label2.Text);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            objdiscount = Convert.ToInt32(label2.Text);
        }
    }
}
