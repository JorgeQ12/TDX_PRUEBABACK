using TdxBackend.Domain.Entities;
using TdxBackend.DTOs;
using TdxBackend.Utilities;

namespace TdxBackend.Domain.Services.Interfaces
{
    public interface ITaskTdxDomain
    {
        ///<summary>
        ///Traer Tareas
        ///</summary>
        List<TaskTdx> GetTask();
        ///<summary>
        ///Traer Estados
        ///</summary>
        List<StateTask> GetStateTask();
        ///<summary>
        ///Traer Tareas depende al Id
        ///</summary>
        TaskTdx GetTaskById(Guid tasks);

        ///<summary>
        ///Crear Tareas 
        ///</summary>
        TaskTdx InsertTask(TaskTdx taskTdx);

        ///<summary>
        ///Actualizar Tarea
        ///</summary>
        TaskTdx UpdateTask(TaskTdx updateTask);
        ///<summary>
        ///Eliminar Tareas
        ///</summary>
        TaskTdx DeleteTask(TaskTdx taskDelete);
    }
}
