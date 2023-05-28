# E-Commerce

Let's design the database of an e-commerce site for the following situations. There are categories, it has information such as name, number of products, number of companies. There are companies. There is the name of the companies and the category they belong to. A company can sell products from more than one category. Products are available, the product has categories, companies, name, code, price. Orders are available. The order has code, address, estimated delivery date, name and surname of the person delivered. Many products can be found in one order. There is an invoice. An invoice can have many items and one order. An invoice is issued for each order.

The draw.io drawing of the above e-commerce database design problem is as follows:

![image](https://user-images.githubusercontent.com/119699844/220654022-07fa70dc-c6b9-4a12-9d55-ed2ef19ec472.png)

create table Category( Id int primary key IDENTITY (1,1), CategoryName varchar(100) ); drop table Category insert into Category (CategoryName) values ('Food')

create table Company( Id int primary key IDENTITY (1,1), CompanyName varchar(100) );

create table Bill( Id int primary key IDENTITY (1,1), Code int );

create table CompanyProduct( Id int primary key IDENTITY (1,1), Price float, CompanyId int, FOREIGN KEY (CompanyId) REFERENCES Company(Id) );

 create table Product( Id int primary key IDENTITY (1,1), ProductName varchar (100), CategoryId int, CompanyProductId int, FOREIGN KEY (CategoryId) REFERENCES Category(Id), FOREIGN KEY (CompanyProductId) REFERENCES CompanyProduct(Id) ); 

create table Orders( Id int primary key IDENTITY (1,1), Code int, Address varchar (150), DeliveryTime time, CustomerName varchar (100), CustomerSurname varchar (100), BillId int, FOREIGN KEY (BillId) REFERENCES Bill(Id) );

create table ProductOrder( Id int primary key IDENTITY (1,1), OrdersId int, ProductId int, FOREIGN KEY (OrdersId) REFERENCES Orders(Id), FOREIGN KEY (ProductId) REFERENCES Product(Id) );

--Addresses of orders with company name B

SELECT Orders.Address FROM Companies, CompanyProduct, Products, Bills, Orders
WHERE Companies.Id = CompanyProduct.CompanyId
AND   Products.Id = CompanyProduct.ProductId
AND	  Bills.ProductId = Products.Id
AND   Orders.Id = Bills.OrderId 
AND   Companies.Name = 'B'

--Category name of the order with order code 3

SELECT Categories.Name FROM Orders, Bills, Products, CategoryProduct, Categories
WHERE Orders.Id = Bills.OrderId
AND   Products.Id = Bills.ProductId
AND   CategoryProduct.ProductId = Products.Id
AND   Categories.Id = CategoryProduct.CategoryId
AND   Orders.Code = 3
