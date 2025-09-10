using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class OrganizationProfile : Form
    {
        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;
        public OrganizationProfile()
        {
            InitializeComponent();
        }

        private void OrganizationProfile_Load(object sender, EventArgs e)
        {
            string[] ListofProgram = new string[]
            {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information System",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };

            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListofProgram[i]);
            }


            string[] Gender = new string[]
            {
                "Male",
                "Female"
            };

            for (int i = 0; i < 2; i++)
            {
                cbGender.Items.Add(Gender[i]);
            }



        }
        public long StudentNumber(string studNum)
        {

            _StudentNo = long.Parse(studNum);

            return _StudentNo;
        }

        public long CContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }

            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }

            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }

            return _Age;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try 
            {
                StudentInfoClass.SetFullName = FullName(txtLastName.Text,
                        txtFirstName.Text, txtMiddleInitial.Text);
                StudentInfoClass.SetStudentNo = (int)StudentNumber(txtStudentNo.Text);
                StudentInfoClass.SetProgram = cbPrograms.Text;
                StudentInfoClass.SetGender = cbGender.Text;
                StudentInfoClass.SetContactNo = CContactNo(txtContactNo.Text);
                StudentInfoClass.SetAge = Age(txtAge.Text);
                StudentInfoClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");
                frmConfirmation frm = new frmConfirmation();
                frm.ShowDialog();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format Error: " + ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Null Error: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Overflow Error: " + ex.Message);
            }

            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Index Error: " + ex.Message);
            }
        }
    }
}
