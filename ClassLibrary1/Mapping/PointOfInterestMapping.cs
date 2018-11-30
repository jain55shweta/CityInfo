using CityInfo.Entity;
using CityInfo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityInfo.Service.Mapping
{
    class PointOfInterestMapping
    {
        public PointOfInterest FromPointOFInterestModelToPointOfInterestEntity(PointOfInterestDto pointOfInterestDto)
        {
            return new PointOfInterest(pointOfInterestDto.Name);

        }

        public PointOfInterestDto FromPointOFInterestEntityToPointOFInterestModel(PointOfInterest pointOfInterestEntity)
        {
            return new PointOfInterestDto(pointOfInterestEntity.Name);
        }
    }
}
