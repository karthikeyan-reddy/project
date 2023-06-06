using propertyinsurance2;
using propertyinsurance2.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ILoanComponent, PropertyLoan>();
builder.Services.AddCors((options) =>
{
    options.AddPolicy("licPolicy", (options) =>
    {
        options.AllowAnyHeader()
            .AllowAnyOrigin()
            .AllowAnyMethod();
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();
app.MapGet("/Customer/{id}", (int id, ILoanComponent com) =>
{
    return com.getCustomerdetails(id);
});
app.MapGet("/Agents", (ILoanComponent com) =>
{
    return com.GetAllAgents();
});
app.MapGet("/Agent/{id}", (int id, ILoanComponent com) =>
{
    return com.getAgentdetails(id);
});
app.MapPost("/Customer", (Customer pb, ILoanComponent com) =>
{
    com.AddCustomer(pb);
});
app.MapPost("/Agent", (Agent pb, ILoanComponent com) =>
{
    com.AddAgent(pb);
});
app.MapPut("/Agent/{agent}", (Agent agent, ILoanComponent com) =>
{
    com.updateAgentdetials(agent);
});
app.MapPut("/Customer/{cus}", (Customer cus, ILoanComponent com) =>
{
    com.UpdateCustomer(cus);
});

app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}