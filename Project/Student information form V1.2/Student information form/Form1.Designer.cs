namespace StudentInformationForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button updateStudentButton;
        private System.Windows.Forms.Button deleteStudentButton;
        private System.Windows.Forms.Button generateSummaryButton;
        private System.Windows.Forms.Label totalStudentsLabel;
        private System.Windows.Forms.Label averageAgeLabel;

        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox courseTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.Label ageLabel;

        private void InitializeComponent()
        {
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.updateStudentButton = new System.Windows.Forms.Button();
            this.deleteStudentButton = new System.Windows.Forms.Button();
            this.generateSummaryButton = new System.Windows.Forms.Button();
            this.totalStudentsLabel = new System.Windows.Forms.Label();
            this.averageAgeLabel = new System.Windows.Forms.Label();

            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.courseTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.courseLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();

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
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.Location = new System.Drawing.Point(12, 275);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(61, 13);
            this.studentIDLabel.TabIndex = 7;
            this.studentIDLabel.Text = "Student ID:";

            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.Location = new System.Drawing.Point(80, 272);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentIDTextBox.TabIndex = 8;

            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 300);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Name:";

            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(80, 297);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 10;

            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Location = new System.Drawing.Point(12, 325);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(43, 13);
            this.courseLabel.TabIndex = 11;
            this.courseLabel.Text = "Course:";

            // 
            // courseTextBox
            // 
            this.courseTextBox.Location = new System.Drawing.Point(80, 322);
            this.courseTextBox.Name = "courseTextBox";
            this.courseTextBox.Size = new System.Drawing.Size(100, 20);
            this.courseTextBox.TabIndex = 12;

            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(12, 350);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(29, 13);
            this.ageLabel.TabIndex = 13;
            this.ageLabel.Text = "Age:";

            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(80, 347);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 14;

            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(200, 272);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(100, 23);
            this.addStudentButton.TabIndex = 1;
            this.addStudentButton.Text = "Add Student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);

            // 
            // updateStudentButton
            // 
            this.updateStudentButton.Location = new System.Drawing.Point(200, 300);
            this.updateStudentButton.Name = "updateStudentButton";
            this.updateStudentButton.Size = new System.Drawing.Size(100, 23);
            this.updateStudentButton.TabIndex = 2;
            this.updateStudentButton.Text = "Update Student";
            this.updateStudentButton.UseVisualStyleBackColor = true;
            this.updateStudentButton.Click += new System.EventHandler(this.UpdateStudentButton_Click);

            // 
            // deleteStudentButton
            // 
            this.deleteStudentButton.Location = new System.Drawing.Point(200, 328);
            this.deleteStudentButton.Name = "deleteStudentButton";
            this.deleteStudentButton.Size = new System.Drawing.Size(100, 23);
            this.deleteStudentButton.TabIndex = 3;
            this.deleteStudentButton.Text = "Delete Student";
            this.deleteStudentButton.UseVisualStyleBackColor = true;
            this.deleteStudentButton.Click += new System.EventHandler(this.DeleteStudentButton_Click);

            // 
            // generateSummaryButton
            // 
            this.generateSummaryButton.Location = new System.Drawing.Point(320, 272);
            this.generateSummaryButton.Name = "generateSummaryButton";
            this.generateSummaryButton.Size = new System.Drawing.Size(120, 23);
            this.generateSummaryButton.TabIndex = 4;
            this.generateSummaryButton.Text = "Generate Summary";
            this.generateSummaryButton.UseVisualStyleBackColor = true;
            this.generateSummaryButton.Click += new System.EventHandler(this.GenerateSummaryButton_Click);

            // 
            // totalStudentsLabel
            // 
            this.totalStudentsLabel.AutoSize = true;
            this.totalStudentsLabel.Location = new System.Drawing.Point(320, 300);
            this.totalStudentsLabel.Name = "totalStudentsLabel";
            this.totalStudentsLabel.Size = new System.Drawing.Size(94, 13);
            this.totalStudentsLabel.TabIndex = 5;
            this.totalStudentsLabel.Text = "Total Students: 0";

            // 
            // averageAgeLabel
            // 
            this.averageAgeLabel.AutoSize = true;
            this.averageAgeLabel.Location = new System.Drawing.Point(320, 325);
            this.averageAgeLabel.Name = "averageAgeLabel";
            this.averageAgeLabel.Size = new System.Drawing.Size(84, 13);
            this.averageAgeLabel.TabIndex = 6;
            this.averageAgeLabel.Text = "Average Age: 0";

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(624, 381);
            this.Controls.Add(this.averageAgeLabel);
            this.Controls.Add(this.totalStudentsLabel);
            this.Controls.Add(this.generateSummaryButton);
            this.Controls.Add(this.deleteStudentButton);
            this.Controls.Add(this.updateStudentButton);
            this.Controls.Add(this.addStudentButton);

            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.courseTextBox);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(this.studentIDLabel);

            this.Controls.Add(this.studentDataGridView);
            this.Name = "Form1";
            this.Text = "Student Information System";
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
