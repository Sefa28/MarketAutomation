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
    public partial class FormDeleteStaff : Form
    {
        public FormDeleteStaff()
        {
            InitializeComponent();
        }
        Classes.Staff staff = new Classes.Staff();
        private void FormDeleteStaff_Load(object sender, EventArgs e)
        {
            DeleteStaffData.DataSource = null;
            DeleteStaffData.DataSource = Classes.Staff.StaffList;
            DeleteStaffData.Refresh();

            staff.NumberofRegistrations(DeleteStaffData.RowCount + 1);
            NumberofRecords.Text = Convert.ToString(staff.StaffNumberofRegistrations);
        }
        private Classes.Staff selectedStaff;
        private void BtnFindStaff_Click(object sender, EventArgs e)
        {
            string searchName = TextStaffName.Text;

            if (!string.IsNullOrEmpty(searchName))
            {
                // Müşteriyi adına göre bul
                selectedStaff = Classes.Staff.StaffList.Find(c => c.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));

                if (selectedStaff != null)
                {
                    // Müşteri bulundu, DataGridView'de ilgili satırı seç
                    int rowIndex = Classes.Staff.StaffList.IndexOf(selectedStaff);
                    DeleteStaffData.Rows[rowIndex].Selected = true;
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

        private void BtnGetLaidOff_Click(object sender, EventArgs e)
        {
            if (selectedStaff != null)
            {
                // Seçili müşteriyi sil
                Classes.Staff.StaffList.Remove(selectedStaff);

                // DataGridView'i güncelle
                DeleteStaffData.DataSource = null;
                DeleteStaffData.DataSource = Classes.Staff.StaffList;
                DeleteStaffData.Refresh();
            }
            else
            {
                // Silinecek müşteri yoksa uyarı mesajı göster
                MessageBox.Show("Lütfen önce bir müşteri bulun.");
            }
            staff.NumberofRegistrations(DeleteStaffData.RowCount + 1);
            NumberofRecords.Text = Convert.ToString(staff.StaffNumberofRegistrations);
        }

        private void BtnGetLaidOffSelect_Click(object sender, EventArgs e)
        {
            int selectedIndex = DeleteStaffData.SelectedRows[0].Index;
            Classes.Staff selectedStaff = Classes.Staff.StaffList[selectedIndex];
            Classes.Staff.StaffList.Remove(selectedStaff);

            DeleteStaffData.DataSource = null;
            DeleteStaffData.DataSource = Classes.Staff.StaffList;
            DeleteStaffData.Refresh();

            staff.NumberofRegistrations(DeleteStaffData.RowCount + 1);
            NumberofRecords.Text = Convert.ToString(staff.StaffNumberofRegistrations);
        }

        private void BtnFireEveryone_Click(object sender, EventArgs e)
        {
            DeleteStaffData.DataSource = null;
            DeleteStaffData.Refresh();
        }
    }
}
