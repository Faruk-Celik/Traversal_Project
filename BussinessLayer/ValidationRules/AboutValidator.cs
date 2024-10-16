﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmını boş geçmeyiniz");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen görsel seçiniz..");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Lütfen en az 50 karekterlik açıklama giriniz.");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Lütfen en az 500 karekterlik açıklama bilgisi ekleyiniz.!");
        }
    }
}
