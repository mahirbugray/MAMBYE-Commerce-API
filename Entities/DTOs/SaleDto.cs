using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class SaleDto
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public int TotalPrice { get; set; }
        public int TotalQuantity { get; set; }
        public int UserId { get; set; }

        //Relation
        public List<SaleDetail> SaleDetails { get; set; }
    }
}
