using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmissionProcessingSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void aboutButton_MouseEnter(object sender, EventArgs e)
        {
           
            aboutButton.BackColor = Color.Tan;
           

        }
        private void openStudentInfoButton_MouseEnter(object sender, EventArgs e)
        {
       ;
            openStudentInfoButton.BackColor = Color.Tan;
            

        }
        private void deleteStudentInfoButton_MouseEnter(object sender, EventArgs e)
        {
          
            deleteStudentInfoButton.BackColor = Color.Tan;
        

        }
        private void addStudentInfoButton_MouseEnter(object sender, EventArgs e)
        {
            
            addStudentInfoButton.BackColor = Color.Tan;

        }






        private void logoutButton_MouseEnter(object sender, EventArgs e)
        {
            logoutButton.BackColor = Color.Tan;
        }

        private void logoutButton_MouseLeave(object sender, EventArgs e)
        {
            logoutButton.BackColor = Color.AntiqueWhite;
        }

        private void openStudentInfoButton_MouseLeave(object sender, EventArgs e)
        {
            openStudentInfoButton.BackColor = Color.AntiqueWhite;
        }

        private void addStudentInfoButton_MouseLeave(object sender, EventArgs e)
        {
            addStudentInfoButton.BackColor = Color.AntiqueWhite;
        }

        private void deleteStudentInfoButton_MouseLeave(object sender, EventArgs e)
        {
            deleteStudentInfoButton.BackColor = Color.AntiqueWhite;

        }

        private void aboutButton_MouseLeave(object sender, EventArgs e)
        {
            aboutButton.BackColor = Color.AntiqueWhite;
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Name: Md. Musfiqur Rahman Shibly\nInstitution: Dhaka City College\nBatch: 13th\nYear: 2015\nEmail:md.musfiqurcse@gmail.com",
                "Developer Details", MessageBoxButtons.OK);
        }

        private void findStudentInfoButton_MessageEnter(object sender, EventArgs e)
        {
            findStudentInfoButton.BackColor = Color.Tan;
        }

        private void findStudentInfoButton_MessageLeave(object sender, EventArgs e)
        {
            findStudentInfoButton.BackColor = Color.AntiqueWhite;
        }

        private void openStudentInfoButton_Click(object sender, EventArgs e)
        {
            StudentInfoForm studentInfoForm=new StudentInfoForm();
            this.Hide();
            studentInfoForm.Closed += (s, args) => this.Close();
            studentInfoForm.Show();
        }

        private void addStudentInfoButton_Click(object sender, EventArgs e)
        {
            AddStudentInfo addStdInfo=new AddStudentInfo();
            this.Hide();
            addStdInfo.Closed += (s, args) => this.Close();
            addStdInfo.Show();
        }

        private void deleteStudentInfoButton_Click(object sender, EventArgs e)
        {
            DeleteStudentResult deleteStudentResult=new DeleteStudentResult();
            this.Hide();
            deleteStudentResult.Closed += (s, args) => this.Close();
            deleteStudentResult.Show();
        }

        private void findStudentInfoButton_Click(object sender, EventArgs e)
        {
            FindStudentInformation searchStudentInfo= new FindStudentInformation();
            this.Hide();
            searchStudentInfo.Closed += (s, args) => this.Close();
            searchStudentInfo.Show();
        }
       
        
    }
}
