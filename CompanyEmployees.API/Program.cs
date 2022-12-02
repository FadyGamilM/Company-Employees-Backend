using CompanyEmployees.Main.Extensions;
using CompanyEmployees.Presentation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// => configure the API project assembly
builder.Services.AddControllers().AddApplicationPart(typeof(CompanyEmployees.Presentation.AssemblyReference).Assembly);

// => Configure the repository manager service
builder.Services.ConfigureRepositoryManager();

// => configure the service manager service
builder.Services.ConfigureServiceManager();

// => configure the dbContext creation service
builder.Services.ConfigureDbContextCreation(builder.Configuration);

// ------------------------------------------------------------------------------

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
