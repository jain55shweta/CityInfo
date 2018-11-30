using CityInfo.Entity;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityInfo.Service.Data
{
    class Context
    {
        private IMongoDatabase _database;
        

        public Context()
        {

            var client = new MongoClient("mongodb://localhost:27017");
            if (client != null)
            {
                _database = client.GetDatabase("test");
              
            }

        }
        public IMongoCollection<Mail> MailCollection
        {
            get
            {
                return _database.GetCollection<Mail>("mail");
            }
        }
        public IMongoCollection<City> CityCollection
        {
            get
            {
                return _database.GetCollection<City>("city");
            }
        }
        public IMongoCollection<PointOfInterest> PointOfInterestCollection
        {
            get
            {
                return _database.GetCollection<PointOfInterest>("point_of_interest");
            }
        }
    }
}
