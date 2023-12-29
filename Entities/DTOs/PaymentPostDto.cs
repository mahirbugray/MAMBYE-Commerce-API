using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class PaymentPostDto
    {
        public List<SaleDetailDto> cardLines { get; set; }
        public decimal totalPrice { get; set; }
        public string city { get; set; }
        public string neighbourhood { get; set; }
        public string aptNo { get; set; }
        public string postCode { get; set; }
        public string cardNo { get; set; }
        public string cardName { get; set; }
        public string cardMounth { get; set; }
        public string cardYear { get; set; }
        public string cardCvv { get; set; }
    }
}
