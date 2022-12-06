using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Unik_TaskManagement.web.Data;
using Unik_TaskManagement.web.MappingOpjects;
using Unik_TaskManagement.web.Services;
using Unik_TaskManagement.web.Services.IServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter( );

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>( );
builder.Services.AddRazorPages( );


builder.Services.AddAutoMapper(typeof(Mapping));
// Add services to the container.

// IHttpClientFactory
builder.Services.AddHttpClient<IKunderService, KunderService>(client =>
    client.BaseAddress = new Uri(builder.Configuration["ServiceUrl"])
);
builder.Services.AddHttpClient<IKunderService, KunderService>( );

// IHttpClientFactory
builder.Services.AddHttpClient<IBookingService, BookingService>(client =>
	client.BaseAddress = new Uri(builder.Configuration["ServiceUrl"])
);
builder.Services.AddHttpClient<IBookingService, BookingService>( );

// IHttpClientFactory
builder.Services.AddHttpClient<IOpgaverService, OpgaverService>(client =>
	client.BaseAddress = new Uri(builder.Configuration["ServiceUrl"])
);
builder.Services.AddHttpClient<IOpgaverService, OpgaverService>( );

// IHttpClientFactory
builder.Services.AddHttpClient<IMedarbejderService, MedarbejderService>(client =>
	client.BaseAddress = new Uri(builder.Configuration["ServiceUrl"])
);
builder.Services.AddHttpClient<IMedarbejderService, MedarbejderService>( );

// IHttpClientFactory
builder.Services.AddHttpClient<IProjectService, ProjectService>(client =>
	client.BaseAddress = new Uri(builder.Configuration["ServiceUrl"])
);
builder.Services.AddHttpClient<IProjectService, ProjectService>( );



var app = builder.Build( );

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment( ))
{
    app.UseMigrationsEndPoint( );
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts( );
}

app.UseHttpsRedirection( );
app.UseStaticFiles( );

app.UseRouting( );

app.UseAuthentication( );
app.UseAuthorization( );

app.MapRazorPages( );

app.Run( );
