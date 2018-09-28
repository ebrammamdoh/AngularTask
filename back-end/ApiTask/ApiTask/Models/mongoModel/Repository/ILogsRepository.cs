using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTask.Models.mongoModel.Repository
{
    public interface ILogsRepository
    {
        Task<bool> Add(Logs entity);
    }
}
