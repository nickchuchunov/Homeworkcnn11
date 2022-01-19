using SecureDevelopment_1;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<BankCardService>(); // ������� ��� EntityFramework
builder.Services.AddSingleton<BankCardServiceDapper>(); // ������� ��� Dapper
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
 1. ���������� ������, � ������� ������ ������ �� ��������� ������ �����������:
a. ���������� CRUD-������.
b. �������������� EF.
2. �������� ������ � ������� ���������������:
a. �������� ���������� ��� ������ � ���������� �������.
b. ���������� ������ CRUD, ���������� � SQL-���������.
 */