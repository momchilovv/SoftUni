--1. Create Database
CREATE DATABASE Minions

--2. Create Tables
CREATE TABLE Minions(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL,
	Age INT
)

CREATE TABLE Towns(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL
)

--3. Alter Minions Table
ALTER TABLE Minions 
ADD TownId INT;

ALTER TABLE Minions 
ADD FOREIGN KEY (TownId) REFERENCES Towns(Id);

--4. Insert Records in Both Tables
INSERT INTO Towns
VALUES  (1, 'Sofia'),
		(2, 'Plovdiv'),
		(3, 'Varna');

INSERT INTO Minions
VALUES  (1, 'Kevin', 22, 1),
		(2, 'Bob', 15, 3),
		(3, 'Steward', NULL, 2);

--5. Truncate Table Minions
TRUNCATE TABLE Minions;

--6. Drop All Tables
DROP TABLE Minions;

--7. Create Table People
CREATE TABLE People(
	Id BIGINT IDENTITY(1,1) PRIMARY KEY,
	[Name] NVARCHAR(200) NOT NULL,
	Picture BIT,
	Height DECIMAL(10,2),
	[Weight] DECIMAL(10,2),
	Gender CHAR(1) NOT NULL,
	Birthdate DATETIME2 NOT NULL,
	Biography NVARCHAR(MAX)
);

INSERT INTO People
VALUES  ('Pesho', NULL, 1.67, 76.22, 'm', '2001-11-01', 'Pesho se kazva pesho zaradi baba si,'),
		('Goshko', NULL, 1.73, 71.63, 'm', '1995-01-09', 'koqto se vliubila v ruski voinik prez vtorata svetovna'),
		('Mariq', 1, 1.54, 48.99, 'f', '2012-12-12', 'sled kato skitala iz boinite poleta'),
		('Petranka', 0, 1.44, 105.12, 'f', '1998-12-18', NULL),
		('Atanaska', NULL, 1.60, 50.00, 'f', '1901-01-05', 'A tova e babata.');

--8. Create Table Users
CREATE TABLE Users(
	Id BIGINT IDENTITY(1,1) PRIMARY KEY,
	Username VARCHAR(30) NOT NULL,
	[Password] VARCHAR(26) NOT NULL,
	ProfilePicture INT,
	LastLoginTime DATETIME2,
	IsDeleted BIT
);

INSERT INTO Users
VALUES	('lamqtaSpaska', '123456', 12, '2022-12-10', 'true'),
		('goshoZmeq', '123456', NULL, '2022-06-16', 'false'),
		('petqShisharkata', '123456', 500, '2022-01-02', 'false'),
		('ledenaKralica', '123456', NULL, '2013-10-11', 'false'),
		('petrankaUshanka', '123456', 1, '2017-03-05', 'true');

--9. Change Primary Key
ALTER TABLE Users
ADD CONSTRAINT PK_User PRIMARY KEY (Id, Username);

--10. Add Check Constraint
ALTER TABLE Users
ADD CONSTRAINT CHK_PasswordLength CHECK (LEN([Password]) >= 5);

--11. Set Default Value of a Field
ALTER TABLE Users
ADD CONSTRAINT DF_LastLoginTime
DEFAULT GETDATE() FOR LastLoginTime;

--12. Set Unique Field
ALTER TABLE Users
DROP CONSTRAINT PK_User;

ALTER TABLE Users
ADD CONSTRAINT PK_User PRIMARY KEY (Id);

ALTER TABLE Users
ADD CONSTRAINT UC_Username UNIQUE (Username);

ALTER TABLE Users 
ADD CONSTRAINT CHK_UsernameLength CHECK (LEN(Username) >= 3);

--13. Movies Database
CREATE DATABASE Movies;

CREATE TABLE Directors(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	DirectorName VARCHAR(25) NOT NULL,
	Notes VARCHAR(MAX)
);

CREATE TABLE Genres(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	GenreName VARCHAR(25) NOT NULL,
	Notes VARCHAR(MAX)
);

CREATE TABLE Categories(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	CategoryName VARCHAR(25) NOT NULL,
	Notes VARCHAR(MAX)
);

CREATE TABLE Movies(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Title VARCHAR(25) NOT NULL,
	DirectorId INT FOREIGN KEY REFERENCES Directors(Id) NOT NULL,
	CopyrightYear INT NOT NULL,
	[Length] VARCHAR(10) NOT NULL,
	GenreId INT FOREIGN KEY REFERENCES Genres(Id) NOT NULL,
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id) NOT NULL,
	Rating VARCHAR(10),
	Notes VARCHAR(MAX)
);

