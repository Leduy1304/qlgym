-- ============================================================
-- GYM MANAGEMENT - SCRIPT DATABASE ĐẦY ĐỦ
-- Cách chạy: Mở SQL Server Management Studio (SSMS),
-- mở file này -> bấm Execute (F5). Chạy lại nhiều lần vẫn an toàn
-- (bảng nào đã có rồi thì script tự bỏ qua, không mất dữ liệu cũ).
-- ============================================================

-- Tạo database gym nếu chưa có
IF DB_ID('gym') IS NULL
    CREATE DATABASE gym;
GO

USE gym;
GO

-- ------------------------------------------------------------
-- 1) Bảng NewMember (Hội viên) - chức năng NEW MEMBER đã làm
--    MID là mã hội viên, tự tăng - dùng cho SEARCH / DELETE MEMBER
-- ------------------------------------------------------------
IF OBJECT_ID('dbo.NewMember', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.NewMember (
        MID            INT IDENTITY(1,1) PRIMARY KEY,
        Fname          NVARCHAR(150) NOT NULL,
        Lname          NVARCHAR(150) NOT NULL,
        Gender         NVARCHAR(20)  NOT NULL,
        Dob            DATE          NOT NULL,
        Mobile         VARCHAR(20)   NOT NULL,
        Email          NVARCHAR(150) NOT NULL,
        JoinDate       DATE          NOT NULL,
        Gymtime        NVARCHAR(120) NOT NULL,
        Maddress       NVARCHAR(250) NOT NULL,
        MembershipTime NVARCHAR(120) NOT NULL
    );
END
GO

-- ------------------------------------------------------------
-- 2) Bảng NewStaff (Nhân viên) - chức năng NEW STAFF (mới)
--    SID là mã nhân viên, tự tăng
-- ------------------------------------------------------------
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

-- ------------------------------------------------------------
-- 3) Bảng Equipment (Thiết bị) - chức năng EQUIPMENT (mới)
--    EID là mã thiết bị, tự tăng
-- ------------------------------------------------------------
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

-- ------------------------------------------------------------
-- Kiểm tra lại 3 bảng sau khi chạy xong
-- ------------------------------------------------------------
SELECT * FROM NewMember;
SELECT * FROM NewStaff;
SELECT * FROM Equipment;
GO

-- ------------------------------------------------------------
-- (Không bắt buộc) Dữ liệu mẫu để test nhanh - bỏ dấu -- ở đầu
-- từng dòng INSERT rồi Execute riêng đoạn này nếu muốn có sẵn
-- dữ liệu để demo SEARCH / DELETE MEMBER và EQUIPMENT.
-- ------------------------------------------------------------
-- INSERT INTO NewStaff (Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Saddress)
-- VALUES (N'Nguyễn Văn', N'An', N'Nam', '2000-05-12', '0901234567', 'an.nguyen@example.com', '2025-01-10', N'Quận 1, TP.HCM');
--
-- INSERT INTO Equipment (EquipName, EDescription, MusclesUsed, Cost, Units, PurchaseDate)
-- VALUES (N'Máy chạy bộ', N'Máy chạy bộ điện, tốc độ tối đa 20km/h', N'Chân - Tim mạch', 25000000, 5, '2025-02-01');
