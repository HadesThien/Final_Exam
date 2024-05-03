use master 
go 



use Final_SE
go
CREATE TABLE Person
(
  Id VARCHAR(10) NOT NULL,
  name NVARCHAR(50) NOT NULL,
  gender NVARCHAR(5) NOT NULL,
  dob DATE NOT NULL,
  numberPhone VARCHAR(11) NOT NULL,
  PRIMARY KEY (Id)
);

CREATE TABLE Teacher
(
  subject NVARCHAR(20) NOT NULL,
  teacherId VARCHAR(10) NOT NULL,
  PRIMARY KEY (teacherId),
  FOREIGN KEY (teacherId) REFERENCES Person(Id)
);

CREATE TABLE Student
(
  school NVARCHAR(30) NOT NULL,
  street NVARCHAR(50) NOT NULL,
  ward NVARCHAR(50) NOT NULL,
  district NVARCHAR(50) NOT NULL,
  city NVARCHAR(50) NOT NULL,
  dateCreated DATE NOT NULL,
  status NVARCHAR(10) NOT NULL,
  note NVARCHAR(50) NOT NULL,
  studentId VARCHAR(10) NOT NULL,
  PRIMARY KEY (studentId),
  FOREIGN KEY (studentId) REFERENCES Person(Id)
);


CREATE TABLE Class
(
  classId VARCHAR(10) NOT NULL,
  subject NVARCHAR(30) NOT NULL,
  shift NVARCHAR(10) NOT NULL,
  grade INT NOT NULL,
  price INT NOT NULL,
  numberOfSession INT NOT NULL,
  numberOfStudent INT NOT NULL,
  dateCreated DATE NOT NULL,
  teacherId VARCHAR(10) NOT NULL,
  status VARCHAR(10),
  PRIMARY KEY (classId),
  FOREIGN KEY (teacherId) REFERENCES Teacher(teacherId)
);


CREATE TABLE Payment
(
  dateCreated DATE NOT NULL,
  period date NOT NULL,
  status NVARCHAR(10) NOT NULL,
  note NVARCHAR(100) NOT NULL,
  promotion FLOAT NOT NULL,
  numberOfSession INT NOT NULL,
  paymentId VARCHAR(10) NOT NULL,
  studentId VARCHAR(10) NOT NULL,
  classId VARCHAR(10) NOT NULL, 
  PRIMARY KEY (paymentId),
  FOREIGN KEY (studentId, classId) REFERENCES Register(studentId, classId)
);

CREATE TABLE Account
(
  password VARCHAR(20) NOT NULL,
  dateCreated DATE NOT NULL,
  username VARCHAR(20) NOT NULL,
  lastLoginDate DATETIME NOT NULL,
  role NVARCHAR(20) NOT NULL,
  email VARCHAR(50) NOT NULL,
  numberPhone VARCHAR(11) NOT NULL,
  name NVARCHAR(50) NOT NULL,
  PRIMARY KEY (username)
);

CREATE TABLE Document
(
  inventory INT NOT NULL,
  handoutId VARCHAR(10) NOT NULL,
  name NVARCHAR(50) NOT NULL,
  dateCreated DATE NOT NULL,
  dateUpdated DATE NOT NULL,
  price INT NOT NULL,
  PRIMARY KEY (handoutId)
);

CREATE TABLE Register
(
  admissionDay DATE NOT NULL,
  studentId VARCHAR(10) NOT NULL,
  classId VARCHAR(10) NOT NULL,
  PRIMARY KEY (studentId, classId),
  FOREIGN KEY (studentId) REFERENCES Student(studentId),
  FOREIGN KEY (classId) REFERENCES Class(classId)
);

