using Microsoft.EntityFrameworkCore;
using Mod5_CRUD.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Registo do DbContext com MySQL
builder.Services.AddDbContext<ApplicationDbContext>(options =>
	options.UseMySql(
		builder.Configuration.GetConnectionString("DefaultConnection"),
		new MySqlServerVersion(new Version(8, 0, 47))
	)
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
	app.UseExceptionHandler("/Home/Error");
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}")
	.WithStaticAssets();

app.Run();