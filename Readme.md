### Northwind Test DB

> Northwind DB Script :
https://github.com/microsoft/sql-server-samples/blob/master/samples/databases/northwind-pubs/instnwnd.sql

Package Manager Console'da (Northwind DB) Mevcut Bir Veritabani Için Model Olusturmak için Scaffold-DbContext arac?n? kullanabiliriz
> Scaffold-DbContext "Data Source=(localdb)\mssqllocaldb;Initial Catalog=Northwind;Integrated Security=True" Microsoft.EntityFrameWorkCore.SqlServer -outputdir DB/Concretes/NorthwindDB/Entities -context NorthwindDbContext -contextdir DB/Concretes/NorthwindDB/Context -UseDatabaseNames -DataAnnotations -Force