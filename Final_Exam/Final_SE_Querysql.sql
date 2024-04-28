use master 
go 

create Database Final_SE
go

use Final_SE
go
CREATE TABLE Person
(
  Id VARCHAR(10) NOT NULL,
  name VARCHAR(50) NOT NULL,
  gender VARCHAR(5) NOT NULL,
  dob DATE NOT NULL,
  numberPhone varchar(11) not null,
  PRIMARY KEY (Id)
);

CREATE TABLE Teacher
(
  subject VARCHAR(20) NOT NULL,
  teacherId VARCHAR(10) NOT NULL,
  PRIMARY KEY (teacherId),
  FOREIGN KEY (teacherId) REFERENCES Person(Id)
);

CREATE TABLE Student
(
  school VARCHAR(30) NOT NULL,
  number VARCHAR(10) NOT NULL,
  street VARCHAR(30) NOT NULL,
  ward VARCHAR(20) NOT NULL,
  district VARCHAR(20) NOT NULL,
  studentId VARCHAR(10) NOT NULL,
  status nvarchar(10) not null,
  note nvarchar(50) ,
  PRIMARY KEY (studentId),
  FOREIGN KEY (studentId) REFERENCES Person(Id)
);

CREATE TABLE Class
(
  classId VARCHAR(10) NOT NULL,
  subject VARCHAR(30) NOT NULL,
  shift VARCHAR(10) NOT NULL,
  grade INT NOT NULL,
  price INT NOT NULL,
  number_of_session INT NOT NULL,
  number_of_student INT NOT NULL,
  date_created DATE NOT NULL,
  Id VARCHAR(10) NOT NULL,
  PRIMARY KEY (classId),
  FOREIGN KEY (Id) REFERENCES Teacher(teacherId)
);

CREATE TABLE Payment
(
  paymentId VARCHAR(10)  NOT NULL,
  date_created DATE NOT NULL,
  month INT NOT NULL,
  status nVARCHAR(10) NOT NULL,
  note VARCHAR(100) ,
  promotion FLOAT NOT NULL,
  numberOfSession INT NOT NULL,
  Id VARCHAR(10) NOT NULL,
  PRIMARY KEY (paymentId),
  FOREIGN KEY (Id) REFERENCES Student(studentId)
);

CREATE TABLE Account
(
  password VARCHAR(20) NOT NULL,
  date_created DATE NOT NULL,
  username VARCHAR(20) NOT NULL,
  lastLoginDate DATE NOT NULL,
  role_ VARCHAR(20) NOT NULL,
  email varchar(30) not null, 
  numberPhone varchar(11) not null, 
  name nvarchar(50) not null,
  PRIMARY KEY (username)
);

CREATE TABLE Document
(
  inventory INT NOT NULL,
  handoutId VARCHAR(10) NOT NULL,
  name VARCHAR(50) NOT NULL,
  dateCreated DATE NOT NULL,
  dateUpdated DATE NOT NULL,
  price Int not null,
  PRIMARY KEY (handoutId)
);

CREATE TABLE Register
(
  admission_day DATE NOT NULL,
  studentId VARCHAR(10) NOT NULL,
  classId VARCHAR(10) NOT NULL,
  PRIMARY KEY (studentId, classId),
  FOREIGN KEY (studentId) REFERENCES Student(studentId),
  FOREIGN KEY (classId) REFERENCES Class(classId)
);

CREATE TABLE Buy
(
  Buying_Date_ DATE NOT NULL,
  number_ INT NOT NULL,
  Price_ INT NOT NULL,
  studentId VARCHAR(10) NOT NULL,
  handoutId VARCHAR(10) NOT NULL,
  status nvarchar(10) not null,
  month int  not null, 
  note  nvarchar(50) ,
  PRIMARY KEY (studentId, handoutId),
  FOREIGN KEY (studentId) REFERENCES Student(studentId),
  FOREIGN KEY (handoutId) REFERENCES Document(handoutId)
);

INSERT INTO Person (Id, name, gender, dob, numberPhone)
VALUES 
('HS001', N'Nguyễn Văn A', N'Nam', '2005-03-15', '0123456789'),
('HS002', N'Trần Thị B', N'Nữ', '2006-07-20', '0987654321'),
('HS003', N'Lê Minh C', N'Nam', '2007-11-10', '0369842571'),
('HS004', N'Phạm Thanh D', N'Nữ', '2005-05-25', '0932145678'),
('HS005', N'Hoàng Nam E', N'Nam', '2006-09-30', '0876543210');

INSERT INTO Person (Id, name, gender, dob, numberPhone)
VALUES 
('GV001', N'Nguyễn Thị X', N'Nữ', '1980-02-10', '0369876543'),
('GV002', N'Trần Văn Y', N'Nam', '1975-08-18', '0987654321'),
('GV003', N'Lê Minh Z', N'Nam', '1982-12-05', '0912345678'),
('GV004', N'Phạm Thị T', N'Nữ', '1978-04-20', '0654321987'),
('GV005', N'Hoàng Văn S', N'Nam', '1985-10-15', '0398765432');

