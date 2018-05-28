using AutoMapper;
using ClassLibrary;
using ClassLibrary.DTOS;

namespace BL.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
        }
    }
        
}
