-- ============================================================
-- CHỈ THÊM 2 BẢNG MỚI VÀO DATABASE gym ĐANG CÓ SẴN
-- (NewStaff cho chức năng NEW STAFF, Equipment cho EQUIPMENT)
-- Không đụng gì tới bảng NewMember và dữ liệu hội viên cũ.
-- Chạy lại nhiều lần vẫn an toàn: bảng nào có rồi thì tự bỏ qua.
-- Cách chạy: mở file này trong SSMS -> Execute (F5)
-- ============================================================

USE gym;
GO

-- Bảng Nhân viên (NEW STAFF)
IF OBJECT_ID('dbo.NewStaff', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.NewStaff (
        SID      INT IDENTITY(1,1) PRIMARY KEY,
        Fname    NVARCHAR(150) NOT NULL,
        Lname    NVARCHAR(150) NOT NULL,
        Gender   NVARCHAR(20)  NOT NULL,
        Dob      DATE          NOT NULL,
        Mobile   VARCHAR(20)   NOT NULL,
        Email    NVARCHAR(150) NOT NULL,
        JoinDate DATE          NOT NULL,
        Saddress NVARCHAR(250) NOT NULL
    );
END
GO

-- Bảng Thiết bị (EQUIPMENT)
IF OBJECT_ID('dbo.Equipment', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Equipment (
        EID          INT IDENTITY(1,1) PRIMARY KEY,
        EquipName    NVARCHAR(150)  NOT NULL,
        EDescription NVARCHAR(500)  NULL,
        MusclesUsed  NVARCHAR(150)  NULL,
        Cost         DECIMAL(18,2)  NOT NULL DEFAULT 0,
        Units        INT            NOT NULL DEFAULT 0,
        PurchaseDate DATE           NULL
    );
END
GO

-- Kiểm tra lại: phải thấy đủ 3 bảng NewMember, NewStaff, Equipment
SELECT * FROM NewMember;
SELECT * FROM NewStaff;
SELECT * FROM Equipment;
GO
