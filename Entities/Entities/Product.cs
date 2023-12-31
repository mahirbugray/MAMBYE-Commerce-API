using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public int Stock {  get; set; }
        public decimal Price {  get; set; }
        public string ThumbnailImage { get; set; }
        public string ContentImage { get; set; }
        public string ContentImage2 { get; set; }
        public string ContentImage3 { get; set; }
        public string ContentImage4 { get; set; }
        public int Point { get; set; }

        //Relation
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Command> Commands { get; set; }
    }
}
