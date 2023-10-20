using StudentAdminPortal.API.DataModels;

namespace StudentAdminPortal.API.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {

        public List<Student> GetAllStudents()
        {
            List<Student> listStudent = new List<Student>();
            //listStudent = StaticData.lsStudent;
            return listStudent;
        }
    }
}
