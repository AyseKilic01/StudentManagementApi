using StudentManagementApi.Models.Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentManagementApi.Controllers
{
    public class LoginController : ApiController
    {
        CourseManager course = new CourseManager();
        // GET api/values
        public IHttpActionResult GetValues()
        {
            var coursevalues = course.GetAllBL();
            return Ok(coursevalues);
        }
    }
}
