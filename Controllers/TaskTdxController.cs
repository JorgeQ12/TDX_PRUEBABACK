using TdxBackend.Utilities;
using Microsoft.AspNetCore.Mvc;
using TdxBackend.Application.Services.Interfaces;
using TdxBackend.Domain.Entities;
using TdxBackend.DTOs;

namespace TdxBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskTdxController : Controller
    {
        private readonly ITaskTdxServices _TaskTdxServices;
        public TaskTdxController(ITaskTdxServices taskTdxServices)
        {
            _TaskTdxServices = taskTdxServices;
        }

        ///<summary>
        ///Traer Tareas
        ///</summary>
        [HttpGet]
        [Route(nameof(TaskTdxController.GetTask))]
        public ResultResponse<List<TaskTdx>> GetTask() => _TaskTdxServices.GetTask();

        ///<summary>
        ///Traer Estados
        ///</summary>
        [HttpGet]
        [Route(nameof(TaskTdxController.GetStateTask))]
        public ResultResponse<List<StateTask>> GetStateTask() => _TaskTdxServices.GetStateTask();

        ///<summary>
        ///Crear Tareas 
        ///</summary>
        [HttpPost]
        [Route(nameof(TaskTdxController.InsertTask))]
        public ResultResponse<string> InsertTask(TaskTdxDTO taskTdx) => _TaskTdxServices.InsertTask(taskTdx);

        ///<summary>
        ///Actualizar Tarea
        ///</summary>
        [HttpPut]
        [Route(nameof(TaskTdxController.UpdateTask))]
        public ResultResponse<string> UpdateTask(UpdateTaskDTO updateTask) => _TaskTdxServices.UpdateTask(updateTask);

        ///<summary>
        ///Eliminar Tareas
        ///</summary>
        [HttpDelete("DeleteTask/{idTask}")]
        public ResultResponse<string> DeleteTask(Guid idTask) => _TaskTdxServices.DeleteTask(idTask);


    }
}
