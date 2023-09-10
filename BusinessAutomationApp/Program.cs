using BusinessAutomation.Database;
using BusinessAutomation.Repositories.Abstractions.Products;
using BusinessAutomation.Repository;
using BusinessAutomationApp.DI_Test_Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//dependency resolve kore ekhane...
builder.Services.AddDbContext<BusinessAutomationDbContext>(opt =>opt.UseSqlServer("Server=DESKTOP-D63RLDO;Database=BusinessAutomationDB;User Id=sa;Password=Abjt@8632;MultipleActiveResultSets=True"));
//productRepository r object baniye dibe
builder.Services.AddScoped<IProductRepository,ProductsRepository>();




//Factory method implementation...........
/*builder.Services.AddScoped<IProductRepository>(serviceProvider =>
{
    int customerType = 1;
    if(customerType == 1)
    {
        var db = serviceProvider.GetService<BusinessAutomationDbContext>(); 
        return new ProductsRepository(db);  
    }
    else
    {
        return new ProductCloudRepository();
    }
});*/








//builder.Services.AddScoped<RandomClass, RandomClass>();
builder.Services.AddScoped<BrandRepository>();







var app = builder.Build();
//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
//builder.Services.AddDbContext<BusinessAutomationDbContext>(options =>
//    options.UseSqlServer(connectionString));
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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
