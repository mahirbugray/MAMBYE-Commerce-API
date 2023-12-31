using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Command : BaseEntity
    {
        public string Content { get; set; }
        
        public int UserId { get; set; }
        public int ProductId { get; set; } 
    }
}
