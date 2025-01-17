﻿--Đề tài
CREATE FUNCTION AUTO_ID_DT(@LAST_ID_DT VARCHAR(4), @PRE VARCHAR(2), @SIZE INT)
      RETURNS VARCHAR(4)
AS
     BEGIN
	    IF(@LAST_ID_DT ='')
		        SET @LAST_ID_DT = @PRE + REPLICATE(0,@SIZE - LEN(@PRE))
        DECLARE @NUM_NEXTID_DT INT, @NEXTID_DT VARCHAR(4)
		SET @LAST_ID_DT = LTRIM(RTRIM(@LAST_ID_DT))
		SET @NUM_NEXTID_DT = REPLACE(@LAST_ID_DT,@PRE,'') + 1
		SET @SIZE = @SIZE - LEN(@PRE)
		SET @NEXTID_DT = @PRE + REPLICATE(0,@SIZE - LEN(@PRE))
		SET @NEXTID_DT = @PRE + RIGHT(REPLICATE(0,@SIZE) + CONVERT(VARCHAR(MAX),@NUM_NEXTID_DT),@SIZE)
		RETURN @NEXTID_DT
    END
GO


CREATE TRIGGER NEXTID_DT ON DETAI
FOR INSERT
AS
    BEGIN
	     DECLARE @LAST_ID_DT VARCHAR(4)
		 SET @LAST_ID_DT = (
		                  SELECT TOP 1 MADT FROM DETAI ORDER BY MADT DESC
						  )
         UPDATE DETAI SET MADT = DBO.AUTO_ID_DT(@LAST_ID_DT,'DT',4) WHERE MADT = ''
	END
GO

INSERT INTO DETAI(MADT,TENDT)
VALUES('',N'SADFED')

INSERT INTO DETAI(MADT,TENDT)
VALUES('',N'ASFQWF')

SELECT * FROM DETAI

--Cán bộ
CREATE FUNCTION AUTO_ID_CB(@LAST_ID_CB VARCHAR(5), @PRE VARCHAR(2), @SIZE INT)
      RETURNS VARCHAR(5)
AS
     BEGIN
	    IF(@LAST_ID_CB ='')
		        SET @LAST_ID_CB = @PRE + REPLICATE(0,@SIZE - LEN(@PRE))
        DECLARE @NUM_NEXTID_CB INT, @NEXTID_CB VARCHAR(5)
		SET @LAST_ID_CB = LTRIM(RTRIM(@LAST_ID_CB))
		SET @NUM_NEXTID_CB = REPLACE(@LAST_ID_CB,@PRE,'') + 1
		SET @SIZE = @SIZE - LEN(@PRE)
		SET @NEXTID_CB = @PRE + REPLICATE(0,@SIZE - LEN(@PRE))
		SET @NEXTID_CB = @PRE + RIGHT(REPLICATE(0,@SIZE) + CONVERT(VARCHAR(MAX),@NUM_NEXTID_CB),@SIZE)
		RETURN @NEXTID_CB
    END
GO

CREATE TRIGGER NEXTID_CB ON CANBO
FOR INSERT
AS
    BEGIN
	     DECLARE @LAST_ID_CB VARCHAR(5)
		 SET @LAST_ID_CB = (
		                  SELECT TOP 1 MACB FROM CANBO ORDER BY MACB DESC
						  )
         UPDATE CANBO SET MACB = DBO.AUTO_ID_CB(@LAST_ID_CB,'CB',5) WHERE MACB = ''
	END
GO

Drop function AUTO_ID_CB

drop trigger NEXTID_CB

INSERT INTO CANBO(MACB,TENCB)
VALUES('',N'SDF')


INSERT INTO CANBO(MACB,TENCB)
VALUES('',N'ÈKHAWGR')

SELECT * FROM CANBO

--Quyết định
CREATE FUNCTION AUTO_ID_QD(@LAST_ID_QD VARCHAR(4), @PRE VARCHAR(2), @SIZE INT)
      RETURNS VARCHAR(4)
AS
     BEGIN
	    IF(@LAST_ID_QD ='')
		        SET @LAST_ID_QD = @PRE + REPLICATE(0,@SIZE - LEN(@PRE))
        DECLARE @NUM_NEXTID_QD INT, @NEXTID_QD VARCHAR(4)
		SET @LAST_ID_QD = LTRIM(RTRIM(@LAST_ID_QD))
		SET @NUM_NEXTID_QD = REPLACE(@LAST_ID_QD,@PRE,'') + 1
		SET @SIZE = @SIZE - LEN(@PRE)
		SET @NEXTID_QD = @PRE + REPLICATE(0,@SIZE - LEN(@PRE))
		SET @NEXTID_QD = @PRE + RIGHT(REPLICATE(0,@SIZE) + CONVERT(VARCHAR(MAX),@NUM_NEXTID_QD),@SIZE)
		RETURN @NEXTID_QD
    END
