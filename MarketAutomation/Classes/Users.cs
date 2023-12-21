using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAutomation.Classes
{
    public abstract class Users
    {
        public abstract void NumberofRegistrations(int number);
        
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string gender { get; set; }
        public DateTime Date { get; set; }

    }
    public class Customer : Users
    {
        public int CustomerNumberofRegistrations;
        public override void NumberofRegistrations(int number)
        {
            CustomerNumberofRegistrations = number;
        }
        public static List<Customer> custList = new List<Customer>();
    }

    public class Staff : Users
    {
        public int StaffNumberofRegistrations;
        public int identity { get; set; }
        public string Graduation { get; set; }
        public string[] GraduationInfo = { "primary school", "secondary school", "high school", "university" };
        public override void NumberofRegistrations(int number)
        {
            StaffNumberofRegistrations = number;
        }
        public static List<Staff> StaffList = new List<Staff>();
    }

}
