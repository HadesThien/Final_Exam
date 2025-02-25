-- Sử dụng cơ sở dữ liệu vừa tạo
USE NQH_Application;
go

-- Tạo bảng Employee (bảng cha)
CREATE TABLE Employee (
    employee_id VARCHAR(10) PRIMARY KEY,
    fullname NVARCHAR(100) NOT NULL,
    salary_coefficient DECIMAL(5, 2) NOT NULL,
    day_off_left INT NOT NULL,
    date_of_birth DATE NOT NULL,
    phone_number VARCHAR(15) NOT NULL,
    email NVARCHAR(100) NOT NULL,
    hire_date DATE NOT NULL
);
-- Tạo bảng Subject
CREATE TABLE Subject (
    subject_id VARCHAR(10) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL
);

-- Tạo bảng Teacher (kế thừa từ Employee)
CREATE TABLE Teacher (
    teacher_id VARCHAR(10) PRIMARY KEY,
    subject_id VARCHAR(10), 
    FOREIGN KEY (teacher_id) REFERENCES Employee(employee_id),
    FOREIGN KEY (subject_id) REFERENCES Subject(subject_id)
);

-- Tạo bảng TeacherAssistant (kế thừa từ Employee)
CREATE TABLE TeacherAssistant (
    ta_id VARCHAR(10) PRIMARY KEY,
    subject_id VARCHAR(10), 
    FOREIGN KEY (ta_id) REFERENCES Employee(employee_id),
    FOREIGN KEY (subject_id) REFERENCES Subject(subject_id)
);

-- Tạo bảng Saler (kế thừa từ Employee)
CREATE TABLE Saler (
    saler_id VARCHAR(10) PRIMARY KEY,
    role NVARCHAR(50) NOT NULL,
	branch_id VARCHAR(10),
	FOREIGN KEY (saler_id) REFERENCES Employee(employee_id),
	FOREIGN KEY (branch_id) REFERENCES Branch(branch_id)
);

-- Tạo bảng Branch
CREATE TABLE Branch (
    branch_id VARCHAR(10) PRIMARY KEY,
    branch_name NVARCHAR(100) NOT NULL,
    address NTEXT NOT NULL
);

-- Tạo bảng Period
CREATE TABLE Period (
    period_id VARCHAR(10) PRIMARY KEY,
    date_created DATE NOT NULL,
    semester NVARCHAR(30) NOT NULL 
);

-- Tạo bảng Class
CREATE TABLE Class (
    class_id VARCHAR(10) PRIMARY KEY,
    class_name NVARCHAR(100) NOT NULL,
    capacity INT NOT NULL,
    date_opened DATE NOT NULL,
    date_closed DATE,
    branch_id VARCHAR(10),
    subject_id VARCHAR(10),
    period_id VARCHAR(10),
    teacher_id VARCHAR(10),
    FOREIGN KEY (branch_id) REFERENCES Branch(branch_id),
    FOREIGN KEY (subject_id) REFERENCES Subject(subject_id),
    FOREIGN KEY (period_id) REFERENCES Period(period_id),
    FOREIGN KEY (teacher_id) REFERENCES Teacher(teacher_id)
);
-- Tạo bảng Leave
CREATE TABLE Leave (
    leave_id VARCHAR(10) PRIMARY KEY,
    date DATE NOT NULL,
    reason NTEXT NOT NULL,
    employee_id VARCHAR(10),
    FOREIGN KEY (employee_id) REFERENCES Employee(employee_id)
);

--Tạo bảng Job Department
CREATE TABLE Job_Department(
	job_id varchar(10) PRIMARY KEY,
	job_dept nvarchar(50) NOT NULL,
	name nvarchar(50) NOT NULL,
	description ntext,
)

-- Tạo bảng Salary
CREATE TABLE Salary (
    salary_id VARCHAR(10) PRIMARY KEY,
    date DATE NOT NULL,
    amount DECIMAL(15, 2) NOT NULL, -- Điều chỉnh cho tiền Việt Nam đồng
    job_id VARCHAR(10)
    FOREIGN KEY (job_id) REFERENCES Job_Department(job_id)
);

