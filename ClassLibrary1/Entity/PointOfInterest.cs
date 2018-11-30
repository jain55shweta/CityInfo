using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Entity
{
    public class PointOfInterest
    {
        public PointOfInterest(string name)
        {
            Name = name;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public String Name { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }

    }
}
 