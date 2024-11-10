namespace StudentManagementSystem
{
    public class Student
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public Student(string studentID, string name, int age, string course)
        {
            StudentID = studentID;
            Name = name;
            Age = age;
            Course = course;
        }

        public override string ToString()
        {
            return $"{StudentID},{Name},{Age},{Course}";
        }
    }
}
