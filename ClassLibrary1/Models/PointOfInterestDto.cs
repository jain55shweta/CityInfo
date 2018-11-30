﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Models
{
    public class PointOfInterestDto
    {
        public PointOfInterestDto()
        {
        }

        public PointOfInterestDto(string name)
        {
            Name = name;
        }

        public String Name { get; set; }
        public int Id { get; set; }
       
    }
}
