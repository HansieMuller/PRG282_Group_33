using System;
using System.Windows.Forms;

namespace Student_information_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for Add Student button
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text;
            string name = txtName.Text;
            string course = txtCourse.Text;
            string age = txtAge.Text;

            // Add student to DataGridView
            dataGridView1.Rows.Add(studentID, name, course, age);

            // Clear the input fields after adding
            txtStudentID.Clear();
            txtName.Clear();
            txtCourse.Clear();
            txtAge.Clear();
        }

        // Event handler for Delete Student button
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(row.Index);
                }
            }
        }
    }
}
