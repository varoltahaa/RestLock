using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class PlaceImage:IEntity
    {
        [Key]
        public int ImageId { get; set; }
        public int PlaceId { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }

    }
}
