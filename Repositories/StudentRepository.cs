using RESTDemo.Data;
using RESTDemo.Model;

namespace RESTDemo.Repositories
{
    public class StudentRepository:IStudentRepository
    {

        private readonly ApplicationDbContext db;

        public StudentRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public int AddStudent(Student student)
        {
            int result = 0;
            db.Students?.Add(student);
            result = db.SaveChanges();
            return result;
        }

        public int DeleteStudent(int id)
        {
            int result = 0;
            var b=db.Students?.Where(x=>x.RollNo == id).FirstOrDefault();
            if(b != null)
            {
                db.Students?.Remove(b);
                result = db.SaveChanges();
            }
            return result;
        }

        public Student GetStudentById(int id)
        {
            return db.Students?.Where(x => x.RollNo == id).FirstOrDefault();
        }

        public IEnumerable<Student> GetStudents()
        {
           return db.Students.ToList(); 
        }

        public int UpdateStudent(Student student)
        {
            int result = 0;
           
           var res= db.Students?.Where(x => x.RollNo == student.RollNo).FirstOrDefault();

            if (res != null)
            {
                
                res.Name = student.Name;
                res.Branch = student.Branch;
                res.Percentage = student.Percentage;
                result = db.SaveChanges();
            }
            return result;
        }
    }
}
