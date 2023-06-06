using DocumentsAPI.Data;
using DocumentsAPI.Helpers;
using DocumentsAPI.Repositories;
using DocumentsAPI.Repositories.Interfaces;
using DocumentsAPI.Services;
using DocumentsAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DbCtx>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DocumentsDBConnectionString")));

builder.Services.AddTransient<IDocumentService, DocumentService>();
builder.Services.AddTransient<IDocumentRepository, DocumentRepository>();

builder.Services.AddTransient<ILookupService, LookupService>();
builder.Services.AddTransient<ILookupRepository, LookupRepository>();

builder.Services.AddAutoMapper(typeof(DocumentMapper));

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
