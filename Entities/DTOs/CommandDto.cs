using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class CommandDto
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public bool? IsDeleted { get; set; }
        public string Content { get; set; }

        public int UserId { get; set; }
		public int ProductId { get; set; }
		public UserDto? User { get; set; }
        public Product? Products { get; set; }

    }
}
