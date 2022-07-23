﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Menu:IEntity
    {
        public int MenuId { get; set; }
        public int PlaceId { get; set; }
        public int MenuCategoryId { get; set; }
        public string? MenuName { get; set; }
    }
}
