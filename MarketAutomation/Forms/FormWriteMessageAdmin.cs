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
    public partial class FormWriteMessageAdmin : Form
    {
        public FormWriteMessageAdmin()
        {
            InitializeComponent();
        }
        public static string Message;
        public static int id;

        private void BtnConfirmProductReturn_Click(object sender, EventArgs e)
        {
            Message = Convert.ToString(TextStaffMessage.Text);
            id = Convert.ToInt32(TextIdentity.Text);
            MessageBox.Show("Sended");
        }
    }
}