INSERT INTO Directors
VALUES	('Pesho Kalibrata', NULL),
		('Gosho Govedoto', 'Mnogo dobur'),
		('Sashko Tupoto', NULL),
		('Strina Gina', '4udesna producentka'),
		('Dida Vaflata', NULL);

INSERT INTO Genres
VALUES	('Komedi', NULL),
		('Horor', 'Mnogo strashno'),
		('Ek6un', NULL),
		('Trilur', 'I tova e strashno'),
		('Fantastik', NULL);

INSERT INTO Categories
VALUES	('18+', NULL),
		('16+', NULL),
		('12+', NULL),
		('6+', 'Filmi kato mecho puh'),
		('Kids', NULL);

INSERT INTO Movies
VALUES	('Umirai lesno', 2, 2003, '1:23:00', 3, 2, NULL, 'Brus Uilis pasti da qde'),
		('Golqmata rusalka', 4, 2004, '1:11:11', 1, 4, 'pet zvezdi', NULL),
		('Gravatar', 3, 2023, '3:53:42', 5, 3, NULL, NULL),
		('Starite susedi', 1, 2011, '4:30:42', 4, 1, '10/10', 'ispanska komediq'),
		('Miki Maus', 5, 2015, '00:23:00', 2, 5, NULL, NULL);

--14. Car Rental Database
CREATE DATABASE CarRental;

CREATE TABLE Categories(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	CategoryName VARCHAR(25) NOT NULL,
	DailyRate FLOAT NOT NULL,
	WeeklyRate FLOAT NOT NULL,
	MonthlyRate FLOAT NOT NULL,
	WeekendRate FLOAT NOT NULL
);

CREATE TABLE Cars(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	PlateNumber VARCHAR(10) NOT NULL,
	Manufacturer VARCHAR(15) NOT NULL,
	Model VARCHAR(10) NOT NULL,
	CarYear INT NOT NULL,
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id) NOT NULL,
	Doors TINYINT NOT NULL,
	Picture VARCHAR(100),
	Condition VARCHAR(15),
	Available BIT NOT NULL
);

CREATE TABLE Employees(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	FirstName VARCHAR(15) NOT NULL,
	LastName VARCHAR(15) NOT NULL,
	Title VARCHAR(15) NOT NULL,
	Notes VARCHAR(MAX)
);

CREATE TABLE Customers(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	DriverLicenseNumber VARCHAR(15) NOT NULL,
	FullName VARCHAR(30) NOT NULL,
	[Address] VARCHAR(40) NOT NULL,
	City VARCHAR(15) NOT NULL,
	ZIPCode VARCHAR(10) NOT NULL,
	Notes VARCHAR(MAX)
);

CREATE TABLE RentalOrders(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id) NOT NULL,
	CustomerId INT FOREIGN KEY REFERENCES Customers(Id) NOT NULL,
	CarId INT FOREIGN KEY REFERENCES Cars(Id) NOT NULL,
	TankLevel INT NOT NULL,
	KilometrageStart INT NOT NULL,
	KilometrageEnd INT NOT NULL,
	TotalKilometrage INT NOT NULL,
	StartDate DATETIME2 NOT NULL,
	EndDate DATETIME2 NOT NULL,
	TotalDays SMALLINT NOT NULL,
	RateApplied FLOAT NOT NULL,
	TaxRate FLOAT NOT NULL,
	OrderStatus BIT NOT NULL,
	Notes VARCHAR(MAX)
);

INSERT INTO Categories
VALUES  ('Van', 15, 70, 150, 50),
		('Sport', 30, 140, 300, 100),
		('Sedan', 20, 90, 100, 65);

INSERT INTO Cars
VALUES	('CB1150MT', 'Audi', 'RS6', 2007, 2, 5, NULL, 'Good', 1),
		('M1275BT', 'BMW', '525i', 2005, 3, 4, NULL, 'Great', 0),
		('H6876PB', 'Volkswagen', 'Sharan', 2017, 1, 7, '8/10', 'New', 1);

INSERT INTO Employees
VALUES  ('Pesho', 'Goshov', 'Sales', NULL),
		('Ceko', 'Cekov', 'Assistant', 'Priema i parkira kolite'),
		('Spas', 'Panagiurov', 'Manager', 'gospodin mlad merindjei 24/7 se opredelq');

