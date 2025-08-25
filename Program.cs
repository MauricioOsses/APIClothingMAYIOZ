using APIClothingMAYIOZ.Data;
using APIClothingMAYIOZ.Mappings;
using APIClothingMAYIOZ.Repositories.GeneroRepository;
using APIClothingMAYIOZ.Repositories.MarcaRepository;
using APIClothingMAYIOZ.Repositories.ProductoRepository;
using APIClothingMAYIOZ.Repositories.TalleRepository;
using APIClothingMAYIOZ.Services.ServiceGenero;
using APIClothingMAYIOZ.Services.ServiceMarca;
using APIClothingMAYIOZ.Services.ServiceProducto;
using APIClothingMAYIOZ.Services.ServiceTalle;
using APIClothingMAYIOZ.Validations.ProductoValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IProductoRepository, ProductoRepository>();
builder.Services.AddScoped<IProductoService, ProductoService>();

builder.Services.AddScoped<IMarcaRepository, MarcaRepository>();
builder.Services.AddScoped<IMarcaService, MarcaService>();

builder.Services.AddScoped<IGeneroRepository, GeneroRepository>();
builder.Services.AddScoped<IGeneroService, GeneroService>();

builder.Services.AddScoped<ITalleRepository, TalleRepository>();
builder.Services.AddScoped<ITalleService, TalleService>();

builder.Services.AddDbContext<ClothingDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("cadenaDdClothing"))
);

builder.Services.AddControllers();

// FluentValidantion
builder.Services.AddControllers().AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<ProductoDtoValidator>());

// AutoMapper
builder.Services.AddAutoMapper(cfg => cfg.AddProfile<AutoMapperProfile>());

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
