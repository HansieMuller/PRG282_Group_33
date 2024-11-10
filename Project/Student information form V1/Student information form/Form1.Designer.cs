namespace Student_information_form
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Controls declaration
        private TextBox txtStudentID;
        private TextBox txtName;
        private TextBox txtCourse;
        private TextBox txtAge;
        private Button btnAddStudent;
        private Button btnDeleteStudent;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn StudentIDColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn CourseColumn;
        private DataGridViewTextBoxColumn AgeColumn;

        // Dispose method to clean up components
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Method to initialize components (Designer-generated code)
        private void InitializeComponent()
        {
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // txtStudentID
            this.txtStudentID.Location = new System.Drawing.Point(12, 12);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(200, 20);
            this.txtStudentID.TabIndex = 0;

            // txtName
            this.txtName.Location = new System.Drawing.Point(12, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 1;

            // txtCourse
            this.txtCourse.Location = new System.Drawing.Point(12, 64);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(200, 20);
            this.txtCourse.TabIndex = 2;

            // txtAge
            this.txtAge.Location = new System.Drawing.Point(12, 90);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(200, 20);
            this.txtAge.TabIndex = 3;

            // btnAddStudent
            this.btnAddStudent.Location = new System.Drawing.Point(12, 116);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(200, 23);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);

            // btnDeleteStudent
            this.btnDeleteStudent.Location = new System.Drawing.Point(12, 145);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(200, 23);
            this.btnDeleteStudent.TabIndex = 5;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);

            // dataGridView1
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentIDColumn,
            this.NameColumn,
            this.CourseColumn,
            this.AgeColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(400, 150);
            this.dataGridView1.TabIndex = 6;

            // StudentIDColumn
            this.StudentIDColumn.HeaderText = "Student ID";
            this.StudentIDColumn.Name = "StudentIDColumn";

            // NameColumn
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";

            // CourseColumn
            this.CourseColumn.HeaderText = "Course";
            this.CourseColumn.Name = "CourseColumn";

            // AgeColumn
            this.AgeColumn.HeaderText = "Age";
            this.AgeColumn.Name = "AgeColumn";

            // Form1
            this.ClientSize = new System.Drawing.Size(434, 341);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtStudentID);
            this.Name = "Form1";
            this.Text = "Student Information Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
