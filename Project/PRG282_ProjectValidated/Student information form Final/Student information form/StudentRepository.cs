using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StudentManagementSystem
{
    public class StudentRepository
    {
        private readonly string studentFilePath = "students.txt";

        // Save a new student record to the students.txt file
        public void SaveStudent(Student student)
        {
            try
            {
                File.AppendAllText(studentFilePath, student.ToString() + Environment.NewLine);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error saving student data: {ex.Message}");
            }
        }

        // Load all student records from students.txt
        public List<Student> LoadAllStudents()
        {
            var students = new List<Student>();

            try
            {
                // Check if the file exists before reading
                if (File.Exists(studentFilePath))
                {
                    var lines = File.ReadAllLines(studentFilePath);
                    foreach (var line in lines)
                    {
                        var parts = line.Split(',');

                        // Validate that each line has exactly 4 parts and that age is an integer
                        if (parts.Length == 4 && int.TryParse(parts[2], out int age))
                        {
                            students.Add(new Student(parts[0], parts[1], age, parts[3]));
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error loading student data: {ex.Message}");
            }

            return students;
        }

        // Delete a student record by ID
        public void DeleteStudent(string studentID)
        {
            try
            {
                // Filter out the student with the specified ID
                var students = File.ReadAllLines(studentFilePath)
                                   .Where(line => !line.StartsWith(studentID + ","))
                                   .ToList();

                // Overwrite the file with the remaining students
                File.WriteAllLines(studentFilePath, students);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error deleting student data: {ex.Message}");
            }
        }
    }
}

