create database Assignment8Db

use Assignment8Db

create table Employees(
EmployeeId int primary key,
FirstName nvarchar(50),
LastName nvarchar(50),
BirthDate date,
Salary decimal(18,2));

create table Products
(
ProductId int Primary key,
ProductName nvarchar(50),
Description nvarchar(50),
Price money,
ReleaseDate datetime);

create table Orders
(OrderId int primary key,
OrderDate datetime,
Quantity smallint,
Discount float,
IsShipped bit);

select * from Employees
select * from Products
select * from Orders

