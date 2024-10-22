using System.Data.Common;
using DependInj2.Services;

var builder=WebApplication.CreateBuilder();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddMemoryCache();

//builder.Services.AddScoped<INumberService,NumberClient>();
builder.Services.AddSingleton<INumberService, NumberClient2>();
builder.Services.AddScoped<IPostNumberCheck, NumberPost>();
// builder.Services.AddScoped<GetDbString>();
builder.Services.Configure<DB_info>(builder.Configuration.GetSection("Db_info"));
var app=builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();
app.Run();