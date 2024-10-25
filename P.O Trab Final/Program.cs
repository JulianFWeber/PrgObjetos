using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<PeixariaContext>(opt => opt.UseInMemoryDatabase("PeixariaDB"));

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();
app.Run();
