using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using PeixariaProject.Data;

var builder = WebApplication.CreateBuilder(args);

// Configurar o banco de dados em memória
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseInMemoryDatabase("DBPeixaria"));

//Adicionar serviços para controllers
builder.Services.AddControllers();
//adicionar Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


 
//Configurar o middleware para usar Swagger
if (app.Environment.IsDevelopment())
{
    
    app.UseSwagger();
    app.UseSwaggerUI(c =>
   {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Peixaria API V1");
    });
}
app.UseHttpsRedirection();


app.UseAuthorization();

app.MapControllers();

app.Run();