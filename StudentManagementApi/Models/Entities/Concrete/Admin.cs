using StudentManagementApi.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentManagementApi.Models.Concrete
{
    public class Admin : IEntity
    {
        [Key]
        public int AID { get; set; }
        public string Name { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}