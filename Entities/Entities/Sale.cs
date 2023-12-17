using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Sale : BaseEntity
    {
        public int TotalPrice { get; set; }
        public int TotalQuantity { get; set; }
        public int UserId { get; set;}

        //Relation
        public List<SaleDetail> SaleDetails { get; set; }
    }
}
