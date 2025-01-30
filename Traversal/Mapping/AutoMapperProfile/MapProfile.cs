using AutoMapper;
using DTOLayer.DTOs.AnnouncementDTOs;
using DTOLayer.DTOs.AppUserDTOs;
using EntityLayer.Concrete;

namespace Traversal.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Announcement, AddAnnouncementDto>().ReverseMap();
            CreateMap<Announcement, ListAnnouncementDto>().ReverseMap();
            CreateMap<Announcement, UpdateAnnouncementDto>().ReverseMap();

            CreateMap<AppUser, AppUserRegisterDTOs>().ReverseMap();
            CreateMap<AppUser, AppUserLoginDTOs>().ReverseMap();
        }
    }
}
