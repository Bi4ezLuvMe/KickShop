namespace KickShop.ViewModels
{
    public class OrderViewModel
    {
        public Guid OrderId { get; set; }
        public string OrderDate { get; set; } = null!;
        public decimal TotalAmount { get; set; }
        public string CustomerEmail { get; set; } = null!;
        public string BillingName { get; set; } = null!;
        public string BillingAddress { get; set; } = null!;
        public string BillingCity { get; set; } = null!;
        public string BillingPostalCode { get; set; } = null!;
    }
}
