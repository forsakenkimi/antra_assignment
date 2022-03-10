/* use AdventureWorks2019;

select *
from Production.Product p

select *
from Production.ProductInventory
order by productID

exec sp_help 'Production.Product'
exec sp_help 'Production.ProductInventory' */

--Question 1
select count(ProductID) CountedProducts
from Production.Product;

--Question 2
select count(p.ProductID) CountedProducts
from Production.Product p 
where p.ProductSubcategoryID is not null;

--Question 3
select p.ProductSubcategoryID, count(p.ProductID) as CountedProducts
from Production.Product p
group by p.ProductSubcategoryID;

--Question 4
select p.ProductSubcategoryID, count(p.ProductID) as CountedProducts
from Production.Product p
where p.ProductSubcategoryID is null
group by p.ProductSubcategoryID;

--Question 5
select sum(p1.Quantity) SumQuantity
from Production.ProductInventory p1;

--Question 6
select p1.ProductID,sum(p1.Quantity) TheSum
from Production.ProductInventory p1
where p1.LocationID = 40
group by p1.ProductID
having sum(p1.Quantity) < 100;

--Question 7
select p1.Shelf, p1.ProductID, sum(p1.Quantity) TheSum
from Production.ProductInventory p1
where p1.LocationID = 40
group by p1.ProductID, p1.Shelf
having sum(p1.Quantity) < 100;

--Question 8
select avg(p1.Quantity) AverageQuantity
from Production.ProductInventory p1
where p1.LocationID = 10;

--Question 9
select p1.ProductID, p1.Shelf, AVG(Quantity) TheAvg
From Production.ProductInventory p1
group by p1.ProductID, p1.Shelf;

--Question 10
select p1.ProductID, p1.Shelf, AVG(Quantity) TheAvg
From Production.ProductInventory p1
where Shelf != 'N/A'
group by p1.ProductID, p1.Shelf;

--Question 11
select p.Color, p.Class, count(p.ProductID) TheCount, avg(p.ListPrice) AvgPrice
from Production.Product p
where p.Color is not null and p.Class is not null
group by p.Color, p.Class;

--Question 12
select r.Name Country, s.Name Province
from Person.CountryRegion r join Person.StateProvince s
on r.CountryRegionCode = s. CountryRegionCode;

--Question 13
select r.Name Country, s.Name Province
from Person.CountryRegion r join Person.StateProvince s
on r.CountryRegionCode = s. CountryRegionCode
where r.Name in ('Canada','Germany');



/*use Northwind; */

--Question 14
select distinct p.ProductName 
from dbo.Orders o join dbo."order Details" od
on o.OrderID = od.OrderID
join products p
on od.ProductID = p.ProductID 
where o.OrderDate > '1997'

--Question 15
select top 5 c.PostalCode, count(*) NumberOfSales
from dbo.Orders o join Dbo.Customers c
on o.CustomerID = c.CustomerID
group by c.PostalCode
order by (NumberOfSales) DESC;

--Question 16
select top 5 c.PostalCode, count(*) NumberOfSales
from dbo.Orders o join Dbo.Customers c
on o.CustomerID = c.CustomerID
where o.OrderDate > '1997'
group by c.PostalCode
order by (NumberOfSales) DESC;

--Question 17
select count(CustomerID) CustomerCount, c.city
from dbo.Customers c
group by c.City

--Question 18
select count(CustomerID) CustomerCount, c.city
from dbo.Customers c
group by c.City
having count(CustomerID) > 2

--Question 19
select distinct c.CompanyName
from dbo.Orders o join dbo.Customers c
on o.CustomerID = c.CustomerID
where o.OrderDate > '1998-1-1'

--Question 20
select c. CompanyName, t.OrderDate
from dbo.Customers c join (
select o.CustomerID, max(OrderDate) OrderDate
from dbo.Orders o join dbo.Customers c
on o.CustomerID = c.CustomerID
group by o.CustomerID) t
on c.CustomerID = t.CustomerID

--Question 21
select c.CompanyName, count(p.ProductID) TheCount
from dbo.Orders o join Dbo.Customers c
on o.CustomerID = c.CustomerID
join dbo.[Order Details] od
on o.OrderId = od.OrderID
join dbo.Products p
on od.ProductID = p.ProductID
group by c.CustomerID, c.CompanyName

--Question 22
select c.CustomerID, count(p.ProductID) TheCount
from dbo.Orders o join Dbo.Customers c
on o.CustomerID = c.CustomerID
join dbo.[Order Details] od
on o.OrderId = od.OrderID
join dbo.Products p
on od.ProductID = p.ProductID
group by c.CustomerID
having count(p.ProductID) > 100

--Question 23
select s1.CompanyName "Supplier Company Name", s2.CompanyName "Shipping Company Name"
from dbo.Suppliers s1 cross join dbo.Shippers s2

--Question 24
select p.ProductName, o.OrderDate
from dbo.Orders o join dbo.[Order Details] od
on o.OrderID = od.OrderID
join dbo.Products p
on p.ProductID = od.ProductID

--Question 25
Select e1.FirstName + ' ' + e1.LastName EmployeeName1, e2.FirstName + ' ' + e2.LastName EmployeeName2
from Employees e1 join Employees e2
on e1.title = e2.title
where e1.EmployeeID != e2.EmployeeID

--Question 26
select e3.FirstName + ' ' + e3.LastName Manager
from Employees e3 join 
(Select e1.ReportsTo
from Employees e1 join Employees e2
on e1.ReportsTo = e2.EmployeeID
group by e1.ReportsTo
having count(e1.ReportsTo) > 2) t
on e3.EmployeeID = t.ReportsTo

--Question 27
select City, CompanyName, ContactName, 'Customer' as Type
from dbo.Customers
Union
select City, CompanyName, ContactName, 'Supplier' as Type
from dbo.Suppliers
