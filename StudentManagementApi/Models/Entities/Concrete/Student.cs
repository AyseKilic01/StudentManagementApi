using StudentManagementApi.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentManagementApi.Models.Concrete
{
    public class Student : IEntity
    {
        [Key]
        public int SID { get; set; }
        public decimal FeesDetail { get; set; }
        public string Name { get; set; }
        public string EducationDetail { get; set; }
        public string PersonelDetail { get; set; }
        public int CID { get; set; }
    }
}