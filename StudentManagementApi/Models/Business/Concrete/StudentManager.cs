using StudentManagementApi.Models.Business.Abstract;
using StudentManagementApi.Models.Business.ValidationRules;
using StudentManagementApi.Models.Concrete;
using StudentManagementApi.Models.DataAccess.Concrete.Repositories;
using StudentManagementApi.Models.Business.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagementApi.Models.Business.Concrete
{
    public class StudentManager : IService<Student>
    {
        #region objects
        GenericRepository<Student> repository = new GenericRepository<Student>();
        StudentValidation validation = new StudentValidation();
        #endregion
        public void Add(Student prop)
        {
            ValidationTool.Validate(new StudentValidation(), prop);
            repository.Insert(prop);
        }

        public void Delete(Student prop)
        {
            repository.Delete(prop);
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
            ValidationTool.Validate(new StudentValidation(), prop);
            repository.Update(prop);
        }
    }
}