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
    public partial class FormAddStaff : Form
    {
        public FormAddStaff()
        {
            InitializeComponent();
        }

        

        private void FormAddStaff_Load(object sender, EventArgs e)
        {
            Classes.Staff staff = new Classes.Staff();
            CmbBoxGraduationInfo.Items.AddRange(staff.GraduationInfo);
        }

        private void BtnAddStaff_Click(object sender, EventArgs e)
        {
            Classes.Staff staff = new Classes.Staff();

            staff.identity = Convert.ToInt32(TextIdentity.Text);
            staff.Name = TextStaffName.Text;
            staff.Telephone = TextStaffPhoneNumber.Text;
            staff.Date = TextBirthDate.Value;

            if (radioButtonMale.Checked)
                staff.gender = "Male";
            else if (radioButtonFemale.Checked)
                staff.gender = "Female";
            else
                staff.gender = "Not specified";

            staff.Graduation = CmbBoxGraduationInfo.Text;
            

            staff.NumberofRegistrations(StaffData.RowCount + 1);
            LabelNumberofRecords.Text = Convert.ToString(staff.StaffNumberofRegistrations);

            Classes.Staff.StaffList.Add(staff);
            StaffData.DataSource = null;
            StaffData.DataSource = Classes.Staff.StaffList;
            StaffData.Refresh();
           
        }

    }
}
