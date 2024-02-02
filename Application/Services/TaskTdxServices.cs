using AutoMapper;
using System.Collections.Generic;
using TdxBackend.Application.Services.Interfaces;
using TdxBackend.Domain.Entities;
using TdxBackend.Domain.Services.Interfaces;
using TdxBackend.DTOs;
using TdxBackend.Resources;
using TdxBackend.Utilities;
using TdxBackend.Validators;

namespace TdxBackend.Application.Services
{
    public class TaskTdxServices : ITaskTdxServices
    {
        private readonly IMapper _mapper;
        private readonly ITaskTdxDomain _TaskTdxDomain;
        private readonly GlobalValidator _globalValidator;

        public TaskTdxServices(ITaskTdxDomain taskTdxDomain, GlobalValidator globalValidator, IMapper mapper )
        {
            _TaskTdxDomain = taskTdxDomain;
            _globalValidator = globalValidator;
            _mapper = mapper;
        }

        ///<summary>
        ///Traer Tareas
        ///</summary>
        public ResultResponse<List<TaskTdx>> GetTask()
        {
            try
            {
                List<TaskTdx> tasks = _TaskTdxDomain.GetTask();

                if(tasks != null)
                {
                    return new ResultResponse<List<TaskTdx>>(true, tasks);
                }

                return new ResultResponse<List<TaskTdx>>(true, GlobalResponses.NoFoundTask);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        ///<summary>
        ///Traer Estados
        ///</summary>
        public ResultResponse<List<StateTask>> GetStateTask()
        {
            try
            {
                List<StateTask> stateTasks = _TaskTdxDomain.GetStateTask();

                if (stateTasks != null)
                {
                    return new ResultResponse<List<StateTask>>(true, stateTasks);
                }

                return new ResultResponse<List<StateTask>>(true, GlobalResponses.NoFoundStateTask);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        ///<summary>
        ///Crear Tareas 
        ///</summary>
        public ResultResponse<string> InsertTask(TaskTdxDTO taskTdx)
        {
            try
            {
                var validationErrors = _globalValidator.ValidateTask(taskTdx);
                if (validationErrors != null)
                {
                    return validationErrors;
                }

                _TaskTdxDomain.InsertTask(_mapper.Map<TaskTdxDTO, TaskTdx>(taskTdx));

                return new ResultResponse<string>(true, GlobalResponses.InsertTask);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        ///<summary>
        ///Actualizar Tarea
        ///</summary>
        public ResultResponse<string> UpdateTask(UpdateTaskDTO updateTask)
        {
            try
            {
                var validationErrors = _globalValidator.ValidateUpdateTask(updateTask);
                if (validationErrors != null)
                {
                    return validationErrors;
                }

                TaskTdx taskTdx = _TaskTdxDomain.GetTaskById(updateTask.IDDTO);
                _TaskTdxDomain.UpdateTask(_mapper.Map(updateTask, taskTdx));

                return new ResultResponse<string>(true, GlobalResponses.UpdateTask);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        ///<summary>
        ///Eliminar Tareas
        ///</summary>
        public ResultResponse<string> DeleteTask(Guid idTask)
        {
            try
            {
                if (idTask.Equals(Guid.Empty))
                {
                    return new ResultResponse<string>(false, GlobalResponses.IdNoGuidNull);
                }

                TaskTdx taskTdx = _TaskTdxDomain.GetTaskById(idTask);
                _TaskTdxDomain.DeleteTask(taskTdx);

                return new ResultResponse<string>(true, GlobalResponses.DeleteTask);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
