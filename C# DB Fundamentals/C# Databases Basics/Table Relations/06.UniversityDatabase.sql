CREATE DATABASE University;

CREATE TABLE Subjects(
	SubjectID INT IDENTITY(1,1) PRIMARY KEY,
	SubjectName VARCHAR(30)
);

CREATE TABLE Majors(
	MajorID INT IDENTITY(1,1) PRIMARY KEY,
	[Name] VARCHAR(25)
);

CREATE TABLE Students(
	StudentID INT IDENTITY(1,1) PRIMARY KEY,
	StudentNumber INT,
	StudentName VARCHAR(25),
	MajorID INT REFERENCES Majors(MajorID)
);

CREATE TABLE Payments(
	PaymentID INT IDENTITY(1,1) PRIMARY KEY,
	PaymentDate DATETIME2,
	PaymentAmount FLOAT,
	StudentID INT REFERENCES Students(StudentID)
);

CREATE TABLE Agenda(
	StudentID INT REFERENCES Students(StudentID),
	SubjectID INT REFERENCES Subjects(SubjectID),
	PRIMARY KEY (StudentID, SubjectID)
);