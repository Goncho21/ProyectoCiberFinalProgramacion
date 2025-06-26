using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProyectoCiber.Models;
using ProyectoCiber.Interfaces;
using ProyectoCiber.Servicio;
using Microsoft.EntityFrameworkCore;
using ProyectoCiber.Data;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TurnoDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Scoped lo toma
builder.Services.AddScoped<IPCServicio, PCServicio>();
builder.Services.AddScoped<ITurnoServicio, TurnoServicio>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});
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


using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<TurnoDBContext>();
        context.Database.CanConnect();
        Console.WriteLine(" Conexión a la base de datos exitosa.");
    }
    catch (Exception ex)
    {
        Console.WriteLine(" Error al conectar con la base de datos:");
        Console.WriteLine(ex.Message);
    }
}


app.Run();
        
