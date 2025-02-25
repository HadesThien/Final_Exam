-- 1. Job_Department
INSERT INTO Job_Department (job_id, job_dept, name, description)
VALUES
('JOB001', N'Giảng dạy', N'Giáo viên', N'Phụ trách giảng dạy các môn học'),
('JOB002', N'Hỗ trợ', N'Trợ giảng', N'Hỗ trợ giáo viên chính'),
('JOB003', N'Kinh doanh', N'Nhân viên Sales', N'Quản lý đăng ký và thanh toán'),
('JOB004', N'Quản lý', N'Quản lý chi nhánh', N'Quản lý hoạt động chi nhánh'),
('JOB005', N'Kế toán', N'Kế toán viên', N'Quản lý tài chính và lương'),
('JOB006', N'IT', N'Kỹ thuật viên', N'Hỗ trợ hệ thống CNTT'),
('JOB007', N'CSVC', N'Quản lý kho', N'Quản lý cơ sở vật chất'),
('JOB008', N'Tuyển sinh', N'Nhân viên tuyển sinh', N'Tuyển sinh viên mới'),
('JOB009', N'Đào tạo', N'Quản lý đào tạo', N'Lên kế hoạch đào tạo'),
('JOB010', N'Hành chính', N'Thư ký', N'Hỗ trợ hành chính tổng hợp');

-- 2. Employee 
INSERT INTO Employee (employee_id, fullname, salary_coefficient, day_off_left, date_of_birth, phone_number, email, hire_date)
VALUES
('EMP001', N'Nguyễn Thị Hồng', 2.10, 7, '1985-03-15', '0912345678', 'hongnt@edu.vn', '2018-04-01'),
('EMP002', N'Trần Văn Nam', 1.80, 7, '1990-07-22', '0987654321', 'namtv@edu.vn', '2020-06-15'),
('EMP003', N'Lê Thị Mai', 2.50, 7, '1982-11-30', '0978123456', 'mailt@edu.vn', '2015-09-01'),
('EMP004', N'Phạm Quốc Toản', 1.95, 7, '1995-02-14', '0903123456', 'toanpq@edu.vn', '2022-03-01'),
('EMP005', N'Hoàng Minh Anh', 3.00, 7, '1978-09-05', '0915987654', 'anhhm@edu.vn', '2010-10-10'),
('EMP006', N'Vũ Thị Ngọc', 2.30, 7, '1988-12-25', '0966333444', 'ngocvt@edu.vn', '2019-08-20'),
('EMP007', N'Đặng Văn Tú', 1.70, 12, '1993-04-18', '0905555666', 'tudv@edu.vn', '2021-01-05'),
('EMP008', N'Bùi Thị Hương', 2.80, 7, '1980-06-09', '0977123987', 'huongbt@edu.vn', '2017-07-15'),
('EMP009', N'Ngô Văn Đức', 2.00, 7, '1991-08-12', '0912123123', 'ducnv@edu.vn', '2023-02-01'),
('EMP010', N'Trịnh Thị Lan', 1.90, 7, '1987-05-20', '0988999888', 'lantt@edu.vn', '2020-11-01'),
('EMP011', N'Trương Nhật Thiên', 2.00, 7, '2004-05-16', '0909552348', 'tnthien165.truong@gmail.com', '2020-11-01');

-- 3. Subject
INSERT INTO Subject (subject_id, name)
VALUES
('SUBJ01', N'Toán học'),
('SUBJ02', N'Vật lý'),
('SUBJ03', N'Hóa học'),
('SUBJ04', N'Tiếng Anh'),
('SUBJ05', N'Ngữ văn'),
('SUBJ06', N'Sinh học'),
('SUBJ07', N'Đánh giá năng lực'),
('SUBJ08', N'Khoa học tự nhiên'),
('SUBJ09', N'Lịch sử'),
('SUBJ10', N'Địa lý');

-- 4. Branch
INSERT INTO Branch (branch_id, branch_name, address)
VALUES
('BRANCH01', N'Lê Đình Thám', N'Số 123, đường Lê Đình Thám, Q. Tân Bình, TP.HCM'),
('BRANCH02', N'Nguyễn Thái Học', N'Số 456, đường Nguyễn Thái Học, Q.1, TP.HCM'),
('BRANCH03', N'Vĩnh Lộc', N'Số 789, khu phố 2, Vĩnh Lộc B, Bình Chánh'),
('BRANCH04', N'Lý Thường Kiệt', N'Số 101, đường Lý Thường Kiệt, Q.10, TP.HCM'),
('BRANCH05', N'Nguyễn Quang Bích', N'Số 234, đường Nguyễn Quang Bích, Q.Tân Phú'),
('BRANCH06', N'Pandora', N'Lầu 5, tòa nhà Pandora, Q.3, TP.HCM'),
('BRANCH07', N'Lê Trọng Tấn', N'Số 567, đường Lê Trọng Tấn, Q.Bình Tân'),
('BRANCH08', N'Trần Hưng Đạo', N'Số 890, đường Trần Hưng Đạo, Q.5, TP.HCM'),
('BRANCH09', N'Quang Trung', N'Số 111, đường Quang Trung, Gò Vấp'),
('BRANCH10', N'Phan Đình Phùng', N'Số 222, đường Phan Đình Phùng, Q.Phú Nhuận');

-- 5. Period
INSERT INTO Period (period_id, date_created, semester)
VALUES
('PERIOD01', '2023-01-10', N'Học kỳ 1 2023'),
('PERIOD02', '2023-06-05', N'Học kỳ 2 2023'),
('PERIOD03', '2023-09-01', N'Học kỳ hè 2023'),
('PERIOD04', '2024-01-08', N'Học kỳ 1 2024'),
('PERIOD05', '2024-05-20', N'Học kỳ xuân 2024'),
('PERIOD06', '2024-07-15', N'Học kỳ hè 2024'),
('PERIOD07', '2024-09-02', N'Học kỳ thu 2024'),
('PERIOD08', '2025-01-06', N'Học kỳ 1 2025'),
('PERIOD09', '2025-04-10', N'Học kỳ 2 2025'),
('PERIOD10', '2025-07-01', N'Học kỳ hè 2025');

-- 6. Teacher
INSERT INTO Teacher (teacher_id, subject_id)
VALUES
('EMP001', 'SUBJ01'),
('EMP003', 'SUBJ02'),
('EMP005', 'SUBJ03'),
('EMP008', 'SUBJ04'),
('EMP010', 'SUBJ05'),
('EMP002', 'SUBJ06'),
('EMP004', 'SUBJ07'),
('EMP006', 'SUBJ08'),
('EMP007', 'SUBJ09'),
('EMP009', 'SUBJ10');

-- 7. TeacherAssistant
INSERT INTO TeacherAssistant (ta_id, subject_id)
VALUES
('EMP002', 'SUBJ01'),
('EMP004', 'SUBJ02 '),
('EMP006', 'SUBJ03'),
('EMP008', 'SUBJ04'),
('EMP010', 'SUBJ05'),
('EMP001', 'SUBJ06'),
('EMP003', 'SUBJ07'),
('EMP005', 'SUBJ08'),
('EMP007', 'SUBJ09'),
('EMP009', 'SUBJ10');

-- 8. Saler
INSERT INTO Saler (saler_id, role)
VALUES
('EMP001', N'Nhân viên bán hàng'),
('EMP002', N'Quản lý bán hàng'),
('EMP003', N'Nhân viên tư vấn'),
('EMP004', N'Nhân viên hỗ trợ'),
('EMP005', N'Nhân viên chăm sóc khách hàng'),
('EMP006', N'Nhân viên tiếp thị'),
('EMP007', N'Nhân viên giao hàng'),
('EMP008', N'Nhân viên thu ngân'),
('EMP009', N'Nhân viên quản lý kho'),
('EMP010', N'Nhân viên phát triển thị trường');

-- 9. Class
INSERT INTO Class (class_id, class_name, capacity, date_opened, date_closed, branch_id, subject_id, period_id, teacher_id)
VALUES
('CLASS01', N'Lớp 1A', 30, '2023-01-15', NULL, 'BRANCH01', 'SUBJ01', 'PERIOD01', 'EMP001'),
('CLASS02', N'Lớp 1B', 25, '2023-01-20', NULL, 'BRANCH02', 'SUBJ02', 'PERIOD01', 'EMP003'),
('CLASS03', N'Lớp 2A', 28, '2023-02-01', NULL, 'BRANCH03', 'SUBJ03', 'PERIOD01', 'EMP005'),
('CLASS04', N'Lớp 2B', 30, '2023-02-10', NULL, 'BRANCH04', 'SUBJ04', 'PERIOD01', 'EMP008'),
('CLASS05', N'Lớp 3A', 32, '2023-03-01', NULL, 'BRANCH05', 'SUBJ05', 'PERIOD01', 'EMP010'),
('CLASS06', N'Lớp 3B', 30, '2023-03-15', NULL, 'BRANCH06', 'SUBJ06', 'PERIOD01', 'EMP002'),
('CLASS07', N'Lớp 4A', 28, '2023-04-01', NULL, 'BRANCH07', 'SUBJ07', 'PERIOD01', 'EMP004'),
('CLASS08', N'Lớp 4B', 30, '2023-04-10', NULL, 'BRANCH08', 'SUBJ08', 'PERIOD01', 'EMP006'),
('CLASS09', N'Lớp 5A', 30, '2023-05-01', NULL, 'BRANCH09', 'SUBJ09', 'PERIOD01', 'EMP007'),
('CLASS10', N'Lớp 5B', 30, '2023-05-15', NULL, 'BRANCH10', 'SUBJ10', 'PERIOD01', 'EMP009');

-- 10. Leave
INSERT INTO Leave (leave_id, date, reason, employee_id)
VALUES
('LEAVE01', '2023-01-10', N'Đi khám bệnh', 'EMP001'),
('LEAVE02', '2023-02-15', N'Việc gia đình', 'EMP002'),
('LEAVE03', '2023-03-20', N'Đi du lịch', 'EMP003'),
('LEAVE04', '2023-04-25', N'Khác', 'EMP004'),
('LEAVE05', '2023-05-30', N'Đi học', 'EMP005'),
('LEAVE06', '2023-06-10', N'Khám sức khỏe', 'EMP006'),
('LEAVE07', '2023-07-15', N'Việc riêng', 'EMP007'),
('LEAVE08', '2023-08-20', N'Đi công tác', 'EMP008'),
('LEAVE09', '2023-09-25', N'Khác', 'EMP009'),
('LEAVE10', '2023-10-30', N'Đi nghỉ phép', 'EMP010');

