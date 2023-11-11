Create Database XemPhim
Go 
Use XemPhim
Create Table Phim (
	IdPhim int IDENTITY(1,1) primary key,
	TieuDe varchar(50),
	TenPhim nvarchar(50) not null,
	NamSanXuat date,
	TheLoai nvarchar(20),
	ThoiLuong varchar(20),
	URLPhim nvarchar(200) not null,
    HinhMinhHoa varchar(30),
	ChiTietPhim nvarchar(600),
	DienVien varchar(200),
	DaoDien varchar(50),
);
CREATE TABLE KhachHang (
  MaKH int IDENTITY(1,1) PRIMARY KEY,
  HoTenKH NVARCHAR(50) not null,
  TenDangNhap NVARCHAR(15) not null,
  MatKhau NVARCHAR(15) not null,
  Email NVARCHAR(50),
);
INSERT INTO Phim (TieuDe, TenPhim, NamSanXuat, TheLoai, ThoiLuong, URLPhim, HinhMinhHoa, ChiTietPhim, DienVien, DaoDien) VALUES
    ('Doraemon: Nobita and the Kingdom of Clouds', N'Doraemon: Nobita và Xứ Quỷ Parareru', '1992-03-07', 'Anime', '01:39:00', 'https://drive.google.com/file/d/1HkH48yGWYsnuGtaKvdlj7Aai7sqyEDf_/preview','doraemon.jpg',
	N'Câu chuyện xoay quanh cuộc phiêu lưu của Nobita và Doraemon trong một thế giới phép thuật, khi họ cố gắng cứu bạn bè khỏi tay vua quỷ ác. Họ phải đối mặt với nhiều thách thức và cuối cùng thành công trong nhiệm vụ của mình nhờ vào các công cụ du hành thời gian.', 
	'Nobuyo Ōyama, Noriko Ohara, Michiko Nomura, Kaneta Kimotsuki, Kazuya Tatekabe', 'Shibayama Tsutomu'),

	('Detective Conan: The Time-Bombed Skyscraper', N'Thám Tử Conan: Quả Bom Chọc Trời', '1997-04-19', 'Anime', '01:34:00', 'https://drive.google.com/file/d/1z-SErlnp0yn93pffhQ5BXa2uLYxfPmE6/preview','conan.jpg', 
	N'"Quả Bom Chọc Trời" là một tập phim đặc biệt trong series, nơi Conan và nhóm thám tử nhí gồm Ran, Kogoro và các thành viên khác phải đối mặt với một quả bom đe dọa sẽ phá hủy một tòa nhà cao tầng. Họ phải nhanh chóng tìm ra người phát bom và ngăn chặn âm mưu nguy hiểm này trước khi quá muộn.',
	'Takayama Minami, Yamaguchi Kappei,Yamazaki Wakana, Kamiya Akira, Chafūrin, Ogata Kenichi, Ishida Taro','Kodama Kenji'),

	('Operation Fortune: Ruse de Guerre', N'Phi Vụ Toàn Sao', '2023-01-13', N'Hành Động', '01:53:34','https://motchill.info/xem-phim/phi-vu-toan-sao-tap-full-11083_131719.html','operation.jpg', 
	N'Phim kể về một điệp viên Orson Fortune, người phải lấy lại một thiết bị công nghệ cao bị đánh cắp trước khi một tay buôn vũ khí (Grant) có thể bán nó cho người trả giá cao nhất.', 
	'Jason Statham, Aubrey Plaza, Josh Hartnett ,Cary Elwes ,Bugzy Malone, Eddie Marsan, Hugh Grantt', 'Guy Ritchieo'),

	('Bullet Train', N'Sát thủ đối đầu', '2022-08-05', N'Hành Động', '02:08:35', 'https://mephimtv.net/xem-phim/sat-thu-doi-dau','bullet.jpg', 
	N'Ladybug là một sát thủ lành nghề vừa trở lại sau khoảng thời gian nghỉ hưu. Anh nhận nhiệm vụ từ sát thủ Maria Beetle là thu hồi chiếc vali trên chuyến tàu cao tốc ở Nhật Bản. Những tưởng đây sẽ là phi vụ dễ ăn thì một loạt biến cố ập đến. Ladybug phải đối mặt với vô số thế lực khác nhau trên chiếc tàu hỏa cùng nhắm vào chiếc vali kia. Đối thủ của anh lần lượt là Lemon, Kimura, Hornet, Prince và Tangerine. Mỗi người đều có những âm mưu và cách thức hoạt động riêng dẫn đến một cục diện vô cùng rối ren.',
	'Brad Pitt, Joey King, Aaron Taylor-Johnson, Brian Tyree Henry, Andrew Koji, Hiroyuki Sanada, Michael Shannon, Bad Bunny, Sandra Bullock','David Leitch'),

	('Mr. Bean`s Holiday', N'Kỳ nghỉ của Mr. Bean', '2007-03-24', N'Hài Hước', '01:31:39', 'https://drive.google.com/file/d/1iiooypj9U-ljj-PRQaqgrLnBeX-sFkHy/preview','mrbean.jpg', 
	N'Mr. Bean quyết định đi nghỉ mát tại một bãi biển tĩnh lặng và trở thành nguồn cười vô tận cho khán giả. Anh gặp phải nhiều tình huống hài hước và gây rối khi điều hành mọi thứ không theo kế hoạch.',
	'Rowan Atkinson, Emma de Caunes, Max Baldry, Willem Dafoe, Karel Roden, Jean Rochefort','Steve Bendelack'),

	('Central Intelligence', N'Điệp Viên Không Hoàn Hảo', '2016-06-17', N'Hài Hước', '01:56:26', 'https://film365.in/phim-diep-vien-khong-hoan-hao-tap-full.5697.html','central.jpg', 
	N'Phim kể về cuộc gặp gỡ giữa hai bạn học cùng trường trung học, Bob Stone và Calvin Joyner. Bob Stone, một nhân viên tình báo giờ đã trở thành một điệp viên nguy hiểm, yêu cầu Calvin giúp đỡ anh ta tiêu diệt một băng đảng tội phạm. Hai người bắt đầu cuộc phiêu lưu hài hước và mạo hiểm để cứu thế giới và tìm hiểu về sự đồng bọn trong quá khứ.',
	'Kevin Hart, Dwayne Johnson, Amy Rya,n Aaron Paul, Danielle Nicolet', 'Rawson Marshall Thurber'),

	('Incantation', N'Chú Nguyền', '2022-03-18', N'Kinh Dị', '01:53:56', 'https://phimmoiyyy.net/phim-le/chu-nguyen','incan.jpg', 
	N'Sáu năm trước, Lý Nhược Nam bị nguyền rủa vì phạm phải điều cấm kị trong tôn giáo. Giờ đây, cô phải bảo vệ con gái trước hậu quả của những hành động mình gây ra.',
	'Tsai Hsuan-yen, Huang Sin-ting, Kao Ying-hsuan, Sean Lin, RQ', 'Kevin Ko'),

	('The Black Phone', N'Điện Thoại Đen', '2022-06-24', N'Kinh Dị', '01:45:28', 'https://mephimtv.net/xem-phim/dien-thoai-den','dienthoaiden.png', 
	N'Câu chuyện kể về một cậu bé tên là Finney Shaw, người bị bắt cóc bởi một tên sát nhân hàng loạt. Trong quá trình bị giam cầm, cậu phát hiện ra một chiếc điện thoại mà cậu có thể liên lạc với các nạn nhân của tên sát nhân. Finney cố gắng sử dụng sức mạnh đặc biệt này để cứu lấy chính mình và ngăn chặn tên sát nhân khỏi việc tiếp tục gây án.',
	'Mason Thames, Madeleine McGraw, Jeremy Davies, James Ransone, Ethan Hawke', 'Scott Derrickson'),

	('Up', N'Vút bay', '2009-07-17', N'Hoạt Hình','01:38:13', 'https://mephimtv.net/xem-phim/vut-bay','up.jpg', 
	N'Câu chuyện xoay quanh nhân vật Carl Fredricksen, một người đàn ông già màu mè và tưởng tượng. Sau khi mất vợ, Carl quyết định thực hiện ước mơ của mình bằng cách buộc hàng trăm quả bóng bay vào ngôi nhà của mình và bay đến "Rạng Đông Thành Phố", một nơi mà Carl và vợ ông luôn mong ước. Trên đường đi, Carl không may gặp một cậu bé kỳ lạ tên Russell, người trở thành bạn đồng hành không mong muốn của ông. Cùng nhau, Carl và Russell trải qua nhiều cuộc phiêu lưu hài hước và xúc động, họ tìm thấy ý nghĩa của tình bạn và tình yêu gia đình.',
	'Edward Asner, Christopher Plummer, Jordan Nagai, Bob Peterson','Pete Docter'),


	('Bolt', N'Chú Chó Tia Chớp', '2008-11-21', N'Hoạt Hình', '01:36:21', 'https://hayghe2.com/phim/chu-cho-tia-chop-14881/xem-phim.html','bolt.jpg', 
	N'Đối với Bolt - chú chó siêu phàm, thì ngày nào cũng tràn đầy những cuộc phiêu lưu, nguy hiểm và bất ngờ. Thế nhưng tất cả những điều đó chỉ xảy ra đằng sau ống kính máy quay. Cho đến một ngày, siêu sao truyền hình tình cờ bị vận chuyển từ sân khấu Hollywood tới thành phố New York, nơi cậu bắt đầu cuộc phiêu lưu lớn nhất - một cuộc hành trình xuyên đất nước trong cuộc đời thực để trở về với người chủ - bạn diễn của mình là Penny.',
	'John Travolta, Miley Cyrus, Susie Essman, Mark Walton, Malcolm McDowell','Chris Williams, Byron Howard');