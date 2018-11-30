using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.Entity;
using CityInfo.service;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CityInfo.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class MailController : ControllerBase
    {
        private IMongoDatabase _database;
        public IMongoCollection<Mail> MailCollection;

        public MailController()
        {

            var client = new MongoClient("mongodb://localhost:27017");
            if (client != null)
            {
                _database = client.GetDatabase("test");
                MailCollection = _database.GetCollection<Mail>("mail");
            }

        }

        [HttpGet]
        public IActionResult Get()

        {
            //return Ok("Shweta");
            // var data= _mailservice.Receive();

            //var data = new IList<Mails> (Mails.Find(_ => true).ToList());

            IList<Mail> mailsList = new List<Mail>();

            mailsList = MailCollection.Find(new BsonDocument()).ToList();

            var data = MailCollection.Find(new BsonDocument()).ToList();
            return Ok(data);
            return new JsonResult(MailCollection.Find(_=>true).ToList());
        }
        //POST api/mail
        [HttpPost]
        public IActionResult Insert([FromBody] Mail data)
        {
           // var data= new Mail("subject", "mess", "mailfrom", "mailto");
            MailCollection.InsertOne(data);

            return Ok("data inserted");
        }
    }
}