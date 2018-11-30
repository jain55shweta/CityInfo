using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.Entity;
using CityInfo.Models;

namespace CityInfo.service
{
    public interface IDataRepository
    {
        List<Mail> GetAll();
        void Save(MailDto data);
    }
}