GO

CREATE TRIGGER NEXTID_QD ON QUYETDINH
FOR INSERT
AS
    BEGIN
	     DECLARE @LAST_ID_QD VARCHAR(4)
		 SET @LAST_ID_QD = (
		                  SELECT TOP 1 MAQD FROM QUYETDINH ORDER BY MAQD DESC
						  )
         UPDATE QUYETDINH SET MAQD = DBO.AUTO_ID_QD(@LAST_ID_QD,'QD',4) WHERE MAQD = ''
	END
GO

INSERT INTO QUYETDINH(MAQD,NOIDUNG)
VALUES ('',N'SDG')

INSERT INTO QUYETDINH(MAQD,NOIDUNG)
VALUES ('',N'DKGJH')

SELECT * FROM QUYETDINH


--Báo cáo
CREATE FUNCTION AUTO_ID_BC(@LAST_ID_BC VARCHAR(4), @PRE VARCHAR(2), @SIZE INT)
      RETURNS VARCHAR(4)
AS
     BEGIN
	    IF(@LAST_ID_BC ='')
		        SET @LAST_ID_BC = @PRE + REPLICATE(0,@SIZE - LEN(@PRE))
        DECLARE @NUM_NEXTID_BC INT, @NEXTID_BC VARCHAR(4)
		SET @LAST_ID_BC = LTRIM(RTRIM(@LAST_ID_BC))
		SET @NUM_NEXTID_BC = REPLACE(@LAST_ID_BC,@PRE,'') + 1
		SET @SIZE = @SIZE - LEN(@PRE)
		SET @NEXTID_BC = @PRE + REPLICATE(0,@SIZE - LEN(@PRE))
		SET @NEXTID_BC = @PRE + RIGHT(REPLICATE(0,@SIZE) + CONVERT(VARCHAR(MAX),@NUM_NEXTID_BC),@SIZE)
		RETURN @NEXTID_BC
    END
GO

CREATE TRIGGER NEXTID_BC ON BAOCAOTIENDO
FOR INSERT
AS
    BEGIN
	     DECLARE @LAST_ID_BC VARCHAR(4)
		 SET @LAST_ID_BC = (
		                  SELECT TOP 1 MABC FROM BAOCAOTIENDO ORDER BY MABC DESC
						  )
         UPDATE BAOCAOTIENDO SET MABC = DBO.AUTO_ID_BC(@LAST_ID_BC,'BC',4) WHERE MABC = ''
	END
GO

INSERT INTO BAOCAOTIENDO(MABC,NOIDUNG)
VALUES('',N'EGWEG')

SELECT* FROM BAOCAOTIENDO


--Công trình

CREATE FUNCTION AUTO_ID_BB(@LAST_ID_BB VARCHAR(6), @PRE VARCHAR(4), @SIZE INT)
      RETURNS VARCHAR(6)
AS
     BEGIN
	    IF(@LAST_ID_BB ='')
		        SET @LAST_ID_BB = @PRE + REPLICATE(0,@SIZE - LEN(@PRE))
        DECLARE @NUM_NEXTID_BB INT, @NEXTID_BB VARCHAR(6)
		SET @LAST_ID_BB = LTRIM(RTRIM(@LAST_ID_BB))
		SET @NUM_NEXTID_BB = REPLACE(@LAST_ID_BB,@PRE,'') + 1
		SET @SIZE = @SIZE - LEN(@PRE)
		SET @NEXTID_BB = @PRE + REPLICATE(0,@SIZE - LEN(@PRE))
		SET @NEXTID_BB = @PRE + RIGHT(REPLICATE(0,@SIZE) + CONVERT(VARCHAR(MAX),@NUM_NEXTID_BB),@SIZE)
		RETURN @NEXTID_BB
    END
GO

CREATE TRIGGER NEXTID_BB ON CONGTRINHNGHIENCUU
FOR INSERT
AS
    BEGIN
	     DECLARE @LAST_ID_BB VARCHAR(6)
		 SET @LAST_ID_BB = (
		                  SELECT TOP 1 MABB FROM CONGTRINHNGHIENCUU ORDER BY MABB DESC
						  )
         UPDATE CONGTRINHNGHIENCUU SET MABB = DBO.AUTO_ID_BB(@LAST_ID_BB,'BBKH',6) WHERE MABB = ''
	END
GO


DROP TRIGGER NEXTID_BB


