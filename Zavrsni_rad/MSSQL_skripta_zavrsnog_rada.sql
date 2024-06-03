--create database EdunovaWebProgramiranjeZavrsniRad;

--use EdunovaWebProgramiranjeZavrsniRad;

--create table Player(
--	Player_ID int not null primary key identity(1,1),
--	Username varchar(50) not null,
--	RegistrationDate date not null,
--	Region varchar(50) not null
--);

--create table Game(
--	Game_ID int not null primary key identity(1,1),
--	Title varchar(50) not null,
--	Developer varchar(50),
--	GamePlatform varchar(50),
--	GameDescription text,
--	CoverImage image
--);

--create table Trophy(
--	Trophy_ID int not null primary key identity(1,1),
--	Title varchar(50) not null,
--	TrophyDescription text,
--	Game_ID int not null foreign key references Game(Game_ID),
--	TrophyType varchar(10),
--	TrophyIcon image,
--	DateAchieved datetime
--);

--create table Comparison(
--	Player1_ID int not null foreign key references Player(Player_ID),
--	Player2_ID int not null foreign key references Player(Player_ID),
--	Game_ID int not null foreign key references Game(Game_ID),
--	Trophy_ID int not null foreign key references Trophy(Trophy_ID),
--	Achieved bit
--);