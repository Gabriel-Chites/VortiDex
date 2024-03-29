
using Microsoft.EntityFrameworkCore;
using VortiDex.Data;

namespace VortiDex;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        var connString = builder.Configuration
            .GetConnectionString("DefaultConnection");

        builder.Services.AddDbContext<PokeContext>(options => options
            .UseMySql(connString, ServerVersion.AutoDetect(connString)));

        builder.Services.AddAutoMapper(AppDomain
            .CurrentDomain.GetAssemblies());

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