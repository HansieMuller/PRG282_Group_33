namespace StudentManagementSystem
{
    public class StudentManager
    {
        private readonly StudentRepository studentRepository;

        public StudentManager()
        {
            studentRepository = new StudentRepository();
        }

        public void AddStudent(Student student)
        {
            studentRepository.SaveStudent(student);
        }

        public List<Student> GetAllStudents()
        {
            return studentRepository.LoadAllStudents();
        }

        public void DeleteStudent(string studentID)
        {
            studentRepository.DeleteStudent(studentID);
        }
    }
}
