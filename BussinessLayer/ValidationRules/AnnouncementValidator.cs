using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public  class AnnouncementValidator:AbstractValidator<AddAnnouncementDto>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen başlığı boş geçmeyin");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen duyuru içeriğini boş geçmeyin");

            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen 500 karekterden küçük veri girişi yapınız"); 
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("Lütfen 500 karekterden küçük veri girişi yapınız");

            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen 5 karekterden büyük veri girişi yapınız");
            RuleFor(x => x.Content).MinimumLength(5).WithMessage("Lütfen 5 karekterden büyük veri girişi yapınız"); 



        }
    }
}
