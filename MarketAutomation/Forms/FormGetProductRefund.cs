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
    public partial class FormGetProductRefund : Form
    {
        public FormGetProductRefund()
        {
            InitializeComponent();
        }

        private void BtnListsProducts_Click(object sender, EventArgs e)
        {
            GetProductData.DataSource = Forms.FormSellProduct.PrdtList;
        }

        private void BtnConfirmProductReturn_Click(object sender, EventArgs e)
        {
            GetProductData.DataSource = null;
            GetProductData.Refresh();
            MessageBox.Show("iadeniz başarılı");
        }
    }
}
