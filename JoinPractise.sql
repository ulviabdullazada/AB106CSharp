--CREATE DATABASE JoinsPractise
--USE JoinsPractise

CREATE TABLE Categories(
Id INT PRIMARY KEY IDENTITY(1,1),
[Name] NVARCHAR(100) NOT NULL UNIQUE
)

CREATE TABLE Products(
Id INT PRIMARY KEY IDENTITY(1,1),
[Name] NVARCHAR(100) NOT NULL UNIQUE,
Price DECIMAL(6,2) CHECK(Price>0), 
Stock INT CHECK(Stock>=0),
CategoryId INT REFERENCES Categories(Id)
)

CREATE TABLE Colors(
Id INT PRIMARY KEY IDENTITY(1,1),
[Name] NVARCHAR(100) NOT NULL UNIQUE
)

CREATE TABLE ProductColors(
Id INT PRIMARY KEY IDENTITY(1,1),
ProductId INT REFERENCES Products(Id),
ColorId INT REFERENCES Colors(Id)
)



INSERT INTO Categories VALUES('Mobile'),('TV'),('Music Bar')

INSERT INTO Products VALUES('Samsung s22',456,12,1)


SELECT p.Name  AS Product,c.Name [Category Name] FROM Products AS p
INNER JOIN Categories AS c
ON p.CategoryId=c.Id


SELECT p.Name AS Product, c.Name AS Category FROM Products AS p
LEFT JOIN Categories AS c
ON p.CategoryId=c.Id
--WHERE p.CategoryId is NULL

SELECT p.Name as Product,c.Name AS Category FROM Products AS p
FULL OUTER JOIN Categories AS c
ON p.CategoryId=c.Id
--WHERE p.CategoryId is NULL



SELECT p.Name as Product, c.Name as Color FROM Products AS p
LEFT JOIN ProductColors AS pc
ON p.Id=pc.ProductId
LEFT JOIN Colors AS c
ON pc.ColorId=c.Id



--Categories:
--Id,
--Name

--Products:
--Id,
--Name,
--Price,
--Stock,
--CategoryId


--Colors:
--Id,
--Name,

--ProductColors:

--Sorgular ->
--a)Mehsullari categorileri ile birlikde cixaran sorgu(category-i olmayan mehsul cixmasin
--b)Butun mehsullar categorileri ile birge cixsinlar(categorisi olmayanlar bele)
--c)Butun mehsul ve categoriler cixsinlar(elaqesi olanlar yan yana cixsin)