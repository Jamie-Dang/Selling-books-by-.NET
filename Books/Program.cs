using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Books.Data;


var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ShopOnline") 
	?? throw new InvalidOperationException("Connection string 'ShopOnline' not found.");

builder.Services.AddDbContext<AppDBContext>(options =>
	options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
		.AddEntityFrameworkStores<AppDBContext>();




// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
	endpoints.MapControllerRoute(
        name: "Admin",
		pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");//mặc định đã có
	endpoints.MapRazorPages();//khai bao them vi dung them dang RazorPage
});

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
