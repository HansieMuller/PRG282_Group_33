namespace StudentManagementSystem
{
    public class Student
    {
        // Properties to hold student information
        public string StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        // Constructor to initialize student fields
        public Student(string studentID, string name, int age, string course)
        {
            // Ensure all fields have valid data before assigning
            StudentID = !string.IsNullOrWhiteSpace(studentID) ? studentID : throw new ArgumentException("Student ID cannot be empty.");
            Name = !string.IsNullOrWhiteSpace(name) ? name : throw new ArgumentException("Name cannot be empty.");
            Age = age > 0 ? age : throw new ArgumentOutOfRangeException(nameof(age), "Age must be a positive integer.");
            Course = !string.IsNullOrWhiteSpace(course) ? course : throw new ArgumentException("Course cannot be empty.");
        }

        // Override ToString method to format student details for file storage
        public override string ToString()
        {
            return $"{StudentID},{Name},{Age},{Course}";
        }
    }
}

