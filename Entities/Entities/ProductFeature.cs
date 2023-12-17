using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class ProductFeature : BaseEntity
    {
        public string Key { get; set; }
        public string value { get; set; }
        public int ProductId { get; set; }

        //Relation
        public virtual Product Product { get; set; }
    }
}
