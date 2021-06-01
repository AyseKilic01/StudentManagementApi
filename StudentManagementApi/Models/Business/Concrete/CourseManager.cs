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
    public class CourseManager : IService<Course>
    {
        //GenericRepository<Course> repository = new GenericRepository<Course>();
        //dependency injection - solide uygun hale çevir direkt nesne türetme constructor içinde set et
        ICourseDAL _dal;
        public CourseManager(ICourseDAL dal)
        {
            _dal = dal;
        }

        public void Add(Course prop)
        {
            _dal.Insert(prop);
        }

        public void Delete(Course prop)
        {
            _dal.Delete(prop);
        }

        public List<Course> GetAllBL()
        {
            return _dal.List();
        }
        public List<Course> GetAllBL(int id)
        {
            return _dal.List().Where(x => x.CID == id).ToList();
        }

        public void Update(Course prop)
        {
            _dal.Update(prop);
        }
    }
}