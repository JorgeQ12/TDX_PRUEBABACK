using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TdxBackend;
using TdxBackend.Application.Services;
using TdxBackend.Application.Services.Interfaces;
using TdxBackend.Automapper;
using TdxBackend.Domain.Services;
using TdxBackend.Domain.Services.Interfaces;
using TdxBackend.Validators;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c =>
{
    // Ruta al archivo XML de documentación
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

    // Incluir el archivo XML de documentación en Swagger
    c.IncludeXmlComments(xmlPath);
});
builder.Services.AddCors(options => options.AddPolicy("AllowWebApp",
                            builder => builder.AllowAnyOrigin()
                                                .AllowAnyHeader()
                                                .AllowAnyMethod()));
builder.Services.AddDbContext<DbContextTdx>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DbConeccionSQL")));
builder.Services.AddScoped<ITaskTdxServices, TaskTdxServices>();
builder.Services.AddScoped<ITaskTdxDomain, TaskTdxDomain>();
builder.Services.AddTransient<GlobalValidator>();
builder.Services.AddAutoMapper(typeof(GlobalMapper));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseCors("AllowWebApp");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
