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
    public partial class FormAddProduct : Form
    {
        public FormAddProduct()
        {
            InitializeComponent();
        }
        
        
        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            Classes.Products Product = new Classes.Products();
            CmbBoxCategory.Items.AddRange(Product.categoryinfo);
        }

        private void BtnNewAddProduct_Click(object sender, EventArgs e)
        {
            Classes.Products Product = new Classes.Products();
            Product.ProductId = Convert.ToInt32(TextProductId.Text);
            Product.ProductName = TextProductName.Text;
            Product.NumberOfPieces = Convert.ToInt32(textNumberOfPieces.Text);
            Product.Price = Convert.ToInt32(textPrice.Text);  
            Product.category = CmbBoxCategory.Text;

            Product.NumberofRegistrations(ProductData.RowCount + 1);
            LabelNumberofRecords.Text = Convert.ToString(Product.productNumberofRegistrations);

            Classes.Products.ProductList.Add(Product);
            ProductData.DataSource = null;
            ProductData.DataSource = Classes.Products.ProductList;
            ProductData.Refresh();

            for (int i = 0; i < Classes.Products.ProductList.Count; i++)
            {
                Classes.Products.matris[i, 0] = Classes.Products.ProductList[i].ProductId;
                Classes.Products.matris[i, 1] = Classes.Products.ProductList[i].ProductName;
                Classes.Products.matris[i, 2] = Classes.Products.ProductList[i].NumberOfPieces;
                Classes.Products.matris[i, 3] = Classes.Products.ProductList[i].Price;
                Classes.Products.matris[i, 4] = Classes.Products.ProductList[i].category;

            }

        }
    }
}
