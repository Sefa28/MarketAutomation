using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketAutomation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Forms.FormSellProduct frm;
        Forms.FormGetProductRefund frm1;
        Forms.FormSaveCustomer frm2;
        Forms.FormDeleteCustomer frm3;
        Forms.FormWriteMessageAdmin frm4;
        Forms.FormFootballGame frm5;
        Forms.FormObjectfindGame frm6;
        Forms.FormAddStaff frm7;
        Forms.FormDeleteStaff frm8;
        Forms.FormAddProduct frm9;
        Forms.FormDeleteProduct frm10;
        Forms.FormListSoldProduct frm11;
        Forms.FormTotalEarn frm12;
        Forms.FormReadMessage frm13;
     
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {      

                frm = new Forms.FormSellProduct();
                frm.MdiParent = this;
                frm.Show();
        }

        private void GetProductRefund_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm1 == null)      
                frm1 = new Forms.FormGetProductRefund();
                frm1.MdiParent = this;
                frm1.Show();     
        }

        private void SaveCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2==null)
                frm2 = new Forms.FormSaveCustomer();
                frm2.MdiParent = this;
                frm2.Show();

        }

        private void DeleteCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                frm3 = new Forms.FormDeleteCustomer();
                frm3.MdiParent = this;
                frm3.Show();
        }

        private void WriteMessageAdmin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm4 == null)
                frm4 = new Forms.FormWriteMessageAdmin();
                frm4.MdiParent = this;
                frm4.Show();
        }

        private void FootballGame_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm5 == null)
                frm5 = new Forms.FormFootballGame();
                frm5.MdiParent = this;
                frm5.Show();
        }

        private void ObjectFindGame_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm6 == null)
                frm6 = new Forms.FormObjectfindGame();
                frm6.MdiParent = this;
                frm6.Show();
        }

        private void AddStaff_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm7 == null)
                frm7 = new Forms.FormAddStaff();
                frm7.MdiParent = this;
                frm7.Show();
        }

        private void DeleteStaff_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                frm8 = new Forms.FormDeleteStaff();
                frm8.MdiParent = this;
                frm8.Show();
        }

        private void AddProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm9 == null)
                frm9 = new Forms.FormAddProduct();
                frm9.MdiParent = this;
                frm9.Show();
        }


        private void DeleteProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
                frm10 = new Forms.FormDeleteProduct();
                frm10.MdiParent = this;
                frm10.Show();
        }

        private void ListSoldProducts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm11 == null)
                frm11 = new Forms.FormListSoldProduct();
                frm11.MdiParent = this;
                frm11.Show();
        }

        private void TotalEarn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm12 == null)
                frm12 = new Forms.FormTotalEarn();
                frm12.MdiParent = this;
                frm12.Show();
        }

        private void ReadMessage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm13 == null)
                frm13 = new Forms.FormReadMessage();
                frm13.MdiParent = this;
                frm13.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
