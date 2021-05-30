using StudentManagementApi.Models.Business.Concrete;
using StudentManagementApi.Models.Concrete;
using System.Web.Http;

namespace StudentManagementApi.Controllers
{
    public class BaseController : ApiController
    {
        #region objects
        StudentManager student = new StudentManager();
        TeacherManager teacher = new TeacherManager();
        CourseManager course = new CourseManager();
        #endregion

        // POST api/values
        public void PostStudent([FromBody]Student students)
        {

            student.Add(students);
        }
        public void PostTeacher([FromBody]string value)
        {

        }
        public void PostCourse([FromBody]string value)
        {

        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
