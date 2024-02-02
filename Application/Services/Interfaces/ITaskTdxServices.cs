using TdxBackend.Utilities;
using TdxBackend.Domain.Entities;
using TdxBackend.DTOs;

namespace TdxBackend.Application.Services.Interfaces
{
    public interface ITaskTdxServices
    {
        ///<summary>
        ///Traer Tareas
        ///</summary>
        ResultResponse<List<TaskTdx>> GetTask();
        ///<summary>
        ///Traer Estados
        ///</summary>
        ResultResponse<List<StateTask>> GetStateTask();

        ///<summary>
        ///Crear Tareas 
        ///</summary>
        ResultResponse<string> InsertTask(TaskTdxDTO taskTdx);

        ///<summary>
        ///Actualizar Tarea
        ///</summary>
        ResultResponse<string> UpdateTask(UpdateTaskDTO updateTask);
        ///<summary>
        ///Eliminar Tareas
        ///</summary>
        ResultResponse<string> DeleteTask(Guid idTask);
    }
}
