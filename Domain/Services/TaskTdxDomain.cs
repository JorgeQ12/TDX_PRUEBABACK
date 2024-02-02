using TdxBackend.Domain.Entities;
using TdxBackend.Domain.Services.Interfaces;

namespace TdxBackend.Domain.Services
{
    public class TaskTdxDomain : ITaskTdxDomain
    {
        private readonly DbContextTdx _context;
        public TaskTdxDomain(DbContextTdx context)
        {
            _context = context;
        }

        ///<summary>
        ///Traer Tareas
        ///</summary>
        public List<TaskTdx> GetTask()
        {
            try
            {
                return _context.TaskTdx.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        ///<summary>
        ///Traer Estados
        ///</summary>
        public List<StateTask> GetStateTask()
        {
            try
            {
                return _context.StateTask.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        ///<summary>
        ///Traer Tareas depende al Id
        ///</summary>
        public TaskTdx GetTaskById(Guid tasks)
        {
            try
            {
                return _context.TaskTdx.Where(x => x.ID.Equals(tasks)).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        ///<summary>
        ///Crear Tareas 
        ///</summary>
        public TaskTdx InsertTask(TaskTdx taskTdx)
        {
            try
            {
                _context.Add(taskTdx);
                _context.SaveChanges();

                return taskTdx;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        ///<summary>
        ///Actualizar Tarea
        ///</summary>
        public TaskTdx UpdateTask(TaskTdx updateTask)
        {
            try
            {
                _context.Update(updateTask);
                _context.SaveChanges();

                return updateTask;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        ///<summary>
        ///Eliminar Tareas
        ///</summary>
        public TaskTdx DeleteTask(TaskTdx taskDelete)
        {
            try
            {
                _context.Remove(taskDelete);
                _context.SaveChanges();

                return taskDelete;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
