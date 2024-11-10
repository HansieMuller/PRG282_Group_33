using System;
using System.Collections.Generic;

namespace StudentManagementSystem
{
    public class StudentManager
    {
        // Reference to the StudentRepository to handle file-based operations
        private readonly StudentRepository studentRepository;

        // Constructor initializes the StudentRepository instance
        public StudentManager()
        {
            studentRepository = new StudentRepository();
        }

        // Adds a new student by calling the repository's SaveStudent method
        public void AddStudent(Student student)
        {
            if (IsValidStudent(student))
            {
                studentRepository.SaveStudent(student);
            }
            else
            {
                Console.WriteLine("Invalid student data. Please ensure all fields are properly filled.");
            }
        }

        // Retrieves all students by calling the repository's LoadAllStudents method
        public List<Student> GetAllStudents()
        {
            return studentRepository.LoadAllStudents();
        }

        // Deletes a student by their ID using the repository's DeleteStudent method
        public void DeleteStudent(string studentID)
        {
            if (!string.IsNullOrWhiteSpace(studentID))
            {
                studentRepository.DeleteStudent(studentID);
            }
            else
            {
                Console.WriteLine("Invalid student ID. Please provide a valid ID.");
            }
        }

        // Validates student data to ensure fields are not null or empty
        private bool IsValidStudent(Student student)
        {
            return !string.IsNullOrWhiteSpace(student.StudentID) &&
                   !string.IsNullOrWhiteSpace(student.Name) &&
                   !string.IsNullOrWhiteSpace(student.Course) &&
                   student.Age > 0;
        }
    }
}

