using KickShop.Data;
using KickShop.Services;
using KickShop.Services.Service_Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace KickShop
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<KickShopDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
     .AddEntityFrameworkStores<KickShopDbContext>()
     .AddDefaultUI()
     .AddDefaultTokenProviders();
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<IBrandService, BrandService>();
            builder.Services.AddScoped<ILayoutPopulateService, LayoutPopulateService>();
            builder.Services.AddScoped<ICartService, CartService>();
            builder.Services.AddScoped<IHomeService, HomeService>();
            builder.Services.AddScoped<IProfileService, ProfileService>();
            builder.Services.AddScoped<IOrderService, OrderService>();

            var app = builder.Build();
            using (var scope = app.Services.CreateScope())
            {
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

                await SeedAndAssingRoles(roleManager,userManager);
            }
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
                //app.UseStatusCodePagesWithReExecute("/Home/StatusCode", "?code={0}");
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();

                app.UseStatusCodePagesWithReExecute("/Home/StatusCode", "?code={0}");
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
        static async Task SeedAndAssingRoles(RoleManager<IdentityRole> roleManager,UserManager<ApplicationUser>userManager)
        {
            string[] roleNames = { "Admin", "Manager", "User" };

            foreach (var roleName in roleNames)
            {
                var roleExist = await roleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    var role = new IdentityRole(roleName);
                    await roleManager.CreateAsync(role);
                }
            }
            ApplicationUser? adminUser = await userManager.FindByEmailAsync("luboslav.vezenkov6907@gmail.com");
            if (adminUser!=null && !await userManager.IsInRoleAsync(adminUser, "Admin"))
            {
                    await userManager.AddToRoleAsync(adminUser, "Admin");
            }
            ApplicationUser? managerUser = await userManager.FindByEmailAsync("l.vezenkov07@pmgkn.com");
            if (adminUser != null && !await userManager.IsInRoleAsync(managerUser,"Manager"))
            {
                    await userManager.AddToRoleAsync(managerUser, "Manager");
            }
        }
    }
}
