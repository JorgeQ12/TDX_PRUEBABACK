using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TdxBackend.Resources
{
    public class GlobalResponses
    {

        public const string NoFoundTask = "No existen Tareas";
        public const string NoFoundStateTask = "No existen Estados";
        public const string IdNoGuidNull = "El Id debe ser diferente a un Guid Vacio";
        public const string TextNotNull = "El campo de texto no puede ser vacio";

        public const string InsertTask = "Tarea Creada Correctamente";
        public const string UpdateTask = "Tarea Actualizada Correctamente";
        public const string DeleteTask = "Tarea Eliminada Correctamente";

    }
}
