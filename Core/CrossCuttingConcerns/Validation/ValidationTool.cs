using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {

        //Ivalidor ver diyoruz mesela Iproduct object enitity de mesela prodcut nesnesi girecek.
        public static void Validate(IValidator validator, object entity)
        {

            var context = new ValidationContext<object>(entity);
            // ProductValidator productValidator = new ProductValidator();
            var result = validator.Validate(context);

            if (!result.IsValid)
            {

                throw new ValidationException(result.Errors);

            }
        }
    }
}
