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

namespace AdmissionProcessingSystem
{
    public partial class DeleteStudentResult : Form
    {
        public DeleteStudentResult()
        {
            InitializeComponent();
        }

        private void backButton_MouseEnter(object sender, EventArgs e)
        {
            backButton.BackColor = Color.Tan;
        }

        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.BackColor = Color.AntiqueWhite;

        }

        private void deleteButton_MouseEnter(object sender, EventArgs e)
        {
            deleteButton.BackColor = Color.Tan;

        }

        private void deleteButton_MouseLeave(object sender, EventArgs e)
        {
            deleteButton.BackColor = Color.AntiqueWhite;

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Main mainForm= new Main();
            this.Hide();
            mainForm.Closed += (s, args) => this.Close();
            mainForm.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string connectionString =
                 @"server =.\SQLEXPRESS; database=AdmissionProcessingSystem;integrated security = SSPI";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string admissionSlNo = admissionSerialNoTextBox.Text;
            SqlCommand searchStudentByName =
                new SqlCommand(
                    "SELECT * FROM studentInfoTable WHERE admissionSerialNo " + " = '" + admissionSlNo + "'", connection);
            SqlDataReader tableReader = searchStudentByName.ExecuteReader();
            bool check = false;
            if (tableReader != null)
            {
                while (tableReader.Read())
                {
                    check = true;
                    if (check)
                    {
                        break;
                    }
                }
                tableReader.Close();
                
            }
            if (check)
            {
                using (
                    SqlCommand command =
                        new SqlCommand(
                            "DELETE FROM studentInfoTable WHERE admissionSerialNo " + " = '" + admissionSlNo + "'",
                            connection))
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Admission Serial No: " + admissionSlNo + "is Deleted ", "Deleted Successfully ",
                        MessageBoxButtons.OK);
                    admissionSerialNoTextBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Your have entered wrong Admission Serial No","Error!");
                admissionSerialNoTextBox.Clear();

            }
            connection.Close();
            
          

        }

    }
}
