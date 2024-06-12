using AutoMapper;
using DTO.DTOs.AnnoucementDTOs;
using DTO.DTOs.AppUserDTOs;
using DTO.DTOs.ContactUsDTOs;
using Entity;

namespace TraversalCoreProje.Mapping.AutoMapProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AnnoucementAddDTOs,Annoucement>();
            CreateMap<Annoucement,AnnoucementAddDTOs>();
 
            CreateMap<AppUserRegisterDTOs, AppUser>();
            CreateMap<AppUser, AppUserRegisterDTOs>();

            CreateMap<AppUserLoginDTOs, AppUser>();
            CreateMap< AppUser,AppUserLoginDTOs>();
           
            CreateMap<AnnoucementListDTO, Annoucement>();
            CreateMap<Annoucement, AnnoucementListDTO>();

            CreateMap<AnnoucementUpdateDto, Annoucement>();
            CreateMap<Annoucement, AnnoucementUpdateDto>();

            CreateMap<SendMessageDTO, ContactUs>();
            CreateMap<ContactUs,SendMessageDTO>();
        }
    }
}
