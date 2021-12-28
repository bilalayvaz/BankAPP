using BankApp.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BankApp.Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.TcNo).NotEmpty().Length(11).WithMessage("Tc Kimlik Numarası 11 Haneden Oluşmalıdır");
            RuleFor(c => c.TcNo).NotEmpty().Matches(@"^\d+$").WithMessage("Tc Kimlik Numarası Sayılardan Oluşmalıdır");
            RuleFor(c => c.Name).NotEmpty().Matches(@"[a-zA-Z]+$").WithMessage("İsim Harflerden Oluşmalıdır");
            RuleFor(c => c.LastName).NotEmpty().Matches(@"[a-zA-Z]+$").WithMessage("Soyisim Harflerden Oluşmalıdır");
            RuleFor(c => c.PhoneNumber).NotEmpty().Length(11).WithMessage("Telefon Numarası 11 Haneden Oluşmalıdır");
            RuleFor(c => c.PhoneNumber).Matches(@"^\d+$").WithMessage("Telefon Numarası Sayılardan Oluşmalıdır");
        }

        
    }
}
