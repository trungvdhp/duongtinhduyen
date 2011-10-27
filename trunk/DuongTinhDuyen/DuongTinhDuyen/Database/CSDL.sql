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
CREATE TABLE NUT
(
	MaNut int NOT NULL PRIMARY KEY IDENTITY,
	NoiDung nvarchar(100) NOT NULL
)
INSERT INTO NUT(NoiDung) VALUES(N'Dài')
INSERT INTO NUT(NoiDung) VALUES(N'Ngắn')
INSERT INTO NUT(NoiDung) VALUES(N'Song song')
INSERT INTO NUT(NoiDung) VALUES(N'Quẹo xuống')
INSERT INTO NUT(NoiDung) VALUES(N'Đứt đoạn')
INSERT INTO NUT(NoiDung) VALUES(N'Gián đoạn')
INSERT INTO NUT(NoiDung) VALUES(N'Chồng chéo')
INSERT INTO NUT(NoiDung) VALUES(N'Nhánh phân nhánh')
INSERT INTO NUT(NoiDung) VALUES(N'Rẽ quạt')
INSERT INTO NUT(NoiDung) VALUES(N'Dạng chữ Y')
INSERT INTO NUT(NoiDung) VALUES(N'Chẻ ba ở cuối')
INSERT INTO NUT(NoiDung) VALUES(N'Uốn éo ngoằn ngoèo')
INSERT INTO NUT(NoiDung) VALUES(N'Cong queo hay tua tủa đường nhỏ')
INSERT INTO NUT(NoiDung) VALUES(N'Chẻ đôi và có thêm hai đường cắt dọc')
INSERT INTO NUT(NoiDung) VALUES(N'Chẻ đôi rồi hợp lại hướng lên trên')
INSERT INTO NUT(NoiDung) VALUES(N'Đi xuống chạm đường hôn nhân thứ nhất')
INSERT INTO NUT(NoiDung) VALUES(N'Ngả về đường Tâm đạo')
INSERT INTO NUT(NoiDung) VALUES(N'Nằm giữa đường Tâm Đạo và lóng thứ 3 ngón út')
INSERT INTO NUT(NoiDung) VALUES(N'Gặp đường Thái Dương')
INSERT INTO NUT(NoiDung) VALUES(N'Vượt quá đường Thái Dương')
INSERT INTO NUT(NoiDung) VALUES(N'Chạy vào lòng bàn tay')
INSERT INTO NUT(NoiDung) VALUES(N'Chạy lên ngón út')
INSERT INTO NUT(NoiDung) VALUES(N'Giữa ngón út và ngón đeo nhẫn')
INSERT INTO NUT(NoiDung) VALUES(N'Dấu chấm')
INSERT INTO NUT(NoiDung) VALUES(N'Dấu chéo')
INSERT INTO NUT(NoiDung) VALUES(N'Ngôi sao')
INSERT INTO NUT(NoiDung) VALUES(N'Chữ thập ở cuối')
INSERT INTO NUT(NoiDung) VALUES(N'Vòng tròn ở cuối')
INSERT INTO NUT(NoiDung) VALUES(N'Hình giống mặt trời ở cuối')
INSERT INTO NUT(NoiDung) VALUES(N'Những đường nhỏ tạo lên đường phá')
INSERT INTO NUT(NoiDung) VALUES(N'Đường dọc chắn ngang')
INSERT INTO NUT(NoiDung) VALUES(N'Thêm đường chỉ nhỏ nằm dọc hướng lên trên')
INSERT INTO NUT(NoiDung) VALUES(N'Thêm đường chỉ nhỏ nằm dọc hướng xuống dưới')
INSERT INTO NUT(NoiDung) VALUES(N'Thêm đường chỉ nhỏ nằm xéo ngang')
INSERT INTO NUT(NoiDung) VALUES(N'Đường tâm đạo uốn éo ngoằn ngoèo')
INSERT INTO NUT(NoiDung) VALUES(N'Gồm hai đường và có một chấm trũng rõ ở giữa một đường cùng với đường trí đạo ngắn, thô, đậm')
--===================================================================================================================================================
CREATE TABLE KETLUAN
(
	MaKL int NOT NULL PRIMARY KEY IDENTITY,
	NoiDung nvarchar(200) NOT NULL
)
INSERT INTO KETLUAN(NoiDung) VALUES(N'Dấu hiệu của một cuộc hôn nhân lâu dài, hạnh phúc')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Hôn nhân không được vĩnh cửu')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Có nhiều người yêu')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Việc cưới hỏi có bất hợp ý, trở ngại')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Có trở ngại trong hôn nhân')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Khó khăn trước và sau khi kết hôn')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Vợ chồng xung khắc, không hợp ý hay bất đồng')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Người đam mê sắc đẹp có nhiều chồng nhiều vợ hay tình nhân và con ngoại hôn')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Ngang trái khổ đau có khi còn thất tình')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Có sự ly dị, góa bụa hay rời xa chồng')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Mối tình rắc rối, éo le, nghịch và có khi phạm vào bà con gần')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Hai vợ chồng dễ có tình riêng, hôn nhân không trọn vẹn')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Vợ bị bệnh ở bộ phận sinh dục và chồng dễ bị bệnh phổi')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Thất bại về hôn nhân, cưới xong cũng gặp chia li hay xung khắc')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Hôn nhân trước khó khăn sau thì tốt thuận lợi')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Hai vợ chồng có thể có tình riêng')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Cưới gả chậm')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Cuộc hôn nhân xảy ra khoảng 25 đến 30 tuổi')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Gặp người bạn trăm năm có tài nghệ')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Cuộc hôn nhất trước thì tốt sau thì xấu')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Dễ bị tai nạn')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Hôn nhân giàu có')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Vợ chồng dễ gặp điều không may')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Dễ gặp cuộc tình bất chính, thường cô đơn, lẻ loi')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Mất mát tiền của')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Kết hôn với người có bệnh')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Dễ có nhiều con trai')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Dễ sinh con gái')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Sức khỏe yếu')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Hướng về tà dâm nhiều hơn')
INSERT INTO KETLUAN(NoiDung) VALUES(N'Kết hôn sớm bất thành nên đợi trung niên mới tốt')
--===================================================================================================================================================
CREATE TABLE LUAT
(
	MaLuat int NOT NULL PRIMARY KEY IDENTITY,
	GiaThiet varchar(100) NOT NULL,
	KetLuan varchar(100) NOT NULL
)
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('1&-5','1')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('21','1')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('29','1')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('2&17','2')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('20','2')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('3','3')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('4','4')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('5','5&7')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('6','6')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('7','7')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('8','8')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('9','9')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('10','10')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('11','11')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('12','12')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('13','7&13')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('14&20','14')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('15','15')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('12&5','16')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('16','17')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('18','18')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('19&26','19')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('21','7')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('23','20')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('24','5')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('25&28','5|21')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('27','22')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('28','23')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('30','5|24')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('1&30','5&25')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('31','5&26')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('32','27')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('33','28')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('34','29')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('35','30')
INSERT INTO LUAT(GiaThiet,KetLuan) VALUES('36','31')
--===================================================================================================================================================