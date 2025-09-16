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
            TestDatabaseOperations();
            InitializeComponent();
        }

        private void TestDatabaseOperations()
        {
            try
            {
                // testing connection
                if (DatabaseConnection.TestConnection())
                {
                    MessageBox.Show("Database connection successful!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Test failed: {ex.Message}");
            }
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
                // testing database connection
                if (!DatabaseConnection.TestConnection())
                {
                    MessageBox.Show("Cannot connect to database. Please check your connection.",
                                  "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // FullName validation
                if (string.IsNullOrWhiteSpace(txtLastName.Text) ||
                    string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtMiddleInitial.Text))
                {
                    throw new ArgumentNullException("Name fields cannot be empty.");
                }
                StudentInfoClass.SetFullName = FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);

                // StudentNo validation
                if (!long.TryParse(txtStudentNo.Text, out long studNo))
                {
                    throw new FormatException("Student Number format is invalid.");
                }
                if (studNo > int.MaxValue || studNo < int.MinValue)
                {
                    throw new OverflowException("Student Number is out of range for int.");
                }

                // check if studentno. exists
                if (StudentInfoClass.IsStudentNumberExists((int)studNo))
                {
                    MessageBox.Show($"Student Number {studNo} already exists. Please use a different number.",
                                  "Duplicate Student Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                StudentInfoClass.SetStudentNo = (int)studNo;

                // Program validation
                if (string.IsNullOrWhiteSpace(cbPrograms.Text))
                {
                    throw new IndexOutOfRangeException("Program selection is required.");
                }
                StudentInfoClass.SetProgram = cbPrograms.Text;

                // Gender validation
                if (string.IsNullOrWhiteSpace(cbGender.Text))
                {
                    throw new IndexOutOfRangeException("Gender selection is required.");
                }
                StudentInfoClass.SetGender = cbGender.Text;

                // ContactNo validation
                if (!Regex.IsMatch(txtContactNo.Text, @"^[0-9]{10,11}$"))
                {
                    throw new FormatException("Contact Number format is invalid.");
                }
                StudentInfoClass.SetContactNo = CContactNo(txtContactNo.Text);

                // Age validation
                if (!int.TryParse(txtAge.Text, out int age))
                {
                    throw new FormatException("Age format is invalid.");
                }
                if (age < 0 || age > 120)
                {
                    throw new OverflowException("Age is out of valid range.");
                }
                StudentInfoClass.SetAge = Age(txtAge.Text);

                StudentInfoClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");

                // confirmatoin form
                MessageBox.Show("Please review your information and click Submit to save to database.", "Review Information",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);

                // show confirmation form
                frmConfirmation frm = new frmConfirmation();
                frm.ShowDialog();

                // clear form only if data is saved
                if (frm.DataWasSaved)
                {
                    ClearForm();
                }
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
            finally
            {
                Console.WriteLine("Registration validation finished.");
            }
        }

        private void ClearForm()
        {
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleInitial.Clear();
            txtStudentNo.Clear();
            txtContactNo.Clear();
            txtAge.Clear();
            cbPrograms.SelectedIndex = -1;
            cbGender.SelectedIndex = -1;
            datePickerBirthday.Value = DateTime.Now;
        }
    }
}