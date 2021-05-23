using StudentManagementApi.Models.Concrete;
using StudentManagementApi.Models.DataAccess.Concrete.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagementApi.Models.Business.Concrete
{
    public class TeacherManager
    {
        GenericRepository<Teacher> repository = new GenericRepository<Teacher>();
        public List<Teacher> GetAllBL()
        {
            return repository.List();
        }
    }
}