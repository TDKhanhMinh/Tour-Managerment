create database TourManagerment
use master
go
use TourManagerment

CREATE TABLE Booking (
  bookingId INT IDENTITY(1,1) PRIMARY KEY,
  date DATE NOT NULL,
  status INT NOT NULL
);

CREATE TABLE Report (
  reportId INT IDENTITY(1,1) PRIMARY KEY,
  revenue INT NOT NULL,
  reportdate DATE NOT NULL,
  description TEXT NOT NULL
);

CREATE TABLE Users (
  userId INT IDENTITY(1,1) PRIMARY KEY,
  username NVARCHAR(255) NOT NULL,
  password NVARCHAR(255) NOT NULL,
  role NVARCHAR(50) NOT NULL,
  phone NVARCHAR(20) NOT NULL,
  email NVARCHAR(255) NOT NULL,
  address NVARCHAR(MAX) NOT NULL,
  bookingId INT NOT NULL,
  FOREIGN KEY (bookingId) REFERENCES Booking(bookingId)
);

CREATE TABLE Tour (
  tourId INT IDENTITY(1,1) PRIMARY KEY,
  tourname NVARCHAR(255) NOT NULL,
  type NVARCHAR(100) NOT NULL,
  price DECIMAL(10,2) NOT NULL,
  transportation NVARCHAR(100) NOT NULL,
  description NVARCHAR(MAX) NOT NULL,
  bookingId INT NOT NULL,
  FOREIGN KEY (bookingId) REFERENCES Booking(bookingId)
);

CREATE TABLE Schedule (
  scheduleId INT IDENTITY(1,1) PRIMARY KEY,
  beginday DATE NOT NULL,
  activity NVARCHAR(MAX) NOT NULL,
  endday_ DATE NOT NULL,
  tourId INT NOT NULL,
  FOREIGN KEY (tourId) REFERENCES Tour(tourId)
);
