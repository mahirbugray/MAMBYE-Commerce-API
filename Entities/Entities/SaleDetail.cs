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
        public int Price { get; set; }
        public int ProductId { get; set; }
        public int SaleId { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Neighbourhood { get; set; }
        public string ZipCode { get; set; }
        public string AptNumber { get; set; }
        public string CardOwner { get; set; }
        public string CardNumber { get; set; }

        //Relation
        public Product Products { get; set; }
        public Sale Sale { get; set; }
    }
}
