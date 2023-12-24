using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Card : BaseEntity
    {
        public decimal TotalPrice { get; set; }
        public int UserId { get; set; }

        //Relation
        public List<CardLine> CardLines { get; set; }   
    }
}
