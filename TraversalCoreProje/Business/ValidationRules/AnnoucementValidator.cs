using DTO.DTOs.AnnoucementDTOs;
using Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class AnnoucementValidator:AbstractValidator<AnnoucementAddDTOs>
    {
        public AnnoucementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Alanı boş geçilemez.");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Mesaj Alanı boş geçilemez.");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Başlık Alanı en az 5 karakterden oluşmalı.");
            RuleFor(x => x.Content).MinimumLength(5).WithMessage("Mesaj Alanı en az 5 karakterden oluşmalı.");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("Mesaj Alanı en fazla 500 karakterden oluşmalı.");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Başlık Alanı en fazla 50 karakterden oluşmalı.");
        }
    }
}
