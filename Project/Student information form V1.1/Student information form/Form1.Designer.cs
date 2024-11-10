namespace StudentInformationForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button updateStudentButton;
        private System.Windows.Forms.Button deleteStudentButton;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox courseTextBox;
        private System.Windows.Forms.TextBox ageTextBox;

        private void InitializeComponent()
        {
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.updateStudentButton = new System.Windows.Forms.Button();
            this.deleteStudentButton = new System.Windows.Forms.Button();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.courseTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();

            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            this.SuspendLayout();

            // 
            // studentDataGridView
            // 
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Location = new System.Drawing.Point(12, 12);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentDataGridView.Size = new System.Drawing.Size(600, 250);
            this.studentDataGridView.TabIndex = 0;
            this.studentDataGridView.SelectionChanged += new System.EventHandler(this.StudentDataGridView_SelectionChanged);

            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(12, 300);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(75, 23);
            this.addStudentButton.TabIndex = 1;
            this.addStudentButton.Text = "Add Student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);

            // 
            // updateStudentButton
            // 
            this.updateStudentButton.Location = new System.Drawing.Point(100, 300);
            this.updateStudentButton.Name = "updateStudentButton";
            this.updateStudentButton.Size = new System.Drawing.Size(100, 23);
            this.updateStudentButton.TabIndex = 2;
            this.updateStudentButton.Text = "Update Student";
            this.updateStudentButton.UseVisualStyleBackColor = true;
            this.updateStudentButton.Click += new System.EventHandler(this.UpdateStudentButton_Click);

            // 
            // deleteStudentButton
            // 
            this.deleteStudentButton.Location = new System.Drawing.Point(220, 300);
            this.deleteStudentButton.Name = "deleteStudentButton";
            this.deleteStudentButton.Size = new System.Drawing.Size(100, 23);
            this.deleteStudentButton.TabIndex = 3;
            this.deleteStudentButton.Text = "Delete Student";
            this.deleteStudentButton.UseVisualStyleBackColor = true;
            this.deleteStudentButton.Click += new System.EventHandler(this.DeleteStudentButton_Click);

            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.Location = new System.Drawing.Point(12, 270);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentIDTextBox.TabIndex = 4;

            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(120, 270);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 5;

            // 
            // courseTextBox
            // 
            this.courseTextBox.Location = new System.Drawing.Point(230, 270);
            this.courseTextBox.Name = "courseTextBox";
            this.courseTextBox.Size = new System.Drawing.Size(100, 20);
            this.courseTextBox.TabIndex = 6;

            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(340, 270);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(50, 20);
            this.ageTextBox.TabIndex = 7;

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(624, 341);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.courseTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(this.deleteStudentButton);
            this.Controls.Add(this.updateStudentButton);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.studentDataGridView);
            this.Name = "Form1";
            this.Text = "Student Information System";
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
