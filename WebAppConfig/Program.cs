using WebAppConfig.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//add configuration to the container
builder.Services.Configure<AppConfiguration>(builder.Configuration.GetSection("Variables"));

//builder.Services.Configure<AppConfiguration>(config =>
//{
//    config.variable1 = "value1";
//    config.variable2 = false;
//    config.variable3 = 3;
//});

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

app.MapRazorPages();

app.Run();
