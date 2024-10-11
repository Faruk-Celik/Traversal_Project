using DTOLayer.DTOs.ApUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTOs>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("ad alanı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("ad alanı boş geçilemez");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("ad alanı boş geçilemez");
            RuleFor(x => x.Username).NotEmpty().WithMessage("ad alanı boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("ad alanı boş geçilemez");
            RuleFor(x => x.ConfirmPassWord).NotEmpty().WithMessage("ad alanı boş geçilemez");
            RuleFor(x => x.Username).NotEmpty().WithMessage("ad alanı boş geçilemez");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassWord).WithMessage("şifreler bir biriyle uyuşmuyor");
        }

    }
}
