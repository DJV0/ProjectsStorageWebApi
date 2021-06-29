using AutoMapper;
using Projects.DAL.Models;
using Projects.WebAPI.Models.DTOs;

namespace Projects.WebAPI.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDTO, User>();
        }
    }
}
