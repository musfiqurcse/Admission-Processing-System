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
    public partial class StudentInfoForm : Form
    {
       
        public StudentInfoForm()
        {
            InitializeComponent();
        }

        private void backButton_MouseEnter(object sender, EventArgs e)
        {
            backButton.BackColor = Color.Tan;
        }

        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.BackColor = Color.PowderBlue;
        }
        private void admissionSerialNo_MouseEnter(object sender, EventArgs e)
        {
            dislpayButton.BackColor = Color.Tan;
        }
        private void admissionSerialNo_MouseLeave(object sender, EventArgs e)
        {
            dislpayButton.BackColor = Color.PowderBlue;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Main formMain=new Main();
            this.Hide();
            formMain.Closed += (s, args) => this.Close();
            formMain.Show();
        }

        private void dislpayButton_Click(object sender, EventArgs e)
        {
          studentDataGridView.Rows.Clear();
            string connectionString =
                @"server =.\SQLEXPRESS; database=AdmissionProcessingSystem;integrated security = SSPI";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string studentInfoTableRead = "SELECT * FROM studentInfoTable";
            SqlCommand selectAllTable=new SqlCommand(studentInfoTableRead,connection);
            SqlDataReader tableReader = selectAllTable.ExecuteReader();
            if (tableReader != null)
            {
                while (tableReader.Read())
                {
                    studentDataGridView.Rows.Add(tableReader[0].ToString(), tableReader[1].ToString(),
                        tableReader[2].ToString(), tableReader[3].ToString(), tableReader[4].ToString(),
                        tableReader[5].ToString(),tableReader[6].ToString());
                }
                tableReader.Close();
                connection.Close();
            }

        }

        private void meritOrderButton_MouseEnter(object sender, EventArgs e)
        {
            meritOrderButton.BackColor = Color.Tan;
        }

        private void meritOrderButton_MouseLeave(object sender, EventArgs e)
        {
            meritOrderButton.BackColor = Color.PowderBlue;
        }

        private void meritOrderButton_Click(object sender, EventArgs e)
        {
            //studentDataGridView.Sort(studentDataGridView.Columns[6], ListSortDirection.Descending);
            
            try
            {
                studentDataGridView.SortCompare += studentResultCompare;
                totalPoint.ValueType = typeof (double);
                studentDataGridView.Sort(totalPoint, ListSortDirection.Descending);
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }

        }
        private void studentResultCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            double a = double.Parse(e.CellValue1.ToString()), b = double.Parse(e.CellValue2.ToString());

          

            e.SortResult = a.CompareTo(b);

            e.Handled = true;
        }
    }
}
