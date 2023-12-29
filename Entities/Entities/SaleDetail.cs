using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class SaleDetail : BaseEntity
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int ProductId { get; set; }
        public int SaleId { get; set; }
 

        //Relation
        public Product Products { get; set; }
        public Sale Sale { get; set; }
    }
}
