using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Application.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public string? Description { get; set; }

        public string? UserName { get; set; }

        public string? OrderStatus { get; set; }

        public AddressDto? Address { get; set; }
    }
}
