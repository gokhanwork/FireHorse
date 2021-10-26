using Core.Entities.Concrete;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ExampleValidator:AbstractValidator<Adress>
    {
        /*public ExampletValidator()
        {
            // Validation codes...
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0); //0'dan büyük
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1); // categorisi 1 olan ve 10 dan büyük unit price
            RuleFor(p => p.ProductName).Must(StartWithA);
        }*/

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
