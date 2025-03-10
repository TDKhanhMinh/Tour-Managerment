create database TourManagerment

use master
go
use TourManagerment

CREATE TABLE Tour (
  tourId INT IDENTITY(1,1) PRIMARY KEY,
  tourname NVARCHAR(255) NOT NULL,
  type NVARCHAR(100) NOT NULL,
  price DECIMAL(10,2) NOT NULL,
  transportation NVARCHAR(100) NOT NULL,
  description NVARCHAR(MAX) NOT NULL,
);

CREATE TABLE Customer (
  customerId INT IDENTITY(1,1) PRIMARY KEY,
  lastname NVARCHAR(255) NOT NULL,
 firstname NVARCHAR(255) NOT NULL,  
  phone NVARCHAR(20) NOT NULL,
  email NVARCHAR(255) NOT NULL unique,
  address NVARCHAR(MAX) NOT NULL,
);

CREATE TABLE Booking (
  bookingId INT IDENTITY(1,1) PRIMARY KEY,
  date DATE NOT NULL,
  status NVARCHAR(20) NOT NULL,
  tourId INT,
  customerId INT,
  FOREIGN KEY (tourId) REFERENCES Tour(tourId),
  FOREIGN KEY (customerId) REFERENCES Customer(customerId)
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
	fullName NVARCHAR(100) ,
	age INT,
    gender NVARCHAR(10) ,
    phone NVARCHAR(20),
    address NVARCHAR(255),
);


CREATE TABLE Schedule (
  scheduleId INT IDENTITY(1,1) PRIMARY KEY,
  tourId INT ,
  bookingId INT ,
  beginday DATE NOT NULL,
  endday_ DATE NOT NULL,
  transport NVARCHAR(255) NOT NULL,
  location NVARCHAR(255) NOT NULL,
  activity NVARCHAR(MAX) NOT NULL,
  guidename NVARCHAR(255) NOT NULL,
  status NVARCHAR(255) NOT NULL,
  settlement NVARCHAR(255) NOT NULL,
  FOREIGN KEY (tourId) REFERENCES Tour(tourId),
  FOREIGN KEY (bookingId) REFERENCES Booking(bookingId)
);
INSERT INTO Users (username, password, role, fullName, age, gender, phone, address)
VALUES 
    ('admin', 'admin', 'ADMIN', 'Nguyễn Văn A', 35, 'Male', '0123456789', 'Hà Nội'),
    ('employee', 'nv123', 'NV', 'Trần Thị B', 28, 'Female', '0987654321', 'TP. Hồ Chí Minh'),
	('nv001', 'pass001', 'NV', 'Lê Văn C', 30, 'Male', '0912345678', 'Đà Nẵng'),
    ('nv002', 'pass002', 'NV', 'Phạm Thị D', 25, 'Female', '0923456789', 'Hải Phòng'),
    ('nv003', 'pass003', 'NV', 'Hoàng Văn E', 27, 'Male', '0934567890', 'Cần Thơ'),
    ('nv004', 'pass004', 'NV', 'Đặng Thị F', 29, 'Female', '0945678901', 'Nha Trang'),
    ('nv005', 'pass005', 'NV', 'Bùi Văn G', 32, 'Male', '0956789012', 'Huế');;



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




INSERT INTO Schedule ( beginday, endday_, transport, location, activity, guidename, status, settlement)  
VALUES  
( '2025-03-10', '2025-03-11', 'Bus', 'Hà Nội', 'Tham quan Hồ Gươm, phố cổ', 'Nguyễn Văn A', 'Chưa khởi hành', 'Chưa thanh toán'),  
( '2025-04-05', '2025-04-07', 'Plane', 'Đà Nẵng', 'Tham quan Bà Nà Hills, Cầu Rồng', 'Trần Thị B', 'Đang diễn ra', 'Chưa thanh toán'),  
('2025-05-15', '2025-05-20', 'Cruise', 'Hạ Long', 'Du thuyền ngắm vịnh Hạ Long', 'Lê Minh C', 'Đã huỷ', 'Chưa thanh toán'),  
( '2025-06-01', '2025-06-03', 'Train', 'Sapa', 'Leo Fansipan, bản Cát Cát', 'Phạm Văn D', 'Đã hoàn thành', 'Chưa thanh toán'),  
('2025-07-10', '2025-07-12', 'Car', 'Đà Lạt', 'Thăm vườn hoa Đà Lạt, hồ Tuyền Lâm', 'Bùi Thị E', 'Đã hoàn thành', 'Chưa thanh toán');  

INSERT INTO Schedule ( beginday, endday_, transport, location, activity, guidename, status, settlement)  
VALUES  ( '2025-03-10', '2025-03-11', 'Bus', 'Hà Nội', 'Tham quan Hồ Gươm, phố cổ', 'Nguyễn Văn A', 'Chua khoi hanh', 'Chua thanh toan')
select * from Schedule

INSERT INTO Tour (tourname, type, price, transportation, description) VALUES 
(N'Tour Sapa 3N2Đ', N'Tiết kiệm', 100, N'Xe', N'Tour du lịch khám phá Sapa trong 3 ngày 2 đêm.'),
(N'Tour Đà Nẵng - Hội An', N'TIết kiệm', 200, N'Máy bay', N'Tour khám phá Đà Nẵng và phố cổ Hội An trong 4 ngày.'),
(N'Tour Phú Quốc 4N3Đ', N'Tiêu chuẩn', 300, N'Máy bay', N'Tour nghỉ dưỡng tại Phú Quốc với các resort cao cấp.'),
(N'Tour Hạ Long 2N1Đ', N'Tiêu chuẩn', 400, N'Xe', N'Tour tham quan Vịnh Hạ Long với du thuyền sang trọng.'),
(N'Tour Đà Lạt 3N2Đ', N'Tiêu chuẩn', 500, N'Xe', N'Tour du lịch Đà Lạt tham quan vườn hoa, đồi chè.'),
(N'Tour Cần Thơ - Châu Đốc', N'Tiêu chuẩn', 600, N'Xe', N'Tour khám phá miền Tây sông nước, chợ nổi Cái Răng.'),
(N'Tour Nha Trang 4N3Đ', N'Tiêu chuẩn', 700, N'Máy bay', N'Tour nghỉ dưỡng tại Nha Trang, tham quan Vinpearl Land.'),
(N'Tour Mộc Châu 2N1Đ', N'Cao cấp', 800, N'Xe', N'Tour khám phá cao nguyên Mộc Châu, đồi chè xanh mướt.'),
(N'Tour Côn Đảo 3N2Đ', N'Cao cấp', 900, N'Máy bay', N'Tour viếng thăm nghĩa trang Hàng Dương, nhà tù Côn Đảo.'),
(N'Tour Huế 3N2Đ', N'Cao cấp', 1000, N'Xe', N'Tour tham quan kinh thành Huế, chùa Thiên Mụ, lăng tẩm vua Nguyễn.');

  INSERT INTO Booking (date, status, tourId, customerId) VALUES 
('2025-03-01', N'Đã cọc', 1, 1),
('2025-03-02', N'Đã cọc', 2, 2),
('2025-03-03', N'Đã cọc', 3, 3),
('2025-03-04', N'Đã cọc', 1, 4),
('2025-03-05', N'Đã cọc', 2, 5),
('2025-03-06', N'Đã cọc', 3, 6),
('2025-03-07', N'Đã cọc', 1, 7),
('2025-03-08', N'Đã cọc', 2, 8),
('2025-03-09', N'Đã cọc', 3, 9),
('2025-03-10', N'Đã cọc', 1, 10);
