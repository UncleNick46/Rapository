using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameShop.Models;
using FluentValidation;

namespace GameShop.Validators
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Title)

                .NotEmpty()
                .WithMessage("Поле 'Title' не заполнено")

                .MaximumLength(50)
                .WithMessage("Длина должна быть не более 50 символов")

                .MinimumLength(10)
                .WithMessage("Длина должна быть не менее 10 символов");
        }
    }
}
