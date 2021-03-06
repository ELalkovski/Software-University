CREATE DATABASE OnlineStore

CREATE TABLE Cities
(
	CityID INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL
)

CREATE TABLE Customers
(
	CustomerID INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	Birthday DATE NOT NULL,
	CityID INT
	CONSTRAINT FK_Customers_City_ID
	FOREIGN KEY (CityID)
	REFERENCES Cities(CityID)
)

CREATE TABLE Orders
(
	OrderID INT PRIMARY KEY IDENTITY,
	CustomerID INT
	CONSTRAINT FK_Customer_ID
	FOREIGN KEY (CustomerID)
	REFERENCES Customers (CustomerID)
)

CREATE TABLE ItemTypes
(
	ItemTypeID INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50)
)

CREATE TABLE Items
(
	ItemID INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	ItemTypeID INT
	CONSTRAINT FK_Items_ItemType_ID
	FOREIGN KEY (ItemTypeID)
	REFERENCES ItemTypes(ItemTypeID)
)

CREATE TABLE OrderItems
(
	ItemID INT,	
	OrderID INT,

	CONSTRAINT FK_OrderItems_Item_ID
	FOREIGN KEY (ItemID)
	REFERENCES Items(ItemID),

	CONSTRAINT FK_OrderItems_Order_ID
	FOREIGN KEY (OrderID)
	REFERENCES Orders(OrderID),

	PRIMARY KEY (ItemID, OrderID)
)