using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class PlaceCategory:IEntity
    {
        public int PlaceCategoryId { get; set; }
        public string Name { get; set; }
    }
}
