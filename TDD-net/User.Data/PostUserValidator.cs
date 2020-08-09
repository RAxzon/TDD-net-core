using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using User.Domain.Models;

namespace User.Data
{
    public class PostUserValidator : AbstractValidator<TDDUser>
    {
        public PostUserValidator()
        {
            RuleFor(x => x.Name)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .MaximumLength(20);
        }
    }
}
