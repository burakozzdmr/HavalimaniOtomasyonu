CREATE DATABASE HavalimaniOtomasyonu

USE HavalimaniOtomasyonu

CREATE TABLE UCUSLAR
(
    UcusID INT PRIMARY KEY,
    Havayolu NVARCHAR(100) NOT NULL,
    UcakModeli NVARCHAR(100) NOT NULL,
    Nereden NVARCHAR(30) NOT NULL,
    Nereye NVARCHAR(30) NOT NULL,
    KalkisTarihi DATETIME NOT NULL,
    InisTarihi DATETIME NOT NULL,
    KalkisHavalimaniKOD NVARCHAR(5) NOT NULL,
    KalkisHavalimani NVARCHAR(100) NOT NULL,
    VarisHavalimaniKOD NVARCHAR(5) NOT NULL,
    VarisHavalimani NVARCHAR(100) NOT NULL,
);

CREATE TABLE HAVALIMANLARI
(
    HavalimaniID INT PRIMARY KEY IDENTITY(1,1),
    Ulke NVARCHAR(30) NOT NULL,
    Sehir NVARCHAR(30) NOT NULL,
    HavalimaniAdi NVARCHAR(100) UNIQUE NOT NULL,
    HavalimaniKodu NVARCHAR(10) UNIQUE NOT NULL,
    Adres NVARCHAR(200) UNIQUE NOT NULL,
    Telefon NVARCHAR(20) UNIQUE NOT NULL,
    Email NVARCHAR(50) UNIQUE NOT NULL,
);

CREATE TABLE YOLCULAR
(
    YolcuID INT PRIMARY KEY,
    Ad NVARCHAR(30) NOT NULL,
    Soyad NVARCHAR(30) NOT NULL,
    TCNO NVARCHAR(15) UNIQUE NOT NULL,
    DogumTarihi DATETIME NOT NULL,
    Cinsiyet BIT NOT NULL,
    Telefon NVARCHAR(15) UNIQUE NOT NULL,
    Email NVARCHAR(50) UNIQUE NOT NULL,
    Adres NVARCHAR(250) NOT NULL,
    Kalkis NVARCHAR(30) NOT NULL,
    Varis NVARCHAR(30) NOT NULL,
    KalkisSaati NVARCHAR(20) NOT NULL,
    VarisSaati NVARCHAR(20) NOT NULL
);

INSERT INTO UCUSLAR (UcusID, Havayolu, UcakModeli, Nereden, Nereye, KalkisTarihi, InisTarihi, KalkisHavalimaniKOD, KalkisHavalimani, VarisHavalimaniKOD, VarisHavalimani)
VALUES (1, 'Turk Hava Yollari', 'Boeing-747-400', 'Batman', 'Zonguldak', '06/28/2024', '06/28/2024', 'BAL', 'Batman Havalimani', 'ONQ', 'Zonguldak Havalimani')

INSERT INTO UCUSLAR (UcusID, Havayolu, UcakModeli, Nereden, Nereye, KalkisTarihi, InisTarihi, KalkisHavalimaniKOD, KalkisHavalimani, VarisHavalimaniKOD, VarisHavalimani)
VALUES (2, 'Pegasus', 'AIRBUS A380', 'Izmir', 'Trabzon', '09/28/2024', '09/28/2024', 'ADB', 'Izmir Adnan Menderes Havalimani', 'TZX', 'Trabzon Havalimani')

INSERT INTO UCUSLAR (UcusID, Havayolu, UcakModeli, Nereden, Nereye, KalkisTarihi, InisTarihi, KalkisHavalimaniKOD, KalkisHavalimani, VarisHavalimaniKOD, VarisHavalimani)
VALUES (3, 'Turk Hava Yollari', 'AIRBUS A320-200', 'Samsun', 'Ankara', '12/15/2024', '12/15/2024', 'SZF', 'Samsun Çarşamba Havalimani', 'ESB', 'Ankara Esenboga Havalimani')
 --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
INSERT INTO HAVALIMANLARI (Ulke, Sehir, HavalimaniAdi, HavalimaniKodu, Adres, Telefon, Email)
VALUES ('Turkiye', 'Ankara', 'Esenboga Havalimani', 'ESB', 'Balıkhisar Mh, Özal Bulvarı Akyurt/Ankara', '(0312) 590 40 00', 'infoesenboga@dhmi.gov.tr')

INSERT INTO HAVALIMANLARI(Ulke, Sehir, HavalimaniAdi, HavalimaniKodu, Adres, Telefon, Email)
VALUES ('Turkiye', 'Samsun', 'Carsamba Havalimani', 'SZF', 'Havaalanı, 55506 Çarşamba/Samsun', '(0362) 844 88 30', 'infocarsamba@dhmi.gov.tr')

INSERT INTO HAVALIMANLARI(Ulke, Sehir, HavalimaniAdi, HavalimaniKodu, Adres, Telefon, Email)
VALUES ('Turkiye', 'Izmir', 'Adnan Menderes Havalimani', 'ADB', 'Dokuz Eylül, 35410 Gaziemir/İzmir', '(0232) 455 00 00', 'www.adnanmenderesairport.com')
 --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
INSERT INTO YOLCULAR (YolcuID, Ad, Soyad, TCNO, DogumTarihi, Cinsiyet, Telefon, Email, Adres, Kalkis, Varis, KalkisSaati, VarisSaati)
VALUES (1, 'Burak', 'Ozdemir', '12586459734', '2003-12-15', 1, '+905349326952', 'burak.ozdemir@gmail.com', 'XXXXXXXXXXXXXXXXXXXXXXXXXXXXX', 'Samsun', 'Ankara', '17:00', '18:15');

INSERT INTO YOLCULAR (YolcuID, Ad, Soyad, TCNO, DogumTarihi, Cinsiyet, Telefon, Email, Adres, Kalkis, Varis, KalkisSaati, VarisSaati)
VALUES (2, 'Melisa', 'Sahin', '24567849312', '2004-09-11', 0, '+905352438955', 'melisa.sahin@gmail.com', 'XXXXXXXXXXXXXXXXXXXXXXXXXXXXX', 'Izmir', 'Trabzon', '23:15', '02:30');

INSERT INTO YOLCULAR (YolcuID, Ad, Soyad, TCNO, DogumTarihi, Cinsiyet, Telefon, Email, Adres, Kalkis, Varis, KalkisSaati, VarisSaati)
VALUES (3, 'Talha', 'Temiz', '25386478465', '2003-07-26', 1, '+905389321523', 'talha.temiz@gmail.com', 'XXXXXXXXXXXXXXXXXXXXXXXXXXXXX', 'Batman', 'Zonguldak', '09:00', '23:00');


SELECT * FROM UCUSLAR
SELECT * FROM HAVALIMANLARI
SELECT * FROM YOLCULAR

