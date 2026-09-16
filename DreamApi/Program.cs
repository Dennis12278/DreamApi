using Scalar.AspNetCore;
using DreamApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<AnotacaoService>();
builder.Services.AddSingleton<UsuarioService>();
builder.Services.AddSingleton<DocumentoService>();
builder.Services.AddSingleton<TipoDocumentoService>();
builder.Services.AddSingleton<GrupoService>();
builder.Services.AddSingleton<GrupoUsuarioService>();
builder.Services.AddSingleton<CompartilhamentoService>();


// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();