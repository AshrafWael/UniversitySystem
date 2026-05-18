using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;
using UniversitySystem.Core;
using UniversitySystem.infrastructure;
using UniversitySystem.infrastructure.Data;
using UniversitySystem.Service;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "University System API",
        Version = "v1"
    });
});
#region Dependancy Enjection

//builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddInfrastructureDependencies();
builder.Services.AddServiceDependencies();
builder.Services.AddCoreDependencies();

#endregion
builder.Services.AddDbContext<ApplicationDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


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


