using ApiTask.Models.DataBaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiTask.Models.BL.Customer;
using ApiTask.Models.mongoModel;

namespace ApiTask.Models.BL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TaskEntities _context;
        private readonly MongoDbEntities _mongodb;
        public UnitOfWork(TaskEntities context, MongoDbEntities mongodb)
        {
            _context = context;
            _mongodb = mongodb;
            Customers = new CustomerRepository(_context, _mongodb);
        }

        public ICustomerRepository Customers { get; private set; }

        public int Complete()
        {
           return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}