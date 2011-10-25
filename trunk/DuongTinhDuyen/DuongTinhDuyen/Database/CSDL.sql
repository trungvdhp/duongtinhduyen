/* Da chinh sua hoan chinh */
USE master
GO
IF EXISTS
(
	SELECT * 
	FROM   master..sysdatabases 
	WHERE  name = N'DuongTinhDuyen'
)
DROP DATABASE DuongTinhDuyen
GO

CREATE DATABASE DuongTinhDuyen
ON
(
	NAME		= 'DuongTinhDuyen',
	FILENAME	= 'C:\DuongTinhDuyen.MDF',
	SIZE		= 20,
	MAXSIZE		= 100,
	FILEGROWTH	= 5
)
GO

USE DuongTinhDuyen
GO
--===================================================================================================================================================
/* Da chinh sua hoan chinh */
CREATE TABLE LOAINGUOIDUNG
(
	MaLoai		VARCHAR (6)		NOT NULL	PRIMARY KEY,
	TenLoaiND	NVARCHAR (30)	NOT NULL
)

INSERT INTO LOAINGUOIDUNG VALUES('LND001',N'Admin')
INSERT INTO LOAINGUOIDUNG VALUES('LND002',N'User')
-----------------------------------------------------------------------------------------------------------------------------------------------------
/* Da chinh sua hoan chinh */
CREATE TABLE  NGUOIDUNG
(
	MaND 		VARCHAR (6) 	NOT NULL	PRIMARY KEY,
	MaLoai		VARCHAR (6)		NOT NULL,
	TenND		NVARCHAR (30)	NOT NULL,
	TenDNhap	VARCHAR (30)	NOT NULL UNIQUE,
	MatKhau		VARCHAR (30)	NOT NULL,
	
	CONSTRAINT F_ND_LND FOREIGN KEY(MaLoai) 	REFERENCES LOAINGUOIDUNG(MaLoai)
)

INSERT INTO NGUOIDUNG VALUES('ND0001','LND001',N'Vũ Đình Trung','admin','admin')
INSERT INTO NGUOIDUNG VALUES('ND0002','LND002',N'Lê Văn Vinh','user','123456')

--===================================================================================================================================================
--===================================================================================================================================================