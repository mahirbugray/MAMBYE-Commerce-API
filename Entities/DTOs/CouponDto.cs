using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class CouponDto
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public int UserId { get; set; }
        public int Discount { get; set; }
        public string Description { get; set; }
        public DateTime GivenDate { get; set; } = DateTime.Now;
    }
}
