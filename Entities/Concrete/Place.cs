using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity.Spatial;
using Core.Entities;

namespace Entities.Concrete
{
    public class Place:IEntity
    {
        public int PlaceId { get; set; }
        public int UserId { get; set; }
        public int PlaceCategoryId { get; set; }
        public string PlaceName { get; set; }
        public string PlacePhoneNumber { get; set; }
        //public DbGeography PlaceAddress { get; set; } ???
        public string PlaceAddress { get; set; }
        public TimeSpan OpenTime { get; set; }
        public TimeSpan CloseTime { get; set; }
        public string Description { get; set; }

    }
}
