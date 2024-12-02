public class OrderConfirmationViewModel
{
    public Guid OrderId { get; set; }
    public string OrderDate { get; set; } = null!;
    public decimal TotalAmount { get; set; }
}
