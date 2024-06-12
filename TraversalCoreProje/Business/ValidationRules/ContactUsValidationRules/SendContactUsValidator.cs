using DTO.DTOs.ContactUsDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.ContactUsValidationRules
{
    public class SendContactUsValidator:AbstractValidator<SendMessageDTO>
    {
        public SendContactUsValidator()
        {
               RuleFor(x=>x.Name).NotEmpty().WithMessage("İsim Alanı boş geçilemez.");
               RuleFor(x=>x.Mail).NotEmpty().WithMessage("Mail Alanı boş geçilemez.");
               RuleFor(x=>x.Subject).NotEmpty().WithMessage("Konu Alanı boş geçilemez.");
               RuleFor(x=>x.MessageBody).NotEmpty().WithMessage("İçerik Alanı boş geçilemez.");
               RuleFor(x=>x.Subject).MinimumLength(5).WithMessage("Konu en az 5 karakterden oluşmalıdır.");
               RuleFor(x=>x.Subject).MaximumLength(100).WithMessage("Konu en fazla 100 karakterden oluşmalıdır.");
               RuleFor(x=>x.Mail).MaximumLength(100).WithMessage("Mail en fazla 100 karakterden oluşmalıdır.");
               RuleFor(x=>x.Mail).MinimumLength(5).WithMessage("Mail en az 5 karakterden oluşmalıdır.");
        }
    }
}
