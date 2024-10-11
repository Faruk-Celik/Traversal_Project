using AutoMapper;
using DTOLayer.DTOs.AnnouncementDTOs;
using DTOLayer.DTOs.ApUserDTOs;
using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrete;

namespace TraversalCoreProje.Mapping.AutoMapperProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<AddAnnouncementDto, Announcement>(); 
            CreateMap<Announcement,AddAnnouncementDto>();
            CreateMap<AnnouncementListDto, Announcement>();
            CreateMap<Announcement, AnnouncementListDto>();

            CreateMap<AppUserRegisterDTOs, AppUser>(); 
            CreateMap<AppUser,AppUserRegisterDTOs>();

            CreateMap<AppUserLoginDTOs, AppUser>(); 
            CreateMap<AppUser, AppUserLoginDTOs>(); 

            CreateMap<UpdateAnnouncementDto,Announcement>().ReverseMap();
           
            CreateMap<SendMessageDTO,ContacUs>().ReverseMap();

        }
    }
}
