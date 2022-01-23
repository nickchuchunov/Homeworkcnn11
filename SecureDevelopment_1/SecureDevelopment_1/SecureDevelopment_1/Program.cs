using Microsoft.AspNetCore.Authorization;
using SecureDevelopment_1;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<BankCardService>(); // ������� ��� EntityFramework
builder.Services.AddSingleton<BankCardServiceDapper>(); // ������� ��� Dapper
builder.Services.AddSwaggerGen(); // ��������� Swagger

builder.Services.AddSingleton<IAuthorizationHandler, UserHandlerAuthentication>(); // ����������� �����������

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
        
        app.UseSwagger(); // �������� �� �������������� ���� Swagger
        app.UseSwaggerUI(); // �������� �� �������������� ���� Swagger

    }

    app.UseAuthorization();

    app.MapControllers();

    app.Run();



/* 
 1. ���������� ������, � ������� ������ ������ �� ��������� ������ �����������:
a. ���������� CRUD-������.
b. �������������� EF.
2. �������� ������ � ������� ���������������:
a. �������� ���������� ��� ������ � ���������� �������.
b. ���������� ������ CRUD, ���������� � SQL-���������.
 */