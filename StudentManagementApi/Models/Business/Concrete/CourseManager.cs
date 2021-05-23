using StudentManagementApi.Models.Concrete;
using StudentManagementApi.Models.DataAccess.Concrete.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagementApi.Models.Business.Concrete
{
    public class CourseManager
    {
        GenericRepository<Course> repository = new GenericRepository<Course>();
        public List<Course> GetAllBL()
        {
            return repository.List();
        }
    }
}