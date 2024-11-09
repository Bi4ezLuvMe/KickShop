using KickShop.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace KickShop.Models
{
    public class Order
    {
        public Order()
        {
            OrderId = Guid.NewGuid();
            OrderDate = DateTime.Now.ToString(ModelConstants.Order.DateTimeFormat);
        }
        [Comment("The Unique Identifier")]
        [Key]
        public Guid OrderId { get; set; }
        [Comment("The Date When The Order Was Placed")]
        public string OrderDate { get; set; }
        [Comment("The Total Amount Of The Order")]
        [Required]
        [Range(ModelConstants.Order.TotalAmountMin, ModelConstants.Order.TotalAmountMax)]
        public decimal TotalAmount { get; set; }
    }
}
