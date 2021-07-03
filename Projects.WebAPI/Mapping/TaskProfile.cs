using AutoMapper;
using Projects.DAL.Entities;
using Projects.WebAPI.Models.DTOs;

namespace Projects.WebAPI.Mapping
{
    public class TaskProfile : Profile
    {
        public TaskProfile()
        {
            CreateMap<TaskDTO, Task>();
        }
    }
}