INSERT INTO Student (school, number, street, ward, district, studentId, status, note)
VALUES 
(N'Trường THCS ABC', '123', N'Đường A', N'Phường 1', N'Quận Gò Vấp', 'HS001', N'Đang học', N''),
(N'Trường THCS XYZ', '456', N'Đường B', N'Phường 2', N'Quận 1', 'HS002', N'Đang học', N''),
(N'Trường THCS KLM', '789', N'Đường C', N'Phường 3', N'Quận Tân Bình', 'HS003', N'Đang học', N''),
(N'Trường THCS NOP', '1011', N'Đường D', N'Phường 4', N'Quận 3', 'HS004', N'Đang học', N''),
(N'Trường THCS QRS', '1213', N'Đường E', N'Phường 5', N'Quận 10', 'HS005', N'Đang học', N'');

INSERT INTO Teacher (subject, teacherId)
VALUES 
(N'Toán', 'GV001'),
(N'Văn', 'GV002'),
(N'Anh', 'GV003'),
(N'KHTN', 'GV004'),
(N'Toán','GV0005');

INSERT INTO Class (classId, subject, shift, grade, price, number_of_session, number_of_student, date_created, Id)
VALUES 
('LH001', N'Toán', '1', 6, 550000, 12, 15, '2024-04-27', 'GV001'),
('LH002', N'Văn', '2', 7, 550000, 12, 18, '2024-04-27', 'GV002'),
('LH003', N'Anh', '1', 8, 550000, 12, 12, '2024-04-27', 'GV003'),
('LH004', N'KHTN', '2', 9, 650000, 12, 10, '2024-04-27', 'GV004'),
('LH005', N'Toán', '2', 10, 550000, 12, 17, '2024-04-27', 'GV005');

INSERT INTO Register (admission_day, studentId, classId)
VALUES 
('2024-04-27', 'HS001', 'LH001'),
('2024-04-27', 'HS002', 'LH002'),
('2024-04-27', 'HS003', 'LH003'),
('2024-04-27', 'HS004', 'LH004'),
('2024-04-27', 'HS005', 'LH005'),
('2024-04-27', 'HS001', 'LH002'),
('2024-04-27', 'HS002', 'LH003'),
('2024-04-27', 'HS003', 'LH004'),
('2024-04-27', 'HS004', 'LH005'),
('2024-04-27', 'HS005', 'LH001');

-- Dữ liệu cho các tài liệu
INSERT INTO Document (inventory, handoutId, name, dateCreated, dateUpdated, price)
VALUES 
(20, 'TL001', N'Chắc kèo', '2024-04-27', '2024-04-27', 50000),
(15, 'TL002', N'Về Đích', '2024-04-27', '2024-04-27', 45000),
(30, 'TL003', N'Ngữ Pháp', '2024-04-27', '2024-04-27', 55000),
(25, 'TL004', N'Ôn luyện', '2024-04-27', '2024-04-27', 60000),
(18, 'TL005', N'Tài liệu tham khảo', '2024-04-27', '2024-04-27', 70000);


INSERT INTO Payment (paymentId, date_created, month, status, note, promotion, numberOfSession, Id)
VALUES 
('DK001', '2024-04-27', 4, N'Đăng ký', N'', 0, 12, 'HS001'),
('DK002', '2024-04-27', 4, N'Đăng ký', N'', 0, 12, 'HS002'),
('DK003', '2024-04-27', 4, N'Đăng ký', N'', 0, 12, 'HS003'),
('DK004', '2024-04-27', 4, N'Đăng ký', N'', 0, 12, 'HS004'),
('DK005', '2024-04-27', 4, N'Đăng ký', N'', 0, 12, 'HS005');
-- Dữ liệu cho việc mua tài liệu
INSERT INTO Buy (Buying_Date_, number_, Price_, studentId, handoutId, status, month, note)
VALUES 
('2024-04-27', 1, 50000, 'HS001', 'TL001', N'Thanh toán', 4, N''),
('2024-04-27', 1, 45000, 'HS002', 'TL002', N'Thanh toán', 4, N''),
('2024-04-27', 1, 55000, 'HS003', 'TL003', N'Thanh toán', 4, N''),
('2024-04-27', 1, 60000, 'HS004', 'TL004', N'Thanh toán', 4, N''),
('2024-04-27', 1, 70000, 'HS005', 'TL005', N'Thanh toán', 4, N''),
('2024-04-27', 1, 50000, 'HS001', 'TL002', N'Thanh toán', 4, N''),
('2024-04-27', 1, 45000, 'HS002', 'TL003', N'Thanh toán', 4, N''),
('2024-04-27', 1, 55000, 'HS003', 'TL004', N'Thanh toán', 4, N''),
('2024-04-27', 1, 60000, 'HS004', 'TL005', N'Thanh toán', 4, N''),
('2024-04-27', 1, 70000, 'HS005', 'TL001', N'Thanh toán', 4, N'');


