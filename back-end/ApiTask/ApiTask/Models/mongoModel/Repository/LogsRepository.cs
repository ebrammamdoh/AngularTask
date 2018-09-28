using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ApiTask.Models.mongoModel.Repository
{
    public class LogsRepository : ILogsRepository
    {
        private IMongoClient _client;
        private IMongoDatabase _database;
        private IMongoCollection<Logs> _logsCollection;

        public LogsRepository(string connectionString)
        {
            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase("RegistTask");
            _logsCollection = _database.GetCollection<Logs>("logs");
        }
        public async Task<bool> Add(Logs log)
        {
            await _logsCollection.InsertOneAsync(log);
            return true;
        }
    }
}