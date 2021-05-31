using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagementApi.Models.Business.Utilities
{
    //sıklıkla kullanıyorsan static
    public static class ValidationTool
    {
        public static void Validate(IValidator validation, object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validation.Validate(context);
            if(result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}