namespace KickShop.Common
{
    public static class ModelConstants
    {
        public static class Brand
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 100;

            public const int CountryMinLength = 3;
            public const int CountryMaxLength = 100;

            public const int AddressMinLength = 5;
            public const int AddressMaxLength = 100;

            public const int PhoneNumberMinLength = 5;
            public const int PhoneNumberMaxLength = 20;

            public const int ImageUrlMinLength = 5;
            public const int ImageUrlMaxLength = 200;
        }
        public static class CartItem
        {
            public const int QuantityRangeMin = 1;
            public const int QuantityRangeMax = 999;
        }
        public static class Category
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 50;

            public const int ImageUrlMinLength = 5;
            public const int ImageUrlMaxLength = 200;
        }
        public static class Order
        {
            public const int TotalAmountMin = 0;
            public const int TotalAmountMax = 99999;

            public const string DateTimeFormat = "yyyy/MM/dd HH:mm";
        }
        public static class Product
        {
            public const int NameMinLength = 5;
            public const int NameMaxLength = 100;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 1000;

            public const int PriceRangeMin = 0;
            public const int PriceRangeMax = 9999;

            public const int QuantityRangeMin = 0;
            public const int QuantityRangeMax = 1000;

            public const int ImageUrlMinLength = 5;
            public const int ImageUrlMaxLength = 200;
        }
        public static class ShoppingCart
        {
            public const string DateTimeFormat = "yyyy/MM/dd HH:mm";
        }
    }
}
