using KickShop.ViewModels.Order;

public class CheckoutSummaryViewModel
{
    public int ProductCount { get; set; }
    public decimal TotalPrice { get; set; }
    public BillingAddressViewModel BillingAddress { get; set; } = null!;
}
