using CityInfo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityInfo.Entity
{
    public class City
    {
        public City(string name, string description, ICollection<PointOfInterestDto> pointsOfInterest)
        {
            Name = name;
            Description = description;
            PointsOfInterest = pointsOfInterest;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
       
        public ICollection<PointOfInterestDto> PointsOfInterest { get; set; }
        = new List<PointOfInterestDto>();

    }
}
