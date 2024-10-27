namespace KickShop.ViewModels
{
    public class CartViewModel
    {
        public CartViewModel()
        {
            CartItems = new List<CartItemViewModel>();
        }
        public required List<CartItemViewModel> CartItems { get; set; }
        public required decimal CartTotal { get; set; }
    }
}
