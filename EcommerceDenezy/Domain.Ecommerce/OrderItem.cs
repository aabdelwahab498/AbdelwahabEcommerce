using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int orderId {  get; set; }
        public Order Order { get; set; }

        public int ProductId { get; set; }
        public product product { get; set; }

        public int quantity { get; set; }

        public Double unitPrice { get; set; }  
    }
}