INSERT INTO CONGTRINHNGHIENCUU(MABB,TENBB)
VALUES('',N'DEGF')

SELECT* FROM CONGTRINHNGHIENCUU

--biểu đồ khoa
create Proc chartkhoa
as
begin 
	select khoa.TENKHOA, count(detai.madt) soluongdetai
	from khoa left join bomon on khoa.MAKHOA = BOMON.MAKHOA
			  left join CANBO on CANBO.mabm= BOMON.mabm
			  left join THAMGIA on THAMGIA.MACB = CANBO.MACB
			  left join DETAI on DETAI.MADT = THAMGIA.MADT
	group by khoa.tenkhoa
end
drop proc chartkhoa

--biểu đồ bộ môn:
create Proc chartbomon
as
begin 
	select bomon.tenbm, count(detai.madt) soluongdetai
	from bomon left join CANBO on CANBO.mabm= BOMON.mabm
			  left join THAMGIA on THAMGIA.MACB = CANBO.MACB
			  left join DETAI on DETAI.MADT = THAMGIA.MADT
	group by BOMON.TENBM
end

--chart chuyên ngành
create Proc chartchuyennganh
as
begin 
	select distinct  CHUYENNGANH.TENCN, count (distinct detai.madt) soluongchuyennganh
	from chuyennganh left join detai on chuyennganh.MANGANH = detai.MANGANH
				     left join CANBO on canbo.MACB = DETAI.MACB
					 left join CAPQUANLY on DETAI.MACAP = CAPQUANLY.MACAP
	
	group by CHUYENNGANH.TENCN
end

Drop proc DT_PQ_NEW
CREATE Proc [dbo].[DT_PQ]
    (@Mak1  varchar(50))
as
begin
    SELECT DISTINCT dt.MADT as 'Mã đề tài', dt.TENDT as 'Tên đề tài', cb.TENCB as 'Chủ nhiệm đề tài', dt.MATB as 'Mã tiểu ban', dt.MACAP as 'Mã cấp quản lý', dt.MANGANH as 'Mã chuyên ngành' , dt.NGAYDANGKI as 'Ngày đăng kí', dt.NAMTHUCHIEN as 'Năm thực hiện', dt.KINHPHI as 'Kinh phí', dt.TRANGTHAI as 'Trạng thái', dt.KETQUA as 'Kết quả'
    FROM DETAI as dt, CANBO as cb, BOMON as bm, KHOA as k
    WHERE  k.MAKHOA =bm.MAKHOA and bm.MABM = cb.MABM and cb.MACB =dt.MACB 
           and k.MAKHOA = @Mak1
end

CREATE Proc [dbo].[DT_PQ_NEW]
as
begin
    SELECT DISTINCT dt.MADT as 'Mã đề tài', dt.TENDT as 'Tên đề tài', cb.TENCB as 'Chủ nhiệm đề tài', dt.MATB as 'Mã tiểu ban', dt.MACAP as 'Mã cấp quản lý', dt.MANGANH as 'Mã chuyên ngành' , dt.NGAYDANGKI as 'Ngày đăng kí', dt.NAMTHUCHIEN as 'Năm thực hiện', dt.KINHPHI as 'Kinh phí', dt.TRANGTHAI as 'Trạng thái'
    FROM DETAI as dt, CANBO as cb, BOMON as bm, KHOA as k
    WHERE  k.MAKHOA =bm.MAKHOA and bm.MABM = cb.MABM and cb.MACB =dt.MACB 
end

DROP PROC BB_DT

CREATE PROC [dbo].[BB_DT] (@Ma varchar(50))
AS
BEGIN
		
    SELECT DISTINCT qd.MABB as'Mã bài báo', qd.TENBB as'Tên bài báo',qd.MANGANH as'Mã chuyên ngành',qd.NGAYDANG as'Ngày đăng',qd.TACGIA AS'Tác giả'
	FROM CONGTRINHNGHIENCUU as qd ,DETAI as dt
	WHERE qd.MADT=dt.MADT and dt.MADT =@Ma
END

CREATE PROC DK_DT
AS
BEGIN 
	SELECT d.MADT as 'Mã đề tài', d.TENDT as 'Tên đề tài', d.KINHPHI as 'Kinh phí', d.NGAYDANGKI as 'Ngày đăng kí', d.NAMTHUCHIEN as 'Năm thực hiện', d.MATB as 'Mã tiểu ban', d.MANGANH as 'Mã chuyên ngành', d.MACAP as 'Mã cấp quản lý', d.MACB as 'Mã cán bộ', d.TRANGTHAI as 'Trạng thái'
	FROM DETAI as d
END

DK_DT
