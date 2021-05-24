using StudentManagementApi.Models.Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentManagementApi.Controllers
{
    public class StudentsController : ApiController
    {
        StudentManager student = new StudentManager();
        // GET api/students
        public IHttpActionResult GetValues()
        {
            var studentvalues = student.GetAllBL();
            return Ok(studentvalues);
        }
    }
}
