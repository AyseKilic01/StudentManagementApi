using StudentManagementApi.Models.Business.Abstract;
using StudentManagementApi.Models.Concrete;
using StudentManagementApi.Models.DataAccess.Abstract;
using StudentManagementApi.Models.DataAccess.Concrete.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagementApi.Models.Business.Concrete
{
    public class TeacherManager : IService<Teacher>
    {
        //GenericRepository<Teacher> repository = new GenericRepository<Teacher>();
        ITeacherDAL _dal;

        public TeacherManager(ITeacherDAL dal)
        {
            _dal = dal;
        }

        public void Add(Teacher prop)
        {
            _dal.Insert(prop);
        }

        public void Delete(Teacher prop)
        {
            _dal.Delete(prop);
        }

        public List<Teacher> GetAllBL()
        {
            return _dal.List();
        }
        public List<Teacher> GetAllBL(int id)
        {
            return _dal.List().Where(x => x.TID == id).ToList();
        }

        public void Update(Teacher prop)
        {
            _dal.Update(prop);
        }
    }
}