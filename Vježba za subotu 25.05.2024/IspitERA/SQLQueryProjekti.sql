--create database Projekti;

--use Projekti;

--create table projekt(
--	sifra INT NOT NULL,
--	naziv VARCHAR(45) NOT NULL,
--	datumpocetka DATETIME,
--	datumkraja DATETIME,
--	PRIMARY KEY(sifra)
--);

--create table odjel(
--	sifra INT NOT NULL,
--	naziv VARCHAR(45),
--	PRIMARY KEY(sifra)
--);

--create table zaposlenik(
--	sifra INT NOT NULL PRIMARY KEY,
--	nadredeni INT NOT NULL,
--	ime VARCHAR(45),
--	prezime VARCHAR(45),
--	datumrodenja DATETIME,
--	placa DECIMAL(18,2),
--	odjel INT FOREIGN KEY REFERENCES odjel(sifra)
--);

--create table sudjeluje(
--	zaposlenik INT NOT NULL FOREIGN KEY REFERENCES zaposlenik(sifra),
--	projekt INT NOT NULL FOREIGN KEY REFERENCES projekt(sifra),
--	datumpristupanja DATETIME
--);

--ALTER TABLE zaposlenik ADD FOREIGN KEY (nadredeni) REFERENCES zaposlenik(sifra);