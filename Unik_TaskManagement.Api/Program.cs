using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Unik_TaskManagement.Api.InitialMigration;
using Unik_TaskManagement.Application;
using Unik_TaskManagement.Persistence;
using Unik_TaskManagement.Persistence.Data;

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
;
builder.Services.AddControllers( ).AddJsonOptions(x =>
				x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

//builder.Services.AddScoped<IUnitOfWork, UnitOfWork>( );
builder.Services.AddApplicationServices( );
builder.Services.AddPersistenceServices( );



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

//app.MigrateDatabase( );

app.Run( );
