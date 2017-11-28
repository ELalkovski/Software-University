CREATE DATABASE Hotel

USE Hotel

CREATE TABLE Employees
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	Title NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Employees (FirstName, LastName, Title) VALUES
('Gosho', 'Goshev', 'Recepcionist'),
('Pesho', 'Peshev', 'Manager'),
('Stamat', 'Gochev', 'Recepcionist')

CREATE TABLE Customers
(
	AccountNumber INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	PhoneNumber NVARCHAR(10) NOT NULL,
	EmergencyName NVARCHAR(50),
	EmergencyNumber NVARCHAR(10) NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Customers (FirstName, LastName, PhoneNumber, EmergencyNumber) VALUES
('Mirko', 'Stakov', 0889923123, 0789923123),
('Sarko', 'Mirkov', 0845623123, 0876923123),
('Goiko', 'Markov', 0889577123, 0789651123)

CREATE TABLE RoomStatus
(
	RoomStatus VARCHAR(20) PRIMARY KEY NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO RoomStatus (RoomStatus) VALUES
('Empty'),
('Occupied'),
('Unavailable')

CREATE TABLE RoomTypes
(
	RoomType NVARCHAR(50) PRIMARY KEY NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO RoomTypes(RoomType) VALUES
('Bedroom'),
('Master Bedroom'),
('President Apartament')

CREATE TABLE BedTypes
(
	BedType NVARCHAR(50) PRIMARY KEY NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO BedTypes(BedType) VALUES
('One Person'),
('Two Person'),
('Oversized Bed')

CREATE TABLE Rooms
(
	RoomNumber INT PRIMARY KEY,
	RoomType NVARCHAR(50) FOREIGN KEY REFERENCES RoomTypes(RoomType),
	BedType NVARCHAR(50) FOREIGN KEY REFERENCES BedTypes(BedType),
	Rate INT,
	RoomStatus VARCHAR(20) FOREIGN KEY REFERENCES RoomStatus(RoomStatus),
	Notes NVARCHAR(MAX)
)

INSERT INTO Rooms (RoomNumber, RoomType, BedType, Rate, RoomStatus) VALUES
(101, 'Bedroom', 'One Person', NULL, 'Empty'),
(102, 'Master Bedroom', 'Two Person', 5, 'Empty'),
(103, 'President Apartament', 'Oversized Bed', 6, 'Empty')

CREATE TABLE Payments
(
	Id INT PRIMARY KEY IDENTITY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
	PaymentDate DATE DEFAULT(GETDATE()),
	AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber),
	FirstDateOccupied DATE DEFAULT(GETDATE()),
	LastDateOccupied DATE,
	TotalDays INT,
	AmountCharged NUMERIC(15, 2),
	TaxRate NUMERIC(15, 2),
	TaxAmount NUMERIC(15, 2),
	PaymentTotal NUMERIC(15, 2),
	Notes NVARCHAR(MAX)
)

INSERT INTO Payments (EmployeeId, AccountNumber) VALUES
(1, 1),
(2, 2),
(3, 3)

CREATE TABLE Occupancies
(
	Id INT PRIMARY KEY IDENTITY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
	DateOccupied DATE DEFAULT(GETDATE()),
	AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber),
	RoomNumber INT FOREIGN KEY REFERENCES Rooms(RoomNumber),
	RateApplied BIT,
	PhoneCharge NUMERIC(15, 2),
	Notes NVARCHAR(MAX)
)

INSERT INTO Occupancies (EmployeeId, AccountNumber, RoomNumber) VALUES
(1, 1, 101),
(1, 1, 102),
(1, 1, 103)
