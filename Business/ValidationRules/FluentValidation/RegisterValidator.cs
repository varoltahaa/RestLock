using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class RegisterValidator: AbstractValidator<UserForRegisterDto>
    {
        public RegisterValidator()
        {
            RuleFor(u => u.Email).EmailAddress().NotEmpty();
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.Password).NotEmpty();
            RuleFor(u => u.Password).NotNull();
            RuleFor(u => u.Password).Length(8,24).WithMessage("Şifre en az 8 en fazla 24 karakter olmak zorunda");
            RuleFor(u => u.Password).Matches("[A-Z]").WithMessage("Şifre büyük harfler içermek zorunda")
            .Matches("[a-z]").WithMessage("Şifre küçük harfler içermek zorunda")
            .Matches("[0-9]").WithMessage("Şifre rakam içermek zorunda")
            .Matches("(?=.*?[.,=|;:<>+#?!@$%^&*-])").WithMessage("Şifre en az 1 tane özel karakter içermek zorunda" );
        }
    }
}
