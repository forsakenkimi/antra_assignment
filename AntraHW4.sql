use Northwind;
select *
from dbo.[Order Details]


--question 1
create view "view_product_order_[Cheng]"
as
select p.ProductID, sum(od.Quantity) TotalQuantity
from dbo.products p left join dbo.[Order Details] od
on p.ProductID = od.ProductID
group by p.ProductID ;

--question 2
create procedure "sp_product_order_quantity_[Cheng]" @id int, @quantity int out
as
begin
select @quantity = sum(od.quantity)
from dbo.[Order Details] od
where od.ProductID = @id
group by od.ProductID 
end

/*declare @result int
execute "sp_product_order_quantity_[Cheng]" '11', @result out
print(@result) */

--question 3
create procedure "sp_product_order_city_[Cheng]" @productName varchar(255)
AS
begin
select top 5 p.ProductName, c.City, sum(od.Quantity) TotalQuantity
from Products p join dbo.[Order Details] od
on p.ProductID = od.ProductID
join dbo.Orders o
on o.OrderID = od.OrderID
join Customers c 
on c.CustomerID = o.CustomerID
where p.ProductName =  @productName
group by p.ProductName, c.City
order by TotalQuantity DESC
end

/*execute "sp_product_order_city_[Cheng]" 'Tofu' */


--Question 4
create table "city_Cheng" (
Id int,
City varchar(25))
insert into "city_Cheng" values 
(1, 'Seattle'),
(2, 'Green Bay')

create table "people_Cheng" (
id int,
Name varchar(25),
City int)
insert into "people_Cheng" values
(1, 'Aaron Rodgers', 2),
(2, 'Russell Wilson', 1),
(3, 'Jody Nelson', 2)

delete from  "city_Cheng" 
where "city_Cheng".City = 'Seattle'
insert into "city_Cheng" values 
(3, 'Madison')

update "people_Cheng"
set "people_Cheng".City = 3
where "people_Cheng".City = 1

create view "Packers_Cheng"
as
select p.Name,c.City
from "people_Cheng" p join  "city_Cheng" c
on c.id = p.City
where c.City = 'Green Bay'

/*select *
from "Packers_Cheng"*/

--Question 5
create procedure "sp_birthday_employees_Cheng"
AS
begin
select * into "birthday_employees_Cheng"
from dbo.Employees
where Month(BirthDate) = 2
end

 --Question 6
 /* union two tables including all fields. If number of rows are the same after union, then two tables are the same.
