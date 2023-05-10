using Microsoft.AspNetCore.Builder;
using Webapp_For__Middleware_Test;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

app.UseLogUrl();

app.Map("/m1", HandleMapOne);

app.Map("/m2", appMap =>
{
    appMap.Run(async context =>
    {
        await context.Response.WriteAsync("Hello from 2nd App.Map /m2 \n");
    });
});

void HandleMapOne(IApplicationBuilder app)
{
    app.Run(async context =>
    {
        await context.Response.WriteAsync("Hello from 1st App.Map /m1 \n");
    });
}

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Before Invoke of 1st App.Use() \n");
    await next();
    await context.Response.WriteAsync("After Invoke of 1st App.Use() \n");
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Before Invoke of 2nd App.Use() \n");
    await next();
    await context.Response.WriteAsync("After Invoke of 2nd App.Use() \n");
});


app.Run(async (context) =>
{
    await context.Response.WriteAsync("Hello from 1st app.Run()\n");
});

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

public static class LogURLMiddlewareExtensions
{
    public static IApplicationBuilder UseLogUrl(this IApplicationBuilder app)
    {
        return app.UseMiddleware<LogURLMiddleware>();
    }
}
