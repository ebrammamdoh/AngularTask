using ApiTask.Models.DataBaseModel;
using ApiTask.Models.mongoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTask.Models.BL.Customer
{
    public class CustomerRepository : Repository<customer> , ICustomerRepository  
    {
        public CustomerRepository(TaskEntities context, MongoDbEntities mongodb)
            :base(context, mongodb)
        {

        }
    }
}