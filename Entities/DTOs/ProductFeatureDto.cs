using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class ProductFeatureDto
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public string Key { get; set; }
        public string value { get; set; }
        public int ProductId { get; set; }

        //Relation
        public virtual Product Product { get; set; }
    }
}
