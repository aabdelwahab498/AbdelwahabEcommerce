using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    public class Catagory
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public required string Name { get; set; }

        public virtual required ICollection<product> Products { get; set; }  // Navigation property to Products

    }
}