-- Tạo bảng Payroll
CREATE TABLE Payroll (
    payroll_id VARCHAR(10) PRIMARY KEY,
    report NTEXT,
    total_amount DECIMAL(15, 2) NOT NULL, 
    date DATE NOT NULL,
    employee_id VARCHAR(10),
    leave_id VARCHAR(10),
    salary_id VARCHAR(10),
	job_id VARCHAR(10),
    FOREIGN KEY (employee_id) REFERENCES Employee(employee_id),
    FOREIGN KEY (leave_id) REFERENCES Leave(leave_id),
    FOREIGN KEY (salary_id) REFERENCES Salary(salary_id),
	FOREIGN KEY (job_id) REFERENCES Job_Department(job_id)
);


-- Tạo bảng Student
CREATE TABLE Student (
    student_id VARCHAR(10) PRIMARY KEY,
    fullname NVARCHAR(100) NOT NULL,
    address NTEXT DEFAULT '',
    date_of_birth DATE NOT NULL,
    phone_number VARCHAR(15) DEFAULT '',
    school NVARCHAR(100) NOT NULL,
    status NVARCHAR(50) NOT NULL,
    parent_phone VARCHAR(15) NOT NULL,
    note NTEXT
);

-- Tạo bảng Account
CREATE TABLE Account (
    username NVARCHAR(50) PRIMARY KEY,
    password VARCHAR(20) NOT NULL,
    date_created DATE NOT NULL,
    role VARCHAR(20) NOT NULL,
    employee_id VARCHAR(10),
    FOREIGN KEY (employee_id) REFERENCES Employee(employee_id)
);


-- Tạo bảng Register
CREATE TABLE Register (
    register_id VARCHAR(10) PRIMARY KEY,
    date DATE NOT NULL,
    date_off DATE,
    student_id VARCHAR(10),
    class_id VARCHAR(10),
    FOREIGN KEY (student_id) REFERENCES Student(student_id),
    FOREIGN KEY (class_id) REFERENCES Class(class_id)
);

-- Tạo bảng Payment
CREATE TABLE Payment (
    payment_id VARCHAR(10) PRIMARY KEY,
	name NVARCHAR(100) NOT NULL,
    price DECIMAL(15, 2) NOT NULL, -- Điều chỉnh cho tiền Việt Nam đồng
    status NVARCHAR(50) NOT NULL,
    date_paid DATE NOT NULL,
    subject NVARCHAR(100) NOT NULL,
    date_created DATE NOT NULL,
    note NTEXT,
    student_id VARCHAR(10),
    period_id VARCHAR(10),
    FOREIGN KEY (student_id) REFERENCES Student(student_id),
    FOREIGN KEY (period_id) REFERENCES Period(period_id)
);
-- Tạo bảng Repository
CREATE TABLE Repository (
    repository_id VARCHAR(10) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    branch_id VARCHAR(10),
    FOREIGN KEY (branch_id) REFERENCES Branch(branch_id)
);

-- Tạo bảng Item
CREATE TABLE Item (
    item_id VARCHAR(10) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
	type NVARCHAR(50) NOT NULL,
	unit NVARCHAR(40) NOT NULL,
    company NVARCHAR(100) DEFAULT '',
    description NTEXT,
);

--Tạo bảng Detail Item
CREATE TABLE Detail_Item(
	detail_item_id varchar(10) PRIMARY KEY,
	quantity INT NOT NULL,
	date_import DATE NOT NULL,
	status NVARCHAR(40) ,
	note NTEXT,
	item_id VARCHAR(10) , 
	repository_id VARCHAR(10) ,
	FOREIGN KEY (item_id) REFERENCES Item(item_id),
	FOREIGN KEY (repository_id) REFERENCES Repository(repository_id)
)

--- End of the file --- 


---To drop all table, highlight this following line, and execute til it messages 'commands completed successfully'
---DROP TABLE IF EXISTS employee, teacher, student,class, saler, TeacherAssistant,Branch, Repository,item,payment,register,Job_Department,Salary,Payroll,Leave, account,period,subject;