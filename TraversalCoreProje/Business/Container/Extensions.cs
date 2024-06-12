using Business.Abstract;
using Business.Abstract.UOW;
using Business.Concrete;
using Business.Concrete.UOW;
using Business.ValidationRules;
using Business.ValidationRules.ContactUsValidationRules;
using Data.Abstract;
using Data.Concrete.EntityFramwork;
using Data.Uow;
using DTO.DTOs.AnnoucementDTOs;
using DTO.DTOs.ContactUsDTOs;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCoreCommentDal>();
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfCoreAppUserDal>();
            services.AddScoped<IGuideService, GuideManager>();
            services.AddScoped<IGuideDal,EfCoreGuideDal>();
            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IDestinationDal,EfCoreDestinationDal>();

            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IReservationDal, EfCoreReservationDal>();


            services.AddScoped<IExcelService, ExcelManager>();
            services.AddScoped<IPdfService, PdfManager>();  

            services.AddScoped<IContactUsService, ContactUsManager>();
            services.AddScoped<IContactUsDal, EfCoreContactUsDal>();




            services.AddScoped<IAnnoucementService,AnnoucementManager>();
            services.AddScoped<IAnnoucementDal, EfCoreAnnoucementDal>();



            services.AddScoped<IAccountService, AccountManager>();
            services.AddScoped<IAccountDal, EfAccountDal>();

            services.AddScoped<IUowDal, UowDal>();
        }
        public static void CustomerValidator(this IServiceCollection services)
        {
           services.AddTransient<IValidator<AnnoucementAddDTOs>, AnnoucementValidator>();
            services.AddTransient<IValidator<SendMessageDTO>,SendContactUsValidator>();
        }
    }
}
