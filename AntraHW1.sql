use AdventureWorks2019;


--Question 1
select p.ProductID, p."Name", p.Color, p.ListPrice
from Production.Product p;

--Question 2
select p.ProductID, p."Name", p.Color, p.ListPrice
from Production.Product p 
where p.listPrice != 0;

--Question 3
select p.ProductID, p."Name", p.Color, p.ListPrice
from Production.Product p 
where p.Color is null;

--Question 4
select p.ProductID, p."Name", p.Color, p.ListPrice
from Production.Product p 
where p.Color is not null;

--Question 5
select p.ProductID, p."Name", p.Color, p.ListPrice
from Production.Product p 
where p.Color is not null and p.ListPrice > 0;

--Question 6
select p."Name" + ' ' + p.Color
from Production.Product p
where color is not null;

--Question 7
select 'NAME:' + p."Name" + ' -- COLOR: ' + p.Color
from Production.product p
where p.Color in ('Black', 'Silver');
/* select TOP 6 ... */

-- Question 8
select p.ProductID, p."Name"
from Production.Product p
where ProductID between 400 and 500;

--Question 9
Select p.ProductID, p."Name", p.Color
from Production.Product p
where p.Color = 'Black' or p.Color = 'Blue';

--Question 10
select p."Name", p.ProductID
from Production.Product p
where p."Name" like 'S%'

--Question 11
Select p."Name", p."ListPrice"
from Production.Product p
order by p."Name";

--Question 12
select p."Name", p."ListPrice" 
from Production.Product p
where p."Name" like 'A%' or p."Name" like 'S%'
order by p."Name";

--Question 13
Select p.Name
from Production.Product p
where p."Name" like 'SPO[^K]%'
order by p."Name";

/* select t."Name"
from (Select p.Name from Production.Product p where p."Name" like 'SPO%') as t
where t."Name" not like ('SPOK%')
order by t."Name"; */

--Question 14
Select distinct p.Color 
from Production.Product p
order by p.Color DESC

--Question 15
select distinct p.ProductSubcategoryID, p.Color
from Production.Product p
where p.ProductSubcategoryID is not null and p.Color is not null
order by p.ProductSubcategoryID, p.Color;