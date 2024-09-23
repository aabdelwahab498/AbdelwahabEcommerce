using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Enums
{
    internal enum OrderStatus
    {
        pendding=0,
        Approved=1,
        Delivered=2,
        Shipped=3,
        Canceled=4,
    }
}
