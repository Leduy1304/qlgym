USE gym;
GO

-- Đổi các cột chữ sang NVARCHAR để hỗ trợ tiếng Việt có dấu
ALTER TABLE NewMember
ALTER COLUMN Fname NVARCHAR(150) NOT NULL;
GO

ALTER TABLE NewMember
ALTER COLUMN Lname NVARCHAR(150) NOT NULL;
GO

ALTER TABLE NewMember
ALTER COLUMN Gender NVARCHAR(20) NOT NULL;
GO

ALTER TABLE NewMember
ALTER COLUMN Maddress NVARCHAR(250) NOT NULL;
GO

ALTER TABLE NewMember
ALTER COLUMN Gymtime NVARCHAR(120) NOT NULL;
GO

ALTER TABLE NewMember
ALTER COLUMN MembershipTime NVARCHAR(120) NOT NULL;
GO

-- Ngày tháng nên dùng DATE thay vì VARCHAR
ALTER TABLE NewMember
ALTER COLUMN Dob DATE NOT NULL;
GO

ALTER TABLE NewMember
ALTER COLUMN JoinDate DATE NOT NULL;
GO

-- Số điện thoại nên dùng VARCHAR để giữ được số 0 ở đầu
ALTER TABLE NewMember
ALTER COLUMN Mobile VARCHAR(20) NOT NULL;
GO

 //Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,Gymtime,Maddress,MembershipTime
	
 select * from NewMember;