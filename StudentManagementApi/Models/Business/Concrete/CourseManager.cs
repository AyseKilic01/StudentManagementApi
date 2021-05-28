using StudentManagementApi.Models.Business.Abstract;
using StudentManagementApi.Models.Concrete;
using StudentManagementApi.Models.DataAccess.Concrete.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagementApi.Models.Business.Concrete
{
    public class CourseManager : IService<Course>
    {
        GenericRepository<Course> repository = new GenericRepository<Course>();

        public void Add(Course prop)
        {
            throw new NotImplementedException();
        }

        public void Delete(Course prop)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAllBL()
        {
            return repository.List();
        }
        public List<Course> GetAllBL(int id)
        {
            return repository.List().Where(x => x.CID == id).ToList();
        }

        public void Update(Course prop)
        {
            throw new NotImplementedException();
        }
    }
}