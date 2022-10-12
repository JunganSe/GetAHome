using GetAHomeApi.Data;
using GetAHomeApi.Interfaces;
using GetAHomeApi.Models;
using GetAHomeApi.Repositories.Sqlite;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GetAHomeApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddDbContext<Context>(options =>
            options.UseSqlite(builder.Configuration.GetConnectionString("Sqlite"))
        );
        builder.Services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<Context>();

        builder.Services.AddScoped<IResidenceTypeRepository, ResidenceTypeRepository>();

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
