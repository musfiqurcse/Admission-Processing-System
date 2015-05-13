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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

       

        private void Form1_Load(object sender, EventArgs e)
        {
      
          
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "admin" && passwordTextBox.Text == "admin")
            {
                Main info = new Main();
                this.Hide();
                info.Closed += (s, args) => this.Close(); 
                info.Show();
            }
            else
            {
                
                
              DialogResult resultFirst=  MessageBox.Show("You have entered wrong user name and password. Try Again","Error",MessageBoxButtons.RetryCancel);
                if (resultFirst == DialogResult.Cancel)
                {
                    this.Close();
                }
                else
                {
                    userNameTextBox.Text = "";
                    passwordTextBox.Text = "";


                }
            }

        }
        //01677399317

        private void enterButton_MouseEnter(object sender, EventArgs e)
        {
            enterButton.BackColor = Color.Tan;
        }

        private void enterButton_MouseLeave(object sender, EventArgs e)
        {
            enterButton.BackColor = Color.AntiqueWhite;
        }

       

    




       
    }
}
