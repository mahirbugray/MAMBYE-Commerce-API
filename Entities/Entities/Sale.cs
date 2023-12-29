using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Sale : BaseEntity
    {
        public decimal TotalPrice { get; set; }
        public int TotalQuantity { get; set; }
        public int UserId { get; set;}
        public string City { get; set; }
        //public string Country { get; set; }
        public string Neighbourhood { get; set; }
        public string ZipCode { get; set; }
        public string AptNumber { get; set; }
        public string CardOwner { get; set; }
        public string CardNumber { get; set; }

        //Relation
        public List<SaleDetail> SaleDetails { get; set; }
    }
}
