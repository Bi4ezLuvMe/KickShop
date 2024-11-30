using KickShop.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KickShop.Models
{
    public class ProductSize
    {
        public ProductSize()
        {
            ProductSizeId = Guid.NewGuid();
        }
        [Comment("The Unique Identifier")]
        [Key]
        public Guid ProductSizeId { get; set; }
        [Comment("Foreign Key To The Product Model")]
        [Required]
        public Guid ProductId { get; set; }
        [Comment("The Product")]
        public Product Product { get; set; } = null!;
        [Comment("The Size")]
        [Required]
        public Sizes Size { get; set; }
        [Comment("The Quantity Of The Sizes")]
        public int Quantity { get; set; }
    }
}
