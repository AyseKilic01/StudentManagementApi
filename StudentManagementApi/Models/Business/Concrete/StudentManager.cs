using StudentManagementApi.Models.Business.Abstract;
using StudentManagementApi.Models.Concrete;
using StudentManagementApi.Models.DataAccess.Concrete.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagementApi.Models.Business.Concrete
{
    public class StudentManager : IService<Student>
    {
        GenericRepository<Student> repository = new GenericRepository<Student>();

        public void Add(Student prop)
        {
            throw new NotImplementedException();
        }

        public void Delete(Student prop)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAllBL()
        {
            return repository.List();
        }
        public List<Student> GetAllBL(int id)
        {
            return repository.List().Where(x=>x.SID == id).ToList();
        }

        public void Update(Student prop)
        {
            throw new NotImplementedException();
        }
    }
}