INSERT INTO Customers 
VALUES  ('5883252', 'Kiro Petkov', 'ul. Pred Parlamenta 69', 'Sofia', '1000', 'HARVARD!'),
		('6741923', 'Patrik Patrikov', 'ul. Industrialna 33', 'Berkovitsa', '3701', NULL),
		('8913282', 'Blagomir Blagovestov', 'bul. Shiroko Pole 999', 'Goce Delchev', '2900', NULL);

INSERT INTO RentalOrders
VALUES  (2, 3, 3, 50, 15000, 20000, 5000, '2022-01-04', '2022-01-06', 2, 70, 1.5, 1, 'Premier4eto naema van.'),
		(1, 2, 1, 60, 233463, 237500, 4037, '2022-06-24', '2022-06-24', 1, 300, 3.5, 1, NULL),
		(3, 1, 2, 70, 215000, 230000, 15000, '2023-01-14', '2023-01-15', 2, 65, 2.6, 0, NULL);

--15. Hotel Database
CREATE DATABASE Hotel;

CREATE TABLE Employees(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	FirstName VARCHAR(15) NOT NULL,
	LastName VARCHAR(15) NOT NULL,
	Title VARCHAR(20) NOT NULL,
	Notes VARCHAR(MAX)
);

CREATE TABLE Customers(
	AccountNumber INT PRIMARY KEY NOT NULL,
	FirstName VARCHAR(15) NOT NULL,
	LastName VARCHAR(15) NOT NULL,
	PhoneNumber INT NOT NULL,
	EmergencyName VARCHAR(15) NOT NULL,
	EmergencyNumber INT NOT NULL,
	Notes VARCHAR(MAX)
);

CREATE TABLE RoomStatus(
	RoomStatus VARCHAR(25) PRIMARY KEY NOT NULL,
	Notes VARCHAR(MAX)
);

CREATE TABLE RoomTypes(
	RoomType VARCHAR(25) PRIMARY KEY NOT NULL,
	Notes VARCHAR(MAX)
);

CREATE TABLE BedTypes(
	BedType VARCHAR(25) PRIMARY KEY NOT NULL,
	Notes VARCHAR(MAX)
);

CREATE TABLE Rooms(
	RoomNumber INT IDENTITY(1,1) PRIMARY KEY,
	RoomType VARCHAR(25) FOREIGN KEY REFERENCES RoomTypes(RoomType) NOT NULL,
	BedType VARCHAR(25) FOREIGN KEY REFERENCES BedTypes(BedType) NOT NULL,
	Rate FLOAT NOT NULL,
	RoomStatus VARCHAR(25) FOREIGN KEY REFERENCES RoomStatus(RoomStatus) NOT NULL,
	Notes VARCHAR(MAX)
);

CREATE TABLE Payments(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id) NOT NULL,
	PaymentDate DATETIME2 NOT NULL,
	AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber) NOT NULL,
	FirstDateOccupied DATETIME2 NOT NULL,
	LastDateOccupied DATETIME2 NOT NULL,
	TotalDays SMALLINT NOT NULL,
	AmountCharged FLOAT NOT NULL,
	TaxRate FLOAT NOT NULL,
	TaxAmount FLOAT NOT NULL,
	TaxTotal FLOAT NOT NULL,
	PaymentTotal FLOAT NOT NULL,
	Notes VARCHAR(MAX)
);

CREATE TABLE Occupancies(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id) NOT NULL,
	DateOccupied DATETIME2 NOT NULL,
	AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber) NOT NULL,
	RoomNumber INT FOREIGN KEY REFERENCES Rooms(RoomNumber) NOT NULL,
	RateApplied FLOAT NOT NULL,
	PhoneCharge FLOAT,
	Notes VARCHAR(MAX)
);

INSERT INTO Employees
VALUES  ('Damqn', 'Didjeiov', 'Recepcionist', '..i DJ v svobodnoto si vreme'),
		('Karla', 'Grigorova', 'Kamerierka', NULL),
		('Petran', 'Petrunkov', 'Pikolo', NULL);

INSERT INTO Customers
VALUES  (14912, 'Pesho', 'Peshov', 0881231231, 'Peshkan', 0812312314, NULL),
		(124512, 'Dimitrina', 'Vuchkova', 0881231231, 'Dimi', 0812312314, NULL),
		(1231233, 'Sebastian', 'James', 0881231231, 'Angli4anina', 0812312314, 'gost ot angliq');
		
INSERT INTO RoomStatus
VALUES  ('zaeta', NULL),
		('svobodna', NULL),
		('rezervirana', NULL);
		
