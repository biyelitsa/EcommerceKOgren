using EcommerceKOgren.DataAccess.Abstract;
using EcommerceKOgren.DataAccess.Concrete;
using EcommerceKOgren.DTO.Responses;
using EcommerceKOgren.UOW.Abstract;
using EcommerceKOgren.UOW.Concrete;
using EcommerceKOgren.WebUI.Identity;
//using EcommerceKOgren.WebUI.Middlewares;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<Context>(options =>
    options.UseSqlServer(connectionString));
var connectionString2 = builder.Configuration.GetConnectionString("IdentityConnection");
builder.Services.AddDbContext<ApplicationIdentityDbContext>(options=>
options.UseSqlServer(connectionString2));
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationIdentityDbContext>()
    .AddDefaultTokenProviders();
builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true;

    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.AllowedForNewUsers = true;

    options.User.RequireUniqueEmail = true;

    options.SignIn.RequireConfirmedEmail = false;
    options.SignIn.RequireConfirmedPhoneNumber = false;
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/account/login";
    options.LogoutPath = "/account/logout";
    options.AccessDeniedPath = "/account/accessdenied";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
    options.SlidingExpiration = true;
    options.Cookie = new CookieBuilder
    {
        HttpOnly = true,
        Name = ".EcommerceKOgren.Security.Cookie"
    };
});


builder.Services.AddControllersWithViews();
builder.Services.AddScoped<GeneralResponses>();
builder.Services.AddScoped<IUOW, UOW>();
builder.Services.AddScoped<ICategoryDal, CategoryDal>();
builder.Services.AddScoped<ICityDal, CityDal>();
builder.Services.AddScoped<IColorDal, ColorDal>();
builder.Services.AddScoped<ICountryDal, CountryDal>();
builder.Services.AddScoped<ICountyDal, CountyDal>();
builder.Services.AddScoped<ICustomerDal, CustomerDal>();
builder.Services.AddScoped<IEmployeeDal, EmployeeDal>();
builder.Services.AddScoped<IFilterDal, FilterDal>();
builder.Services.AddScoped< IOrderDal, OrderDal >();
builder.Services.AddScoped<IOrderDetailDal, OrderDetailDal>();
builder.Services.AddScoped<IProductDal, ProductDal>();
builder.Services.AddScoped<ISizeDal, SizeDal>();
builder.Services.AddScoped<ISupplierDal, SupplierDal>();
builder.Services.AddScoped<IUnitDal, UnitDal>();

builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    
}
else
{
    //SeedDatabase.Seed(app);
}

app.UseHttpsRedirection();
app.UseStaticFiles();
//app.CustomStaticFiles();
app.UseAuthentication();
app.UseRouting();

app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Register}/{id?}");
app.MapRazorPages();

app.Run();


//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
//}
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapRazorPages();

//app.Run();
