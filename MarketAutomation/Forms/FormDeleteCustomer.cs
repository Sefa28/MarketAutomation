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
    public partial class FormDeleteCustomer : Form
    {
        public FormDeleteCustomer()
        {
            InitializeComponent();
        }
        Classes.Customer customer = new Classes.Customer();
        private void FormDeleteCustomer_Load(object sender, EventArgs e)
        {
            DeleteCustomerData.DataSource = null;
            DeleteCustomerData.DataSource = Classes.Customer.custList;
            DeleteCustomerData.Refresh();

            customer.NumberofRegistrations(DeleteCustomerData.RowCount);
            NumberofRecords.Text = Convert.ToString(customer.CustomerNumberofRegistrations);

        }


        private Classes.Customer selectedCustomer;
        private void BtnFindCustomer_Click(object sender, EventArgs e)
        {
            string searchName = TxtCustomerName.Text;

            if (!string.IsNullOrEmpty(searchName))
            {
                // Müşteriyi adına göre bul
                selectedCustomer = Classes.Customer.custList.Find(c => c.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));

                if (selectedCustomer != null)
                {
                    // Müşteri bulundu, DataGridView'de ilgili satırı seç
                    int rowIndex = Classes.Customer.custList.IndexOf(selectedCustomer);
                    DeleteCustomerData.Rows[rowIndex].Selected = true;
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

        private void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (selectedCustomer != null)
            {
                // Seçili müşteriyi sil
                Classes.Customer.custList.Remove(selectedCustomer);

                // DataGridView'i güncelle
                DeleteCustomerData.DataSource = null;
                DeleteCustomerData.DataSource = Classes.Customer.custList;
                DeleteCustomerData.Refresh();
            }
            else
            {
                // Silinecek müşteri yoksa uyarı mesajı göster
                MessageBox.Show("Lütfen önce bir müşteri bulun.");
            }  
         customer.NumberofRegistrations(DeleteCustomerData.RowCount);
         NumberofRecords.Text = Convert.ToString(customer.CustomerNumberofRegistrations);           
        }

        private void BtnDeleteAllCustomer_Click(object sender, EventArgs e)
        {
            DeleteCustomerData.DataSource = null;
            DeleteCustomerData.Refresh();
            customer.NumberofRegistrations(DeleteCustomerData.RowCount);
            NumberofRecords.Text = Convert.ToString(customer.CustomerNumberofRegistrations);
        }

        private void BtnDeleteCustomerSelected_Click(object sender, EventArgs e)
        {   
                int selectedIndex = DeleteCustomerData.SelectedRows[0].Index;       
                Classes.Customer selectedCustomer = Classes.Customer.custList[selectedIndex];
                Classes.Customer.custList.Remove(selectedCustomer);

                DeleteCustomerData.DataSource = null;
                DeleteCustomerData.DataSource = Classes.Customer.custList;
                DeleteCustomerData.Refresh();

                customer.NumberofRegistrations(DeleteCustomerData.RowCount);
                NumberofRecords.Text = Convert.ToString(customer.CustomerNumberofRegistrations);
            
        }
    }
}
