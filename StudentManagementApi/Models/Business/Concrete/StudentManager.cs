using StudentManagementApi.Models.Concrete;
using StudentManagementApi.Models.DataAccess.Concrete.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagementApi.Models.Business.Concrete
{
    public class StudentManager
    {
        GenericRepository<Student> repository = new GenericRepository<Student>();
        public List<Student> GetAllBL()
        {
            return repository.List();
        }
    }
}