CREATE TABLE People (
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(200) NOT NULL,
	Picture VARBINARY(2000),
	Height NUMERIC(3, 2),
	[Weight] NUMERIC(5, 2),
	Gender CHAR(1) NOT NULL,
	BirthDate DATE NOT NULL,
	Biography NVARCHAR (MAX)
)

INSERT INTO People (Name, Picture, Height, Weight, Gender, BirthDate, Biography) VALUES
('Gosho Manolev', NULL, 1.99, 60.00, 'm', '19900201' , NULL),
('Pesho Goshov', NULL, 1.77, 87.00, 'm', '19931201' , 'TEST Biography'),
('Stoko Ramirez', NULL, 1.53, 50.00, 'm', '19831201' , 'TEST Biography again'),
('Jana GlastenbauerDorf', NULL, 2.12, 90.00, 'f', '19921101' , 'Im very big woman'),
('Mariq Juana Dos Santos', NULL, 1.65, 53.00, 'f', '19900801' , NULL)

TRUNCATE TABLE People