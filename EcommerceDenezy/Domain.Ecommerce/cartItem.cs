using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
   public class CartItem

    {

        public int Id { get; set; }

        public int CartID { get; set; }
        public int Cart { get; set; }

        public int ProductId{ get; set; }
        public int Product { get; set; }

        public int quantity{ get; set; }


       
    }
}
