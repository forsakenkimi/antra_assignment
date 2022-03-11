/*use Northwind;*/

--Question 1
select distinct c.City
from dbo.Customers c
where c.City in (
select e. City
from dbo.Employees e)

/*
select c. City
from dbo.Customers c
intersect
select e. City
from dbo.Employees e
*/

--Question 2
--a
select distinct c.City
from dbo.Customers c
where c.City not in (
select e. City
from dbo.Employees e)

--b
select distinct c.City
from dbo.Customers c full join dbo.Employees e
on c.City = e.City
where e.EmployeeID is null

/* select distinct c. City
from dbo.Customers c
except
select e. City
from dbo.Employees e */

--Question 3
select p.ProductID, sum(od.Quantity) SumOfQuantity
from dbo.Products p left join dbo.[Order Details] od
on p.ProductID = od.ProductID
group by p.ProductID

--Question 4
select c.City, sum(od.Quantity) SumOfQuantity
from dbo.Customers c join dbo.Orders o
on c.CustomerID = o.CustomerID
join dbo.[Order Details] od
on o.OrderID = od.OrderID
group by c.City

--Question 5
--a
select top 0 percent c.city, count(c.CustomerID) CountOfCity
from dbo.Customers c
group by c.city
having count(c.CustomerID) >= 2
union
select top 100 percent c.city, count(c.CustomerID)
from dbo.Customers c
group by c.city
having count(c.CustomerID) >= 2

--b
select distinct c1.city, (select count(*) from dbo.Customers c2 where c1.City = C2.City) CountOfCity
from dbo.Customers c1
where (select count(*) from dbo.Customers c2 where c1.City = C2.City) >= 2


--Question 6
select c.city, count(od.ProductID)
from dbo.Customers c join dbo.Orders o
on c.CustomerID = o.CustomerID
join dbo.[Order Details] od
on o.OrderID = od.OrderID
group by c.city
having count(od.ProductID) >= 2

--Quesiton 7
select distinct c.CompanyName
from dbo.Customers c join dbo.Orders o
on c.CustomerID = o.CustomerID
where c.city != o.ShipCity

--Question 8
select top 5 p.ProductID, COUNT(p.ProductID) CountOfOrder, 
(select (sum(od1.UnitPrice * od1.Quantity) / sum(od1.Quantity)) from dbo.[Order Details] od1 where p.productID = od1.ProductID) AvgUnitPrice,
(select top 1 c2.CompanyName
from dbo.Customers c2 join dbo.Orders o2
on c2.CustomerID = o2.CustomerID
join dbo.[Order Details] od2
on o2.OrderID = od2.OrderID
where p.ProductID = od2.ProductID 
group by c2.CustomerID, c2.CompanyName
order by sum(od2.Quantity) desc)
from dbo.Products p join dbo.[Order Details] od
on p.ProductID = od.ProductID
group by p.ProductID
order by CountOfOrder desc

--Question 9
--a
select e.City
from dbo.Employees e
where e.City not in (
select c.City
from dbo.Customers c
)
--b
select e.City
from dbo.Employees e left join dbo.Customers c
on e.city = c.City
where c.CustomerID is null

--Question 10
select e.City
from dbo.Employees e
where e.EmployeeID = (select top 1 e.EmployeeID
from dbo.Employees e join dbo.Orders o
on e.EmployeeID = o.EmployeeID
group by e.EmployeeID
order by count(o.OrderID) desc) 
union
select c2.city
from dbo.Customers c2
where c2.city = (
select top 1 c1.city
from dbo.Customers c1 join dbo.Orders o1
on c1.CustomerID = o1.CustomerID
join dbo.[Order Details] od1
on o1.OrderID = od1.OrderID
group by c1.city
order by sum(od1.Quantity) DESC)

--Question 11
/*I will use distinct keyword in the select clause*/





