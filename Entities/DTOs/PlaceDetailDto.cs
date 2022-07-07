using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class PlaceDetailDto:IDto
    {
        public int PlaceId { get; set; }
        public string PlaceName { get; set; }
        public string MenuCategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
