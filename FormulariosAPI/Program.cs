using FormulariosAPI.ServiceRegistration;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureIdentityServices(builder.Configuration);

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddCors(options =>
{
    options.AddPolicy("localhostApp", builder =>
    {
        builder.SetIsOriginAllowed(_ => true)
               .AllowAnyHeader()
               .AllowAnyMethod()
               .AllowCredentials();
    });

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors("localhostApp");
}

app.UseCors("localhostApp");

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
