
-- use edunovawp5;

select * from grupe;

select * from smjerovi where sifra = 1;

-- kuharica prema materijalima

select a.naziv as smjer, b.naziv as grupa
from smjerovi a inner join grupe b
on a.sifra = b.smjer


select a.naziv as smjer, b.naziv as grupa
from smjerovi a left join grupe b
on a.sifra = b.smjer


select
a.naziv as smjer,
b.naziv as grupa,
d.ime, d.prezime
from smjerovi a inner join grupe b
on a.sifra = b.smjer
inner join clanovi c on b.sifra=c.grupa
inner join polaznici d on c.polaznik=d.sifra
where d.ime like 'P%'
order by 4;

--broj članova po grupi
select a.naziv, count(b.polaznik) as polaznika
from grupe a inner join clanovi b
on a.sifra = b.grupa
group by a.naziv
having count(b.polaznik)>5;


use svastara;

--Želim vidjeti sve nazive mjesta u Osječko-Baranjskoj županiji

select a.naziv, b.naziv as opcina, c.naziv as zupanija
from mjesta a inner join opcine b
on a.opcina = b.sifra
inner join zupanije c on b.zupanija=c.sifra
where c.naziv like '%baranj%'
order by a.naziv;

--Koja opcina u OBŽ ima najveći broj mjesta?

select b.naziv as opcina, count(a.sifra) as mjesta
from mjesta a inner join opcine b
on a.opcina = b.sifra
inner join zupanije c on b.zupanija=c.sifra
where c.naziv like '%split%'
group by b.naziv
order by 2 desc;

-- Uprava tvrke Svaštara d.o.o. je odlučila
-- 5 direktora svojih dobavljača odvesti
-- na krstarenje. Koga će povesti?

select top 5 a.naziv,
sum(c.kolicina * c.cijena) as ukupno,
min(c.kolicina * c.cijena) as minimalno,
max(c.kolicina * c.cijena) as makismalno
from dobavljaci a inner join primke b
on a.sifra = b.dobavljac
inner join ArtikliNaPrimci c on b.sifra = c.primka
where b.datum between '2017-01-01' and '2017-12-31'
group by a.naziv
having min(c.kolicina * c.cijena)>0
order by 3 desc, 2 desc;

-- Izlistajte imena i prezimena kupaca koji dolaze iz mjesta u kojem Vi živite

select distinct b.ime
from mjesta a inner join kupci b
on a.sifra=b.mjesto
where a.naziv in ('Osijek', 'Punitovi');

-- Idete u svatove i planirate kupiti poklon
-- u rasponu 1000 - 1100 eura, koliko artikala možete kupiti?

select a.*
from artikli a
where cijena between '1000' and '1100'
order by 6 desc;

select count(*) from Artikli;

select distinct artikl from ArtikliNaPrimci;

select * from artikli where
sifra not in (
	select distinct artikl from ArtikliNaPrimci
);

delete from Artikli where
sifra not in (
	select distinct artikl from ArtikliNaPrimci
);

-- Unesite sebe kao kupca s mjestom u kojem živite

insert into Kupci(ime, jmbg, prezime, adresa, mjesto, email, telefon) values
	('Renato', '1234567890123', 'Kuna', 'Mije Kišpatića 57', 45691, 'renatokuna01@gmail.com', '+385912564789');

select * from Mjesta
where naziv = 'Osijek';

select * from Kupci
where ime='Renato' AND prezime='Kuna';