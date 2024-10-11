using BussinessLayer.Abstract;
using BussinessLayer.Abstract.AbstractUow;
using BussinessLayer.Concrete;
using BussinessLayer.Concrete.UowConcrete;
using BussinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.UnitOfWork;
using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace BussinessLayer.Container
{
    public static class Extensions
    {
        public static void ContanierDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCommentDal>();
            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IDestinationDal, EfDestinationDal>();
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();
            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IReservationDal, EfReservationDal>();

            services.AddScoped<IGuideService, GuideManage>();
            services.AddScoped<IGuideDal, EfGuideDal>();

            services.AddScoped<IContactUsService, ContactUsManager>();
            services.AddScoped<IContactUsDal, EfContactUsDal>(); 
            
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();   
            services.AddScoped<IAnnouncementService,AnnouncementManager>();  

            services.AddScoped<IAccountService,AccountManager>(); 
            services.AddScoped<IAccountDal,EfAccountDal>(); 

            services.AddScoped<IUowDal,UowDal>();
        } 

        public static void CustomerValidator(this  IServiceCollection services)
        {
            services.AddTransient<IValidator<AddAnnouncementDto>, AnnouncementValidator>();

        }
    }
}
