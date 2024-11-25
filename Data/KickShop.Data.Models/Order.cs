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
            CustomerOrders = new List<CustomerOrder>();
            IsDeleted = false;
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
        [Comment("The Billing Name Of The Order")]
        [Required]
        public string BillingName { get; set; }
        [Comment("The Billing Address Of The Order")]
        [Required]
        public string BillingAddress { get; set; }
        [Comment("The Billing City Of The Order")]
        [Required]
        public string BillingCity { get; set; }
        [Comment("The Billing PostCode Of The Order")]
        [Required]
        public string BillingPostalCode { get; set; }
        [Comment("Soft Delete Property")]
        [Required]
        public bool IsDeleted { get; set; }
        public List<CustomerOrder> CustomerOrders { get; set; }
    }
}
