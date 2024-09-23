﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    public class Image
    {
        public int Id { get; set; }

        [Required] 
        public string Url { get; set; }

        public int ProuductId { get; set; }

        public required product product { get; set; }
    }
}
