using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules.ContactUs
{
    public class SendContactUsValidator:AbstractValidator<SendMessageDTO>
    {
        public SendContactUsValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Alanı Boş geçilemez");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Alanı Boş geçilemez");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Alanı Boş geçilemez");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Mesaj Alanı Boş geçilemez");
         
        }
    }
}