INSERT INTO RoomTypes
VALUES  ('dvoina', NULL),
		('apartament', NULL),
		('edinichna', NULL);

INSERT INTO BedTypes
VALUES  ('dvoino', NULL),
		('vodno', NULL),
		('prista', NULL);

INSERT INTO Rooms
VALUES  ('dvoina', 'vodno', 170.50, 'zaeta', NULL),
		('apartament', 'dvoino', 196.20, 'rezervirana', NULL),
		('edinichna', 'prista', 70.70, 'svobodna', NULL);

INSERT INTO Payments
VALUES  (1, '2022-12-12', 14912, '2022-12-10', '2022-12-15', 5, 605, 2023.2, 2628.20, 15, 55, 'mnogo golqma taksa chuek'),
		(2, '2022-10-06', 124512, '2022-10-10', '2022-10-15', 5, 100, 15.20, 115.20, 15, 55, NULL),
		(3, '2022-03-09', 1231233, '2022-05-06', '2022-05-12', 6, 33, 2, 35, 15, 55, 'mnogo evtino chuek');
		
INSERT INTO Occupancies
VALUES  (1, GETDATE(), 14912, 1, 105, 50, NULL),
		(2, GETDATE(), 124512, 2, 105, 50, NULL),
		(3, GETDATE(), 1231233, 3, 105, 50, NULL);

--16. Create SoftUni Database
CREATE DATABASE SoftUni;

CREATE TABLE Towns(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	[Name] VARCHAR(25) NOT NULL
);

CREATE TABLE Addresses(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	AddressText VARCHAR(25) NOT NULL,
	TownId INT FOREIGN KEY REFERENCES Towns(Id) NOT NULL
);

CREATE TABLE Departments(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	[Name] VARCHAR(20) NOT NULL
);

CREATE TABLE Employees(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	FirstName VARCHAR(20) NOT NULL,
	MiddleName VARCHAR(20) NOT NULL,
	LastName VARCHAR(20) NOT NULL,
	JobTitle VARCHAR(25) NOT NULL,
	DepartmentId INT FOREIGN KEY REFERENCES Departments(Id) NOT NULL,
	HireDate DATETIME2 NOT NULL,
	Salary FLOAT NOT NULL,
	AddressId INT FOREIGN KEY REFERENCES Addresses(Id)
);

--17. Backup Database
--Object Explorer -> Rigth click on the database you want to back up ->
--Tasks -> Back Up... 

-- 18. Basic Insert
INSERT INTO Towns
VALUES  ('Sofia'),
		('Plovdiv'),
		('Varna'),
		('Burgas');

INSERT INTO Departments
VALUES  ('Engineering'),
		('Sales'),
		('Marketing'),
		('Software Development'),
		('Quality Assurance');
		
INSERT INTO Employees
VALUES  ('Ivan', 'Ivanov', 'Ivanov', '.NET Developer', 4, '2013/02/01', 3500.00, NULL),
		('Petar', 'Petrov', 'Petrov', 'Senior Engineer', 1, '2004/03/02', 4000.00, NULL),
		('Maria', 'Petrova', 'Ivanova', 'Intern', 5, '2016/08/28', 525.25, NULL),
		('Georgi', 'Terziev', 'Ivanov', 'CEO', 2, '2007/12/09', 3000.00, NULL),
		('Peter', 'Pan', 'Pan', 'Intern', 3, '2016/08/28', 599.88, NULL);

--19. Basic Select All Fields
SELECT * FROM Towns;
SELECT * FROM Departments;
SELECT * FROM Employees;

--20. Basic Select All Fields and Order Them
SELECT * FROM Towns ORDER BY [Name];
SELECT * FROM Departments ORDER BY [Name];
SELECT * FROM Employees ORDER BY Salary DESC;

--21. Basic Select Some Fields
SELECT [Name] FROM Towns ORDER BY [Name];
SELECT [Name] FROM Departments ORDER BY [Name];
SELECT FirstName, LastName, JobTitle, Salary
FROM Employees ORDER BY Salary DESC;

--22. Increase Employees Salary
UPDATE Employees SET Salary = Salary + (Salary * 0.10);
SELECT Salary FROM Employees;

--23. Decrease Tax Rate
UPDATE Payments SET TaxRate = TaxRate - (TaxRate * 0.03);
SELECT TaxRate FROM Payments;

--24. Delete All Records
TRUNCATE TABLE Occupancies;