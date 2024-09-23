using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
   public class Review
    {
        public int Id { get; set; }

        public int rating  { get; set; }
        
        [Required,MaxLength(1000)]
        public string Comment { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public int ProductId { get; set; }
        public product product { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }


        

        


    }
}