-- 11. Salary
INSERT INTO Salary (salary_id, date, amount, job_id)
VALUES
('SALARY01', '2023-01-31', 10000000.00, 'JOB001'),
('SALARY02', '2023-02-28', 12000000.00, 'JOB002'),
('SALARY03', ' 2023-03-31', 11000000.00, 'JOB003'),
('SALARY04', '2023-04-30', 15000000.00, 'JOB004'),
('SALARY05', '2023-05-31', 13000000.00, 'JOB005'),
('SALARY06', '2023-06-30', 14000000.00, 'JOB006'),
('SALARY07', '2023-07-31', 16000000.00, 'JOB007'),
('SALARY08', '2023-08-31', 17000000.00, 'JOB008'),
('SALARY09', '2023-09-30', 18000000.00, 'JOB009'),
('SALARY10', '2023-10-31', 19000000.00, 'JOB010');

-- 12. Payroll
INSERT INTO Payroll (payroll_id, report, total_amount, date, employee_id, leave_id, salary_id, job_id)
VALUES
('PAYROLL01', N'Tháng 1/2023', 10000000.00, '2023-01-31', 'EMP001', 'LEAVE01', 'SALARY01', 'JOB001'),
('PAYROLL02', N'Tháng 2/2023', 12000000.00, '2023-02-28', 'EMP002', 'LEAVE02', 'SALARY02', 'JOB002'),
('PAYROLL03', N'Tháng 3/2023', 11000000.00, '2023-03-31', 'EMP003', 'LEAVE03', 'SALARY03', 'JOB003'),
('PAYROLL04', N'Tháng 4/2023', 15000000.00, '2023-04-30', 'EMP004', 'LEAVE04', 'SALARY04', 'JOB004'),
('PAYROLL05', N'Tháng 5/2023', 13000000.00, '2023-05-31', 'EMP005', 'LEAVE05', 'SALARY05', 'JOB005'),
('PAYROLL06', N'Tháng 6/2023', 14000000.00, '2023-06-30', 'EMP006', 'LEAVE06', 'SALARY06', 'JOB006'),
('PAYROLL07', N'Tháng 7/2023', 16000000.00, '2023-07-31', 'EMP007', 'LEAVE07', 'SALARY07', 'JOB007'),
('PAYROLL08', N'Tháng 8/2023', 17000000.00, '2023-08-31', 'EMP008', 'LEAVE08', 'SALARY08', 'JOB008'),
('PAYROLL09', N'Tháng 9/2023', 18000000.00, '2023-09-30', 'EMP009', 'LEAVE09', 'SALARY09', 'JOB009'),
('PAYROLL10', N'Tháng 10/2023', 19000000.00, '2023-10-31', 'EMP010', 'LEAVE10', 'SALARY10', 'JOB010');

-- 13. Student
INSERT INTO Student (student_id, fullname, address, date_of_birth, phone_number, school, status, parent_phone, note)
VALUES
('STU001', N'Trần Văn A', N'Số 1, đường ABC, Q.1', '2005-01-01', '0912345678', N'Trường THPT A', N'Đang học', '0987654321', N'Chăm chỉ'),
('STU002', N'Lê Thị B', N'Số 2, đường DEF, Q.2', '2006-02-02', '0912345679', N'Trường THPT B', N'Đang học', '0987654322', N'Giỏi toán'),
('STU003', N'Nguyễn Văn C', N'Số 3, đường GHI, Q.3', '2007-03-03', '0912345680', N'Trường THPT C', N'Đang học', '0987654323', N'Chăm học'),
('STU004', N'Phạm Thị D', N'Số 4, đường JKL, Q.4', '2008-04-04', '0912345681', N'Trường THPT D', N'Đang học', '0987654324', N'Yêu thích văn học'),
('STU005', N'Ngô Văn E', N'Số 5, đường MNO, Q .5', '2009-05-05', '0912345682', N'Trường THPT E', N'Đang học', '0987654325', N'Chơi thể thao'),
('STU006', N'Bùi Thị F', N'Số 6, đường PQR, Q.6', '2010-06-06', '0912345683', N'Trường THPT F', N'Đang học', '0987654326', N'Giỏi ngoại ngữ'),
('STU007', N'Vũ Văn G', N'Số 7, đường STU, Q.7', '2011-07-07', '0912345684', N'Trường THPT G', N'Đang học', '0987654327', N'Chăm chỉ'),
('STU008', N'Nguyễn Thị H', N'Số 8, đường VWX, Q.8', '2012-08-08', '0912345685', N'Trường THPT H', N'Đang học', '0987654328', N'Yêu thích khoa học'),
('STU009', N'Trần Văn I', N'Số 9, đường YZ, Q.9', '2013-09-09', '0912345686', N'Trường THPT I', N'Đang học', '0987654329', N'Giỏi thể thao'),
('STU010', N'Lê Thị J', N'Số 10, đường ABCD, Q.10', '2014-10-10', '0912345687', N'Trường THPT J', N'Đang học', '0987654330', N'Chăm học');

-- 14. Account
INSERT INTO Account (username, password, date_created, role, employee_id)
VALUES
(N'admin', 'admin123', '2023-01-01', N'Admin', 'EMP001'),
(N'teacher1', 'teacher123', '2023-01-02', N'Teacher', 'EMP002'),
(N'saler1', 'saler123', '2023-01-03', N'Saler', 'EMP003'),
(N'teacher2', 'teacher123', '2023-01-04', N'Teacher', 'EMP004'),
(N'saler2', 'saler123', '2023-01-05', N'Saler', 'EMP005'),
(N'teacher3', 'teacher123', '2023-01-06', N'Teacher', 'EMP006'),
(N'saler3', 'saler123', '2023-01-07', N'Saler', 'EMP007'),
(N'teacher4', 'teacher123', '2023-01-08', N'Teacher', 'EMP008'),
(N'saler4', 'saler123', '2023-01-09', N'Saler', 'EMP009'),
(N'teacher5', 'teacher123', '2023-01-10', N'Teacher', 'EMP010'),
(N'hadesthien', '123', '2023-01-10', N'Admin', 'EMP011');

-- 15. Register
INSERT INTO Register (register_id, date, date_off, student_id, class_id)
VALUES
('REG001', '2023-01-15', NULL, 'STU001', 'CLASS01'),
('REG002', '2023-01-16', NULL, 'STU002', 'CLASS02'),
('REG003', '2023-01-17', NULL, 'STU003', 'CLASS03'),
('REG004', '2023-01-18', NULL, 'STU004', 'CLASS04'),
('REG005', '2023-01-19', NULL, 'STU005', 'CLASS05'),
('REG006', '2023-01-20', NULL, 'STU006', 'CLASS06'),
('REG007', '2023-01-21', NULL, 'STU007', 'CLASS07'),
('REG008', '2023-01-22', NULL, 'STU008', 'CLASS08'),
('REG009', '2023-01-23', NULL, 'STU009', 'CLASS09'),
('REG010', '2023-01-24', NULL, 'STU010', 'CLASS10');

-- 16. Payment
INSERT INTO Payment (payment_id, name, price, status, date_paid, subject, date_created, note, student_id, period_id)
VALUES
('PAY001', N'Học phí tháng 1', 5000000.00, N'Đã thanh toán', '2023-01-31', N'Toán học', '2023-01-01', N'Thanh toán học phí tháng 1', 'STU001', 'PERIOD01'),
('PAY002', N'Học phí tháng 2', 5000000.00, N'Đã thanh toán', '2023-02-28', N'Vật lý', '2023-01-01', N'Thanh toán học phí tháng 2', 'STU002', 'PERIOD01'),
('PAY003', N'Học phí tháng 3', 5000000.00, N'Đã thanh toán', '2023-03-31', N'Hóa học', '2023-01-01', N'Thanh toán học phí tháng 3', 'STU003', 'PERIOD01'),
('PAY004', N'Học phí tháng 4', 5000000.00, N'Chưa thanh toán', '2023-04-30', N'Tiếng Anh', '2023-01-01', N'Thanh toán học phí tháng 4', 'STU004', 'PERIOD01'),
('PAY005', N'Học phí tháng 5', 5000000.00, N'Chưa thanh toán', '2023-05-31', N'Ngữ văn', '2023-01-01', N'Thanh toán học phí tháng 5', 'STU005', 'PERIOD01'),
('PAY006', N'Học phí tháng 6', 5000000.00, N'Đã thanh toán', '2023-06-30', N'Sinh học', '2023-01-01', N'Thanh toán học phí tháng 6', 'STU006', 'PERIOD01'),
('PAY007', N'Học phí tháng 7', 5000000.00, N'Chưa thanh toán', '2023-07-31', N'Đánh giá năng lực', '2023-01-01', N'Thanh toán học phí tháng 7', 'STU007', 'PERIOD01'),
('PAY008', N'Học phí tháng 8', 5000000.00, N'Đã thanh toán', '2023-08-31', N'Khoa học tự nhiên', '2023-01-01', N'Thanh toán học phí tháng 8', 'STU008', 'PERIOD01'),
('PAY009', N'Học phí tháng 9', 5000000.00, N'Chưa thanh toán', '2023-09-30', N'Lịch sử', '2023-01-01', N'Thanh toán học phí tháng 9', 'STU009', 'PERIOD01'),
('PAY010', N'Học phí tháng 10', 5000000.00, N'Đã thanh toán', '2023-10-31', N'Địa lý', '2023-01-01', N'Thanh toán học phí tháng 10', 'STU010', 'PERIOD01');

-- 17. Repository

