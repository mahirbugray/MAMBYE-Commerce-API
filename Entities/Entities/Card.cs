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
        private List<CardLine> cardLines = new List<CardLine>();
        public List<CardLine> CardLines => cardLines;
    }
}
