using BackEnd.Models;
using BackEnd.Responsitory;
using BackEnd.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<LibraryDbContext>(
    option => option.UseSqlServer("Server=DESKTOP-Q7NGFSM;Initial Catalog=LibraryDb;Integrated Security=True")
);
builder.Services.AddTransient<IBookResponsitory, BookResponsitory>();
builder.Services.AddTransient<IBookServices, BookServices>();
builder.Services.AddTransient<ICategoryResponsitory, CategoryResponsitory>();
builder.Services.AddTransient<ICategoryServices,CategoryServices>();
builder.Services.AddTransient<IUserResponsitory, UserResponsitory>();
builder.Services.AddTransient<IUserServices,UserServices>();
builder.Services.AddCors(option => {
    option.AddPolicy(MyAllowSpecificOrigins,
    builder=>{
        builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader()
        .WithExposedHeaders("*");
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
app.UseCors(MyAllowSpecificOrigins);
app.UseAuthorization();

app.MapControllers();

app.Run();
