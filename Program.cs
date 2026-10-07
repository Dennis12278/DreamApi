using Scalar.AspNetCore;
using DreamApi.Services;
using DreamApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirSite", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddDbContext<DreamDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("ConexaoDream")));

// Serviços atuais
builder.Services.AddScoped<AnotacaoService>();
builder.Services.AddScoped<UsuarioService>();
builder.Services.AddScoped<DocumentoService>();
builder.Services.AddScoped<TipoDocumentoService>();
builder.Services.AddScoped<GrupoService>();
builder.Services.AddScoped<GrupoUsuarioService>();
builder.Services.AddScoped<CompartilhamentoService>();
builder.Services.AddScoped<NotificacaoService>();
builder.Services.AddScoped<CalendarioService>();
builder.Services.AddScoped<ColecaoService>();

builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseCors("PermitirSite");

app.UseAuthorization();

app.MapControllers();

app.Run();