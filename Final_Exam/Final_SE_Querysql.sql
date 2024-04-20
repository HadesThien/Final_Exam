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
  date_created DATE NOT NULL,
  month INT NOT NULL,
  status VARCHAR NOT NULL,
  note VARCHAR(100) NOT NULL,
  promotion FLOAT NOT NULL,
  numberOfSession INT NOT NULL,
  paymentId VARCHAR(10) NOT NULL,
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
  PRIMARY KEY (username)
);

CREATE TABLE Document
(
  inventory INT NOT NULL,
  handoutId VARCHAR(10) NOT NULL,
  name VARCHAR(50) NOT NULL,
  dateCreated DATE NOT NULL,
  dateUpdated DATE NOT NULL,
  PRIMARY KEY (handoutId)
);

CREATE TABLE Center_Account
(
  users_name VARCHAR(50) NOT NULL,
  number_phone VARCHAR(50) NOT NULL,
  username VARCHAR(20) NOT NULL,
  PRIMARY KEY (username),
  FOREIGN KEY (username) REFERENCES Account(username)
);

CREATE TABLE Teacher_Account
(
  username VARCHAR(20) NOT NULL,
  PRIMARY KEY (username),
  FOREIGN KEY (username) REFERENCES Account(username)
);

CREATE TABLE Admin_Account
(
  username VARCHAR(20) NOT NULL,
  PRIMARY KEY (username),
  FOREIGN KEY (username) REFERENCES Account(username)
);

CREATE TABLE Register
(
  admission_day DATE NOT NULL,
  state VARCHAR(20) NOT NULL,
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
  PRIMARY KEY (studentId, handoutId),
  FOREIGN KEY (studentId) REFERENCES Student(studentId),
  FOREIGN KEY (handoutId) REFERENCES Document(handoutId)
);

CREATE TABLE Person_number_phone
(
  number_phone VARCHAR NOT NULL,
  Id VARCHAR(10) NOT NULL,
  PRIMARY KEY (number_phone, Id),
  FOREIGN KEY (Id) REFERENCES Person(Id)
);
