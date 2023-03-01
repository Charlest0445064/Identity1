
using Identity®Ø¬[1;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<MyDbContext>(options =>
	options.UseSqlServer(connectionString));

builder.Services.AddDataProtection();
builder.Services.AddIdentityCore<MyUser>(options =>
{
	options.Password.RequireDigit = false;
	options.Password.RequireLowercase = false;
	options.Password.RequireNonAlphanumeric = false;
	options.Password.RequireUppercase = false;
	options.Password.RequiredLength = 6;
	options.Tokens.PasswordResetTokenProvider = TokenOptions.DefaultEmailProvider;
	var iBuilder = new IdentityBuilder(typeof(MyUser), typeof(MyRole), builder.Services);//µù¥UªA°È
	iBuilder.AddEntityFrameworkStores<MyDbContext>().AddDefaultTokenProviders()
	.AddUserManager<UserManager<MyUser>>().AddRoleManager<RoleManager<MyRole>>();

});


// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
