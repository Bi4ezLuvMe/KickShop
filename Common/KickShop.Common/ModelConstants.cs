using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KickShop.Common
{
    public static class ModelConstants
    {
        public static class Brand
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 100;
            public const string NameRequiredError = "The Brand Name Is Required!";
            public const string NameMinLengthError = "The Brand Name Is Too Short!";
            public const string NameMaxLengthError = "The Brand Name Is Too Long!";

            public const int CountryMinLength = 3;
            public const int CountryMaxLength = 100;
            public const string CountryRequiredError = "The Brand Country Is Required!";
            public const string CountryMinLengthError = "The Brand Country Is Too Short!";
            public const string CountryMaxLengthError = "The Brand Country Is Too Long!";

            public const int AddressMinLength = 5;
            public const int AddressMaxLength = 100;
            public const string AddressRequiredError = "The Brand Address Is Required!";
            public const string AddressMinLengthError = "The Brand Address Is Too Short!";
            public const string AddressMaxLengthError = "The Brand Address Is Too Long!";

            public const int PhoneNumberMinLength = 5;
            public const int PhoneNumberMaxLength = 20;
            public const string PhoneNumberRequiredError = "The Brand Phone Number Is REquired!";
            public const string PhoneNumberMinLengthError = "The Brand Phone Number Is Too Short!";
            public const string PhoneNumberMaxLengthError = "The Brand Phone Number Is Too Long!";

            public const int ImageUrlMinLength = 5;
            public const int ImageUrlMaxLength = 100;
            public const string ImageRequiredError = "The Brand Image Is Required!";

            public const int DescriptionMaxLength = 1000;
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
            public const string NameRequiredError = "Category Name Is Required!";
            public const string NameMinLengthError = "Category Name Is Too Short!";
            public const string NameMaxLengthError = "Category Name Is Too Long!";

            public const string ImageRequiredError = "Category Image Is Required!";
            public const int ImageUrlMinLength = 5;
            public const int ImageUrlMaxLength = 100;
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
            public const string NameRequiredError = "Product Name Is Required!";
            public const string NameMinLengthError = "Product Name Is Too Short!";
            public const string NameMaxLengthError = "Product Name Is Too Long!";

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 1000;
            public const string DescriptionRequiredError = "Product Description Is Required!";
            public const string DescriptionMinLengthError = "Product Description Is Too Short!";
            public const string DescriptionMaxLengthError = "Product Description Is Too Long!";

            public const int PriceRangeMin = 0;
            public const int PriceRangeMax = 9999;
            public const string InvalidPriceError = "Invalid Price!";

            public const int QuantityRangeMin = 0;
            public const int QuantityRangeMax = 1000;
            public const string InvalidQuantityError = "Invalid Stock Quantity!";

            public const string ImageRequiredError = "Product Image Is Required!";
        }
        public static class ShoppingCart
        {
            public const string DateTimeFormat = "yyyy/MM/dd HH:mm";
        }
        public static class ProductImage
        {
            public const int ImageUrlMinLength = 5;
            public const int ImageUrlMaxLength = 200;
        }
        public static class Account
        {
            public const int PassowordMinLength = 6;
            public const int PasswordMaxLength = 100;
            public const string PassowordMinLengthError = "The Chosen Password Is Too Short!";
            public const string PasswordMaxLengthError = "The Chosen Password Is Too Long!";

            public const string PasswordsDontMatchError = "The Password And Confirmation Password Don't Match!";

        }
        public static class Profile
        {
            public const int UserNameMinLength = 3;
            public const int UserNameMaxLength = 100;
            public const string UserNameRequiredError = "Username Is Required!";
            public const string UserNameMinLengthError = "Username Is Too Short!";
            public const string UserNameMaxLengthError = "UserName Is Too Long!";

            public const string EmailRequiredError = "Email Is Required!";
            public const string InvalidEmailError = "Invalid Email Address!";

            public const int NameMinLength = 5;
            public const int NameMaxLength = 200;
            public const string NameRequiredError = "Name Is Required!";
            public const string NameMinLengthError = "Name Is Too Short!";
            public const string NameMaxLengthError = "Name Is Too Long!";

            public const string InvalidPhoneNumberError = "Invalid Phone Number!";
        }
        public class Common
        {
            public const string ImageFileExtentions = "PNG,JPG,JPEG";
            public const string ImageFileExtentionError = "Please Upload Image With (PNG,JPG or JPEG) File Extention!";
        }
    }
}
