using DTO.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDTOs>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Alanı boş geçilemez.");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("Soyisim Alanı boş geçilemez.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email Alanı boş geçilemez.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Alanı boş geçilemez.");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre Tekrar Alanı boş geçilemez.");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı Alanı boş geçilemez.");
            RuleFor(x => x.UserName).MinimumLength(6).WithMessage("Kullanıcı Adı alanı en az 6 karakterden oluşmalıdır.");
            RuleFor(x => x.UserName).MaximumLength(20).WithMessage("Kullanıcı Adı alanı en fazla 20 karakterden oluşmalıdır.");
            RuleFor(x => x.Password).Equal(y=>y.ConfirmPassword).WithMessage("Şifreler eşleşmiyor.");
        }
    }
}
