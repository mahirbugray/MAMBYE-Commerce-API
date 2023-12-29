using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class SaleDetailDto
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int ProductId { get; set; }
        public int SaleId { get; set; }


        //Relation
        public ProductDto? Products { get; set; }
        public SaleDto? Sale { get; set; }
    }
}