INSERT INTO Repository (repository_id, name, branch_id)
VALUES
('REP001', N'Lê Đình Thám', 'BRANCH01'),
('REP002', N'Nguyễn Thái Học', 'BRANCH02'),
('REP003', N'Vĩnh Lộc', 'BRANCH03'),
('REP004', N'Lý Thường Kiệt', 'BRANCH04'),
('REP005', N'Nguyễn Quang Bích', 'BRANCH05'),
('REP006', N'Pandora', 'BRANCH06'),
('REP007', N'Lê Trọng Tấn', 'BRANCH07'),
('REP008', N'Trần Hưng Đạo', 'BRANCH08'),
('REP009', N'Quang Trung', 'BRANCH09'),
('REP010', N'Phan Đình Phùng', 'BRANCH10');
-- 18. Item



--- Test 

SELECT d.detail_item_id,i.name,i.type,i.unit,d.status ,r.name ,i.company,d.quantity,i.item_id,r.repository_id FROM Detail_Item d
INNER JOIN Item i ON i.item_id = d.item_id
INNER JOIN Repository r ON r.repository_id = d.repository_id
WHERE r.repository_id = 'REP011'

select * from Repository

INSERT INTO Detail_Item(detail_item_id, quantity,date_import, status, item_id, repository_id) VALUES 
('DI00000292',8,'2025-02-22', N'M?i','I000000228','REP011' );

SELECT d.detail_item_id, i.name, i.type, i.unit, d.status ,r.name ,i.description, i.company FROM Detail_Item d 
SELECT * FROM Detail_Item d
JOIN Item i on i.item_id = d.item_id
JOIN Repository r ON r.repository_id = d.repository_id
WHERE i.name = N'Test 2'

select  TOP 1 * FROM Item Order by item_id desc;
select * from item where name = 'test 1'

UPDATE Detail_Item 
set quantity += 1
FROM Detail_Item
JOIN Repository  ON Repository.repository_id = Detail_Item.repository_id
JOIN Item ON Detail_Item.item_id = Item.item_id
Where Repository.name = N'Trần Hưng Đạo' and item.item_id = 'I000000227';


