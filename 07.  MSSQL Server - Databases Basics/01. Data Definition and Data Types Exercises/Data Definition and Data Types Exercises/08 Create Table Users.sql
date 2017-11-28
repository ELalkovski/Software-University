CREATE TABLE Users 
(
	Id INT PRIMARY KEY IDENTITY,
	Username VARCHAR(30) NOT NULL,
	Password VARCHAR(26) NOT NULL,
	ProfilePicture VARBINARY(900),
	LastLoginTime DATETIME,
	IsDeleted BIT DEFAULT(1)
)

INSERT INTO Users (Username, Password, LastLoginTime) VALUES
('Gosho', 'dsfsdfsd', GETDATE()),
('Pesho', 'todoreeee', GETDATE()),
('Kosta', 'keremida', GETDATE()),
('Boci', 'stupidpassword', GETDATE()),
('KoksalBaba', 'hackme', GETDATE())

DROP TABLE Users