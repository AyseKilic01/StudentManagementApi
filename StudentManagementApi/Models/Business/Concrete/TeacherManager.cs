using StudentManagementApi.Models.Business.Abstract;
using StudentManagementApi.Models.Concrete;
using StudentManagementApi.Models.DataAccess.Concrete.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagementApi.Models.Business.Concrete
{
    public class TeacherManager : IService<Teacher>
    {
        GenericRepository<Teacher> repository = new GenericRepository<Teacher>();

        public void Add(Teacher prop)
        {
            repository.Insert(prop);
        }

        public void Delete(Teacher prop)
        {
            repository.Delete(prop);
        }

        public List<Teacher> GetAllBL()
        {
            return repository.List();
        }
        public List<Teacher> GetAllBL(int id)
        {
            return repository.List().Where(x => x.TID == id).ToList();
        }

        public void Update(Teacher prop)
        {
            repository.Update(prop);
        }
    }
}