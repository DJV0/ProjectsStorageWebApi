using AutoMapper;
using Projects.DAL.Models;
using Projects.WebAPI.Models.DTOs;

namespace Projects.WebAPI.Mapping
{
    public class TeamProfile : Profile
    {
        public TeamProfile()
        {
            CreateMap<TeamDTO, Team>();
            CreateMap<Team, BLL.Entities.Team>()
        }
    }
}
