using AutoMapper;
using Projects.DAL.Models;
using Projects.WebAPI.Models.DTOs;

namespace Projects.WebAPI.Mapping
{
    public class TaskProfile : Profile
    {
        public TaskProfile()
        {
            CreateMap<TaskDTO, Task>();
            CreateMap<TaskState, BLL.Entities.TaskState>();
        }
    }
}
