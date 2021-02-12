using CleverBit.API.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleverBit.API.Validation
{
    public class EmployeeModelValidation : AbstractValidator<EmployeeModel>
    {
        public EmployeeModelValidation()
        {
            RuleFor(x => x.Name)
               .NotEmpty()
               .MinimumLength(5)
               .WithMessage("Please Enter A Valid Name");

            RuleFor(x => x.Surname)
              .NotEmpty()
              .MinimumLength(5)
              .WithMessage("Please Enter A Valid Surname");

            RuleFor(x => x.RegionID)
              .Must(x => x > 0)
              .WithMessage("Please Enter A Valid RegionID");
        }
    }
}
