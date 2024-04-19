-- DB: MyHotel
CREATE DATABASE MyHotel;
GO


USE MyHotel;
GO

-- Table: Employees
CREATE TABLE [Employees]
(
  [EmployeeID] INT IDENTITY(1,1) PRIMARY KEY,
  [Name]       VARCHAR(255) NOT NULL,
  [Gender]     VARCHAR(255) CHECK ([Gender] IN('Male', 'Female', 'Other')) NOT NULL,
  [Telephone]  VARCHAR(255) NOT NULL,
  [Email]      VARCHAR(255) UNIQUE NOT NULL,
  [Username]   VARCHAR(255) UNIQUE NOT NULL,
  [Password]   VARCHAR(255) NOT NULL
);

-- Table: Customers
CREATE TABLE [Customers]
(
  [CustomerID]   INT IDENTITY(1,1) PRIMARY KEY,
  [Name]         VARCHAR(255) NOT NULL,
  [Gender]       VARCHAR(255) CHECK ([Gender] IN('Male', 'Female', 'Other')) NOT NULL,
  [DateOfBirth]  VARCHAR(255) NOT NULL,
  [Telephone]    VARCHAR(255) NOT NULL,
  [Address]      VARCHAR(255) NOT NULL,
  [Nationality]  VARCHAR(255) NOT NULL,
  [IDProof]      VARCHAR(255) NOT NULL,
  [CheckInDate]  DATE NOT NULL,
  [CheckOutDate] DATE NULL,
);

-- Table: Rooms
CREATE TABLE [Rooms]
(
  [RoomID] UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
  [RoomNumber] VARCHAR(255) UNIQUE NOT NULL,
  [Type]   VARCHAR(255) CHECK ([Type] IN('AC', 'Non-AC')) NOT NULL,
  [Bed]    VARCHAR(255) CHECK ([Bed] IN('Single', 'Double', 'Triple')) NOT NULL,
  [Price]  FLOAT(24) NOT NULL,
  [Booked] BIT DEFAULT 0 NULL
);

INSERT INTO [Employees] ([Name], [Gender], [Telephone], [Email], [Username], [Password])
VALUES ('Edikan Ekanem', 'Female', '55223344110', 'eekanem5146@conestogac.on.ca', 'admin', 'admin'),
('Mahendra Patel', 'Male', '11123344110', 'mpatel@conestogac.on.ca', 'mahendra', 'admin'),
('Motunrayo', 'Female', '12323344110', 'mogunseye@conestogac.on.ca', 'motun', 'admin'),
('Anish Reddi', 'Male', '88523344110', 'areddi@conestogac.on.ca', 'anish', 'admin'),
('Mayank Sharma', 'Male', '092723344110', 'msharma@conestogac.on.ca', 'mayank', 'admin');

INSERT INTO [Customers] ([Name], [Gender], [DateOfBirth], [Telephone], [Address], [Nationality], [IDProof], [CheckInDate])
VALUES ('Edikan Ekanem', 'Female', '1999-12-30', '55223344110', 'Nigeria, Akwaibom State', 'Nigerian', '000-000-000-000', '2024-04-19');

INSERT INTO [Rooms] ([RoomNumber], [Type], [Bed], [Price], [Booked])
VALUES ('A240', 'AC', 'Double', 150, 1);