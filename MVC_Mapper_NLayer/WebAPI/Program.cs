using BLL.Extensions;
using DAL.DbStartUp;

var builder = WebApplication.CreateBuilder(args);

IConfiguration configuration = builder.Configuration;

builder.Services.InjectDAL(configuration);
builder.Services.AddServiceInjection();

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
using(var scope = app.Services.CreateScope())
{
    var serviceProvider = scope.ServiceProvider;
    try
    {
        var context = serviceProvider.GetRequiredService<DBContext>();
        DbInitializer.Initialize(context);
    }
    catch(Exception exception)
    {
        throw exception;
    }
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
