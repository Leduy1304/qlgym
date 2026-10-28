-- ============================================================
-- HỆ THỐNG QUẢN LÝ GYM ANH TÚ - SCRIPT DATABASE ĐẦY ĐỦ
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
-- 1) Bảng NewMember (Hội viên) - chức năng ĐĂNG KÝ / QUẢN LÝ HỘI VIÊN
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
        Mobile         VARCHAR(20)   NOT NULL UNIQUE,
        Email          NVARCHAR(150) NOT NULL UNIQUE,
        JoinDate       DATE          NOT NULL,
        Gymtime        NVARCHAR(120) NOT NULL,
        Maddress       NVARCHAR(250) NOT NULL,
        MembershipTime NVARCHAR(120) NOT NULL,
        AssignedPT     NVARCHAR(150) NULL
    );
END
ELSE
BEGIN
    -- Bổ sung cột AssignedPT nếu bảng NewMember đã tồn tại từ trước
    IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'NewMember' AND COLUMN_NAME = 'AssignedPT')
    BEGIN
        ALTER TABLE dbo.NewMember ADD AssignedPT NVARCHAR(150) NULL;
    END
END
GO

-- ------------------------------------------------------------
-- 2) Bảng NewPT (PT - Huấn luyện viên) - chức năng ĐĂNG KÝ / QUẢN LÝ PT
--    PID là mã PT, tự tăng
-- ------------------------------------------------------------
IF OBJECT_ID('dbo.NewPT', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.NewPT (
        PID      INT IDENTITY(1,1) PRIMARY KEY,
        Fname    NVARCHAR(150) NOT NULL,
        Lname    NVARCHAR(150) NOT NULL,
        Gender   NVARCHAR(20)  NOT NULL,
        Dob      DATE          NOT NULL,
        Mobile   VARCHAR(20)   NOT NULL UNIQUE,
        Email    NVARCHAR(150) NOT NULL UNIQUE,
        JoinDate DATE          NOT NULL,
        Paddress NVARCHAR(250) NOT NULL
    );
END
GO

-- ------------------------------------------------------------
-- 3) Bảng Equipment (Thiết bị phòng tập) - Admin có quyền thêm/xóa
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
-- 4) Bảng TaiKhoan (Tài khoản đăng nhập hệ thống)
--    Liên kết với NewMember (MID) hoặc NewPT (PID)
-- ------------------------------------------------------------
IF OBJECT_ID('dbo.TaiKhoan', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.TaiKhoan (
        Id          INT IDENTITY(1,1) PRIMARY KEY,
        TenDangNhap NVARCHAR(100) NOT NULL UNIQUE,
        MatKhau     NVARCHAR(250) NOT NULL,
        VaiTro      NVARCHAR(50)  NOT NULL, -- 'Admin', 'HoiVien', 'PT'
        MID         INT           NULL,     -- Mã Hội viên liên kết (nếu là Hội viên)
        PID         INT           NULL,     -- Mã PT liên kết (nếu là PT)
        NgayTao     DATETIME      NOT NULL DEFAULT GETDATE(),
        CONSTRAINT FK_TaiKhoan_NewMember FOREIGN KEY (MID) REFERENCES dbo.NewMember(MID) ON DELETE CASCADE,
        CONSTRAINT FK_TaiKhoan_NewPT FOREIGN KEY (PID) REFERENCES dbo.NewPT(PID) ON DELETE CASCADE
    );
END
GO

-- ------------------------------------------------------------
-- 5) Bảng DeXuatThietBi (Hội viên và PT đề xuất thiết bị mới)
--    Chỉ Admin có quyền phê duyệt để đưa vào bảng Equipment chính thức
-- ------------------------------------------------------------
IF OBJECT_ID('dbo.DeXuatThietBi', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.DeXuatThietBi (
        Id           INT IDENTITY(1,1) PRIMARY KEY,
        EquipName    NVARCHAR(150) NOT NULL,
        EDescription NVARCHAR(500) NULL,
        MusclesUsed  NVARCHAR(150) NULL,
        Cost         DECIMAL(18,2) NOT NULL DEFAULT 0,
        Units        INT           NOT NULL DEFAULT 1,
        NguoiDeXuat  NVARCHAR(100) NOT NULL, -- Tên tài khoản người đề xuất
        VaiTro       NVARCHAR(50)  NOT NULL, -- 'HoiVien' hoặc 'PT'
        NgayDeXuat   DATE          NOT NULL,
        TrangThai    NVARCHAR(50)  NOT NULL DEFAULT N'Chờ duyệt', -- N'Chờ duyệt', N'Đã duyệt', N'Từ chối'
        GhiChuAdmin  NVARCHAR(250) NULL
    );
END
GO

-- ------------------------------------------------------------
-- 6) Khởi tạo tài khoản Admin mặc định (admin / 12345)
-- ------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM dbo.TaiKhoan WHERE TenDangNhap = 'admin')
BEGIN
    INSERT INTO dbo.TaiKhoan (TenDangNhap, MatKhau, VaiTro)
    VALUES ('admin', '12345', 'Admin');
END
GO

-- ------------------------------------------------------------
-- 7) Dữ liệu mẫu khởi tạo cho Thiết bị và Đề xuất thiết bị
-- ------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM dbo.Equipment)
BEGIN
    INSERT INTO dbo.Equipment (EquipName, EDescription, MusclesUsed, Cost, Units, PurchaseDate)
    VALUES 
    (N'Máy chạy bộ cao cấp', N'Máy chạy bộ điện Impulse RT700, tốc độ tối đa 22km/h', N'Chân - Đùi - Tim mạch', 28500000, 5, '2025-01-15'),
    (N'Ghế đẩy ngực đa năng', N'Ghế đẩy ngực ngang điều chỉnh 3 góc độ dốc', N'Ngực - Vai - Tay sau', 6500000, 8, '2025-02-01'),
    (N'Bộ tạ đơn tháp 2.5kg - 30kg', N'Dàn tạ đơn bọc cao su chống va đập nhập khẩu', N'Toàn thân', 18000000, 2, '2025-02-10');
END
GO

IF NOT EXISTS (SELECT 1 FROM dbo.DeXuatThietBi)
BEGIN
    INSERT INTO dbo.DeXuatThietBi (EquipName, EDescription, MusclesUsed, Cost, Units, NguoiDeXuat, VaiTro, NgayDeXuat, TrangThai)
    VALUES 
    (N'Máy chèo thuyền (Rowing Machine)', N'Đề xuất bổ sung thêm máy tập chèo thuyền để hỗ trợ bài tập Cardio và lưng xô', N'Lưng - Tay - Tim mạch', 12000000, 2, 'duy', 'HoiVien', '2026-10-25', N'Chờ duyệt'),
    (N'Khung gánh tạ Smith Machine', N'Đề xuất trang bị thêm 1 khung Smith để học viên tập squat an toàn hơn', N'Đùi - Mông', 22000000, 1, 'duypt', 'PT', '2026-10-26', N'Chờ duyệt');
END
GO

-- ------------------------------------------------------------
-- Kiểm tra lại các bảng sau khi chạy xong
-- ------------------------------------------------------------
SELECT * FROM dbo.TaiKhoan;
SELECT * FROM dbo.NewMember;
SELECT * FROM dbo.NewPT;
SELECT * FROM dbo.Equipment;
SELECT * FROM dbo.DeXuatThietBi;
GO
