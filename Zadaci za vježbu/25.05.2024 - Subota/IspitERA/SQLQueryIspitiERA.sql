--create database IspitiERA;

--use IspitiERA;

--create table IspitniRok(
--	sifra int NOT NULL,
--	predmet varchar(50) NOT NULL,
--	vrstaIspita varchar(50) NOT NULL,
--	datum DATE,
--	pristupio BIT NOT NULL,
--	PRIMARY KEY(sifra)
--);

--create table Pristupnici(
--	ispitniRok int NOT NULL FOREIGN KEY
--	REFERENCES IspitniRok(sifra),
--	student varchar(50) NOT NULL,
--	brojBodova decimal(4,2) NOT NULL,
--	ocjena int NOT NULL
--);