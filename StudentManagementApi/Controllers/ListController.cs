using StudentManagementApi.Models.Business.Concrete;
using StudentManagementApi.Models.Concrete;
using StudentManagementApi.Models.DataAccess.Abstract;
using StudentManagementApi.Models.DataAccess.Concrete;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace StudentManagementApi.Controllers
{
    [EnableCors("*", "*", "get")]
    public class ListController : ApiController
    {
        #region objects
        StudentManager student = new StudentManager(new IStudentDAL());
        CourseManager course;
        TeacherManager teacher;
        #endregion

        // GET api/students
        public IHttpActionResult getstudent()
        {
            var studentvalues = student.GetAllBL();
            return Ok(studentvalues);
        }
        public IHttpActionResult getstudent(int ID)
        {
            var studentvalues = student.GetAllBL(ID);
            return Ok(studentvalues);
        }
        public IHttpActionResult getcourse()
        {
            var coursevalues = course.GetAllBL();
            return Ok(coursevalues);
        }
        public IHttpActionResult getcourse(int ID)
        {
            var coursevalues = course.GetAllBL(ID);
            return Ok(coursevalues);
        }
        public IHttpActionResult getteacher()
        {
            var teachervalues = teacher.GetAllBL();
            return Ok(teachervalues);
        }
        public IHttpActionResult getteacher(int ID)
        {
            var teachervalues = teacher.GetAllBL(ID);
            return Ok(teachervalues);
        }
        // POST api/students
        public HttpResponseMessage Post([FromBody]Student student)
        {
            try
            {
                using (ManageContext entities = new ManageContext())
                {
                    entities.Students.Add(student);
                    entities.SaveChanges();
                    var message = Request.CreateResponse(HttpStatusCode.Created, student);
                    message.Headers.Location = new Uri(Request.RequestUri + student.SID.ToString());
                    return message;
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
