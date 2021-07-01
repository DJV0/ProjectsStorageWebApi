using AutoMapper;
using Projects.DAL.Models;
using Projects.WebAPI.Models.DTOs;

namespace Projects.WebAPI.Mapping
{
    public class ProjectProfile : Profile
    {
        public ProjectProfile()
        {
            CreateMap<ProjectDTO, Project>();
            CreateMap<Project, BLL.Entities.ProjectInfo>();
        }
    }
}
