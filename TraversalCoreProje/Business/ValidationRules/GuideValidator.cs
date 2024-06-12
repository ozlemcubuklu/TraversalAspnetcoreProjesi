using Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name Alanı Boş Geçilemez.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description Alanı Boş Geçilemez.");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Rehber Görseli Boş Geçilemez.");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen 30 karakterden daha az bir isim giriniz.");
            RuleFor(x => x.Name).MinimumLength(6).WithMessage("Lütfen 6 karakterden daha fazla bir isim giriniz.");
        }
    }
}
