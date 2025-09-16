using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class frmConfirmation : Form
    {
        // track if data was saved successfully
        public bool DataWasSaved { get; private set; } = false;

        public frmConfirmation()
        {
            InitializeComponent();
        }

        private void frmConfirmation_Load(object sender, EventArgs e)
        {
            // display all the information for review
            lblStudentNo.Text = StudentInfoClass.SetStudentNo.ToString();
            lblName.Text = StudentInfoClass.SetFullName;
            lblProgram.Text = StudentInfoClass.SetProgram;
            lblBirthday.Text = StudentInfoClass.SetBirthday;
            lblGender.Text = StudentInfoClass.SetGender;
            lblContactNo.Text = StudentInfoClass.SetContactNo.ToString();
            lblAge.Text = StudentInfoClass.SetAge.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // show confirmation dialog before saving
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to save this student information to the database?\n\n" +
                    $"Student No: {StudentInfoClass.SetStudentNo}\n" +
                    $"Name: {StudentInfoClass.SetFullName}\n" +
                    $"Program: {StudentInfoClass.SetProgram}",
                    "Confirm Save to Database",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // test database connection before saving
                    if (!DatabaseConnection.TestConnection())
                    {
                        MessageBox.Show("Cannot connect to database. Please check your connection.",
                                      "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // check one more time if student number exists
                    if (StudentInfoClass.IsStudentNumberExists(StudentInfoClass.SetStudentNo))
                    {
                        MessageBox.Show($"Student Number {StudentInfoClass.SetStudentNo} was added by another user. Please go back and use a different number.",
                                      "Duplicate Student Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // save to database
                    if (StudentInfoClass.SaveToDatabase())
                    {
                        DataWasSaved = true; // pop up that data was saved successfully

                        MessageBox.Show("Student registration saved successfully to database!", "Success",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // show success message with student details
                        string successMessage = $"Student registered successfully!\n\n" +
                                              $"Student ID: {StudentInfoClass.SetStudentNo}\n" +
                                              $"Name: {StudentInfoClass.SetFullName}\n" +
                                              $"Program: {StudentInfoClass.SetProgram}\n" +
                                              $"Saved to database: {DateTime.Now:yyyy-MM-dd HH:mm:ss}";

                        MessageBox.Show(successMessage, "Registration Complete",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // show current database statistics
                        try
                        {
                            DataTable students = StudentInfoClass.GetAllStudents();
                            MessageBox.Show($"Total students now in database: {students.Rows.Count}",
                                          "Database Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Could not retrieve student count: {ex.Message}");
                        }

                        // close the confirmation form
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save student registration to database. Please try again.",
                                      "Database Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // user clicked No - just inform them
                    MessageBox.Show("Student information was not saved to database.",
                                  "Save Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred while saving to database: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Submit button error: {ex.Message}");
            }
        }

        //cancel button
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel? The student information will not be saved to the database.",
                "Cancel Registration",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DataWasSaved = false;
                this.Close();
            }
        }
    }
}