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
    public partial class FormListSoldProduct : Form
    {
        public FormListSoldProduct()
        {
            InitializeComponent();
        }

        private void btnSoldProduct_Click(object sender, EventArgs e)
        {
            SoldProductData.DataSource = Forms.FormSellProduct.PrdtList;
        }
    }
}
