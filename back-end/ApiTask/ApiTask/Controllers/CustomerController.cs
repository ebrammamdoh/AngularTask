using ApiTask.Models.BL.UnitOfWork;
using ApiTask.Models.DataBaseModel;
using ApiTask.Models.mongoModel;
using ApiTask.Models.Utilities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApiTask.Controllers
{
    public class CustomerController : ApiController
    {
        UnitOfWork uow = new UnitOfWork(new TaskEntities(), new MongoDbEntities("mongodb://localhost:27017"));
        
        [HttpGet]
        public IEnumerable<customer> Get()
        {
            return uow.Customers.GetAll();
        }
        [HttpPost]
        public IEnumerable<customer> Add([FromBody]customer entity)
        {
            Email.Send(entity.email, entity.firstName + " " + entity.lastName, "Thanks for registration.");
            uow.Customers.Add(entity);
            uow.Complete();
            return Get();
        }
        [HttpPut]
        public async Task<customer> Put([FromBody]customer entity)
        {
            customer cust = uow.Customers.Get(entity.customerId);
            cust.firstName = entity.firstName;
            cust.lastName = entity.lastName;
            cust.email = entity.email;
            cust.mobile = entity.mobile;
            cust.jobDescription = cust.jobDescription;
            if (uow.Complete() > 0)
            {
                return cust;
            }
            else
                return new customer();
        }
        [HttpDelete]
        public IEnumerable<customer> Delete(int id)
        {
            customer entity = uow.Customers.Get(id);
            uow.Customers.Remove(entity);
            uow.Complete();
            return Get();
        }

    }
}
