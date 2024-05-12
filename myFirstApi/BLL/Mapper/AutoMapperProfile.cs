using AutoMapper;
using myFirstApi.DTOs;
using myFirstApi.Etities;

namespace myFirstApi.BLL.Mapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserToGetDto>();
            CreateMap<UserToAddDto, User>();
            CreateMap<UserToUpdateDto, User>();
            CreateMap<RoleDto, Role>();
        }
    }
}
