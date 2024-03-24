using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.ReviewCommands;

namespace Udemy_CarBook.Aplication.Validators.ReviewValidators
{
    public class UpdateReviewValidator : AbstractValidator<UpdateReviewCommand>
    {
        public UpdateReviewValidator()
        {
            RuleFor(x => x.CoustomerName).NotEmpty().WithMessage("Lütfen müşteri adını boş geçmeyin!!!");
            RuleFor(x => x.CoustomerName).MinimumLength(5).WithMessage("Lütfen en az 5 karekter veri girişi yapınız");
            RuleFor(x => x.RaytingValue).NotEmpty().WithMessage("Lütfen puan değerini boş geçmeyiniz");
            RuleFor(x => x.Comment).NotEmpty().WithMessage("Lütfen yorum değerini boş geçmeyiniz");
            RuleFor(x => x.Comment).MinimumLength(50).WithMessage("Lütfen en az 50 karekter veri girişi yapınız");
            RuleFor(x => x.Comment).MaximumLength(500).WithMessage("Lütfen en fazla 500 karekter veri girişi yapınız");
            RuleFor(x => x.CoustomerImage).NotEmpty().WithMessage("Lütfen görsel değerini boş geçmeyiniz");
            RuleFor(x => x.CoustomerImage).MinimumLength(10).WithMessage("Lütfen en az 10 karekter veri girişi yapınız").MaximumLength(200).WithMessage("En Fazla 200 Karakterlik veri girişi yapınız");

        }
    }
}
