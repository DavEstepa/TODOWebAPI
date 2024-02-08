using TODOWebAPI.Configurations;
using TODOWebAPI.Domain.Constants;
using TODOWebAPI.Domain.Entities;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration.GetSection("InternalConfig");
// Add services to the container.
builder.Services.Configure<AppConfiguration>(config);
builder.Services.AddRepositories();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCORS();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(AppSettings.CORS_POLICY_NAME_VALUE);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
