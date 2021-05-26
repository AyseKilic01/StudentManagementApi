using StudentManagementApi.Models.Business.Concrete;
using StudentManagementApi.Models.Concrete;
using StudentManagementApi.Models.DataAccess.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace StudentManagementApi.Controllers
{
    public class ValuesController : ApiController
    {
        StudentManager student = new StudentManager();
        // GET api/values
        public IHttpActionResult GetValues()
        {
            var studentvalues = student.GetAllBL();
            return Ok(studentvalues);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
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
