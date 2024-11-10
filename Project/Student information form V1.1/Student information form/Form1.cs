using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StudentInformationForm
{
    public partial class Form1 : Form
    {
        // List to store students
        private List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
            LoadStudents();
        }

        // Load student data from students.txt
        private void LoadStudents()
        {
            students.Clear();
            if (File.Exists("students.txt"))
            {
                var lines = File.ReadAllLines("students.txt");
                foreach (var line in lines)
                {
                    var fields = line.Split(',');
                    if (fields.Length == 4)
                    {
                        students.Add(new Student
                        {
                            StudentID = fields[0],
                            Name = fields[1],
                            Course = fields[2],
                            Age = int.Parse(fields[3])
                        });
                    }
                }
            }
            // Bind students to DataGridView
            studentDataGridView.DataSource = students.ToList();
        }

        // Save student data to students.txt
        private void SaveStudents()
        {
            var lines = students.Select(s => $"{s.StudentID},{s.Name},{s.Course},{s.Age}").ToList();
            File.WriteAllLines("students.txt", lines);
        }

        // Handle Add New Student
        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                StudentID = studentIDTextBox.Text,
                Name = nameTextBox.Text,
                Course = courseTextBox.Text,
                Age = int.TryParse(ageTextBox.Text, out int age) ? age : 0
            };

            students.Add(student);
            SaveStudents();
            LoadStudents(); // Refresh DataGridView
        }

        // Handle Update Student
        private void UpdateStudentButton_Click(object sender, EventArgs e)
        {
            var selectedRow = studentDataGridView.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                var studentID = selectedRow.Cells[0].Value.ToString();
                var student = students.FirstOrDefault(s => s.StudentID == studentID);

                if (student != null)
                {
                    student.Name = nameTextBox.Text;
                    student.Course = courseTextBox.Text;
                    student.Age = int.TryParse(ageTextBox.Text, out int age) ? age : 0;
                    SaveStudents();
                    LoadStudents(); // Refresh DataGridView
                }
            }
        }

        // Handle Delete Student
        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            var selectedRow = studentDataGridView.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                var studentID = selectedRow.Cells[0].Value.ToString();
                var student = students.FirstOrDefault(s => s.StudentID == studentID);

                if (student != null)
                {
                    students.Remove(student);
                    SaveStudents();
                    LoadStudents(); // Refresh DataGridView
                }
            }
        }

        // Handle selecting a student from DataGridView
        private void StudentDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var selectedRow = studentDataGridView.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                studentIDTextBox.Text = selectedRow.Cells[0].Value.ToString();
                nameTextBox.Text = selectedRow.Cells[1].Value.ToString();
                courseTextBox.Text = selectedRow.Cells[2].Value.ToString();
                ageTextBox.Text = selectedRow.Cells[3].Value.ToString();
            }
        }
    }

    // Student class to represent student records
    public class Student
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public int Age { get; set; }
    }
}
