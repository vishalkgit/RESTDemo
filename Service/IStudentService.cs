using RESTDemo.Model;

namespace RESTDemo.Service
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudents();

        public int AddStudent(Student student);


        public int UpdateStudent(Student student);


        public Student GetStudentById(int id);

        public int DeleteStudent(int id);
    }
}
