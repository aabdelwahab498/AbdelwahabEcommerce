using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    public class product
    {
        public int Id { get; set; }  // Primary Key
        public string Name { get; set; }  // Product Name
        public string Description { get; set; }  // Detailed description
        public Double Price { get; set; }  // Product Price
        public int StockQuantity { get; set; }  // Available stock quantity
        public DateTime CreatedDate { get; set; }  // Date product was added
        public DateTime? UpdatedDate { get; set; }  // Date product was last updated (nullable)

        // Category relationship (assuming each product belongs to a category)
       
        public int CategoryId { get; set; }  // Foreign Key to Category
        public Catagory Category { get; set; }  // Navigation property

        // Supplier relationship (optional)
        public int? SupplierId { get; set; }  // Foreign Key to Supplier (nullable)
        // List of product tags or attributes (e.g., color, size)
        // Images for the product
        public ICollection<Image> Images { get; set; }

        // Reviews for the product

        public ICollection<Review> Reviews { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }

    }
}
