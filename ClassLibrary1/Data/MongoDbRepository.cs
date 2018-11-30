using System;
using System.Collections.Generic;
using CityInfo.Entity;
using CityInfo.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CityInfo.service
{
    public class MongoDbRepository:IDataRepository
    {
        private IMongoDatabase _database;
        public IMongoCollection<Mail> MailCollection
        {
            get
            {
                return _database.GetCollection<Mail>("mail");
            }
        }
        public MongoDbRepository()
        {
          //  _context = new Context(settings);
        }

        public void Save(MailDto data)
        {
            var entity = new Mail(data.Subject, data.Subject, data._mailFrom, data._mailTo);
           
            MailCollection.InsertOne(entity);
            // _context.Mails.InsertOne(entity);
        }
        
        public List<Mail> GetAll()
        {
            //  return _context.Mails.Find(_=>true).ToList();
            //List<Mail> mail = new List<Mail> { };
            var data = MailCollection.Find(new BsonDocument()).ToList();
            return data;
        }
    }
}

