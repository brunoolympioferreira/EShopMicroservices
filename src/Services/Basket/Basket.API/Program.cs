var builder = WebApplication.CreateBuilder(args);

//Add Services to the container.

//Application Services
var assembly = typeof(Program).Assembly;
builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(assembly);
    config.AddOpenBehavior(typeof(ValidationBehavior<,>));
    config.AddOpenBehavior(typeof(LoggingBehavior<,>));
});

var app = builder.Build();

//Configure the HTTP request pipeline.
app.MapCarter();
app.UseExceptionHandler(options => { });

app.MapGet("/", () => "Hello World!");

app.Run();
