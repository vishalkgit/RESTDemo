using RESTDemo.Model;

namespace RESTDemo.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudents();

       
        public int AddStudent(Student student); 


        public int UpdateStudent(Student student);


        public Student GetStudentById(int id);

        public int DeleteStudent(int id);



    }
}
