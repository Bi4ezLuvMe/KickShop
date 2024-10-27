﻿// <auto-generated />
using System;
using KickShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KickShop.Migrations
{
    [DbContext(typeof(KickShopDbContext))]
    [Migration("20241027155401_AddedApplicationUser")]
    partial class AddedApplicationUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("KickShop.Models.Brand", b =>
                {
                    b.Property<Guid>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("The Unique Identifier");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("The Country Of Origin Of The The Brand");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("The Name Of The Brand");

                    b.HasKey("BrandId");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            BrandId = new Guid("10fc2f80-c63b-4c0c-bfc7-472b4f4af4e8"),
                            Country = "USA",
                            Name = "Everlast"
                        },
                        new
                        {
                            BrandId = new Guid("f875996a-d95b-4539-a0af-843b85d50ac3"),
                            Country = "France",
                            Name = "Venum"
                        },
                        new
                        {
                            BrandId = new Guid("6e5dd27c-e9a8-4cfd-9e7d-ad63b8215f60"),
                            Country = "Germany",
                            Name = "Adidas"
                        });
                });

            modelBuilder.Entity("KickShop.Models.CartItem", b =>
                {
                    b.Property<Guid>("CartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("The Unique Indentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Foreign Key To The Product Entity");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("ShoppingCartId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Foreign Key To The ShoppingCart Entity");

                    b.HasKey("CartItemId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("CartsItems");
                });

            modelBuilder.Entity("KickShop.Models.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("The Unique Identifier");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Image For The Category");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("The Name Of The Category");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("dc2f95f0-793c-45b7-95f5-cfc2ebbfb418"),
                            ImageUrl = "/images/gloves-category.jpg",
                            Name = "Gloves"
                        },
                        new
                        {
                            CategoryId = new Guid("9374212f-7d1d-4be1-b05d-9b2de9c43f49"),
                            ImageUrl = "/images/protective-gear-category.jpg",
                            Name = "Protective Gear"
                        },
                        new
                        {
                            CategoryId = new Guid("9c37c417-9dd6-44d0-a2cf-aa76762e3161"),
                            ImageUrl = "/images/apparel-category.jpg",
                            Name = "Apparel"
                        });
                });

            modelBuilder.Entity("KickShop.Models.CustomerOrder", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Foreign Key To The Order Entity. Also Primary Key");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Foreign Key To The ASP.NET User Entity. Also Primary Key");

                    b.HasKey("OrderId", "CustomerId");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomersOrders");
                });

            modelBuilder.Entity("KickShop.Models.Order", b =>
                {
                    b.Property<Guid>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("The Unique Identifier");

                    b.Property<string>("OrderDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("The Date When The Order Was Placed");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)")
                        .HasComment("The Total Amount Of The Order");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("KickShop.Models.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("The Unique Identifier");

                    b.Property<Guid>("BrandId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Foreign Key To The Brand Entity");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Foreign Key To The Category Entity");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasComment("The Description For The Product");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("URL To The Product Image");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("The Product Name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)")
                        .HasComment("The Price Of The Product");

                    b.Property<string>("Sizes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("The Size Of The Product");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int")
                        .HasComment("Current Stock Quantity");

                    b.HasKey("ProductId");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("435f522b-7750-44f0-8dda-d74629427649"),
                            BrandId = new Guid("10fc2f80-c63b-4c0c-bfc7-472b4f4af4e8"),
                            CategoryId = new Guid("dc2f95f0-793c-45b7-95f5-cfc2ebbfb418"),
                            Description = "High-quality kickboxing gloves for training and competition.",
                            ImageUrl = "/images/gloves.jpg",
                            Name = "Kickboxing Gloves",
                            Price = 49.99m,
                            Sizes = "[0,1,2,3]",
                            StockQuantity = 5
                        },
                        new
                        {
                            ProductId = new Guid("3a75ab89-c959-4cad-8485-dcfc9a044a01"),
                            BrandId = new Guid("f875996a-d95b-4539-a0af-843b85d50ac3"),
                            CategoryId = new Guid("dc2f95f0-793c-45b7-95f5-cfc2ebbfb418"),
                            Description = "Durable shin guards for protection during sparring.",
                            ImageUrl = "/images/shin-guards.jpg",
                            Name = "Shin Guards",
                            Price = 35.99m,
                            Sizes = "[0,1,2,3]",
                            StockQuantity = 6
                        },
                        new
                        {
                            ProductId = new Guid("a6e7e1ff-75ca-4a25-83db-5fa08d6e064c"),
                            BrandId = new Guid("6e5dd27c-e9a8-4cfd-9e7d-ad63b8215f60"),
                            CategoryId = new Guid("9374212f-7d1d-4be1-b05d-9b2de9c43f49"),
                            Description = "Protective headgear for safety during training.",
                            ImageUrl = "/images/headgear.jpg",
                            Name = "Headgear",
                            Price = 59.99m,
                            Sizes = "[0,1,2,3]",
                            StockQuantity = 2
                        },
                        new
                        {
                            ProductId = new Guid("bf005e8b-217d-4213-bd9c-497fbbc66d7b"),
                            BrandId = new Guid("10fc2f80-c63b-4c0c-bfc7-472b4f4af4e8"),
                            CategoryId = new Guid("9c37c417-9dd6-44d0-a2cf-aa76762e3161"),
                            Description = "Comfortable shorts designed for kickboxing training.",
                            ImageUrl = "/images/shorts.jpg",
                            Name = "Kickboxing Shorts",
                            Price = 29.99m,
                            Sizes = "[0,1,2,3]",
                            StockQuantity = 4
                        },
                        new
                        {
                            ProductId = new Guid("72675002-8534-4774-9ee6-8e5f729aece5"),
                            BrandId = new Guid("f875996a-d95b-4539-a0af-843b85d50ac3"),
                            CategoryId = new Guid("9374212f-7d1d-4be1-b05d-9b2de9c43f49"),
                            Description = "Essential mouth guard for protecting your teeth.",
                            ImageUrl = "/images/mouth-guard.jpg",
                            Name = "Mouth Guard",
                            Price = 12.99m,
                            Sizes = "[0,1,2,3]",
                            StockQuantity = 6
                        });
                });

            modelBuilder.Entity("KickShop.Models.ShoppingCart", b =>
                {
                    b.Property<Guid>("ShoppingCartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("The Unique Identifier");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Foreign Key To The Customer Entity");

                    b.Property<string>("DateCreated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("The Date When The Shopping Cart Was Created");

                    b.HasKey("ShoppingCartId");

                    b.HasIndex("CustomerId");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("KickShop.Models.CartItem", b =>
                {
                    b.HasOne("KickShop.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KickShop.Models.ShoppingCart", "ShoppingCart")
                        .WithMany("CartItems")
                        .HasForeignKey("ShoppingCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("KickShop.Models.CustomerOrder", b =>
                {
                    b.HasOne("ApplicationUser", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KickShop.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("KickShop.Models.Product", b =>
                {
                    b.HasOne("KickShop.Models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KickShop.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("KickShop.Models.ShoppingCart", b =>
                {
                    b.HasOne("ApplicationUser", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KickShop.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("KickShop.Models.ShoppingCart", b =>
                {
                    b.Navigation("CartItems");
                });
#pragma warning restore 612, 618
        }
    }
}
