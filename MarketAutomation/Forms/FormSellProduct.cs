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
    public partial class FormSellProduct : Form
    {
        public FormSellProduct()
        {
            InitializeComponent();
        }

        public Classes.Products Prd = new Classes.Products();
        public static List<Classes.Products> PrdtList = new List<Classes.Products>();
        public static decimal toplam;


        int number1;
        int number2;
        int number3;
        int total;
        int change;
        private void UpdateDataSource()
        {
            SellProductData.DataSource = null;
            SellProductData.DataSource = PrdtList;
            SellProductData.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.Products Prd = new Classes.Products();
            Prd.tomato(); 
            PrdtList.Add(Prd);
            UpdateDataSource(); 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Classes.Products Prd = new Classes.Products();
            Prd.pepper(); 
            PrdtList.Add(Prd); 
            UpdateDataSource(); 
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Classes.Products Prd = new Classes.Products();
            Prd.eggplant();
            PrdtList.Add(Prd);
            UpdateDataSource();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            Classes.Products Prd = new Classes.Products();
            Prd.pasta();
            PrdtList.Add(Prd);
            UpdateDataSource();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            Classes.Products Prd = new Classes.Products();
            Prd.rice();
            PrdtList.Add(Prd);
            UpdateDataSource();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            Classes.Products Prd = new Classes.Products();
            Prd.sugar();
            PrdtList.Add(Prd);
            UpdateDataSource();
        }
        private void button24_Click(object sender, EventArgs e)
        {
            Classes.Products Prd = new Classes.Products();
            Prd.chips();
            PrdtList.Add(Prd);
            UpdateDataSource();
        }
        private void button26_Click(object sender, EventArgs e)
        {
            Classes.Products Prd = new Classes.Products();
            Prd.chocolate();
            PrdtList.Add(Prd);
            UpdateDataSource();
        }
        private void button25_Click(object sender, EventArgs e)
        {
            Classes.Products Prd = new Classes.Products();
            Prd.sunflowerseed();
            PrdtList.Add(Prd);
            UpdateDataSource();
        }
        private void button35_Click(object sender, EventArgs e)
        {
            Classes.Products Prd = new Classes.Products();
            Prd.water();
            PrdtList.Add(Prd);
            UpdateDataSource();
        }
        private void button34_Click(object sender, EventArgs e)
        {
            Classes.Products Prd = new Classes.Products();
            Prd.milk();
            PrdtList.Add(Prd);
            UpdateDataSource();
        }
        private void button36_Click(object sender, EventArgs e)
        {
            Classes.Products Prd = new Classes.Products();
            Prd.ayran();
            PrdtList.Add(Prd);
            UpdateDataSource();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = Classes.Products.matris[0, 1];
            button8.Text = Classes.Products.matris[1, 1];
            button9.Text = Classes.Products.matris[2, 1];
            Classes.Products Prd = new Classes.Products();
            Prd.btn7();
            PrdtList.Add(Prd);
            UpdateDataSource();      
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Classes.Products Prd = new Classes.Products();
            Prd.btn8();
            PrdtList.Add(Prd);
            UpdateDataSource();
        }
        private void button9_Click(object sender, EventArgs e)
        {   
            Classes.Products Prd = new Classes.Products();
            Prd.btn9();
            PrdtList.Add(Prd);
            UpdateDataSource();
        }





        private void BtnConfirmList_Click(object sender, EventArgs e)
        {
            DataGridViewRowCollection rows = SellProductData.Rows;
            toplam = rows.Cast<DataGridViewRow>()
                            .Sum(row => Convert.ToDecimal(row.Cells["Price"].Value));
            txtTotalAmount.Text = Convert.ToString(toplam);
            
        }
        private void ellipseBtn1_Click(object sender, EventArgs e)
        {
            if (RadioBtnFootball.Checked == true)
            {
                txtDiscount.Text = Convert.ToString(Forms.FormFootballGame.ftblDiscount);
            }
            else if (RadioBtnObject.Checked == true)
            {
                txtDiscount.Text = Convert.ToString(Forms.FormObjectfindGame.objdiscount);
        }
        number2 = Convert.ToInt32(txtDiscount.Text);
        }

        private void BtnCalcuate_Click(object sender, EventArgs e)
        {
            Classes.Money mny = new Classes.Money();
            Interfaces.IMoney money = (Interfaces.IMoney)mny;

            number1 = Convert.ToInt32(txtTotalAmount.Text);
                if(radioBtnTl.Checked)
                    number3= money.ConvertToTl(Convert.ToInt32(txtboxAmountReceived.Text));
                else if (radioBtnDollar.Checked)
                    number3 = money.ConvertToDollar(Convert.ToInt32(txtboxAmountReceived.Text));
                else if (radioBtnEuro.Checked)
                    number3 = money.ConvertToEuro(Convert.ToInt32(txtboxAmountReceived.Text));
                else if (radioBtnPound.Checked)
                     number3 = money.ConvertToPound(Convert.ToInt32(txtboxAmountReceived.Text));

            total = number1 - number2;
            change = number3 - total;
            txtChange.Text = Convert.ToString(change);
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The printer is broken, unfortunately we cannot print");
        }


    }
}
