using ApiTask.Models.mongoModel.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTask.Models.mongoModel
{
    public class MongoDbEntities : LogsRepository
    {
        public MongoDbEntities(string connectionString)
            :base(connectionString)
        {

        }
    }
}