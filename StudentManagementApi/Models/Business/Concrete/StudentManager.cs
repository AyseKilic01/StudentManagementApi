using StudentManagementApi.Models.Business.Abstract;
using StudentManagementApi.Models.Business.ValidationRules;
using StudentManagementApi.Models.Concrete;
using StudentManagementApi.Models.DataAccess.Concrete.Repositories;
using StudentManagementApi.Models.Business.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentManagementApi.Models.DataAccess.Abstract;

namespace StudentManagementApi.Models.Business.Concrete
{
    public class StudentManager : IService<Student>
    {
        #region objects
        //GenericRepository<Student> repository = new GenericRepository<Student>();
        IStudentDAL _dal;
        StudentValidation validation = new StudentValidation();

        public StudentManager(IStudentDAL dal)
        {
            _dal = dal;
        }
        #endregion
        public void Add(Student prop)
        {
            ValidationTool.Validate(new StudentValidation(), prop);
            _dal.Insert(prop);
        }

        public void Delete(Student prop)
        {
            _dal.Delete(prop);
        }

        public List<Student> GetAllBL()
        {
            return _dal.List();
        }
        public List<Student> GetAllBL(int id)
        {
            return _dal.List().Where(x=>x.SID == id).ToList();
        }

        public void Update(Student prop)
        {
            ValidationTool.Validate(new StudentValidation(), prop);
            _dal.Update(prop);
        }
    }
}