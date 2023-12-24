using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class CardDto
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public decimal TotalPrice { get; set; }
        public int UserId { get; set; }

        //Relation
        public List<CardLine> CardLines { get; set; }
    }
}
