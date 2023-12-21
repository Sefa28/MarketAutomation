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
    public partial class FormReadMessage : Form
    {
        public FormReadMessage()
        {
            InitializeComponent();
        }

        private void BtnReadMessage_Click(object sender, EventArgs e)
        {
            label4.Text = Forms.FormWriteMessageAdmin.Message;
            label3.Text =Convert.ToString(Forms.FormWriteMessageAdmin.id);
        }
    }
}
