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
    public partial class FindStudentInformation : Form
    {
        public FindStudentInformation()
        {
            InitializeComponent();
        }

        private void searchButton_MouseEnter(object sender, EventArgs e)
        {
            searchButton.BackColor = Color.Tan;

        }

        private void searchButton_MouseLeave(object sender, EventArgs e)
        {
            searchButton.BackColor = Color.AntiqueWhite;
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
            Main mainMenu=new Main();
            this.Hide();
            mainMenu.Closed += (s, args) => this.Close();
            mainMenu.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            studentDataGridView.Rows.Clear();
                string connectionString =
                    @"server=.\sqlexpress;database=AdmissionProcessingSystem;integrated security=SSPI";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
            string studentName = searchStudentNameTextBox.Text;
            try
            {
                SqlCommand searchStudentByName = new SqlCommand("SELECT * FROM studentInfoTable WHERE studentName " + " = '" + studentName + "'", connection);
                SqlDataReader tableReader = searchStudentByName.ExecuteReader();
                if (tableReader != null)
                {
                    bool check = true;
                    while (tableReader.Read())
                    {
                        studentDataGridView.Rows.Add(tableReader[0].ToString(), tableReader[1].ToString(),
                            tableReader[2].ToString(), tableReader[3].ToString(), tableReader[4].ToString(),
                            tableReader[5].ToString(), tableReader[6].ToString());
                        check = false;
                    }
                    if (check)
                    {
                     
             
                    MessageBox.Show("Your Student Name is not present in the database. ", "Not Found",
                        MessageBoxButtons.OKCancel);
                        searchStudentNameTextBox.Clear();
       
                    }
                    tableReader.Close();
                    connection.Close();
                }
                
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
            

            connection.Close();
            
           
            
        }
    }
}
