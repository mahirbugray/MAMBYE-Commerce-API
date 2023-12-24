using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class CardLineDto
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public int Price { get; set; }
        public int ProductId { get; set; }
        public int CardId { get; set; }

        //Relation
        public Card Card { get; set; }
        public Product Product { get; set; }
    }
}
