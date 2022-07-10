using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class PlaceValidator : AbstractValidator<Place>
    {
        public PlaceValidator()
        {
            RuleFor(p => p.PlaceName).MinimumLength(2);
            RuleFor(p => p.PlaceName).NotEmpty();
            RuleFor(p => p.PlaceAddress).NotEmpty();
            RuleFor(p => p.PlacePhoneNumber).NotEmpty();
        }
    }
}
