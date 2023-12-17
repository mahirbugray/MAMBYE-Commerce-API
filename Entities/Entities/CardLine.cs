using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class CardLine : BaseEntity
    {
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
        public int Price { get; set; }
        public int ProductId { get; set; }
        public int CardId { get; set; }

        //Relation
        public Card Card { get; set; }
        public Product Product { get; set; }
    }
}
