using Checkout.Vault.CardStorage.Application.Handle;
using Checkout.Vault.CardStorage.Core.Ports;
using Checkout.Vault.CardStorage.Infrastructure.Events.Sns;
using Checkout.Vault.CardStorage.Infrastructure.Persistence.InMemory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<ICreateCardHandler, CreateCardHandler>();
builder.Services.AddTransient<IRaiseEvent, SnsEventNotification>();
builder.Services.AddTransient<ICardsRepository, CardsRepositoryInMemory>();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
