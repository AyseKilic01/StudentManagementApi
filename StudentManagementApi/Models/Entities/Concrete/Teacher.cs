using StudentManagementApi.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentManagementApi.Models.Concrete
{
    public class Teacher : IEntity
    {
        [Key]
        public int TID { get; set; }
        public string TName { get; set; }
        public string Education { get; set; }
        public int CID { get; set; }
    }
}