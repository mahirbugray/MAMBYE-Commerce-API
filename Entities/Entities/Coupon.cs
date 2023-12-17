using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Coupon : BaseEntity
    {
        public int UserId { get; set; }
        public int Discount { get; set; }
        public string Description { get; set; }
        public DateTime GivenDate { get; set; }
    }
}



//Burayı detaylarını istersek card ile bağlayıp hangi alışverişte kullanılmış onu öğrenebiliriz.