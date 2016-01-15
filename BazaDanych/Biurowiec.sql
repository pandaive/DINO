create database Biurowiec
---drop database Biurowiec

GO

use Biurowiec
--use Master

GO
-------------------------------------------------------------------
-------------------------------------------------------------------
-------------------------------TABLES------------------------------
-------------------------------------------------------------------
-------------------------------------------------------------------

create table Pietra
(
numer int primary key
)

GO

create table Firmy
(
id int identity(1,1) primary key,
nazwa varchar(30) unique,
pietro int foreign key references Pietra(numer)
)

GO

create table Pokoje
(
pietro int foreign key references Pietra(numer),
numer int primary key
)

GO


--drop table Pracownicy_firm
create table Pracownicy_firm
(
id int identity(1,1) primary key,
nazwisko varchar(30),
imie varchar(30),
stanowisko varchar(30),
firma int foreign key references Firmy(id),
pokoj int foreign key references Pokoje(numer) unique,
telefon int,
email varchar(40)
)

GO

create table Goscie
(
nazwisko varchar(30) primary key,
imie varchar(30),
data_odwiedzin varchar(10),
godzina_wejscia varchar(10),
godzina_wyjscia varchar(10),
odwiedzany varchar(61)
)




------------------------------------------------------------------
------------------------------------------------------------------
-------------------PROCEDURES&FUNCTIONS---------------------------
------------------------------------------------------------------
------------------------------------------------------------------

select * from Pietra
select * from Pokoje
select * from Firmy
select * from Pracownicy_firm

GO

create procedure dodaj_firme
	@nazwa varchar(30),
	@pietro int
AS
		begin
			insert into Firmy values (@nazwa, @pietro)
		end


GO

create procedure dodaj_pietro
	(@numer int)
AS
		insert into Pietra values (@numer)

GO

--drop procedure dodaj_pracownika
create procedure dodaj_pracownika
	@nazwisko varchar(30),
	@imie varchar(30),
	@firma varchar(30),
	@stanowisko varchar(30),
	@pokoj int,
	@telefon int,
	@email varchar(30)
AS
begin try
declare @id_firmy int = (select id from Firmy where nazwa=@firma)
	if not exists (select * from Pracownicy_firm where nazwisko=@nazwisko and firma=@id_firmy)
		begin
			insert into Pracownicy_firm values (@nazwisko, @imie, @stanowisko, @id_firmy, @pokoj, @telefon, @email)
		end
	else Raiserror('Pracownik juz istnieje!',11,1)
end try
begin catch
	SELECT ERROR_NUMBER() AS 'NUMER BLEDU',ERROR_MESSAGE() AS 'KOMUNIKAT'
end catch

GO

--drop procedure dodaj_goscia
create procedure dodaj_goscia
	@nazwisko varchar(30),
	@imie varchar(30),
	@data varchar(10),
	@godz_wej varchar(10),
	@godz_wyj varchar(10),
	@odwiedzany_nazw varchar(30),
	@odwiedzany_imie varchar(30)
AS
begin
	declare @odwiedzany varchar(61) = (@odwiedzany_imie + ' ' + @odwiedzany_nazw)
	insert into Goscie values (@nazwisko, @imie, @data, @godz_wej, @godz_wyj, @odwiedzany)
end

GO