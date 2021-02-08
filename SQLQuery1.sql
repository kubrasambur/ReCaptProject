Create table Cars(
	Id int primary key identity(1,1),
	BrandId int,
	ColorId int,
	ModelYear int,
	DailyPrice decimal,
	Descriptions nvarchar(25),
	Foreign Key (BrandId) References Colors(ColorId),
	Foreign Key (ColorId) References Brands(BrandId)
)
Create table Colors(
	ColorId int primary Key identity(1,1),
	ColorName nvarchar(25)
)
Create table Brands(
	BrandId int Primary Key identity (1,1),
	BrandName nvarchar(25)
)
Insert Into Cars(BrandId,ColorId,ModelYear,DailyPrice,Descriptions)
Values
	('1','1','2003','500','Otomatik Hybrid'),
	('2','2','2014','800','Otomatik benzin'),
	('4','2','2009','400','Manuel dizel'),
	('2','3','2004','700','Manuel benzin'),
	('3','1','2019','200','Otomatik dizel')

Insert Into Brands(BrandName)
Values
	('Toyota'),
	('Audi'),
	('Tesla'),
	('Mercedes'),
	('Fiat')

Insert Into Colors (ColorName)
Values
	('Siyah'),
	('Lacivert'),
	('Beyaz')

Select * from Cars
Select * from Brands
Select * from Colors

