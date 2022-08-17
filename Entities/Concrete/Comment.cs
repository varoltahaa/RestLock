using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Comment:IEntity
    {
        public int CommentId { get; set; }
        public int PlaceId { get; set; }
        public string UserName { get; set; }
        public string EMail { get; set; }
        public string Comments { get; set; }
        public DateTime Date { get; set; }
    }

    
}
