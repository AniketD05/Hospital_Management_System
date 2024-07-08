using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using HospitalManagementSystem.Data;
using HospitalManagementSystem.Areas.Identity.Data;
namespace HospitalManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("HospitalManagementDbContextConnection") ?? throw new InvalidOperationException("Connection string 'HospitalManagementDbContextConnection' not found.");

            builder.Services.AddDbContext<HospitalManagementDbContext>(options => options.UseSqlServer(connectionString));

            builder.Services.AddDefaultIdentity<HospitalManagementSystemUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<HospitalManagementDbContext>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddRazorPages();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();
            app.Run();
        }
    }
}
