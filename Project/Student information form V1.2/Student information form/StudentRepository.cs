namespace StudentManagementSystem
{
    public class StudentRepository
    {
        private readonly string studentFilePath = "students.txt";

        public void SaveStudent(Student student)
        {
            File.AppendAllText(studentFilePath, student.ToString() + Environment.NewLine);
        }

        public List<Student> LoadAllStudents()
        {
            var students = new List<Student>();

            if (File.Exists(studentFilePath))
            {
                var lines = File.ReadAllLines(studentFilePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 4)
                    {
                        students.Add(new Student(parts[0], parts[1], int.Parse(parts[2]), parts[3]));
                    }
                }
            }

            return students;
        }

        public void DeleteStudent(string studentID)
        {
            var students = File.ReadAllLines(studentFilePath)
                               .Where(line => !line.StartsWith(studentID + ","))
                               .ToList();

            File.WriteAllLines(studentFilePath, students);
        }
    }
}
