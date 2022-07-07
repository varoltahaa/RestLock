using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MenuCategory:IEntity
    {
        public int MenuCategoryId { get; set; }
        public string Name { get; set; }
    }
}
