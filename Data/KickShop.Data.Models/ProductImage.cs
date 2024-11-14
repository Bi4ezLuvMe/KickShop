using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using KickShop.Models;
using Microsoft.EntityFrameworkCore;
using KickShop.Common;

public class ProductImage
{
    public ProductImage()
    {
        ImageId = Guid.NewGuid();
    }
    [Comment("The Unique Identifier")]
    [Key]
    public Guid ImageId { get; set; }

    [Comment("The Url To The Image")]
    [MinLength(ModelConstants.ProductImage.ImageUrlMinLength)]
    [MaxLength(ModelConstants.ProductImage.ImageUrlMaxLength)]
    [Required]
    public string ImageUrl { get; set; }

    [Comment("Foreign Key To The Product Entity To Which The Picture Belongs")]
    [Required]
    public Guid ProductId { get; set; }

    [Comment("The Product To Which The Picture Belongs")]
    [ForeignKey("ProductId")]
    public Product Product { get; set; }
}