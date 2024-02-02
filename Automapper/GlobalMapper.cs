using AutoMapper;
using TdxBackend.Domain.Entities;
using TdxBackend.DTOs;
using TdxBackend.Resources;

namespace TdxBackend.Automapper
{
    public class GlobalMapper : Profile
    {
        public GlobalMapper()
        {
            CreateMap<TaskTdxDTO, TaskTdx>()
                .ForMember(target => target.ID, opt => opt.MapFrom(source => Guid.NewGuid()))
                .ForMember(target => target.TaskName, opt => opt.MapFrom(source => source.TaskNameDTO))
                .ForMember(target => target.TaskDescription, opt => opt.MapFrom(source => source.TaskDescriptionDTO))
                .ForMember(target => target.IdStateTask, opt => opt.MapFrom(source => source.IdStateTaskDTO))
                .ForMember(target => target.DateRegister, opt => opt.MapFrom(source => DateTime.Now));

            CreateMap<UpdateTaskDTO, TaskTdx>()
            .ForMember(target => target.TaskName, opt => opt.MapFrom(source => source.TaskNameDTO))
            .ForMember(target => target.TaskDescription, opt => opt.MapFrom(source => source.TaskDescriptionDTO))
            .ForMember(target => target.IdStateTask, opt => opt.MapFrom(source => source.IdStateTaskDTO));

        }
    }
}
