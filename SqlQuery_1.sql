--Select
--ANSII
Select ContactName Adi, CompanyName Sirketadi, City Sehir from Customers

Select * from Customers where City = 'Berlin'

--case insensitive
SeLeCt * from Products where CategoryID=1 or CategoryID=3

Select * from Products where CategoryID=1 and UnitPrice>=10

Select * from Products order by ProductName

Select * from Products where CategoryID=1 order by UnitPrice desc --asc = adcending (artan) // desc = descending (azalan)

Select count(*) Adet from Products where CategoryID=2

Select CategoryID Kategori, count(*) ÜrünSayısı from Products where UnitPrice>20 group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName from Products inner join Categories on Products.CategoryID = Categories.CategoryID

--DTO Data Transformation object

Select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID

--inner join sadece eşleşenleri birleştirir
--left solda olup sağda olmayanları da getirir

Select * from Customers c left join Orders o on c.customerID = o.CustomerID where o.CustomerID is null


Select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID inner join Orders o on o.OrderID = od.OrderID