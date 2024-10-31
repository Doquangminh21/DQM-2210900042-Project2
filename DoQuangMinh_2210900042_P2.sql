create database DoQuangMinh_2210900042_prj2
go
use DoQuangMinh_2210900042_prj2
go
create table QUAN_TRI(
	ID INT PRIMARY KEY,             
    Tai_khoan NVARCHAR(50) NOT NULL,  
    Mat_lhau NVARCHAR(255) NOT NULL, 
    Email NVARCHAR(100) NOT NULL,   
    Trang_thai tinyint default 1	
);
go
create table KHACH_HANG(
	Ma_KH INT PRIMARY KEY,              
    Tai_khoan NVARCHAR(50) NOT NULL,  
    Mat_khau NVARCHAR(255) NOT NULL, 
    Email NVARCHAR(100) NOT NULL,    
    Ho_ten NVARCHAR(100),          
    Dia_chi NVARCHAR(255),           
    PhoneNumber NVARCHAR(15),        
    Trang_thai tinyint default 1
);
go
CREATE TABLE SAN_PHAM (
    Ma_SP INT PRIMARY KEY,              
    Ten_SP NVARCHAR(100) NOT NULL,
    Kich_thuoc NVARCHAR(10),              
    Mau NVARCHAR(20),              
    Gia DECIMAL(18, 2) NOT NULL,   
    Soluongtonkho INT default 0                        
);
go
CREATE TABLE PHIEU_GIAM_GIA (
    Ma_PGG INT PRIMARY KEY,               
    Ma_GG NVARCHAR(20) NOT NULL,   
    So_tien_giam DECIMAL(18, 2),     
    Ngay_het_han DATE,                 
    Trang_thai bit                      
);
go
CREATE TABLE DON_HANG (
    Ma_DH INT PRIMARY KEY,              
    Ma_KH INT,             
	Ma_PGG int,
    Ngay_dat DATE,                  
    Tong_gia DECIMAL(18, 2),      
    Trang_thai tinyint default 0,             
    FOREIGN KEY (Ma_KH) REFERENCES KHACH_HANG(Ma_KH),
	FOREIGN KEY (Ma_PGG) REFERENCES PHIEU_GIAM_GIA(Ma_PGG)
);
go
CREATE TABLE CHI_TIET_DON_HANG (
    Ma_CTDH INT PRIMARY KEY,                
    Ma_DH INT,                      
    Ma_SP INT,                     
    So_luong INT NOT NULL,            
    Gia DECIMAL(18, 2) NOT NULL,    
    FOREIGN KEY (Ma_DH) REFERENCES DON_HANG(Ma_DH), 
    FOREIGN KEY (Ma_SP) REFERENCES SAN_PHAM(Ma_SP) 
);
go
