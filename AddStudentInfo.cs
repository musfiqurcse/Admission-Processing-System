using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CSharp;

namespace AdmissionProcessingSystem
{
    public partial class AddStudentInfo : Form
    {
        public AddStudentInfo()
        {
            InitializeComponent();
        }

        private void saveButton_MouseEnter(object sender, EventArgs e)
        {
            saveButton.BackColor = Color.Tan;

        }

        private void saveButton_MouseLeave(object sender, EventArgs e)
        {
            saveButton.BackColor = Color.AntiqueWhite;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string connectionString =
                @"server =.\SQLEXPRESS; database=AdmissionProcessingSystem;integrated security = SSPI";
            SqlConnection connection =new SqlConnection(connectionString);
           connection.Open();
            string admissionSerialNo, studentName, hscRollNo, sscRollNo, hscGpa, sscGpa,totalPoint;
            admissionSerialNo = admissionSerialNoTextBox.Text;
            studentName = studentNameTextBox.Text;
            hscRollNo = hscRollNoTextBox.Text;
            sscRollNo = sscRollNoTextBox.Text;
            hscGpa =hscGpaTextBox.Text;
            sscGpa = sscGpaTextBox.Text;
            double hscGpaPoint, sscGpaPoint;
            hscGpaPoint = Convert.ToDouble(hscGpa);
            sscGpaPoint = Convert.ToDouble(sscGpa);
            totalPoint = Convert.ToString(hscGpaPoint + sscGpaPoint);

            if (studentNameTextBox.Text == "" || hscRollNoTextBox.Text == "" || admissionSerialNoTextBox.Text == "" ||
                sscRollNoTextBox.Text == "" || hscGpaTextBox.Text == "" || sscGpaTextBox.Text == "")
            {
                MessageBox.Show("Please Fill Up All The Information", "Error", MessageBoxButtons.RetryCancel);
            }
            else
            {
                string insertQuery =
                    "insert into studentInfoTable(admissionSerialNo,studentName,hscRollNo,sscRollNo,hscGPA,sscGPA,pointOrder)values('" +
                    admissionSerialNo + "','" + studentName + "','" + hscRollNo + "','" + sscRollNo + "','" + hscGpa +
                    "','" +
                    sscGpa + "','" +
                    totalPoint + "')";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                int effectedRow = command.ExecuteNonQuery();
                DialogResult newResult = MessageBox.Show(" Submission Recieved Successfully . ",
                    "Submission Result",
                    MessageBoxButtons.OKCancel);

                studentNameTextBox.Text = "";
                admissionSerialNoTextBox.Text = "";
                hscRollNoTextBox.Text = "";
                sscRollNoTextBox.Text = "";
                hscGpaTextBox.Text = "";
                sscGpaTextBox.Text = "";
            }


            connection.Close();
            
        }

        private void backButton_MouseEnter(object sender, EventArgs e)
        {
            backButton.BackColor = Color.Tan;
        }

        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.BackColor = Color.AntiqueWhite;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Main mainInfo=new Main();
            this.Hide();
            mainInfo.Closed += (s, args) => this.Close();
            mainInfo.Show();
        }

       
    }
}
