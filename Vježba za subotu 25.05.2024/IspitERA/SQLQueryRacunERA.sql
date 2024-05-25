--create database racunERA;

--use racunERA;

--create table racun(
--	sifra INT NOT NULL PRIMARY KEY,
--	redniBroj INT NOT NULL,
--	datum DATETIME,
--	kupac VARCHAR(50) NOT NULL,
--	placeno BIT NOT NULL
--);

--create table StavkeRacuna(
--	racun INT NOT NULL FOREIGN KEY REFERENCES racun(sifra),
--	artikl VARCHAR(50) NOT NULL,
--	cijena DECIMAL(18,2) NOT NULL,
--	kolicina INT NOT NULL,
--	popust DECIMAL(18,2)
--);