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
            RuleFor(student => student.Name).NotEmpty().WithMessage("Öğrenci Adı Boş Olamaz !!!");
            RuleFor(student => student.CID).NotEmpty().WithMessage("Öğrenci Kurs Bilgisi Boş Olamaz !!!");
            RuleFor(student => student.PersonelDetail).NotEmpty().WithMessage("Öğrenci Personel Bilgisi Boş Olamaz !!!");
            RuleFor(student => student.EducationDetail).NotEmpty().WithMessage("Öğrenci Eğitim Bilgisi Boş Olamaz !!!");
            RuleFor(student => student.FeesDetail).NotEmpty().WithMessage("Öğrenci Ücret Bilgisi Boş Olamaz !!!");

            RuleFor(student => student.CID).GreaterThan(0);
        }
    }
}