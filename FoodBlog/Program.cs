﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FoodBlog.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<FoodBlogContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FoodBlogContext") ?? throw new InvalidOperationException("Connection string 'FoodBlogContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Recipes}/{action=Index}/{id?}");

app.Run();
