using StudentManagementApi.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentManagementApi.Models.Concrete
{
    public class Course : IEntity
    {
        [Key]
        public int CID { get; set; }
        public TimeSpan Duration { get; set; }
        public decimal Fees { get; set; }
        public string CName { get; set; }
        public int AdminID { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
    }
}