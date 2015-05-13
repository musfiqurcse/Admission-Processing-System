namespace AdmissionProcessingSystem
{
    partial class FindStudentInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindStudentInformation));
            this.label1 = new System.Windows.Forms.Label();
            this.searchStudentNameTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.admissionSerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hscRollNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sscRollNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hscGPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sscGPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name:";
            // 
            // searchStudentNameTextBox
            // 
            this.searchStudentNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStudentNameTextBox.Location = new System.Drawing.Point(223, 20);
            this.searchStudentNameTextBox.Name = "searchStudentNameTextBox";
            this.searchStudentNameTextBox.Size = new System.Drawing.Size(132, 21);
            this.searchStudentNameTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.DarkRed;
            this.searchButton.Location = new System.Drawing.Point(378, 16);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(93, 29);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            this.searchButton.MouseEnter += new System.EventHandler(this.searchButton_MouseEnter);
            this.searchButton.MouseLeave += new System.EventHandler(this.searchButton_MouseLeave);
            this.searchButton.MouseHover += new System.EventHandler(this.searchButton_MouseEnter);
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.admissionSerialNo,
            this.studentName,
            this.hscRollNo,
            this.sscRollNo,
            this.hscGPA,
            this.sscGPA,
            this.totalPoint});
            this.studentDataGridView.Location = new System.Drawing.Point(12, 59);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.Size = new System.Drawing.Size(745, 308);
            this.studentDataGridView.TabIndex = 3;
            // 
            // admissionSerialNo
            // 
            this.admissionSerialNo.HeaderText = "Admission Serial No.";
            this.admissionSerialNo.Name = "admissionSerialNo";
            // 
            // studentName
            // 
            this.studentName.HeaderText = "Student Name";
            this.studentName.Name = "studentName";
            // 
            // hscRollNo
            // 
            this.hscRollNo.HeaderText = "H.S.C. Roll No.";
            this.hscRollNo.Name = "hscRollNo";
            // 
            // sscRollNo
            // 
            this.sscRollNo.HeaderText = "S.S.C. Roll No.";
            this.sscRollNo.Name = "sscRollNo";
            // 
            // hscGPA
            // 
            this.hscGPA.HeaderText = "H.S.C. GPA";
            this.hscGPA.Name = "hscGPA";
            // 
            // sscGPA
            // 
            this.sscGPA.HeaderText = "S.S.C. GPA";
            this.sscGPA.Name = "sscGPA";
            // 
            // totalPoint
            // 
            this.totalPoint.HeaderText = "Total Point";
            this.totalPoint.Name = "totalPoint";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.DarkRed;
            this.backButton.Location = new System.Drawing.Point(486, 16);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 29);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.MouseEnter += new System.EventHandler(this.backButton_MouseEnter);
            this.backButton.MouseLeave += new System.EventHandler(this.backButton_MouseLeave);
            this.backButton.MouseHover += new System.EventHandler(this.backButton_MouseEnter);
            // 
            // FindStudentInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(783, 406);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.studentDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchStudentNameTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindStudentInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Student Information";
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchStudentNameTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissionSerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn hscRollNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sscRollNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn hscGPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn sscGPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPoint;
        private System.Windows.Forms.Button backButton;
    }
}