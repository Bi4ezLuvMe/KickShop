using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KickShop.Models
{
    public class CustomerOrder
    {
        public CustomerOrder()
        {
            IsDeleted = false;
        }
        [Comment("Foreign Key To The ASP.NET User Entity. Also Primary Key")]
        [Required]
        public string CustomerId { get; set; } = null!;
        [Comment("The Customer Who Placed The Order")]
        [ForeignKey("CustomerId")]
        [Required]
        public ApplicationUser Customer { get; set; } = null!;
        [Comment("Foreign Key To The Order Entity. Also Primary Key")]
        [Required]
        public Guid OrderId { get; set; }
        [Comment("The Order Which The Customer Placed")]
        [ForeignKey("OrderId")]
        [Required]
        public Order Order { get; set; } = null!;
        [Comment("Soft Delete Property")]
        [Required]
        public bool IsDeleted { get; set; }
    }
}
