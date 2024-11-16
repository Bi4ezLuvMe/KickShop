using KickShop.Common;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KickShop.Models
{
    public class CartItem
    {
        public CartItem()
        {
            CartItemId = Guid.NewGuid();
        }
        [Comment("The Unique Indentifier")]
        [Key]
        public Guid CartItemId { get; set; }
        [Comment("Foreign Key To The ShoppingCart Entity")]
        [Required]
        public Guid ShoppingCartId { get; set; }
        [Comment("The Shopping Cart")]
        [Required]
        [ForeignKey("ShoppingCartId")]
        public ShoppingCart ShoppingCart { get; set; } = null!;
        [Comment("Foreign Key To The Product Entity")]
        [Required]
        public Guid ProductId { get; set; } 
        [Comment("The Product To Be Added")]
        [ForeignKey("ProductId")]
        [Required]
        public Product Product { get; set; } = null!;
        [Comment("The Quantity Of The Product")]
        [Required]
        [Range(ModelConstants.CartItem.QuantityRangeMin, ModelConstants.CartItem.QuantityRangeMax)]
        public int Quantity { get; set; }
        [Comment("The Selected Size Of The Product")]
        [Required]
        public string Size { get; set; }
    }
}
