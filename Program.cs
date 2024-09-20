using WebApplication2.Data;
using WebApplication2.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Register DapperContext
builder.Services.AddSingleton<DapperContext>();
builder.Services.AddScoped<CustomerRepository>();
builder.Services.AddScoped<HomeRepository>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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