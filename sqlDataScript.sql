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
CREATE TABLE Users(
userId INT IDENTITY(1,1) PRIMARY KEY,
username NVARCHAR(255) NOT NULL,
password NVARCHAR(255) NOT NULL,
role NVARCHAR(50) NOT NULL,
);

CREATE TABLE Customer (
  customerId INT IDENTITY(1,1) PRIMARY KEY,
  lastname NVARCHAR(255) NOT NULL,
 firstname NVARCHAR(255) NOT NULL,  
  phone NVARCHAR(20) NOT NULL,
  email NVARCHAR(255) NOT NULL unique,
  address NVARCHAR(MAX) NOT NULL,
  bookingId INT ,
  FOREIGN KEY (bookingId) REFERENCES Booking(bookingId)
);

CREATE TABLE Tour (
  tourId INT IDENTITY(1,1) PRIMARY KEY,
  tourname NVARCHAR(255) NOT NULL,
  type NVARCHAR(100) NOT NULL,
  price DECIMAL(10,2) NOT NULL,
  transportation NVARCHAR(100) NOT NULL,
  description NVARCHAR(MAX) NOT NULL,
  bookingId INT ,
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

INSERT INTO Users (username, password, role) VALUES ('admin1', 'admin', 'ADMIN');
INSERT INTO Users (username, password, role) VALUES ('nhanvien1', '123', 'NV');
INSERT INTO Users (username, password, role) VALUES ('nhanvien2', '123', 'NV');
INSERT INTO Users (username, password, role) VALUES ('nhanvien3', '123', 'NV');



INSERT INTO Customer ( lastname,firstname, phone, email, address) 
VALUES 
('Nguyen', 'Van A', '0987654321', 'nguyenvana@example.com', 'Ha Noi, Vietnam'),
('Tran', 'Thi B', '0978654321', 'tranthib@example.com', 'Ho Chi Minh, Vietnam'),
('Le', 'Van C', '0967543210', 'levanc@example.com', 'Da Nang, Vietnam'),
('Pham', 'Thi D', '0956432109', 'phamthid@example.com', 'Can Tho, Vietnam'),
('Hoang', 'Van E', '0945321098', 'hoangvane@example.com', 'Hai Phong, Vietnam'),
('Dang', 'Thi F', '0934210987', 'dangthif@example.com', 'Hue, Vietnam'),
('Bui', 'Van G', '0923109876', 'buivang@example.com', 'Nha Trang, Vietnam'),
('Do', 'Thi H', '0912098765', 'dothih@example.com', 'Vinh, Vietnam'),
('Ngo', 'Van I', '0901987654', 'ngovani@example.com', 'Quang Ninh, Vietnam'),
('Vu', 'Thi J', '0890876543', 'vuthij@example.com', 'Binh Duong, Vietnam');



select * from Customer