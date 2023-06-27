using System.ComponentModel.DataAnnotations;
using TurkuvazMedyaNews.Core.Repositories;
using TurkuvazMedyaNews.Core.Services;
using TurkuvazMedyaNews.Repository.Repositories;
using TurkuvazMedyaNews.Service.Mapping;
using TurkuvazMedyaNews.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<INewsService, NewsService>();
builder.Services.AddScoped<INewsRepository, NewsRepository>();
builder.Services.AddScoped<IVideosService, VideosService>();
builder.Services.AddScoped<IVideoRepository ,VideosRepository>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MapProfile));
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
