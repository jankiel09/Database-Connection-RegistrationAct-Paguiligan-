namespace AccountRegistration
{
    public partial class FrmRegistration : Form
    {
        private ComboBox cbProgram;
        public FrmRegistration()
        {
            InitializeComponent();
            this.Text = "Account Registration";

            cbProgram = new ComboBox();
            cbProgram.Location = new System.Drawing.Point(189, 28);
            cbProgram.Size = new System.Drawing.Size(218, 23);
            this.Controls.Add(cbProgram);
            AddItemsMethod1_Individual();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        private void nextBtn_Click(object sender, EventArgs e)
        {
            try
            {
                StudentInfoClass.StudentNo = long.Parse(txtboxStudno.Text);
                StudentInfoClass.LastName = txtboxLname.Text;
                StudentInfoClass.FirstName = txtboxFname.Text;
                StudentInfoClass.MiddleName = txtboxMname.Text;
                StudentInfoClass.Age = long.Parse(txtboxAge.Text);
                StudentInfoClass.ContactNo = long.Parse(txtboxContNo.Text);
                StudentInfoClass.Address = txtboxAddr.Text;
                StudentInfoClass.Program = cbProgram.Text.ToString();

                FrmConfirm confirmForm = new FrmConfirm();


                if (confirmForm.ShowDialog() == DialogResult.OK)
                {
                    txtboxStudno.Clear();
                    txtboxLname.Clear();
                    txtboxFname.Clear();
                    txtboxMname.Clear();
                    txtboxAge.Clear();
                    txtboxContNo.Clear();
                    txtboxAddr.Clear();
                    cbProgram.SelectedIndex = -1;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for Student No, Age, and Contact No.",
                              "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddItemsMethod1_Individual()
        {
            cbProgram.Items.Add("BS Information Technology");
            cbProgram.Items.Add("BS Computer Science");
            cbProgram.Items.Add("BS Information Systems");
            cbProgram.Items.Add("BS Computer Engineering");
            cbProgram.Items.Add("BS Software Engineering");
        }
    }
}