CREATE TABLE Buy
( 
  buyingDate DATE NOT NULL,
  number INT NOT NULL,
  price INT NOT NULL,
  status NVARCHAR(50) NOT NULL,
  period date not null,
  note NVARCHAR(50) NOT NULL,
  buyId VARCHAR(10) NOT NULL,
  studentId VARCHAR(10) NOT NULL,
  handoutId VARCHAR(10) NOT NULL,
  PRIMARY KEY (buyId, studentId, handoutId),
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


INSERT INTO Student (school, street, ward, district,city,dateCreated ,studentId, status, note)
VALUES 
(N'Trường THCS ABC',  N'Đường A', N'Phường 1', N'Quận Gò Vấp',N'TP.Hồ Chí Minh','05-16-2024' ,'HS001', N'Đang học', N''),
(N'Trường THCS XYZ',  N'Đường B', N'Phường 2', N'Quận 1',N'TP.Hồ Chí Minh', '07-14-2023','HS002', N'Đang học', N''),
(N'Trường THCS KLM',  N'Đường C', N'Phường 3', N'Quận Tân Bình',N'TP.Hồ Chí Minh','01-02-2023' ,'HS003', N'Đang học', N''),
(N'Trường THCS NOP',  N'Đường D', N'Phường 4', N'Quận 3',N'TP.Hồ Chí Minh','05-08-2022' ,'HS004', N'Đang học', N''),
(N'Trường THCS QRS',  N'Đường E', N'Phường 5', N'Quận 10', N'TP.Hồ Chí Minh','01-01-2022','HS005', N'Đang học', N'');
INSERT INTO Teacher (subject, teacherId)
VALUES 
(N'Toán', 'GV001'),
(N'Văn', 'GV002'),
(N'Anh', 'GV003'),
(N'KHTN', 'GV004'),
(N'Toán','GV005');


INSERT INTO Class (classId, subject, shift, grade, price, numberOfSession, numberOfStudent, dateCreated, teacherId, status)
VALUES 
('LH001', N'Toán', '1', 6, 550000, 12, 15, '2024-04-27', 'GV001',N'Đang mở'),
('LH002', N'Văn', '2', 7, 550000, 12, 18, '2024-04-27', 'GV002',N'Đang mở'),
('LH003', N'Anh', '1', 8, 550000, 12, 12, '2024-04-27', 'GV003',N'Đang mở'),
('LH004', N'KHTN', '2', 9, 650000, 12, 10, '2024-04-27', 'GV004',N'Đang mở'),
('LH005', N'Toán', '2', 10, 550000, 12, 17, '2024-04-27', 'GV005',N'Đang mở');

INSERT INTO Register (admissionDay, studentId, classId)
VALUES 
('2024-04-29', 'HS001', 'LH001'),
('2024-04-28', 'HS002', 'LH002'),
('2024-04-27', 'HS003', 'LH003'),
('2024-04-26', 'HS004', 'LH004'),
('2024-04-25', 'HS005', 'LH005'),
('2024-04-24', 'HS001', 'LH002'),
('2024-04-23', 'HS002', 'LH003'),
('2024-04-22', 'HS003', 'LH004'),
('2024-04-21', 'HS004', 'LH005'),
('2024-04-20', 'HS005', 'LH001'),
('2024-04-19', 'HS001', 'LH003'),
('2024-04-18', 'HS002', 'LH004'),
('2024-04-17', 'HS003', 'LH005'),
('2024-04-16', 'HS004', 'LH001'),
('2024-04-15', 'HS005', 'LH002');



-- Dữ liệu cho các tài liệu
INSERT INTO Document (inventory, handoutId, name, dateCreated, dateUpdated, price)
VALUES 
(20, 'TL001', N'Chắc kèo', '2024-04-27', '2024-04-27', 50000),
(15, 'TL002', N'Về Đích', '2024-04-27', '2024-04-27', 45000),
(30, 'TL003', N'Ngữ Pháp', '2024-04-27', '2024-04-27', 55000),
(25, 'TL004', N'Ôn luyện', '2024-04-27', '2024-04-27', 60000),
(18, 'TL005', N'Tài liệu tham khảo', '2024-04-27', '2024-04-27', 70000);


INSERT INTO Payment (dateCreated, period, status, note, promotion, numberOfSession, paymentId, studentId, classId)
VALUES 
('2024-04-29', '2024-04-01', N'Thanh toán', N'', 0, 12, 'DK001', 'HS001', 'LH001'),
('2024-04-28', '2024-04-01', N'Đăng ký', N'', 0, 12, 'DK002', 'HS002', 'LH002'),
('2024-04-27', '2024-04-01', N'Thanh toán', N'', 0, 12, 'DK003', 'HS003', 'LH003'),
('2024-04-26', '2024-04-01', N'Thanh toán', N'', 0, 12, 'DK004', 'HS004', 'LH004'),
('2024-04-25', '2024-04-01', N'Đăng ký', N'', 0, 12, 'DK005', 'HS005', 'LH005'),
('2024-04-24', '2024-04-01', N'Thanh toán', N'', 0, 12, 'DK006', 'HS001', 'LH002'),
('2024-04-23', '2024-04-01', N'Đăng ký', N'', 0, 12, 'DK007', 'HS002', 'LH003'),
('2024-04-22', '2024-04-01', N'Thanh toán', N'', 0, 12, 'DK008', 'HS003', 'LH004'),
('2024-04-21', '2024-04-01', N'Đăng ký', N'', 0, 12, 'DK009', 'HS004', 'LH005'),
('2024-04-20', '2024-04-01', N'Đăng ký', N'', 0, 12, 'DK010', 'HS005', 'LH001'),
('2024-04-19', '2024-04-01', N'Thanh toán', N'', 0, 12, 'DK011', 'HS001', 'LH003'),
('2024-04-18', '2024-04-01', N'Đăng ký', N'', 0, 12, 'DK012', 'HS002', 'LH004'),
('2024-04-17', '2024-04-01', N'Thanh toán', N'', 0, 12, 'DK013', 'HS003', 'LH005'),
('2024-04-16', '2024-04-01', N'Thanh toán', N'', 0, 12, 'DK014', 'HS004', 'LH001'),
('2024-04-15', '2024-04-01', N'Đăng ký', N'', 0, 12, 'DK015', 'HS005', 'LH002');



INSERT INTO Buy (buyId,buyingDate, number, price, studentId, handoutId, status, period, note)
VALUES 
('DH001','2024-04-27', 1, 50000, 'HS001', 'TL001', N'Thanh toán', getDate(), N''),
('DH002','2024-04-27', 1, 45000, 'HS002', 'TL002', N'Thanh toán', getDate(), N''),
('DH003','2024-04-27', 1, 55000, 'HS003', 'TL003', N'Thanh toán', getDate(), N''),
('DH004','2024-04-27', 1, 60000, 'HS004', 'TL004', N'Thanh toán', getDate(), N''),
('DH005','2024-04-27', 1, 70000, 'HS005', 'TL005', N'Thanh toán', getDate(), N''),
('DH006','2024-04-27', 1, 50000, 'HS001', 'TL002', N'Thanh toán', getDate(), N''),
('DH007','2024-04-27', 1, 45000, 'HS002', 'TL003', N'Thanh toán', getDate(), N''),
('DH008','2024-04-27', 1, 55000, 'HS003', 'TL004', N'Thanh toán', getDate(), N''),
('DH009','2024-04-27', 1, 60000, 'HS004', 'TL005', N'Thanh toán', getDate(), N''),
('DH010','2024-04-27', 1, 70000, 'HS005', 'TL001', N'Thanh toán', getDate(), N'');

INSERT INTO Account (password, dateCreated, username, lastLoginDate, role, email, numberPhone, name)
VALUES	('password123', '2024-04-28', 'user1', '2024-04-28', 'user', 'user1@example.com', '1234567890', 'John Doe'),
		('123', '2024-04-28', 'admin1', '2024-04-28', 'admin', 'admin1@example.com', '0987654321', 'Admin Smith'),
		('pass1234', '2024-04-27', 'user2', '2024-04-27', 'user', 'user2@example.com', '1112223333', 'Jane Doe'),
		('adminpass', '2024-04-26', 'admin2', '2024-04-26', 'admin', 'admin2@example.com', '4445556666', 'Admin Johnson'),
		('123456', '2024-04-25', 'user3', '2024-04-25', 'user', 'user3@example.com', '7778889999', 'Max Smith');


SELECT p.paymentId,pe.name AS TenHocSinh,CONCAT(c.subject, ' ', c.grade, '.', c.shift) AS TenLop,c.Price, FORMAT(p.period, 'MM/yyyy') AS Period,p.status,p.promotion,p.numberOfSession,p.dateCreated
FROM Payment p
JOIN Register r ON r.studentId = p.studentId and r.classId = p.classId
JOIN Student s ON s.studentId = r.studentId
JOIN Person pe ON s.studentId = pe.Id
JOIN Class c ON c.classId = r.classId