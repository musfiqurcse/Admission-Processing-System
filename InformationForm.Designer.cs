namespace AdmissionProcessingSystem
{
    partial class StudentInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentInfoForm));
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.admissionSerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hscRollNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sscRollNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hscGPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sscGPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dislpayButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.meritOrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.studentDataGridView.Location = new System.Drawing.Point(30, 29);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.Size = new System.Drawing.Size(744, 303);
            this.studentDataGridView.TabIndex = 0;
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
            // dislpayButton
            // 
            this.dislpayButton.BackColor = System.Drawing.Color.PowderBlue;
            this.dislpayButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dislpayButton.ForeColor = System.Drawing.Color.DarkRed;
            this.dislpayButton.Location = new System.Drawing.Point(309, 346);
            this.dislpayButton.Name = "dislpayButton";
            this.dislpayButton.Size = new System.Drawing.Size(150, 52);
            this.dislpayButton.TabIndex = 1;
            this.dislpayButton.Text = "Show Student Information";
            this.dislpayButton.UseVisualStyleBackColor = false;
            this.dislpayButton.Click += new System.EventHandler(this.dislpayButton_Click);
            this.dislpayButton.MouseEnter += new System.EventHandler(this.admissionSerialNo_MouseEnter);
            this.dislpayButton.MouseLeave += new System.EventHandler(this.admissionSerialNo_MouseLeave);
            this.dislpayButton.MouseHover += new System.EventHandler(this.admissionSerialNo_MouseEnter);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.PowderBlue;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.DarkRed;
            this.backButton.Location = new System.Drawing.Point(621, 346);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(153, 52);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.MouseEnter += new System.EventHandler(this.backButton_MouseEnter);
            this.backButton.MouseLeave += new System.EventHandler(this.backButton_MouseLeave);
            this.backButton.MouseHover += new System.EventHandler(this.backButton_MouseEnter);
            // 
            // meritOrderButton
            // 
            this.meritOrderButton.BackColor = System.Drawing.Color.PowderBlue;
            this.meritOrderButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meritOrderButton.ForeColor = System.Drawing.Color.DarkRed;
            this.meritOrderButton.Location = new System.Drawing.Point(465, 346);
            this.meritOrderButton.Name = "meritOrderButton";
            this.meritOrderButton.Size = new System.Drawing.Size(150, 52);
            this.meritOrderButton.TabIndex = 2;
            this.meritOrderButton.Text = "Merit Order";
            this.meritOrderButton.UseVisualStyleBackColor = false;
            this.meritOrderButton.Click += new System.EventHandler(this.meritOrderButton_Click);
            this.meritOrderButton.MouseEnter += new System.EventHandler(this.meritOrderButton_MouseEnter);
            this.meritOrderButton.MouseLeave += new System.EventHandler(this.meritOrderButton_MouseLeave);
            this.meritOrderButton.MouseHover += new System.EventHandler(this.meritOrderButton_MouseEnter);
            // 
            // StudentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(812, 420);
            this.Controls.Add(this.meritOrderButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dislpayButton);
            this.Controls.Add(this.studentDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information";
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.Button dislpayButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button meritOrderButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissionSerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn hscRollNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sscRollNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn hscGPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn sscGPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPoint;
    }
}