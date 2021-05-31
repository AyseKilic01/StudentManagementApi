using StudentManagementApi.Models.Concrete;
using StudentManagementApi.Models.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace StudentManagementApi.Models.DataAccess.Concrete
{
    public class EStudentDAL : IStudentDAL
    {
        public void Delete(Student p)
        {
            using (ManageContext context = new ManageContext())
            {
                var entity = context.Entry(p);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Insert(Student p)
        {
            using (ManageContext context = new ManageContext())
            {
                var entity = context.Entry(p);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
            public List<Student> List()
        {
            using (ManageContext context = new ManageContext())
            {
                return context.Students.ToList();
            }
        }

        public List<Student> List(Expression<Func<Student, bool>> filter)
        {
            using (ManageContext context = new ManageContext())
            {
                return context.Students.ToList();
            }
        }

        public void Update(Student p)
        {
            using (ManageContext context = new ManageContext())
            {
                var entity = context.Entry(p);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}