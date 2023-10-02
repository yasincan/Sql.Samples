using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Sql.Samples.DB.Concretes.NorthwindDB.Context;
using Sql.Samples.DB.Concretes.NorthwindDB.Entities;
using System.Data;

//Entity Framework Core Raw Sql Örnekleri

//01 Entity Framework Core FromSqlRaw ile RAW SQL Kullanarak DB'de değer alama 

NorthwindDbContext northwindDbContext = new();
List<MyOrder> myOrders = northwindDbContext.MyOrders.FromSqlRaw("SELECT OrderID, OrderDate FROM Orders").ToList();



//02 Entity Framework Core ExecuteSqlRaw ile RAW SQL Kullanarak DB'de değer alama

DateTime startDate = new DateTime(1997, 05, 06);
DateTime endDate = new DateTime(1998, 05, 06);
string sql = @"(SELECT SUM(od.UnitPrice * od.Quantity) 
AS TotalPrice FROM Orders o JOIN [Order Details] od ON o.OrderID = od.OrderID 
WHERE @startDate<= o.OrderDate AND o.OrderDate <= @endDate)";


SqlParameter totalPrice = new("@totalPrice", SqlDbType.Decimal) //Dönüş için SqlParameter
{
    Direction = ParameterDirection.Output
};

object[] currentTotalParamlist = new object[]
{
    new SqlParameter { ParameterName = "@startDate", Value = startDate },
    new SqlParameter { ParameterName = "@endDate", Value = endDate },
    totalPrice
};

northwindDbContext.Database.ExecuteSqlRaw($"SET @totalPrice = {sql}", currentTotalParamlist);
decimal totalResult = (decimal)totalPrice.Value; //Sonuç

Console.WriteLine($"Tarihleri {startDate:dd.MM.yyyy} - {endDate:dd.MM.yyyy} arası siparişlerin toplam fiyatı {totalResult}");


//03 Entity Framework Core ile Dinamik LINQ Kullanımı





Console.WriteLine("Hello, World!");
