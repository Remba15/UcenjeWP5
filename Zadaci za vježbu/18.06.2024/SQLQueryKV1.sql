use master
go
drop database if exists kv1
go
create database kv1
go
use kv1;

create table svekar(
	sifra int not null primary key identity(1,1),
	bojaociju varchar(40) not null,
	prstena int,
	dukserica varchar(41),
	lipa decimal(13,8),
	eura decimal(12,7),
	majica varchar(35)
);

create table sestra(
	sifra int not null primary key identity(1,1),
	introvertno bit,
	haljina varchar(31) not null,
	maraka decimal(16,6),
	hlace varchar(46) not null,
	narukvica int not null
);

create table sestra_svekar(
	sifra int not null primary key identity(1,1),
	sestra int not null foreign key references sestra(sifra),
	svekar int not null foreign key references svekar(sifra)
);

create table zena(
	sifra int not null primary key identity(1,1),
	treciputa datetime,
	hlace varchar(46),
	kratkamajica varchar(31) not null,
	jmbag char(11) not null,
	bojaociju varchar(39) not null,
	haljina varchar(44),
	sestra int not null foreign key references sestra(sifra)
);

create table muskarac(
	sifra int not null primary key identity(1,1),
	bojaociju varchar(50) not null,
	hlace varchar(30),
	modelnaocala varchar(43),
	maraka decimal(14,5) not null,
	zena int not null foreign key references zena(sifra)
);

create table mladic(
	sifra int not null primary key identity(1,1),
	suknja varchar(50) not null,
	kuna decimal(16,8) not null,
	drugiputa datetime,
	asocijalno bit,
	ekstrovertno bit not null,
	dukserica varchar(48) not null,
	muskarac int foreign key references muskarac(sifra)
);

create table punac(
	sifra int not null primary key identity(1,1),
	ogrlica int,
	gustoca decimal(14,9),
	hlace varchar(41) not null
);

create table cura(
	sifra int not null primary key identity(1,1),
	novcica decimal(16,5) not null,
	gustoca decimal(18,6) not null,
	lipa decimal(13,10),
	ogrlica int not null,
	bojakose varchar(38),
	suknja varchar(36),
	punac int foreign key references punac(sifra)
);

-- 1. U tablice muskarac, zena i sestra_svekar unesite po 3 retka

INSERT INTO sestra(introvertno, haljina, maraka, hlace, narukvica) values
	(1, 'Crvena', 10.2, 'Plave',  2), (0, 'Zelena', 15.5, 'Crvene', 1), (1, 'Žuta', 20.43, 'Zelene', 4);

INSERT INTO zena(kratkamajica, jmbag, bojaociju, sestra) values
	('Plava', '11111111111', 'Zelena', 2), ('Zelena', '11112111111', 'Plava', 1), ('Crvena', '11111111121',  'Plava', 3);


INSERT INTO muskarac(bojaociju, maraka, zena) values
	('Plava', 12512.24, 3), ('Zelena', 42352.23, 2), ('Smeđa', 934697.24, 1);

INSERT INTO svekar(bojaociju) values
	('Plava'), ('Smeđa'), ('Zelena');

INSERT INTO sestra_svekar(sestra, svekar) values
	(1, 2), (2,3), (3,1);

-- 2. U tablici cura postavite svim zapisima kolonu gustoca na vrijednost 15,77

INSERT INTO punac(hlace) values
	('Plave'), ('Crne'), ('Sive');

INSERT INTO cura(novcica, gustoca, ogrlica) values
	(12.2, 10.2, 3), (24.5, 11.5, 5), (100.26, 9.52, 2);

select * from cura;

UPDATE cura set gustoca=15.77;

select * from cura;

-- 3. U tablici mladic obrišite sve zapise čija je vrijednost kolone kuna veće od 15,78

INSERT INTO mladic(suknja, kuna, ekstrovertno, dukserica) values
	('Ne', 124.25, 0, 'Plava'), ('Ne', 11, 0, 'Crna'), ('Ne', 512.2, 1, 'Siva');

select * from mladic;

DELETE from mladic where kuna>15.78;

select * from mladic;

-- 4. Izlistajte kratkamajica iz tablice zena uz uvjet da vrijednost kolone hlace sadrže slova ana.

select kratkamajica from zena where hlace LIKE '%ana%';

-- 5. Prikažite dukserica iz tablice svekar, asocijalno iz tablice mladic te hlace
-- iz tablice muskarac uz uvjet da vrijednosti kolone hlace iz tablice zena pocinju
-- slovom "a" te da vrijednosti kolone haljina iz tablice sestra sadrže niz znakova ba.
-- Podatke posložite po hlace iz tablice muskarac silazno.

select a.dukserica, f.asocijalno, e.hlace
from svekar a inner join sestra_svekar b
on a.sifra = b.svekar
inner join sestra c on c.sifra=b.sestra
inner join zena d on c.sifra=d.sestra
inner join muskarac e on d.sifra=e.zena
inner join mladic f on e.sifra=f.muskarac
where d.hlace LIKE 'a%' AND c.haljina LIKE '%ba%'
order by e.hlace desc;

-- 6. Prikažite kolone haljina i maraka iz tablice sestra
-- čiji se primarni ključ ne nalaze u tablici sestra_svekar

select a.haljina, a.maraka
from sestra a left join sestra_svekar b
on a.sifra = b.sestra
where b.sestra = null;