INSERT INTO Detail_Item (detail_item_id, quantity, date_import, status, note, item_id, repository_id) VALUES
('DI00000001', 5, '2023-07-15', N'Mới', NULL, 'I000000001', 'REP001'),-- Nước rửa chén Sunlight (Can)
('DI00000002', 5, '2023-08-20', N'Mới', NULL, 'I000000002', 'REP001'), -- Nước rửa tay
('DI00000003', 0, '2023-09-01', N'Mới', NULL, 'I000000003', 'REP001'), -- Xịt phòng Spring
('DI00000004', 0, '2023-06-10', N'Mới', NULL, 'I000000004', 'REP001'), -- Xịt phòng OASIS
('DI00000005', 0, '2023-05-05', N'Mới', NULL, 'I000000005', 'REP001'), -- Khăn giấy lụa Bless you
('DI00000006', 28, '2023-04-12', N'Mới', NULL, 'I000000006', 'REP001'), -- Vim
('DI00000007', 0, '2023-03-01', N'Mới', NULL, 'I000000007', 'REP001'), -- Bìa lá mềm
('DI00000008', 8, '2023-02-14', N'Mới', NULL, 'I000000008', 'REP001'), -- Tẩy phòng tắm
('DI00000009', 7, '2023-01-20', N'Mới', NULL, 'I000000009', 'REP001'), -- Lau sàn Gift
('DI00000010', 0, '2023-07-01', N'Mới', NULL, 'I000000010', 'REP001'), -- Phấn trắng
('DI00000011', 0, '2023-08-15', N'Mới', NULL, 'I000000011', 'REP001'), -- Thảm chùi chân
('DI00000012', 2, '2023-09-22', N'Mới', NULL, 'I000000012', 'REP001'), -- Nước rửa chén Sunlight (Chai)
('DI00000013', 0, '2023-06-03', N'Mới', NULL, 'I000000013', 'REP001'), -- Thảm mặt tiền cỡ bự
('DI00000014', 7, '2023-05-18', N'Đã qua sử dụng', NULL, 'I000000014', 'REP001'), -- Kệ tài liệu để bàn
('DI00000015', 5, '2023-04-01', N'Mới', NULL, 'I000000015', 'REP001'), -- Bộ lau nhà
('DI00000016', 1, '2023-03-10', N'Mới', NULL, 'I000000016', 'REP001'), -- Máy in bill
('DI00000017', 212, '2023-02-28', N'Mới', NULL, 'I000000017', 'REP001'), -- Sáp thơm
('DI00000018', 36, '2023-01-05', N'Mới', NULL, 'I000000018', 'REP001'), -- Nước lau kính Gift
('DI00000019', 67, '2023-08-01', N'Mới', NULL, 'I000000019', 'REP001'), -- Bìa sơ mi
('DI00000020', 205, '2023-09-15', N'Mới', NULL, 'I000000020', 'REP001'), -- Cuộn in bill
('DI00000021', 1, '2023-06-22', N'Mới', NULL, 'I000000021', 'REP001'), -- Thùng rác cỡ nhỏ
('DI00000022', 4, '2023-05-03', N'Mới', NULL, 'I000000022', 'REP001'), -- Rổ nhựa nhỏ
('DI00000023', 24, '2023-04-18', N'Mới', NULL, 'I000000023', 'REP001'), -- Rổ nhựa lớn
('DI00000024', 41, '2023-03-05', N'Mới', NULL, 'I000000024', 'REP001'), -- Bút
('DI00000025', 30, '2023-02-10', N'Mới', NULL, 'I000000025', 'REP001'), -- Bìa sơ mi A5 cute
('DI00000026', 8, '2023-01-15', N'Mới', NULL, 'I000000026', 'REP001'), -- Chổi
('DI00000027', 23, '2023-07-22', N'Mới', NULL, 'I000000027', 'REP001'), -- Ghim bấm
('DI00000028', 1, '2023-08-03', N'Mới', NULL, 'I000000028', 'REP001'), -- Bấm lỗ
('DI00000029', 4, '2023-09-10', N'Mới', NULL, 'I000000029', 'REP001'), -- Kẹp giấy
('DI00000030', 10, '2023-06-15', N'Mới', NULL, 'I000000030', 'REP001'), -- Giấy note
('DI00000031', 5, '2023-05-22', N'Mới', NULL, 'I000000031', 'REP001'), -- Rổ nhỏ chữ nhật
('DI00000032', 13, '2023-04-03', N'Mới', NULL, 'I000000032', 'REP001'), -- Bấm giấy mini
('DI00000033', 3, '2023-03-18', N'Mới', NULL, 'I000000033', 'REP001'), -- Pin 2A
('DI00000034', 4, '2023-02-05', N'Mới', NULL, 'I000000034', 'REP001'), -- Pin 2A (bị lẻ)
('DI00000035', 0, '2023-01-10', N'Mới', NULL, 'I000000035', 'REP001'), -- Pin 3A
('DI00000036', 4, '2023-07-18', N'Mới', NULL, 'I000000036', 'REP001'), -- Pin đại
('DI00000037', 0, '2023-08-05', N'Mới', NULL, 'I000000037', 'REP001'), -- Khăn lau bảng
('DI00000038', 4, '2023-09-12', N'Mới', NULL, 'I000000038', 'REP001'), -- Chà bồn cầu
('DI00000039', 5, '2023-06-01', N'Mới', NULL, 'I000000039', 'REP001'), -- Cây lau nhà
('DI00000040', 4, '2023-05-10', N'Mới', NULL, 'I000000040', 'REP001'), -- Mê hốt rác
('DI00000041', 6, '2023-04-22', N'Mới', NULL, 'I000000041', 'REP001'), -- Bông lau nhà
('DI00000042', 15, '2023-03-03', N'Mới', NULL, 'I000000042', 'REP001'), -- Giấy A4
('DI00000043', 0, '2023-02-18', N'Mới', NULL, 'I000000043', 'REP001'), -- Bìa lỗ
('DI00000044', 77, '2023-01-05', N'Mới', NULL, 'I000000044', 'REP001'), -- Bút lông đen
('DI00000045', 2, '2023-07-08', N'Mới', NULL, 'I000000045', 'REP001'), -- Bút lông đỏ
('DI00000046', 35, '2023-08-12', N'Mới', NULL, 'I000000046', 'REP001'), -- Bút lông xanh
('DI00000047', 2, '2023-09-05', N'Mới', NULL, 'I000000047', 'REP001'), -- Tấm Mica dán bàn TVV
('DI00000048', 8, '2023-06-18', N'Mới', NULL, 'I000000048', 'REP001'), -- Mực in đỏ (dấu mộc)
('DI00000049', 25, '2023-05-01', N'Mới', NULL, 'I000000049', 'REP001'), -- Bao rác đen cỡ lớn
('DI00000050', 2, '2023-04-10', N'Mới', NULL, 'I000000050', 'REP001'), -- Băng keo trong nhỏ
('DI00000051', 5, '2023-03-22', N'Mới', NULL, 'I000000051', 'REP001'), -- Bìa cây
('DI00000052', 0, '2023-02-03', N'Mới', NULL, 'I000000052', 'REP001'), -- Cồn
('DI00000053', 27, '2023-01-18', N'Mới', NULL, 'I000000053', 'REP001'), -- Bao rác nhỏ
('DI00000054', 0, '2023-07-05', N'Mới', NULL, 'I000000054', 'REP001'), -- Máy xông tinh dầu
('DI00000055', 0, '2023-08-10', N'Mới', NULL, 'I000000055', 'REP001'), -- Ống cắm bút
('DI00000056', 1, '2023-09-22', N'Mới', NULL, 'I000000056', 'REP001'), -- Kéo
('DI00000057', 0, '2023-06-03', N'Mới', NULL, 'I000000057', 'REP001'), -- Đồ bấm ghim
('DI00000058', 0, '2023-05-18', N'Mới', NULL, 'I000000058', 'REP001'), -- Bút bi xanh
('DI00000059', 1, '2023-04-01', N'Mới', NULL, 'I000000059', 'REP001'), -- Mực in con dấu
('DI00000060', 6, '2023-03-10', N'Mới', NULL, 'I000000060', 'REP001'), -- Standee Menu A4
('DI00000061', 1, '2023-02-28', N'Mới', NULL, 'I000000061', 'REP001'), -- Cà phê
('DI00000062', 6, '2023-01-05', N'Mới', NULL, 'I000000062', 'REP001'), -- Tờ Premium
('DI00000063', 33, '2023-07-10', N'Mới', NULL, 'I000000063', 'REP001'), -- Nestea vị chanh
('DI00000064', 30, '2023-08-01', N'Mới', NULL, 'I000000064', 'REP001'), -- Nestea vị vải và lài
('DI00000065', 2, '2023-09-15', N'Mới', NULL, 'I000000065', 'REP001'), -- Bịch Milo gói
('DI00000066', 264, '2023-06-22', N'Mới', NULL, 'I000000066', 'REP001'), -- Hộp milo
('DI00000067', 354, '2023-05-03', N'Mới', NULL, 'I000000067', 'REP001'), -- Bánh Cal Cheese
('DI00000068', 2, '2023-04-18', N'Mới', NULL, 'I000000068', 'REP001'), -- Thùng rác Premium
('DI00000069', 160, '2023-03-05', N'Mới', NULL, 'I000000069', 'REP001'), -- NesCafe
('DI00000070', 10, '2023-02-10', N'Mới', NULL, 'I000000070', 'REP001'), -- Miếng rửa chén
('DI00000071', 43, '2023-01-15', N'Mới', NULL, 'I000000071', 'REP001'), -- Gói Tipo
('DI00000072', 260, '2023-07-22', N'Mới', NULL, 'I000000072', 'REP001'), -- Bánh Ochi
('DI00000073', 5, '2023-08-03', N'Mới', NULL, 'I000000073', 'REP001'), -- Áo Premium
('DI00000074', 9, '2023-09-10', N'Mới', NULL, 'I000000074', 'REP001'), -- Phong bì thư NQH
('DI00000075', 3, '2023-06-15', N'Đã qua sử dụng', NULL, 'I000000075', 'REP001'), -- Thùng đá
('DI00000076', 1, '2023-05-22', N'Đã qua sử dụng', NULL, 'I000000076', 'REP001'), -- Cây thông thầy Hiệu
('DI00000077', 3502, '2023-04-03', N'Mới', NULL, 'I000000077', 'REP001'), -- Vở NQH
('DI00000078', 1, '2023-03-18', N'Mới', NULL, 'I000000078', 'REP001'), -- Banner Hệ thống giáo dục
('DI00000079', 27, '2023-02-05', N'Mới', NULL, 'I000000079', 'REP001'), -- Khung ảnh
('DI00000080', 7, '2023-01-10', N'Mới', NULL, 'I000000080', 'REP001'), -- Balo NQH
('DI00000081', 6, '2023-07-18', N'Mới', NULL, 'I000000081', 'REP001'), -- Áo Tư vấn viên Cấp 2
('DI00000082', 1, '2023-08-05', N'Mới', NULL, 'I000000082', 'REP001'), -- Đồ từ thiện
('DI00000083', 67, '2023-09-12', N'Mới', NULL, 'I000000083', 'REP001'), -- Sổ đậu Đại học
('DI00000084', 1, '2023-06-01', N'Đã qua sử dụng', NULL, 'I000000084', 'REP001'), -- Dây đèn Tân Phú
('DI00000085', 15, '2023-05-10', N'Mới', NULL, 'I000000085', 'REP001'), -- Bìa nhiều lớp
('DI00000086', 36, '2023-04-22', N'Mới', NULL, 'I000000086', 'REP001'), -- lọ thủy tinh mini
('DI00000087', 70, '2023-03-03', N'Mới', NULL, 'I000000087', 'REP001'), -- Vòng tay NQH
('DI00000088', 18, '2023-02-18', N'Mới', NULL, 'I000000088', 'REP001'), -- Giấy màu
('DI00000089', 78, '2023-01-05', N'Mới', NULL, 'I000000089', 'REP001'), -- Mũ NQH
('DI00000090', 11, '2023-07-08', N'Mới', NULL, 'I000000090', 'REP001'), -- Khăn quàng đỏ
('DI00000091', 51, '2023-08-12', N'Mới', NULL, 'I000000091', 'REP001'), -- Phong bì thư trắng
('DI00000092', 4, '2023-09-05', N'Mới', NULL, 'I000000092', 'REP001'), -- Vòng tay NQH Cấp 2
('DI00000093', 1, '2023-06-18', N'Mới', NULL, 'I000000093', 'REP001'), -- Bảng khu vực
('DI00000094', 18, '2023-05-01', N'Đã qua sử dụng', NULL, 'I000000094', 'REP001'), -- Áo Hệ thống
('DI00000095', 8, '2023-04-10', N'Mới', NULL, 'I000000095', 'REP001'), -- Áo thể thao NQH
('DI00000096', 1, '2023-03-22', N'Mới', NULL, 'I000000096', 'REP001'), -- Súng bắn tiền
('DI00000097', 1, '2023-02-03', N'Mới', NULL, 'I000000097', 'REP001'), -- Vòng quay loto
('DI00000098', 15, '2023-01-18', N'Mới', NULL, 'I000000098', 'REP001'), -- Đĩa sứ
('DI00000099', 0, '2023-07-05', N'Mới', NULL, 'I000000099', 'REP001'), -- Giấy chơi loto
('DI00000100', 2, '2023-08-10', N'Đã qua sử dụng', NULL, 'I000000100', 'REP001'), -- Hàng rào trang trí
('DI00000101', 19, '2023-09-22', N'Đã qua sử dụng', NULL, 'I000000101', 'REP001'), -- Bóng nhỏ
('DI00000102', 4, '2023-06-03', N'Mới', NULL, 'I000000102', 'REP001'), -- Khăn xanh trải bàn
('DI00000103', 1, '2023-05-18', N'Đã qua sử dụng', NULL, 'I000000103', 'REP001'), -- Khăn đỏ trải bàn
('DI00000104', 29, '2023-04-01', N'Mới', NULL, 'I000000104', 'REP001'), -- Ly mini quà tặng
('DI00000105', 1, '2023-03-10', N'Đã qua sử dụng', NULL, 'I000000105', 'REP001'), -- Manocanh decor
('DI00000106', 478, '2023-02-28', N'Mới', NULL, 'I000000085', 'REP001'), -- Bìa nhiều lớp (Sửa lại Bìa sơ mi logo NQH do bị trùng id)
('DI00000107', 16, '2023-01-05', N'Mới', NULL, 'I000000107', 'REP001'), -- Bút chì IELTS
('DI00000108', 236, '2023-07-10', N'Đã qua sử dụng', NULL, 'I000000108', 'REP001'), -- Bút chì NQH
('DI00000109', 45, '2023-08-01', N'Mới', NULL, 'I000000109', 'REP001'), -- Bút chì thường
('DI00000110', 5, '2023-09-15', N'Mới', NULL, 'I000000110', 'REP001'), -- Hạt xốp
('DI00000111', 139, '2023-06-22', N'Mới', NULL, 'I000000111', 'REP001'), -- Lồng đèn
('DI00000112', 55, '2023-05-03', N'Mới', NULL, 'I000000112', 'REP001'), -- Giấy gói quà
('DI00000113', 3, '2023-04-18', N'Mới', NULL, 'I000000113', 'REP001'), -- Súng nước
('DI00000114', 1, '2023-03-05', N'Mới', NULL, 'I000000114', 'REP001'), -- Cây mai giả
('DI00000115', 4, '2023-02-10', N'Mới', NULL, 'I000000115', 'REP001'), -- Bơm bong bóng tay
('DI00000116', 1, '2023-01-15', N'Đã qua sử dụng', NULL, 'I000000116', 'REP001'), -- Bơm bong bóng máy
('DI00000117', 32, '2023-07-22', N'Mới', NULL, 'I000000117', 'REP001'), -- Cài tóc đen trơn
('DI00000118', 0, '2023-08-03', N'Mới', NULL, 'I000000118', 'REP001'), -- Quà pin cài Noel
('DI00000119', 1, '2023-09-10', N'Mới', NULL, 'I000000119', 'REP001'), -- Trống mini
('DI00000120', 2, '2023-06-15', N'Mới', NULL, 'I000000120', 'REP001'), -- Mâm gỗ
('DI00000121', 1, '2023-05-22', N'Mới', NULL, 'I000000121', 'REP001'), -- Loa phát thanh
('DI00000122', 11, '2023-04-03', N'Mới', NULL, 'I000000122', 'REP001'), -- Ruy băng cam
('DI00000123', 0, '2023-03-18', N'Mới', NULL, 'I000000123', 'REP001'), -- Ruy băng Vàng - Cam + Decal lửa
('DI00000124', 8, '2023-02-05', N'Mới', NULL, 'I000000124', 'REP001'), -- Bóng đập cổ vũ
('DI00000125', 13, '2023-01-10', N'Mới', NULL, 'I000000125', 'REP001'), -- Bìa sơ mi My Clear
('DI00000126', 10, '2023-07-18', N'Mới', NULL, 'I000000126', 'REP001'), -- Cài tai thỏ
('DI00000127', 6, '2023-08-05', N'Mới', NULL, 'I000000127', 'REP001'), -- Heo nhựa
('DI00000128', 14, '2023-09-12', N'Mới', NULL, 'I000000128', 'REP001'), -- Cán cờ
('DI00000129', 1, '2023-06-01', N'Mới', NULL, 'I000000129', 'REP001'), -- Tripod
('DI00000130', 0, '2023-05-10', N'Mới', NULL, 'I000000130', 'REP001'), -- Dây đen led
('DI00000131', 1, '2023-04-22', N'Mới', NULL, 'I000000131', 'REP001'), -- Thùng trang trí Halloween
('DI00000132', 0, '2023-03-03', N'Mới', NULL, 'I000000132', 'REP001'), -- Thùng trang trí Tết
('DI00000133', 98, '2023-02-18', N'Mới', NULL, 'I000000133', 'REP001'), -- Tim đèn
('DI00000134', 1, '2023-01-05', N'Mới', NULL, 'I000000134', 'REP001'), -- Thùng đồ Cosplay
('DI00000135', 1, '2023-07-08', N'Mới', NULL, 'I000000135', 'REP001'), -- Chân standee đứng
('DI00000136', 1, '2023-08-12', N'Mới', NULL, 'I000000136', 'REP001'), -- Giấy vụn trang trí
('DI00000137', 0, '2023-09-05', N'Mới', NULL, 'I000000137', 'REP001'), -- Túi nilon NQH
('DI00000138', 0, '2023-06-18', N'Mới', NULL, 'I000000138', 'REP001'), -- Túi vải NQH
('DI00000139', 3, '2023-05-01', N'Mới', NULL, 'I000000139', 'REP001'), -- Phao
('DI00000140', 0, '2023-04-10', N'Mới', NULL, 'I000000140', 'REP001'), -- Khăn rằn
('DI00000141', 10.5, '2023-03-22', N'Mới', NULL, 'I000000141', 'REP001'), -- Ủng đen
('DI00000142', 54, '2023-02-03', N'Mới', NULL, 'I000000142', 'REP001'), -- Bao tay
('DI00000143', 9, '2023-01-18', N'Mới', NULL, 'I000000143', 'REP001'), -- Bong bóng + cây
('DI00000144', 0, '2023-07-05', N'Mới', NULL, 'I000000144', 'REP001'), -- Dây đeo bảng tên
('DI00000145', 1, '2023-08-10', N'Mới', NULL, 'I000000145', 'REP001'), -- Dây thun
('DI00000146', 3, '2023-09-22', N'Mới', NULL, 'I000000146', 'REP001'), -- Bảng tỉ số
('DI00000147', 1, '2023-06-03', N'Mới', NULL, 'I000000147', 'REP001'), -- Áo trọng tài
('DI00000148', 3, '2023-05-18', N'Mới', NULL, 'I000000148', 'REP001'), -- Bảng tên bàn
('DI00000149', 1, '2023-04-01', N'Mới', NULL, 'I000000149', 'REP001'), -- Giấy ruki
('DI00000150', 38, '2023-03-10', N'Mới', NULL, 'I000000150', 'REP001'), -- Dây cột tóc
('DI00000151', 6, '2023-02-28', N'Mới', NULL, 'I000000151', 'REP001'), -- Huy chương đeo
('DI00000152', 2, '2023-01-05', N'Mới', NULL, 'I000000152', 'REP001'), -- Cờ Cấp 3 khu vực
('DI00000153', 1, '2023-07-10', N'Mới', NULL, 'I000000153', 'REP001'), -- Cờ Cấp 2 khu vực
('DI00000154', 3, '2023-08-01', N'Mới', NULL, 'I000000154', 'REP001'), -- Cuộn giấy Flipchart
('DI00000155', 3, '2023-09-15', N'Mới', NULL, 'I000000155', 'REP001'), -- Áo Liên Minh
('DI00000156', 1, '2023-06-22', N'Mới', NULL, 'I000000156', 'REP001'), -- Đèn livestream
('DI00000157', 2, '2023-05-03', N'Mới', NULL, 'I000000157', 'REP001'), -- Vỏ bình nước lọc
('DI00000158', 1, '2023-04-18', N'Mới', NULL, 'I000000158', 'REP001'), -- Quấn wrap
('DI00000159', 1, '2023-03-05', N'Mới', NULL, 'I000000159', 'REP001'), -- Banner cầu lông CHÁY
('DI00000160', 1, '2023-02-10', N'Mới', NULL, 'I000000160', 'REP001'), -- Lightstick
('DI00000161', 17, '2023-01-15', N'Mới', NULL, 'I000000161', 'REP001'), -- Áo Tư vấn viên Cấp 3
('DI00000162', 1, '2023-07-22', N'Đã qua sử dụng', NULL, 'I000000162', 'REP001'), -- Sơn
('DI00000163', 30, '2023-08-03', N'Mới', NULL, 'I000000163', 'REP001'), -- Phiếu gửi xe
('DI00000164', 1, '2023-09-10', N'Mới', NULL, 'I000000164', 'REP001'), -- Tấm thạch cao
('DI00000165', 0, '2023-06-15', N'Mới', NULL, 'I000000165', 'REP001'), -- Dây rút
('DI00000166', 2, '2023-05-22', N'Mới', NULL, 'I000000166', 'REP001'), -- Ruột gà 25m
('DI00000167', 1, '2023-04-03', N'Mới', NULL, 'I000000167', 'REP001'), -- Đèn pha
('DI00000168', 1, '2023-03-18', N'Mới', NULL, 'I000000168', 'REP001'), -- Thiết bị camera
('DI00000169', 1, '2023-02-05', N'Mới', NULL, 'I000000169', 'REP001'), -- Đèn pha trắng
('DI00000170', 2, '2023-01-10', N'Mới', NULL, 'I000000170', 'REP001'), -- Chân chống TV
('DI00000171', 2, '2023-07-18', N'Mới', NULL, 'I000000171', 'REP001'), -- Dây cước
('DI00000172', 3, '2023-08-05', N'Mới', NULL, 'I000000172', 'REP001'), -- Quạt gió
('DI00000173', 2, '2023-09-12', N'Mới', NULL, 'I000000173', 'REP001'), -- Đèn led 1m2
('DI00000174', 5, '2023-06-01', N'Mới', NULL, 'I000000174', 'REP001'), -- Miếng lót sàn
('DI00000175', 2, '2023-05-10', N'Mới', NULL, 'I000000175', 'REP001'), -- Ống đồng
('DI00000176', 1, '2023-04-22', N'Mới', NULL, 'I000000176', 'REP001'), -- Súng silicon
('DI00000177', 1, '2023-03-03', N'Mới', NULL, 'I000000177', 'REP001'), -- Màn chiếu
('DI00000178', 1, '2023-02-18', N'Mới', NULL, 'I000000178', 'REP001'), -- Cửa nhôm
('DI00000179', 1, '2023-01-05', N'Mới', NULL, 'I000000179', 'REP001'), -- Dây điện
('DI00000180', 1, '2023-07-08', N'Mới', NULL, 'I000000180', 'REP001'), -- Nắp cống
('DI00000181', 1, '2023-08-12', N'Mới', NULL, 'I000000181', 'REP001'), -- Dây nilon
('DI00000182', 1, '2023-09-05', N'Mới', NULL, 'I000000182', 'REP001'), -- Dây HDMI
('DI00000183', 1, '2023-06-18', N'Mới', NULL, 'I000000183', 'REP001'), -- Ấm đun nước
('DI00000184', 1, '2023-05-01', N'Mới', NULL, 'I000000184', 'REP001'), -- Bình công nhân
('DI00000185', 1, '2023-04-10', N'', NULL, 'I000000185', 'REP001'), -- Bình nóng lạnh (cố ý để trống status)
('DI00000186', 6, '2023-03-22', N'Mới', NULL, 'I000000186', 'REP001'), -- Điện thoại bàn
('DI00000187', 1, '2023-02-03', N'Mới', NULL, 'I000000187', 'REP001'), -- Dây kẽm
('DI00000188', 1, '2023-01-18', N'Mới', NULL, 'I000000188', 'REP001'), -- Ổ cứng HDD Seagate
('DI00000189', 8, '2023-07-05', N'Mới', NULL, 'I000000046', 'REP002'), -- Bút lông xanh
('DI00000190', 1, '2023-08-10', N'Mới', NULL, 'I000000044', 'REP002'), -- Bút lông đen
('DI00000191', 6, '2023-09-22', N'Đã qua sử dụng', NULL, 'I000000022', 'REP002'), -- Rổ nhựa nhỏ
('DI00000192', 1, '2023-06-03', N'Đã qua sử dụng', NULL, 'I000000023', 'REP002'), -- Rổ nhựa lớn
('DI00000193', 2, '2023-05-18', N'Mới', NULL, 'I000000002', 'REP002'), -- Nước rửa tay
('DI00000194', 192, '2023-04-01', N'Mới', NULL, 'I000000109', 'REP002'), -- Bút chì thường
('DI00000195', 260, '2023-03-10', N'Mới', NULL, 'I000000077', 'REP002'), -- Vở NQH
('DI00000196', 20, '2023-02-28', N'Mới', NULL, 'I000000046', 'REP002'), -- Bút lông xanh
('DI00000197', 95, '2023-01-05', N'Mới', NULL, 'I000000109', 'REP002'), -- Bút chì thường
('DI00000198', 0, '2023-07-10', N'Mới', NULL, 'I000000210', 'REP002'), -- Bịch nhựa dẻo
('DI00000199', 30, '2023-08-01', N'Mới', NULL, 'I000000211', 'REP002'), -- Quà Noel lật đật
('DI00000200', 0, '2023-09-15', N'Mới', NULL, 'I000000212', 'REP002'), -- Túi bóng quà
('DI00000201', 6, '2023-06-22', N'Đã qua sử dụng', NULL, 'I000000213', 'REP002'), -- Khuôn làm bánh
('DI00000202', 2, '2023-05-03', N'Đã qua sử dụng', NULL, 'I000000214', 'REP002'), -- Ly chia thể tích
('DI00000203', 1, '2023-04-18', N'Đã qua sử dụng', NULL, 'I000000215', 'REP002'), -- Tấm bạt
('DI00000204', 1, '2023-03-05', N'Đã qua sử dụng', NULL, 'I000000216', 'REP002'), -- Vải trắng decor
('DI00000205', 1, '2023-02-10', N'Mới', NULL, 'I000000217', 'REP002'), -- Giấy A0
('DI00000206', 2, '2023-01-15', N'Mới', NULL, 'I000000218', 'REP002'), -- Giấy ruki
('DI00000207', 1, '2023-07-22', N'Đã qua sử dụng', NULL, 'I000000219', 'REP002'), -- Thùng trang trí Noel
('DI00000208', 1, '2023-08-03', N'Đã qua sử dụng', NULL, 'I000000220', 'REP002'), -- Cây thông Noel
('DI00000209', 1, '2023-09-10', N'Đã qua sử dụng', NULL, 'I000000221', 'REP002'), -- Hộp quà Noel decor
('DI00000210', 1, '2023-06-15', N'Đã qua sử dụng', NULL, 'I000000222', 'REP002'), -- Đèn ông sao khổng lồ
('DI00000211', 0, '2023-05-22', N'Mới', NULL, 'I000000130', 'REP002'), -- Dây đen led
('DI00000212', 1, '2023-04-03', N'Đã qua sử dụng', NULL, 'I000000223', 'REP002'), -- Ổ cắm điện
('DI00000213', 0, '2023-03-18', N'Mới', NULL, 'I000000224', 'REP002'), -- Pin cài
('DI00000214', 2, '2023-02-05', N'Đã qua sử dụng', NULL, 'I000000205', 'REP002'), -- Ván dài bàn ghế
('DI00000215', 3, '2023-01-10', N'Mới', NULL, 'I000000206', 'REP002'), -- Gạch trắng lót sàn
('DI00000216', 1, '2023-07-18', N'Đã qua sử dụng', NULL, 'I000000207', 'REP002'), -- Cuộn dây điện lớn
('DI00000217', 1, '2023-08-05', N'Mới', NULL, 'I000000208', 'REP002'), -- Đèn vòng
('DI00000218', 3, '2023-09-12', N'Mới', NULL, 'I000000169', 'REP002'), -- Đèn pha trắng
('DI00000219', 1, '2023-06-01', N'Đã qua sử dụng', NULL, 'I000000209', 'REP002'), -- Hộp đèn Tutor
('DI00000220', 30, '2023-05-10', N'Mới', NULL, 'I000000005', 'REP002'), -- Khăn giấy lụa Bless you
('DI00000221', 5, '2023-04-22', N'Mới', NULL, 'I000000020', 'REP002'), -- Cuộn in bill
('DI00000222', 2, '2023-03-03', N'Mới', NULL, 'I000000226', 'REP002'), -- Phấn màu
('DI00000223', 6, '2023-02-18', N'Mới', NULL, 'I000000053', 'REP002'), -- Bao rác nhỏ
('DI00000224', 4, '2023-01-05', N'Mới', NULL, 'I000000050', 'REP002'), -- Băng keo trong nhỏ
('DI00000225', 2, '2023-07-08', N'Mới', NULL, 'I000000011', 'REP003'), -- Thảm chùi chân
('DI00000226', 1, '2023-08-12', N'Mới', NULL, 'I000000189', 'REP003'), -- Nước rửa tay lifeboy
('DI00000227', 1, '2023-09-05', N'Mới', NULL, 'I000000190', 'REP003'), -- Thau nước
('DI00000228', 5, '2023-06-18', N'Mới', NULL, 'I000000053', 'REP003'), -- Bao rác nhỏ
('DI00000229', 4, '2023-05-01', N'Mới', NULL, 'I000000049', 'REP003'), -- Bao rác đen cỡ lớn
('DI00000230', 1, '2023-04-10', N'Mới', NULL, 'I000000019', 'REP003'), -- Bìa đứng để tài liệu
('DI00000231', 2, '2023-03-22', N'Cũ', NULL, 'I000000191', 'REP003'), -- Chân standee
('DI00000232', 8, '2023-02-03', N'Cũ', NULL, 'I000000192', 'REP003'), -- Khung tranh
('DI00000233', 6, '2023-01-18', N'Cũ', NULL, 'I000000193', 'REP003'), -- Đồ trang trí
('DI00000234', 5, '2023-07-05', N'Cũ', NULL, 'I000000194', 'REP003'), -- Máy chiếu
('DI00000235', 1, '2023-08-10', N'Cũ', NULL, 'I000000195', 'REP003'), -- Bảng trắng chữ nhật đứng (lớn)
('DI00000236', 1, '2023-09-22', N'Cũ', NULL, 'I000000196', 'REP003'), -- Bảng trắng chữ nhật đứng (nhỏ)
('DI00000237', 2, '2023-06-03', N'Cũ', NULL, 'I000000197', 'REP003'), -- Quạt
('DI00000238', 3, '2023-05-18', N'Cũ', NULL, 'I000000198', 'REP003'), -- Miếng bạc (trải ngủ)
('DI00000239', 4, '2023-04-01', N'Cũ', NULL, 'I000000199', 'REP003'), -- Thùng carton
('DI00000240', 1, '2023-03-10', N'Cũ', NULL, 'I000000200', 'REP003'), -- Ổ điện
('DI00000241', 33, '2023-02-28', N'Cũ', NULL, 'I000000201', 'REP003'), -- Bóng đèn LBD 5w
('DI00000242', 1, '2023-01-05', N'Cũ', NULL, 'I000000202', 'REP003'), -- Bóng đèn quẩy bar bling bling
('DI00000243', 3, '2023-07-10', N'Cũ', NULL, 'I000000203', 'REP003'), -- Bóng đèn Led Rotating Lamp
('DI00000244', 1, '2023-08-01', N'Cũ', NULL, 'I000000204', 'REP003'), -- Dây điện nối dài
('DI00000245', 96, '2023-09-15', N'Mới', NULL, 'I000000066', 'REP003'), -- Hộp milo
('DI00000246', 4, '2023-06-22', N'Mới', NULL, 'I000000005', 'REP003'), -- Khăn giấy lụa Bless you
('DI00000247', 1, '2023-05-03', N'Mới', NULL, 'I000000125', 'REP003'), -- Bìa sơ mi My Clear
('DI00000248', 1, '2023-04-18', N'Mới', NULL, 'I000000125', 'REP003'), -- Bìa sơ mi My Clear
('DI00000249', 10, '2023-03-05', N'Mới', NULL, 'I000000224', 'REP004'), -- Pin cài (Item 1)
('DI00000250', 10, '2023-02-10', N'Đã qua sử dụng', NULL, 'I000000099', 'REP001'), -- Giấy chơi loto (Item 2)
('DI00000251', 10, '2023-01-15', N'Mới', NULL, 'I000000042', 'REP001'), -- Giấy A4 (Item 3)
('DI00000252', 10, '2023-07-22', N'Mới', NULL, 'I000000062', 'REP001'), -- Tờ Premium (Item 4)
('DI00000253', 1, '2023-08-03', N'Mới', NULL, 'I000000006', 'REP001'), -- Vim
('DI00000254', 1, '2023-09-10', N'Mới', NULL, 'I000000018', 'REP004'), -- Nước lau kính Gift
('DI00000255', 1, '2023-06-15', N'Mới', NULL, 'I000000018', 'REP004'), -- Nước lau kính Gift
('DI00000256', 2, '2023-05-22', N'Mới', NULL, 'I000000001', 'REP004'), -- Nước rửa chén Sunlight (Can)
('DI00000257', 1, '2023-04-03', N'Mới', NULL, 'I000000009', 'REP004'), -- Lau sàn Gift
('DI00000258', 13, '2023-03-18', N'Mới', NULL, 'I000000049', 'REP004'), -- Bao rác đen cỡ lớn
('DI00000259', 5, '2023-02-05', N'Mới', NULL, 'I000000005', 'REP004'), -- Khăn giấy lụa Bless you
('DI00000260', 2, '2023-01-10', N'Mới', NULL, 'I000000226', 'REP004'), -- Phấn màu
('DI00000261', 1, '2023-07-18', N'Mới', NULL, 'I000000050', 'REP004'), -- Băng keo trong nhỏ
('DI00000262', 10, '2023-08-05', N'Mới', NULL, 'I000000224', 'REP005'), -- Pin cài (Item 1)
('DI00000263', 10, '2023-09-12', N'Đã qua sử dụng', NULL, 'I000000099', 'REP005'), -- Giấy chơi loto (Item 2)
('DI00000264', 10, '2023-06-01', N'Mới', NULL, 'I000000042', 'REP005'), -- Giấy A4 (Item 3)
('DI00000265', 10, '2023-05-10', N'Mới', NULL, 'I000000062', 'REP005'), -- Tờ Premium (Item 4)
('DI00000266', 5, '2023-04-22', N'Mới', NULL, 'I000000005', 'REP005'), -- Khăn giấy lụa Bless you
('DI00000267', 5, '2023-03-03', N'Mới', NULL, 'I000000005', 'REP005'), -- Khăn giấy lụa Bless you
('DI00000268', 20, '2023-02-18', N'Mới', NULL, 'I000000046', 'REP005'), -- Bút lông xanh
('DI00000269', 1, '2023-01-05', N'Mới', NULL, 'I000000052', 'REP005'), -- Cồn
('DI00000270', 1, '2023-07-10', N'Mới', NULL, 'I000000011', 'REP005'), -- Thảm chùi chân
('DI00000271', 10, '2023-08-01', N'Mới', NULL, 'I000000224', 'REP006'), -- Pin cài (Item 1)
('DI00000272', 10, '2023-09-15', N'Đã qua sử dụng', NULL, 'I000000099', 'REP006'), -- Giấy chơi loto (Item 2)
('DI00000273', 10, '2023-06-22', N'Mới', NULL, 'I000000042', 'REP006'), -- Giấy A4 (Item 3)
('DI00000274', 10, '2023-05-03', N'Mới', NULL, 'I000000062', 'REP006'), -- Tờ Premium (Item 4)
('DI00000275', 2, '2023-04-18', N'Mới', NULL, 'I000000226', 'REP006'), -- Phấn màu
('DI00000276', 4, '2023-03-05', N'Mới', NULL, 'I000000035', 'REP006'), -- Pin 3A
('DI00000277', 10, '2023-02-10', N'Mới', NULL, 'I000000224', 'REP007'), -- Pin cài (Item 1)
('DI00000278', 10, '2023-01-15', N'Đã qua sử dụng', NULL, 'I000000099', 'REP007'), -- Giấy chơi loto (Item 2)
('DI00000279', 10, '2023-07-22', N'Mới', NULL, 'I000000042', 'REP007'), -- Giấy A4 (Item 3)
('DI00000280', 10, '2023-08-03', N'Mới', NULL, 'I000000062', 'REP007'), -- Tờ Premium (Item 4)
('DI00000281', 5, '2023-09-10', N'Mới', NULL, 'I000000024', 'REP007'), -- Bút
('DI00000282', 2, '2023-06-15', N'Mới', NULL, 'I000000005', 'REP007'), -- Khăn giấy lụa Bless you
('DI00000283', 2, '2023-05-22', N'Mới', NULL, 'I000000033', 'REP007'), -- Pin 2A
('DI00000284', 10, '2023-04-03', N'Mới', NULL, 'I000000035', 'REP007'), -- Pin 3A
('DI00000285', 5, '2023-03-18', N'Mới', NULL, 'I000000017', 'REP007'), -- Sáp thơm
('DI00000286', 10, '2023-02-05', N'Mới', NULL, 'I000000049', 'REP007'), -- Bao rác đen cỡ lớn
('DI00000287', 10, '2023-02-05', N'Mới', NULL, 'I000000226', 'REP001'); -- Phấn màu



