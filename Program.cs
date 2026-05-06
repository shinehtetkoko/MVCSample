using Microsoft.EntityFrameworkCore;
using MVCSample.Configurations;
using MVCSample.Data;
using MVCSample.Interfaces;
using MVCSample.Services;

var builder = WebApplication.CreateBuilder(args);
//connect to the database.
builder.Configuration.AddIniFile("dbConnection.conf", optional: false, reloadOnChange: true);
var dbSettings = builder.Configuration.GetSection("DbSettings").Get<DbSettings>();
if (dbSettings != null)
{
    builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseNpgsql(dbSettings.ConnectionString));
}

//DI injection
builder.Services.AddScoped<IEmployeeService, EmployeeService>();

builder.Services.AddControllersWithViews();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Database Connection ကို စစ်ဆေးမည့်အပိုင်း
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<AppDbContext>();
        if (context.Database.CanConnect())
        {
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Account}/{action=Login}/{id?}");
        }
        else
        {
            Console.WriteLine("---- Database Connection: Failed! ----");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"---- Error connecting to DB: {ex.Message} ----");
    }
}
app.Run();
