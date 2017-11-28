CREATE DATABASE CarRental

USE CarRental

CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY,
	CategoryName NVARCHAR(50) NOT NULL,
	DailyRate INT,
	WeeklyRate INT,
	MonthlyRate INT NOT NULL,
	WeekendRate INT
)

INSERT INTO Categories (CategoryName, MonthlyRate) VALUES
('Hechbacks', 5),
('Sedans', 6),
('Minivans', 6)

CREATE TABLE Cars 
(
	Id INT PRIMARY KEY IDENTITY,
	PlateNumber NVARCHAR(15) NOT NULL,
	Manufacturer VARCHAR(20) NOT NULL,
	Model VARCHAR(30) NOT NULL,
	CarYear VARCHAR(4) NOT NULL,
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	Doors VARCHAR(10),
	Picture VARBINARY(2000),
	Condition NVARCHAR(30) NOT NULL,
	Available BIT NOT NULL
)

INSERT INTO Cars (PlateNumber, Manufacturer, Model, CarYear, CategoryId, 
Condition, Available) VALUES
('CA 9398 MM', 'Opel', 'Astra', '2006', 1, 'Excellent', 1),
('CB 1213 AA', 'Ford', 'KA', '2003', 1, 'Good', 0),
('CA 6693 BA', 'BMW', 'M3', '2015', 2, 'Excellent', 1)

CREATE TABLE Employees
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	Title NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Employees (FirstName, LastName, Title) VALUES
('Pesho', 'Peshov', 'Rental Manager'),
('Gosho', 'Goshov', 'Executive Manager'),
('Stamat', 'Stamatov', 'Engineer')

CREATE TABLE Customers
(
	Id INT PRIMARY KEY IDENTITY,
	DriverLicenceNumber INT NOT NULL,
	FullName NVARCHAR(100) NOT NULL,
	Adress NVARCHAR(200) NOT NULL,
	City NVARCHAR(20) NOT NULL,
	ZIPCode INT NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Customers (DriverLicenceNumber, FullName, 
Adress, City, ZIPCode) VALUES
(312412, 'Misho Mishov', 'dfsfsdfsadfs', 'Sofia', 1133),
(231432, 'Mitko Mishov', 'asdgbhgf', 'Plovdiv', 1236),
(111111, 'Ivan Ivanov', 'ddsffdgdffsfsdfsadfs', 'Varna', 5412)

CREATE TABLE RentalOrders
(
	Id INT PRIMARY KEY IDENTITY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
	CustomerId INT FOREIGN KEY REFERENCES Customers(Id),
	CarId INT FOREIGN KEY REFERENCES Cars(Id),
	TankLevel NUMERIC(5, 2) NOT NULL,
	KilometrageStart NUMERIC(15, 2) NOT NULL,
	KilometrageEnd NUMERIC(15, 2),
	TotalKilometrage NUMERIC(15, 2),
	StartDate DATE DEFAULT(GETDATE()),
	EndDate DATE,
	TotalDays INT,
	RateApplied BIT,
	TaxRate NUMERIC(15, 2) NOT NULL,
	OrderStatus NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX) 
)

INSERT INTO RentalOrders (EmployeeId, CustomerId, CarId, TankLevel,
KilometrageStart, TaxRate, OrderStatus) VALUES
(1, 1, 3, 90.00, 56.33, 120.00, 'Pending'),
(1, 2, 2, 50.00, 123.33, 40.00, 'Pending'),
(1, 3, 1, 40.00, 150.33, 30.00, 'Pending')