using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    public class Cart
    {
       

        public int Id { get; set; }

        public int UserID { get; set; }

        public User User { get; set; }

        public Double total  { get; set; }
      
        //public Icollection<CartItem>CartItem{get;set}


    }
}
