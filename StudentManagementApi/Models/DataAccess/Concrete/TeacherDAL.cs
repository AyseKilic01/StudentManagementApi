using StudentManagementApi.Models.Concrete;
using StudentManagementApi.Models.DataAccess.Abstract;
using StudentManagementApi.Models.DataAccess.Concrete.Repositories;

namespace StudentManagementApi.Models.DataAccess.Concrete
{
    public class TeacherDAL : GenericRepository<Teacher>, ITeacherDAL
    {
    }
}