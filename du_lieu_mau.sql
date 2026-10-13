-- ============================================================
-- GYM MANAGEMENT - DU LIEU MAU DE DEMO / TEST NHANH
-- Cach chay: Mo SSMS -> mo file nay -> Execute (F5).
-- An toan: moi dong deu co kiem tra "chua co thi moi them"
-- (theo Email voi hoi vien/nhan vien, theo Ten voi thiet bi),
-- nen chay lai nhieu lan KHONG bi trung du lieu.
-- Luu y: MID/SID/EID la so tu tang, nen ma thuc te tren may
-- cua ban co the khong bat dau tu 1 neu ban da tung them/xoa
-- du lieu test truoc do - cu nhin cot MID trong form Search
-- Member la biet ma dung de tim/xoa.
-- ============================================================

USE gym;
GO

-- ------------------------------------------------------------
-- 1) Hoi vien mau (bang NewMember) - 3 nguoi
--    Gymtime va MembershipTime dung dung cac gia tri co san
--    trong ComboBox cua form New Member.
-- ------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM NewMember WHERE Email = 'an.nguyen@example.com')
    INSERT INTO NewMember (Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Gymtime, Maddress, MembershipTime)
    VALUES (N'Nguyễn Văn', N'An', N'Nam', '2000-05-12', '0901234567', 'an.nguyen@example.com', '2025-09-01', '06AM-07AM', N'Quận 1, TP.HCM', N'3 tháng');
GO

IF NOT EXISTS (SELECT 1 FROM NewMember WHERE Email = 'bich.tran@example.com')
    INSERT INTO NewMember (Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Gymtime, Maddress, MembershipTime)
    VALUES (N'Trần Thị', N'Bích', N'Nữ', '2002-08-20', '0912345678', 'bich.tran@example.com', '2025-09-15', '05PM-06PM', N'Quận 3, TP.HCM', N'6 tháng');
GO

IF NOT EXISTS (SELECT 1 FROM NewMember WHERE Email = 'cuong.le@example.com')
    INSERT INTO NewMember (Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Gymtime, Maddress, MembershipTime)
    VALUES (N'Lê Văn', N'Cường', N'Nam', '1999-01-30', '0987654321', 'cuong.le@example.com', '2025-10-01', '07PM-08PM', N'Bình Thạnh, TP.HCM', N'1 năm');
GO

-- ------------------------------------------------------------
-- 2) Nhan vien mau (bang NewStaff) - 2 nguoi
-- ------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM NewStaff WHERE Email = 'dung.pham@example.com')
    INSERT INTO NewStaff (Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Saddress)
    VALUES (N'Phạm Văn', N'Dũng', N'Nam', '1998-03-15', '0903456789', 'dung.pham@example.com', '2025-01-10', N'Quận 7, TP.HCM');
GO

IF NOT EXISTS (SELECT 1 FROM NewStaff WHERE Email = 'ha.vo@example.com')
    INSERT INTO NewStaff (Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Saddress)
    VALUES (N'Võ Thị', N'Hà', N'Nữ', '2001-11-05', '0934567890', 'ha.vo@example.com', '2025-03-01', N'Thủ Đức, TP.HCM');
GO

-- ------------------------------------------------------------
-- 3) Thiet bi mau (bang Equipment) - 3 thiet bi
-- ------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM Equipment WHERE EquipName = N'Máy chạy bộ')
    INSERT INTO Equipment (EquipName, EDescription, MusclesUsed, Cost, Units, PurchaseDate)
    VALUES (N'Máy chạy bộ', N'Máy chạy bộ điện, tốc độ tối đa 20km/h', N'Chân - Tim mạch', 25000000, 5, '2025-02-01');
GO

IF NOT EXISTS (SELECT 1 FROM Equipment WHERE EquipName = N'Xe đạp tập')
    INSERT INTO Equipment (EquipName, EDescription, MusclesUsed, Cost, Units, PurchaseDate)
    VALUES (N'Xe đạp tập', N'Xe đạp tập tại chỗ, kháng lực từ', N'Chân - Tim mạch', 8500000, 4, '2025-02-01');
GO

IF NOT EXISTS (SELECT 1 FROM Equipment WHERE EquipName = N'Bộ tạ tay')
    INSERT INTO Equipment (EquipName, EDescription, MusclesUsed, Cost, Units, PurchaseDate)
    VALUES (N'Bộ tạ tay', N'Bộ tạ tay 5kg - 25kg, bọc cao su', N'Tay - Vai - Ngực', 4200000, 10, '2025-04-15');
GO

-- ------------------------------------------------------------
-- Kiem tra lai sau khi chay
-- ------------------------------------------------------------
SELECT * FROM NewMember;
SELECT * FROM NewStaff;
SELECT * FROM Equipment;
GO
