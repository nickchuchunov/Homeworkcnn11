using Microsoft.AspNetCore.Authorization;
using SecureDevelopment_1;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<BankCardService>(); // сервисы для EntityFramework
builder.Services.AddSingleton<BankCardServiceDapper>(); // сервисы для Dapper
builder.Services.AddSwaggerGen(); // добавояем Swagger

builder.Services.AddSingleton<IAuthorizationHandler, UserHandlerAuthentication>(); // Регистрация обработчика

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("UserAuthentication", policy => policy.Requirements.Add(new UserAuthentication("login", "password")));
});


    var app = builder.Build();

app.UseSwagger(c =>
{
    c.SerializeAsV2 = true;
});
app.UseRouting();
app.UseEndpoints(endpoints =>{endpoints.MapControllers();});
app.UseSwaggerUI(c =>{ c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");});

app.UseRouting();
app.UseEndpoints(endpoints =>{ endpoints.MapControllers(); });

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
    {
        
        app.UseSwagger(); // включаем ПО промежуточного слоя Swagger
        app.UseSwaggerUI(); // включаем ПО промежуточного слоя Swagger

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