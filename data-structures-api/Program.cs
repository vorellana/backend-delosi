var builder = WebApplication.CreateBuilder(args);

// Agrega la URL personalizada
builder.WebHost.UseUrls("http://*:5024");

// Add services to the container.

builder.Services.AddControllers();


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

app.UseAuthorization();

// Middleware para asegurar que todas las solicitudes sean application/json
app.Use(async (context, next) =>
{
    if (context.Request.ContentType != null && !context.Request.ContentType.StartsWith("application/json"))
    {
        context.Response.StatusCode = 415;
        await context.Response.WriteAsync("Expected content type application/json");
    }
    else
    {
        await next.Invoke();
    }
});

app.MapControllers();

// Middleware para asegurar que todas las respuestas sean application/json
app.Use(async (context, next) =>
{
    context.Response.ContentType = "application/json";
    await next.Invoke();
});

app.Run();
