using FluentValidation;
using RentAllCars.Data.Entities;

namespace RentAllCars.Service.ValidationRules.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.Name).MinimumLength(2);
        }
    }
}
