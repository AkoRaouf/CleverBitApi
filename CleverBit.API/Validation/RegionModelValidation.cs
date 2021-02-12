using CleverBit.API.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleverBit.API.Validation
{
    public class RegionModelValidation : AbstractValidator<RegionModel>
    {
        public RegionModelValidation()
        {
            RuleFor(x => x.Name)
               .NotEmpty()
               .MinimumLength(5)
               .WithMessage("Please Enter A Valid Name");

            RuleFor(x => x.ParentRegionID)
              .Must(x => x > 0)
              .WithMessage("Please Enter A Valid RegionID");
        }
    }
}
