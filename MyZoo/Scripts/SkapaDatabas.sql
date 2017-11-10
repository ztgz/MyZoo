use master
go
drop Database Zoo
go
create Database Zoo
go
use Zoo
go

create Table Enviorment(
	Id int identity(1,1) primary key,
	EName varchar(50) not null,
);

create Table FoodType(
	Id int identity(1,1) primary key,
	FName varchar(50) not null, 
);

create Table Species(
	Id int identity(1,1) primary key,
	SName varchar(50),
	Country varchar(50),
	EnviormentId int not null,
	FoodTypeId int not null,
	foreign key (EnviormentId) references Enviorment(Id),
	foreign key (FoodTypeId) references FoodType(Id),
);

create Table Animal(
	Id int identity(1,1) primary key,
	AnimalWeight decimal,
	SpeciesId int not null,
	foreign key (SpeciesId) references Species(Id),
);

create Table Relations(
	Id int identity(1,1) primary key,
	ParentId int,
	ChildId int,
	foreign key (ParentId) references Animal(Id),
	foreign key (ChildId) references Animal(Id),
);

create table Veterinary(
	Id int identity(1,1) primary key,
	PersonName varchar(100),
);

create table Booking(
	Id int identity(1,1) primary key,
	AnimalId int not null,
	StartDate DateTime not null,
	EndDate DateTime not null,
	VeterinaryId int not null,
	foreign key (VeterinaryId) references Veterinary(Id),
	foreign key (AnimalId) references Animal(Id)
);

create Table Medicine(
	Id int identity(1,1) primary key,
	MedicineName varchar(100)
);

create Table Diagnosis(
	Id int identity(1,1) primary key,
	Journal varchar(250),
	BookingId int not null,
	foreign key (BookingId) references Booking(Id)
);

create Table MedicineDiagnosisRelation(
	Id int identity(1,1) primary key,
	DiagnosisId int not null,
	MedicineId int not null,
	foreign key (DiagnosisId) references Diagnosis(Id),
	foreign key (MedicineId) references Medicine(Id)
);

insert into Enviorment(EName)
values('Mark'), ('Träd'), ('Vatten');

insert into FoodType(FName)
values ('Köttätare'), ('Växtätare');

insert into Species(SName, Country, EnviormentId, FoodTypeId)
values('Lejon', 'Sydafrika', 1, 1), ('Gädda', 'Norge', 3, 1); 

insert into Animal(AnimalWeight, SpeciesId)
	values(50, 1), (45,1), (25,1), (3,2);

insert into Relations(ParentId,ChildId)
values(1,3), (2,3);

insert into Veterinary(PersonName)
values('Jenny'),('Karl'),('Pontus'),('Emma'),('Lillemor');

insert into Booking(VeterinaryId, AnimalId, StartDate, EndDate)
values(1,1, '2017-11-11 11:00:00', '2017-11-11 11:59:00')

insert into Medicine(MedicineName)
values ('amitraz'), ('ofloxacin'), ('doxycycline')

insert into Diagnosis(BookingId, Journal)
values(1, 'Detta djur har löss')

insert into MedicineDiagnosisRelation(MedicineId, DiagnosisId)
values(1,1)



--insert into Booking(VeterinaryId, AnimalId, StartDate, EndDate)
--values(1,1, '2017-11-09 11:00:00', '2017-11-09 11:59:00')

--insert into Diagnosis(BookingId, Journal)
--values(2, 'Detta djur har löss')

--insert into MedicineDiagnosisRelation(MedicineId, DiagnosisId)
--values(2,2)