INSERT INTO Item (item_id, name, type, unit, company, description) VALUES
('I000000001', N'Nước rửa chén Sunlight (Can)', N'Vật tư', N'Can', N'', NULL),
('I000000002', N'Nước rửa tay', N'Vật tư', N'Can', N'', NULL),
('I000000003', N'Xịt phòng Spring', N'Vật tư', N'Chai', N'', NULL),
('I000000004', N'Xịt phòng OASIS', N'Vật tư', N'Chai', N'', NULL),
('I000000005', N'Khăn giấy lụa Bless you', N'Vật tư', N'Gói', N'', NULL),
('I000000006', N'Vim', N'Vật tư', N'Chai', N'', NULL),
('I000000007', N'Bìa lá mềm', N'Vật tư', N'Cái', N'', NULL),
('I000000008', N'Tẩy phòng tắm', N'Vật tư', N'Chai', N'', NULL),
('I000000009', N'Lau sàn Gift', N'Vật tư', N'Can', N'', NULL),
('I000000010', N'Phấn trắng', N'Vật tư', N'Hộp', N'', NULL),
('I000000011', N'Thảm chùi chân', N'Vật tư', N'Cái', N'', NULL),
('I000000012', N'Nước rửa chén Sunlight (Chai)', N'Vật tư', N'Chai', N'', NULL),
('I000000013', N'Thảm mặt tiền cỡ bự', N'Vật tư', N'Cái', N'', NULL),
('I000000014', N'Kệ tài liệu để bàn', N'Vật tư', N'Cái', N'', NULL),
('I000000015', N'Bộ lau nhà', N'Vật tư', N'Cái', N'', NULL),
('I000000016', N'Máy in bill', N'Vật tư', N'Cái', N'', NULL),
('I000000017', N'Sáp thơm', N'Vật tư', N'Cái', N'', NULL),
('I000000018', N'Nước lau kính Gift', N'Vật tư', N'Chai', N'', NULL),
('I000000019', N'Bìa sơ mi', N'Vật tư', N'Cái', N'', NULL),
('I000000020', N'Cuộn in bill', N'Vật tư', N'Cuộn', N'', NULL),
('I000000021', N'Thùng rác cỡ nhỏ', N'Vật tư', N'Cái', N'', NULL),
('I000000022', N'Rổ nhựa nhỏ', N'Vật tư', N'Cái', N'', NULL),
('I000000023', N'Rổ nhựa lớn', N'Vật tư', N'Cái', N'', NULL),
('I000000024', N'Bút', N'Vật tư', N'Cây', N'', NULL),
('I000000025', N'Bìa sơ mi A5 cute', N'Vật tư', N'Cái', N'', NULL),
('I000000026', N'Chổi', N'Vật tư', N'Cây', N'', NULL),
('I000000027', N'Ghim bấm', N'Vật tư', N'Hộp', N'', NULL),
('I000000028', N'Bấm lỗ', N'Vật tư', N'Cái', N'', NULL),
('I000000029', N'Kẹp giấy', N'Vật tư', N'Hộp', N'', NULL),
('I000000030', N'Giấy note', N'Vật tư', N'Sấp', N'', NULL),
('I000000031', N'Rổ nhỏ chữ nhật', N'Vật tư', N'Cái', N'', NULL),
('I000000032', N'Bấm giấy mini', N'Vật tư', N'Cái', N'', NULL),
('I000000033', N'Pin 2A', N'Vật tư', N'Hộp', N'', NULL),
('I000000034', N'Pin 2A (bị lẻ)', N'Vật tư', N'Cặp', N'', NULL),
('I000000035', N'Pin 3A', N'Vật tư', N'Cặp', N'', NULL),
('I000000036', N'Pin đại', N'Vật tư', N'Cái', N'', NULL),
('I000000037', N'Khăn lau bảng', N'Vật tư', N'Cái', N'', NULL),
('I000000038', N'Chà bồn cầu', N'Vật tư', N'Cây', N'', NULL),
('I000000039', N'Cây lau nhà', N'Vật tư', N'Cây', N'', NULL),
('I000000040', N'Mê hốt rác', N'Vật tư', N'Cây', N'', NULL),
('I000000041', N'Bông lau nhà', N'Vật tư', N'Cái', N'', NULL),
('I000000042', N'Giấy A4', N'Vật tư', N'Sấp', N'', NULL),
('I000000043', N'Bìa lỗ', N'Vật tư', N'Cái', N'', NULL),
('I000000044', N'Bút lông đen', N'Vật tư', N'Cây', N'', NULL),
('I000000045', N'Bút lông đỏ', N'Vật tư', N'Cây', N'', NULL),
('I000000046', N'Bút lông xanh', N'Vật tư', N'Cây', N'', NULL),
('I000000047', N'Tấm Mica dán bàn TVV', N'Vật tư', N'Cái', N'', NULL),
('I000000048', N'Mực in đỏ (dấu mộc)', N'Vật tư', N'Hộp', N'', NULL),
('I000000049', N'Bao rác đen cỡ lớn', N'Vật tư', N'Tờ', N'', NULL),
('I000000050', N'Băng keo trong nhỏ', N'Vật tư', N'Cuộn', N'', NULL),
('I000000051', N'Bìa cây', N'Vật tư', N'Cái', N'', NULL),
('I000000052', N'Cồn', N'Vật tư', N'Chai', N'', NULL),
('I000000053', N'Bao rác nhỏ', N'Vật tư', N'Cục', N'', NULL),
('I000000054', N'Máy xông tinh dầu', N'Vật tư', N'Cái', N'', NULL),
('I000000055', N'Ống cắm bút', N'Vật tư', N'Cái', N'', NULL),
('I000000056', N'Kéo', N'Vật tư', N'Cái', N'', NULL),
('I000000057', N'Đồ bấm ghim', N'Vật tư', N'Cái', N'', NULL),
('I000000058', N'Bút bi xanh', N'Vật tư', N'Cái', N'', NULL),
('I000000059', N'Mực in con dấu', N'Vật tư', N'Chai', N'', NULL),
('I000000060', N'Standee Menu A4', N'Vật tư', N'Cái', N'', NULL),
('I000000061', N'Cà phê', N'Premium', N'Bịch', N'', NULL),
('I000000062', N'Tờ Premium', N'Premium', N'Sấp', N'', NULL),
('I000000063', N'Nestea vị chanh', N'Premium', N'Hộp', N'', NULL),
('I000000064', N'Nestea vị vải và lài', N'Premium', N'Hộp', N'', NULL),
('I000000065', N'Bịch Milo gói', N'Premium', N'Bịch', N'', NULL),
('I000000066', N'Hộp milo', N'Premium', N'Hộp', N'', NULL),
('I000000067', N'Bánh Cal Cheese', N'Premium', N'Thanh', N'', NULL),
('I000000068', N'Thùng rác Premium', N'Premium', N'Cái', N'', NULL),
('I000000069', N'NesCafe', N'Premium', N'Gói', N'', NULL),
('I000000070', N'Miếng rửa chén', N'Premium', N'Miếng', N'', NULL),
('I000000071', N'Gói Tipo', N'Premium', N'Gói', N'', NULL),
('I000000072', N'Bánh Ochi', N'Premium', N'Cái', N'', NULL),
('I000000073', N'Áo Premium', N'Premium', N'Cái', N'', NULL),
('I000000074', N'Phong bì thư NQH', N'Khu vực - MKT', N'Sấp', N'', NULL),
('I000000075', N'Thùng đá', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000076', N'Cây thông thầy Hiệu', N'Khu vực - MKT', N'Thùng', N'', NULL),
('I000000077', N'Vở NQH', N'Khu vực - MKT', N'Cuốn', N'', NULL),
('I000000078', N'Banner Hệ thống giáo dục', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000079', N'Khung ảnh', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000080', N'Balo NQH', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000081', N'Áo Tư vấn viên Cấp 2', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000082', N'Đồ từ thiện', N'Khu vực - MKT', N'Bao', N'', NULL),
('I000000083', N'Sổ đậu Đại học', N'Khu vực - MKT', N'Cuốn', N'', NULL),
('I000000084', N'Dây đèn Tân Phú', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000085', N'Bìa nhiều lớp', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000086', N'lọ thủy tinh mini', N'Khu vực - MKT', N'Lọ', N'', NULL),
('I000000087', N'Vòng tay NQH', N'Khu vực - MKT', N'Vòng', N'', NULL),
('I000000088', N'Giấy màu', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000089', N'Mũ NQH', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000090', N'Khăn quàng đỏ', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000091', N'Phong bì thư trắng', N'Khu vực - MKT', N'Sấp', N'', NULL),
('I000000092', N'Vòng tay NQH Cấp 2', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000093', N'Bảng khu vực', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000094', N'Áo Hệ thống', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000095', N'Áo thể thao NQH', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000096', N'Súng bắn tiền', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000097', N'Vòng quay loto', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000098', N'Đĩa sứ', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000099', N'Giấy chơi loto', N'Khu vực - MKT', N'Sấp', N'', NULL),
('I000000100', N'Hàng rào trang trí', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000101', N'Bóng nhỏ', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000102', N'Khăn xanh trải bàn', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000103', N'Khăn đỏ trải bàn', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000104', N'Ly mini quà tặng', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000105', N'Manocanh decor', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000106', N'Bìa sơ mi logo NQH', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000107', N'Bút chì IELTS', N'Khu vực - MKT', N'Cây', N'', NULL),
('I000000108', N'Bút chì NQH', N'Khu vực - MKT', N'Cây', N'', NULL),
('I000000109', N'Bút chì thường', N'Khu vực - MKT', N'Cây', N'', NULL),
('I000000110', N'Hạt xốp', N'Khu vực - MKT', N'Bịch', N'', NULL),
('I000000111', N'Lồng đèn', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000112', N'Giấy gói quà', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000113', N'Súng nước', N'Khu vực - MKT', N'Cây', N'', NULL),
('I000000114', N'Cây mai giả', N'Khu vực - MKT', N'Cây', N'', NULL),
('I000000115', N'Bơm bong bóng tay', N'Khu vực - MKT', N'Cây', N'', NULL),
('I000000116', N'Bơm bong bóng máy', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000117', N'Cài tóc đen trơn', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000118', N'Quà pin cài Noel', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000119', N'Trống mini', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000120', N'Mâm gỗ', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000121', N'Loa phát thanh', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000122', N'Ruy băng cam', N'Khu vực - MKT', N'Cuộn', N'', NULL),
('I000000123', N'Ruy băng Vàng - Cam + Decal lửa', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000124', N'Bóng đập cổ vũ', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000125', N'Bìa sơ mi My Clear', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000126', N'Cài tai thỏ', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000127', N'Heo nhựa', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000128', N'Cán cờ', N'Khu vực - MKT', N'Cây', N'', NULL),
('I000000129', N'Tripod', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000130', N'Dây đen led', N'Khu vực - MKT', N'Dây', N'', NULL),
('I000000131', N'Thùng trang trí Halloween', N'Khu vực - MKT', N'Thùng', N'', NULL),
('I000000132', N'Thùng trang trí Tết', N'Khu vực - MKT', N'Thùng', N'', NULL),
('I000000133', N'Tim đèn', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000134', N'Thùng đồ Cosplay', N'Khu vực - MKT', N'Thùng', N'', NULL),
('I000000135', N'Chân standee đứng', N'Khu vực - MKT', N'Cây', N'', NULL),
('I000000136', N'Giấy vụn trang trí', N'Khu vực - MKT', N'Bao', N'', NULL),
('I000000137', N'Túi nilon NQH', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000138', N'Túi vải NQH', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000139', N'Phao', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000140', N'Khăn rằn', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000141', N'Ủng đen', N'Khu vực - MKT', N'Đôi', N'', NULL),
('I000000142', N'Bao tay', N'Khu vực - MKT', N'Đôi', N'', NULL),
('I000000143', N'Bong bóng + cây', N'Khu vực - MKT', N'Bịch', N'', NULL),
('I000000144', N'Dây đeo bảng tên', N'Khu vực - MKT', N'Dây', N'', NULL),
('I000000145', N'Dây thun', N'Khu vực - MKT', N'Bịch', N'', NULL),
('I000000146', N'Bảng tỉ số', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000147', N'Áo trọng tài', N'Khu vực - MKT', N'Bịch', N'', NULL),
('I000000148', N'Bảng tên bàn', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000149', N'Giấy ruki', N'Khu vực - MKT', N'Tờ', N'', NULL),
('I000000150', N'Dây cột tóc', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000151', N'Huy chương đeo', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000152', N'Cờ Cấp 3 khu vực', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000153', N'Cờ Cấp 2 khu vực', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000154', N'Cuộn giấy Flipchart', N'Khu vực - MKT', N'Cuộn', N'', NULL),
('I000000155', N'Áo Liên Minh', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000156', N'Đèn livestream', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000157', N'Vỏ bình nước lọc', N'Khu vực - MKT', N'Thùng', N'', NULL),
('I000000158', N'Quấn wrap', N'Khu vực - MKT', N'Cuộn', N'', NULL),
('I000000159', N'Banner cầu lông CHÁY', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000160', N'Lightstick', N'Khu vực - MKT', N'Thùng', N'', NULL),
('I000000161', N'Áo Tư vấn viên Cấp 3', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000162', N'Sơn', N'CSVC', N'Thùng', N'', NULL),
('I000000163', N'Phiếu gửi xe', N'CSVC', N'Sấp', N'', NULL),
('I000000164', N'Tấm thạch cao', N'CSVC', N'Cái', N'', NULL),
('I000000165', N'Dây rút', N'CSVC', N'Dây', N'', NULL),
('I000000166', N'Ruột gà 25m', N'CSVC', N'Cuộn', N'', NULL),
('I000000167', N'Đèn pha', N'CSVC', N'Cái', N'', NULL),
('I000000168', N'Thiết bị camera', N'CSVC', N'Hộp', N'', NULL),
('I000000169', N'Đèn pha trắng', N'CSVC', N'Cái', N'', NULL),
('I000000170', N'Chân chống TV', N'CSVC', N'Cái', N'', NULL),
('I000000171', N'Dây cước', N'CSVC', N'Cuộn', N'', NULL),
('I000000172', N'Quạt gió', N'CSVC', N'Cây', N'', NULL),
('I000000173', N'Đèn led 1m2', N'CSVC', N'Cây', N'', NULL),
('I000000174', N'Miếng lót sàn', N'CSVC', N'Miếng', N'', NULL),
('I000000175', N'Ống đồng', N'CSVC', N'Mét', N'', NULL),
('I000000176', N'Súng silicon', N'CSVC', N'Cây', N'', NULL),
('I000000177', N'Màn chiếu', N'CSVC', N'Bộ', N'', NULL),
('I000000178', N'Cửa nhôm', N'CSVC', N'Cái', N'', NULL),
('I000000179', N'Dây điện', N'CSVC', N'Cuộn', N'', NULL),
('I000000180', N'Nắp cống', N'CSVC', N'Thùng', N'', NULL),
('I000000181', N'Dây nilon', N'CSVC', N'Cuộn', N'', NULL),
('I000000182', N'Dây HDMI', N'CSVC', N'Dây', N'', NULL),
('I000000183', N'Ấm đun nước', N'CSVC', N'Cái', N'', NULL),
('I000000184', N'Bình công nhân', N'CSVC', N'Bịch', N'', NULL),
('I000000185', N'Bình nóng lạnh', N'CSVC', N'Bịch', N'', NULL),
('I000000186', N'Điện thoại bàn', N'CSVC', N'Bộ', N'', NULL),
('I000000187', N'Dây kẽm', N'CSVC', N'Vòng', N'', NULL),
('I000000188', N'Ổ cứng HDD Seagate', N'CSVC', N'Cái', N'', NULL),
('I000000189', N'Nước rửa tay lifeboy', N'Vật tư', N'Cái', N'', NULL),
('I000000190', N'Thau nước', N'Vật tư', N'Cái', N'', NULL),
('I000000191', N'Chân standee', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000192', N'Khung tranh', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000193', N'Đồ trang trí', N'Khu vực - MKT', N'Bao', N'', NULL),
('I000000194', N'Máy chiếu', N'CSVC', N'Cái', N'', NULL),
('I000000195', N'Bảng trắng chữ nhật đứng (lớn)', N'CSVC', N'Cái', N'', NULL),
('I000000196', N'Bảng trắng chữ nhật đứng (nhỏ)', N'CSVC', N'Cái', N'', NULL),
('I000000197', N'Quạt', N'CSVC', N'Cái', N'', NULL),
('I000000198', N'Miếng bạc (trải ngủ)', N'CSVC', N'Miếng', N'', NULL),
('I000000199', N'Thùng carton', N'CSVC', N'Thùng', N'', NULL),
('I000000200', N'Ổ điện', N'CSVC', N'Cái', N'', NULL),
('I000000201', N'Bóng đèn LBD 5w', N'CSVC', N'Cái', N'', NULL),
('I000000202', N'Bóng đèn quẩy bar bling bling', N'CSVC', N'Cái', N'', NULL),
('I000000203', N'Bóng đèn Led Rotating Lamp', N'CSVC', N'Cái', N'', NULL),
('I000000204', N'Dây điện nối dài', N'CSVC', N'Cái', N'', NULL),
('I000000205', N'Ván dài bàn ghế', N'CSVC', N'tấm', N'', NULL),
('I000000206', N'Gạch trắng lót sàn', N'CSVC', N'miếng', N'', NULL),
('I000000207', N'Cuộn dây điện lớn', N'CSVC', N'cuộn', N'', NULL),
('I000000208', N'Đèn vòng', N'CSVC', N'cái', N'', NULL),
('I000000209', N'Hộp đèn Tutor', N'CSVC', N'cái', N'', NULL),
('I000000210', N'Bịch nhựa dẻo', N'Khu vực - MKT', N'cái', N'', NULL),
('I000000211', N'Quà Noel lật đật', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000212', N'Túi bóng quà', N'Khu vực - MKT', N'túi', N'', NULL),
('I000000213', N'Khuôn làm bánh', N'Khu vực - MKT', N'cái', N'', NULL),
('I000000214', N'Ly chia thể tích', N'Khu vực - MKT', N'cái', N'', NULL),
('I000000215', N'Tấm bạt', N'Khu vực - MKT', N'cái', N'', NULL),
('I000000216', N'Vải trắng decor', N'Khu vực - MKT', N'cái', N'', NULL),
('I000000217', N'Giấy A0', N'Khu vực - MKT', N'cuộn', N'', NULL),
('I000000218', N'Giấy ruki', N'Khu vực - MKT', N'cuộn', N'', NULL),
('I000000219', N'Thùng trang trí Noel', N'Khu vực - MKT', N'thùng', N'', NULL),
('I000000220', N'Cây thông Noel', N'Khu vực - MKT', N'cây', N'', NULL),
('I000000221', N'Hộp quà Noel decor', N'Khu vực - MKT', N'thùng', N'', NULL),
('I000000222', N'Đèn ông sao khổng lồ', N'Khu vực - MKT', N'cái', N'', NULL),
('I000000223', N'Ổ cắm điện', N'Khu vực - MKT', N'Cái',N'',NULL),
('I000000224', N'Pin cài', N'Khu vực - MKT', N'Cái', N'', NULL),
('I000000225', N'Ủng đen', N'Khu vực - MKT', N'Đôi', N'', NULL),
('I000000226', N'Phấn màu', N'Vật tư', N'Hộp', N'', NULL);

