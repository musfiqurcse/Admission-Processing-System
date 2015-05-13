namespace AdmissionProcessingSystem
{
    partial class DeleteStudentResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteStudentResult));
            this.label1 = new System.Windows.Forms.Label();
            this.admissionSerialNoTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admission Serial No:";
            // 
            // admissionSerialNoTextBox
            // 
            this.admissionSerialNoTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admissionSerialNoTextBox.Location = new System.Drawing.Point(213, 60);
            this.admissionSerialNoTextBox.Name = "admissionSerialNoTextBox";
            this.admissionSerialNoTextBox.Size = new System.Drawing.Size(159, 25);
            this.admissionSerialNoTextBox.TabIndex = 1;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.DarkRed;
            this.deleteButton.Location = new System.Drawing.Point(153, 133);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(101, 42);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            this.deleteButton.MouseEnter += new System.EventHandler(this.deleteButton_MouseEnter);
            this.deleteButton.MouseLeave += new System.EventHandler(this.deleteButton_MouseLeave);
            this.deleteButton.MouseHover += new System.EventHandler(this.deleteButton_MouseEnter);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.DarkRed;
            this.backButton.Location = new System.Drawing.Point(271, 133);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(101, 42);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.MouseEnter += new System.EventHandler(this.backButton_MouseEnter);
            this.backButton.MouseLeave += new System.EventHandler(this.backButton_MouseLeave);
            this.backButton.MouseHover += new System.EventHandler(this.backButton_MouseEnter);
            // 
            // DeleteStudentResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(466, 249);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.admissionSerialNoTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteStudentResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Student Result";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox admissionSerialNoTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button backButton;
    }
}