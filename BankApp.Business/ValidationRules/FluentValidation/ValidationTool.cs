using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Business.ValidationRules.FluentValidation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator, IValidationContext entity)
        {
            var result = validator.Validate(entity);
            if (result.Errors.Count > 0 )
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
