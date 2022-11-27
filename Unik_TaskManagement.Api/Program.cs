using Microsoft.EntityFrameworkCore;
using Unik_TaskManagement.Application.Contracts.Persistence;
using Unik_TaskManagement.Persistence.Data;
using Unik_TaskManagement.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers( );
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer( );
builder.Services.AddSwaggerGen( );
//builder.Services.AddSingleton<IEmailSender, EmailSender>( );
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("MyConnectionString")
    ));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>( );

var app = builder.Build( );

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment( ))
{
    app.UseSwagger( );
    app.UseSwaggerUI( );
}

app.UseHttpsRedirection( );

app.UseAuthorization( );

app.MapControllers( );

app.Run( );
