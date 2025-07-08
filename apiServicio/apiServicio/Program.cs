using apiServicio.Business.Clases;
using apiServicio.Business.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add services to the container.


//builder.Services.AddTransient<apiServicio.Business.Contracts.IRolService, RolRepository>(); // Registro de la dependencia
//builder.Services.AddTransient<IRolService, RolService>(); // Registro de la dependencia

builder.Services.AddTransient<IRolRepository, RolRepository>();
builder.Services.AddTransient<IRolService, RolService>();


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
