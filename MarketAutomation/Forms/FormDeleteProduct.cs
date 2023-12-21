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
    public partial class FormDeleteProduct : Form
    {
        public FormDeleteProduct()
        {
            InitializeComponent();
        }
        Classes.Products Products = new Classes.Products();
        private void FormDeleteProduct_Load(object sender, EventArgs e)
        {
            DeleteProductData.DataSource = null;
            DeleteProductData.DataSource = Classes.Products.ProductList;
            DeleteProductData.Refresh();
            Products.NumberofRegistrations(DeleteProductData.RowCount);
            NumberofRecords.Text = Convert.ToString(Products.productNumberofRegistrations);
        }
        private Classes.Products selectedProduct;

        private void BtnFindProduct_Click(object sender, EventArgs e)
        {
            string searchName = TextProductName.Text;

            if (!string.IsNullOrEmpty(searchName))
            {
                // Müşteriyi adına göre bul
                selectedProduct = Classes.Products.ProductList.Find(c => c.ProductName.Equals(searchName, StringComparison.OrdinalIgnoreCase));

                if (selectedProduct != null)
                {
                    // Müşteri bulundu, DataGridView'de ilgili satırı seç
                    int rowIndex = Classes.Products.ProductList.IndexOf(selectedProduct);
                    DeleteProductData.Rows[rowIndex].Selected = true;
                }
                else
                {
                    // Müşteri bulunamadı
                    MessageBox.Show("Müşteri bulunamadı.");
                }
            }
            else
            {
                // Boş bir arama yapıldı
                MessageBox.Show("Lütfen bir müşteri adı girin.");
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                // Seçili müşteriyi sil
                Classes.Products.ProductList.Remove(selectedProduct);

                // DataGridView'i güncelle
                DeleteProductData.DataSource = null;
                DeleteProductData.DataSource = Classes.Products.ProductList;
                DeleteProductData.Refresh();
            }
            else
            {
                // Silinecek müşteri yoksa uyarı mesajı göster
                MessageBox.Show("Lütfen önce bir müşteri bulun.");
            }
            Products.NumberofRegistrations(DeleteProductData.RowCount);
            NumberofRecords.Text = Convert.ToString(Products.productNumberofRegistrations);
        }

        private void BtnDeleteProductSelect_Click(object sender, EventArgs e)
        {
            int selectedIndex = DeleteProductData.SelectedRows[0].Index;
            Classes.Products selectedProduct = Classes.Products.ProductList[selectedIndex];
            Classes.Products.ProductList.Remove(selectedProduct);

            DeleteProductData.DataSource = null;
            DeleteProductData.DataSource = Classes.Products.ProductList;
            DeleteProductData.Refresh();

            Products.NumberofRegistrations(DeleteProductData.RowCount);
            NumberofRecords.Text = Convert.ToString(Products.productNumberofRegistrations);
        }

        private void BtnDeleteAllProduct_Click(object sender, EventArgs e)
        {
            DeleteProductData.DataSource = null;
            DeleteProductData.Refresh();

            Products.NumberofRegistrations(DeleteProductData.RowCount);
            NumberofRecords.Text = Convert.ToString(Products.productNumberofRegistrations);
        }
    }
}
