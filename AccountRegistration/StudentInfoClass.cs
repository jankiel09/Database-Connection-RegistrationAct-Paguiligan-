using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountRegistration
{
    public class StudentInfoClass
    {
        public delegate long DelegateNumber(long number);
        public delegate string DelegateText(string txt);

        public static int SetStudentNo = 0;
        public static long SetContactNo = 0;
        public static int SetAge;

        public static string SetProgram = " ";
        public static string SetGender = " ";
        public static string SetBirthday = " ";
        public static string SetFullName = " ";


        public static string FirstName = " ";
        public static string LastName = " ";
        public static string MiddleName = " ";
        public static string Address = " ";
        public static string Program = " ";

        public static long Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;

        public static bool SaveToDatabase()
        {
            string query = @"
                INSERT INTO Students (StudentNo, FirstName, LastName, MiddleInitial, 
                                    Program, Gender, Age, ContactNo, Birthday) 
                VALUES (@StudentNo, @FirstName, @LastName, @MiddleInitial, 
                        @Program, @Gender, @Age, @ContactNo, @Birthday)";

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        string[] nameParts = SetFullName.Split(',');
                        string lastName = nameParts.Length > 0 ? nameParts[0].Trim() : "";
                        string firstName = nameParts.Length > 1 ? nameParts[1].Trim() : "";
                        string middleInitial = nameParts.Length > 2 ? nameParts[2].Trim() : "";

                        // adding parameters
                        cmd.Parameters.AddWithValue("@StudentNo", SetStudentNo);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@MiddleInitial", middleInitial);
                        cmd.Parameters.AddWithValue("@Program", SetProgram);
                        cmd.Parameters.AddWithValue("@Gender", SetGender);
                        cmd.Parameters.AddWithValue("@Age", SetAge);
                        cmd.Parameters.AddWithValue("@ContactNo", SetContactNo);
                        cmd.Parameters.AddWithValue("@Birthday", DateTime.Parse(SetBirthday));

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (SqlException ex) when (ex.Number == 2627) // Unique constraint violation
            {
                MessageBox.Show($"Student Number {SetStudentNo} already exists in the database!",
                              "Duplicate Student Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool IsStudentNumberExists(int studentNo)
        {
            string query = "SELECT COUNT(*) FROM Students WHERE StudentNo = @StudentNo";

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentNo", studentNo);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static DataTable GetAllStudents()
        {
            string query = @"
                SELECT StudentID, StudentNo, Program, Gender, Age, 
                       ContactNo, Birthday, DateRegistered 
                FROM Students 
                ORDER BY DateRegistered DESC";

            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }
        public static string GetFirstName(string FirstName)
        {
            return FirstName;
        }
        public static string GetLastName(string LastName)
        {
            return LastName;
        }

        public static string GetMiddleName(string MiddleName)
        {
            return MiddleName;
        }

        public static string GetAddress(string Address)
        {
            return Address;
        }

        public static string GetProgram(string Program)
        {
            return Program;
        }

        public static long GetAge(long Age)
        {
            return Age;
        }

        public static long GetContactNo(long ContactNo)
        {
            return ContactNo;
        }

        public static long GetStudentNo(long StudentNo)
        {
            return StudentNo;
        }
    }
}
