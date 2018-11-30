using CityInfo.Entity;
using CityInfo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityInfo.Service.Mapping
{
    class CityMapping
    {
        public City FromCityModelToCityEntity(CityDto cityDto)
        {
            return new City(cityDto.Name, cityDto.Description,cityDto.PointsOfInterest);


        }

        public CityDto FromCityEntityToCityModel(City cityEntity)
        {
            return new CityDto(cityEntity.Name, cityEntity.Description,cityEntity.PointsOfInterest);
        }
    }
}
