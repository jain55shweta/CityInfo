using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.IO;

namespace CityInfo.Entity
{
    public class Mail
    {
       

        public Mail(string subject, string message, string mailFrom, string mailTo)
        {
            this.Subject = subject;
            this.Message = message;
            _mailFrom = mailFrom;
            _mailTo = mailTo;
        }
        [BsonId]
        public BsonObjectId Id { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string _mailTo { set; get; }
        public string _mailFrom { set; get; }

      
    }
}
