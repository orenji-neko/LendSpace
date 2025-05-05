using LendSpace.Components;
using LendSpace.Data;
using LendSpace.Models;
using LendSpace.Services;
using LendSpace.Services.Background;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Blazored.Toast; // Add this for Toast service


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<LendSpace.Services.NotificationServices>();
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddControllers();
builder.Services.AddHttpClient();

// Add Blazored Toast Service
builder.Services.AddBlazoredToast();
builder.Services.AddScoped<LendSpace.Services.NotificationServices>();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlite("Data Source=database.db");
});

builder.Services.AddIdentity<UserModel, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
})
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddRoles<IdentityRole>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

// Register the EventService - update the namespace to match your interface
builder.Services.AddScoped<EventManager, EventService>();

builder.Services.AddAuthorizationBuilder()
    .AddPolicy("UserOnly", policy =>
    {
        policy.RequireRole("User");
    })
    .AddPolicy("AdminOnly", policy =>
    {
        policy.RequireRole("Admin");
    })
    .AddPolicy("StaffOnly", policy =>
    {
        policy.RequireRole("Staff");
    });

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Login";
    options.AccessDeniedPath = "/AccessDenied";
});

// File Manager
builder.Services.AddScoped<FileManager>();

// Dialogs
builder.Services.AddSingleton<DialogManager>();

// Background services
builder.Services.AddHostedService<Scheduler>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Development Environment
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseAuthentication();
app.UseAuthorization();
app.UseHttpsRedirection();
app.UseAntiforgery();
app.MapStaticAssets();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();