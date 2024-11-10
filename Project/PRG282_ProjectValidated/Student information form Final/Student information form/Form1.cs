using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StudentInformationForm
{
    public partial class Form1 : Form
    {
        // List to store student records
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
            try
            {
                // Check if the students file exists
                if (File.Exists("students.txt"))
                {
                    var lines = File.ReadAllLines("students.txt");
                    foreach (var line in lines)
                    {
                        var fields = line.Split(',');
                        // Ensure the record has exactly 4 fields
                        if (fields.Length == 4 && int.TryParse(fields[3], out int age))
                        {
                            students.Add(new Student
                            {
                                StudentID = fields[0],
                                Name = fields[1],
                                Course = fields[2],
                                Age = age
                            });
                        }
                    }
                }
                // Bind the student list to the DataGridView
                studentDataGridView.DataSource = students.ToList();
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error loading student data: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Save student data to students.txt
        private void SaveStudents()
        {
            try
            {
                var lines = students.Select(s => $"{s.StudentID},{s.Name},{s.Course},{s.Age}").ToList();
                File.WriteAllLines("students.txt", lines);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error saving student data: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add a new student
        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(studentIDTextBox.Text) ||
                string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(courseTextBox.Text) ||
                !int.TryParse(ageTextBox.Text, out int age))
            {
                MessageBox.Show("Please enter valid student details.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add new student
            var student = new Student
            {
                StudentID = studentIDTextBox.Text,
                Name = nameTextBox.Text,
                Course = courseTextBox.Text,
                Age = age
            };

            students.Add(student);
            SaveStudents();
            LoadStudents(); // Refresh DataGridView
        }

        // Update an existing student's information
        private void UpdateStudentButton_Click(object sender, EventArgs e)
        {
            var selectedRow = studentDataGridView.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                var studentID = selectedRow.Cells[0].Value.ToString();
                var student = students.FirstOrDefault(s => s.StudentID == studentID);

                if (student != null)
                {
                    // Validate inputs
                    if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                        string.IsNullOrWhiteSpace(courseTextBox.Text) ||
                        !int.TryParse(ageTextBox.Text, out int age))
                    {
                        MessageBox.Show("Please enter valid updated details.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Update student details
                    student.Name = nameTextBox.Text;
                    student.Course = courseTextBox.Text;
                    student.Age = age;

                    SaveStudents();
                    LoadStudents(); // Refresh DataGridView
                }
            }
        }

        // Delete a student record
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

        // Generate the summary report
        private void GenerateSummaryButton_Click(object sender, EventArgs e)
        {
            // Calculate total number of students and average age
            int totalStudents = students.Count;
            double averageAge = students.Count > 0 ? students.Average(s => s.Age) : 0;

            // Display the summary information
            totalStudentsLabel.Text = $"Total Students: {totalStudents}";
            averageAgeLabel.Text = $"Average Age: {averageAge:F2}";

            // Save the summary report to summary.txt
            try
            {
                string summaryReport = $"Total Students: {totalStudents}\nAverage Age: {averageAge:F2}";
                File.WriteAllText("summary.txt", summaryReport);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error saving summary report: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

