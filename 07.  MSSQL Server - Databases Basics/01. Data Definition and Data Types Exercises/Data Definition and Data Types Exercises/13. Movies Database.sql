CREATE DATABASE Movies

USE Movies

CREATE TABLE Directors 
(
	Id INT PRIMARY KEY IDENTITY,
	DirectorName VARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
)

CREATE TABLE Genres 
(
	Id INT PRIMARY KEY IDENTITY,
	GenreName VARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
)

CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY,
	CategoryName VARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
)

CREATE TABLE Movies
(
	Id INT PRIMARY KEY IDENTITY,
	Title VARCHAR(50) NOT NULL,
	DirectorId INT FOREIGN KEY REFERENCES Directors(Id),
	CopyrightYear DATE,
	[Length] NUMERIC (3, 2),
	GenreId INT FOREIGN KEY REFERENCES Genres(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	Rating NUMERIC (3, 2),
	Notes NVARCHAR(MAX)
)

INSERT INTO Directors (DirectorName) VALUES
('Pesho'),
('Gosho'),
('Tosho'),
('Stamen'),
('Martin')

INSERT INTO Genres (GenreName) VALUES
('Horror'),
('Comedy'),
('War Drama'),
('Thriller'),
('Action')

INSERT INTO Categories (CategoryName) VALUES
('Science Fiction'),
('Superhero Fiction'),
('Historical Movies'),
('Apocalyptic Movies'),
('Alternate History Fiction')

INSERT INTO Movies (Title, DirectorId, GenreId, CategoryId) VALUES
('Star Wars Episode I: Phantom Menace', 1, 5, 1),
('Star Wars Episode II: Clone Wars', 1, 5, 1),
('Star Wars Episode III: Revenge of the Sith', 1, 5, 1),
('Spiderman: Homecoming', 3, 5, 2),
('The Red Dragon', 4, 1, 3)