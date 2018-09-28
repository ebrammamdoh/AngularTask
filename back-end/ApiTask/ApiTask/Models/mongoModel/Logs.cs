using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes; 

namespace ApiTask.Models.mongoModel
{
    public class Logs
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("action")]
        public string Action { get; set; }
        [BsonElement("time")]
        private DateTime time;
        public DateTime Time {
            get { return time; }
            private set { value = DateTime.Now.Date; }
        }
    }
}