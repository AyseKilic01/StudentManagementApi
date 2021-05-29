using FluentValidation;
using StudentManagementApi.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagementApi.Models.Business.ValidationRules
{
    public class StudentValidation : AbstractValidator<Student>
    {   //nesne üzerinden .validate(classnesnesi)
        public StudentValidation()
        {
            RuleFor(student => student.Name).NotNull();
        }
    }
}