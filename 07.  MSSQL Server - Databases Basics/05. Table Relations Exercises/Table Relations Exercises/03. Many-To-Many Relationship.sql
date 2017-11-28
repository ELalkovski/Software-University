CREATE TABLE Students
(
	StudentID INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL
)

INSERT INTO Students ([Name]) VALUES
('Mila'),
('Toni'),
('Ron')

CREATE TABLE Exams
(
	ExamID INT PRIMARY KEY IDENTITY(101, 1),
	[Name] VARCHAR(50) NOT NULL
)

INSERT INTO Exams ([Name]) VALUES
('SpringMVC'),
('Neo4j'),
('Oracle 11g')

CREATE TABLE StudentsExams
(
	StudentID INT,	
	ExamID INT,

	CONSTRAINT FK_Student_ID
	FOREIGN KEY(StudentID)
	REFERENCES Students(StudentID),

	CONSTRAINT FK_Exam_ID
	FOREIGN KEY(ExamID)
	REFERENCES Exams(ExamID),

	PRIMARY KEY (StudentID, ExamID)
)

INSERT INTO StudentsExams (StudentID, ExamID) VALUES
(1, 101),
(1, 102),
(2, 101),
(3, 103),
(2, 102),
(2, 103)