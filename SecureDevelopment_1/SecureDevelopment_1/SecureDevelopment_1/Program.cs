using SecureDevelopment_1;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<BankCardService>(); // сервисы для EntityFramework
builder.Services.AddSingleton<BankCardServiceDapper>(); // сервисы для Dapper
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

/* 
 1. Реализуйте сервис, в который войдут данные по дебетовым картам покупателей:
a. Реализуйте CRUD-методы.
b. Воспользуйтесь EF.
2. Создайте сервис с базовым инструментарием:
a. Добавьте контроллер для работы с дебетовыми картами.
b. Реализуйте методы CRUD, устойчивые к SQL-инъекциям.
 */