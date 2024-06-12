using Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x=>x.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez.");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen görsel seçiniz.");
            RuleFor(x=>x.Description).MinimumLength(50).MaximumLength(1500).WithMessage("girilen deger 50-1500 karakter arasında olmalı.");
        }
    }
}
