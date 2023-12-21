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
    public partial class FormSaveCustomer : Form
    {
        public FormSaveCustomer()
        {
            InitializeComponent();
        }
        
        private void BtnSaveCustomer_Click(object sender, EventArgs e)
        {
            Classes.Customer customer = new Classes.Customer();
            
            customer.Name = TextCustomerName.Text;
            customer.Telephone = TextCustomerPhoneNumber.Text;
            customer.Date = TextCustomerBirthdate.Value;
            customer.NumberofRegistrations(CustomerData.RowCount+1);
            LabelNumberofRecords.Text = Convert.ToString(customer.CustomerNumberofRegistrations);

            if (radioButtonMale.Checked)
                customer.gender = "Male";
            else if (radioButtonFemale.Checked)
                customer.gender = "Female";
            else
                customer.gender = "Not specified";

            Classes.Customer.custList.Add(customer);
            CustomerData.DataSource = null;
            CustomerData.DataSource = Classes.Customer.custList;
            CustomerData.Refresh(); 
        }
    }
}
