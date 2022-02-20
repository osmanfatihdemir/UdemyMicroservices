using FluentValidation;
using FreeCourse.WebUI.Models.Catalogs;

namespace FreeCourse.WebUI.Validators
{
    public class CourseUpdateInputValidator : AbstractValidator<CourseUpdateInput>
    {
        public CourseUpdateInputValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.Feature.Duration).InclusiveBetween(1, int.MaxValue);
            RuleFor(x => x.Price).NotEmpty().ScalePrecision(2, 6);
            RuleFor(x => x.CategoryId).NotEmpty();
        }
    }
}
