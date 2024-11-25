namespace KickShop.ViewModels
{
    public class OrderViewModel
    {
        public Guid OrderId { get; set; }
        public string OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string CustomerEmail { get; set; }
        public string BillingName { get; set; }
        public string BillingAddress { get; set; }
        public string BillingCity { get; set; }
        public string BillingPostalCode { get; set; }
        public string BillingCountry { get; set; }
    }
}
