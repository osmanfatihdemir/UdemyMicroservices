using FluentValidation;
using FreeCourse.WebUI.Models.Catalogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.WebUI.Validators
{
    public class CourseCreateInputValidator:AbstractValidator<CourseCreateInput>
    {
        public CourseCreateInputValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.Feature.Duration).InclusiveBetween(1, int.MaxValue);
            RuleFor(x => x.Price).NotEmpty().ScalePrecision(2, 6);
            RuleFor(x => x.CategoryId).NotEmpty();
        }
    }
}
