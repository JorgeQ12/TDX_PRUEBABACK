using TdxBackend.Resources;
using TdxBackend.Utilities;
using TdxBackend.Domain.Entities;
using TdxBackend.DTOs;

namespace TdxBackend.Validators
{
    public class GlobalValidator
    {
        public ResultResponse<string> ValidateTask(TaskTdxDTO taskTdx)
        {

            if (taskTdx.IdStateTaskDTO.Equals(Guid.Empty))
            {
                return new ResultResponse<string>(false, GlobalResponses.IdNoGuidNull);
            }
            if (string.IsNullOrWhiteSpace(taskTdx.TaskNameDTO) || string.IsNullOrWhiteSpace(taskTdx.TaskDescriptionDTO))
            {
                return new ResultResponse<string>(false, GlobalResponses.TextNotNull);
            }
            return null;
        }

        public ResultResponse<string> ValidateUpdateTask(UpdateTaskDTO taskTdx)
        {

            if (taskTdx.IDDTO.Equals(Guid.Empty) || taskTdx.IdStateTaskDTO.Equals(Guid.Empty))
            {
                return new ResultResponse<string>(false, GlobalResponses.IdNoGuidNull);
            }
            if (string.IsNullOrWhiteSpace(taskTdx.TaskNameDTO) || string.IsNullOrWhiteSpace(taskTdx.TaskDescriptionDTO))
            {
                return new ResultResponse<string>(false, GlobalResponses.TextNotNull);
            }
            return null;
        }
    }
}
