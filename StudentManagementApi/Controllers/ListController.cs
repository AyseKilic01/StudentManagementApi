﻿using StudentManagementApi.Models.Business.Concrete;
using StudentManagementApi.Models.Concrete;
using StudentManagementApi.Models.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace StudentManagementApi.Controllers
{
    [EnableCors("*", "*", "get")]
    public class ListController : ApiController
    {
        StudentManager student = new StudentManager();
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
