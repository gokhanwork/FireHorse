using Core.Entities.Concrete;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class TableValidator:AbstractValidator<Table>
    {
        public TableValidator()
        {
            // Validation codes...
            RuleFor(p => p.TableName)
                .NotEmpty()
                .MaximumLength(40);
            RuleFor(p => p.TableStatus).NotEmpty();
        }
    }
}
