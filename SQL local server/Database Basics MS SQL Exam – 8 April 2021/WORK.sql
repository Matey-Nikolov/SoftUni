CREATE TABLE Users
(
[Id]        INT PRIMARY KEY IDENTITY,
[Username]  VARCHAR(40) NOT NULL UNIQUE,
[Password]  VARCHAR(50) NOT NULL,
[Name]      NVARCHAR(50) NULL,
[Birthdate] DATETIME    NULL,
[Age]		INT CHECK (Age BETWEEN 14 AND 111) NOT NULL,
[Email]     VARCHAR(50) NOT NULL,
)

CREATE TABLE Departments
(
[Id]        INT PRIMARY KEY IDENTITY,
[Name]      VARCHAR(50) NOT NULL,
)

CREATE TABLE Employees
(
[Id]        INT PRIMARY KEY IDENTITY,
[FirstName] VARCHAR(25) NULL,
[LastName]  VARCHAR(25) NULL,
[Birthdate] DATETIME    NULL,
[Age]		INT CHECK (Age BETWEEN 18 AND 111) NULL,  --CHECK HERE
[DepartmentId] INT FOREIGN KEY REFERENCES Departments(Id)
)

CREATE TABLE Categories
(
[Id]           INT PRIMARY KEY IDENTITY NOT NULL,
[Name]         VARCHAR(50) NOT NULL,
[DepartmentId] INT FOREIGN KEY REFERENCES Departments(Id)
)

CREATE TABLE [Status]
(
[Id]        INT PRIMARY KEY IDENTITY,
[Label]     VARCHAR(30) NOT NULL,
)

CREATE TABLE Reports
(
[Id]          INT PRIMARY KEY IDENTITY,
[CategoryId]  INT FOREIGN KEY  REFERENCES [Categories](Id) NOT NULL,
[StatusId]    INT FOREIGN KEY  REFERENCES [Status]    (Id) NOT NULL,
[OpenDate]    DATETIME	   NOT NULL,
[CloseDate]   DATETIME	   NULL,  --CHECK HERE BECAUSE THEY HAVE WRONG VALIDATION
[Description] VARCHAR(200) NULL,
[UserId]      INT FOREIGN KEY  REFERENCES Users(Id) NOT NULL,
[EmployeeId]  INT FOREIGN KEY  REFERENCES Employees(Id) NULL --CHECK HERE THEY WANT TO ALLOW NULL
)