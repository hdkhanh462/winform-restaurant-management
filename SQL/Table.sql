------------------------------------------------------------------------
--BÀN
------------------------------------------------------------------------
create table TTable
(
	ID int IDENTITY(1,1) Primary Key,
	TName varchar(10) Not Null,
	TChair smallint Null,
	TKind smallint Null,
	TStatus Tinyint Null,
)
go
------------------------------------------------------------------------
--KHÁCH HÀNG
------------------------------------------------------------------------
create table TCustomer
(
	ID int IDENTITY(1,1) Primary Key,
	CName nvarchar(50) Not Null,
	CCCD varchar(12) Null,
	CPhone varchar(10) Null,
	IsMale bit Not Null,
)
go
------------------------------------------------------------------------
--MÓN ĂN
------------------------------------------------------------------------
create table TFoodKind
(
	ID int IDENTITY(1,1) Primary Key,
	FKName nvarchar(50) Not Null
)
go
create table TFood
(
	ID int IDENTITY(1,1) Primary Key,
	FName nvarchar(50) Not Null,
	FKindID int Null,
	FPrice int Null,
	FImage nvarchar(max) Null,
	constraint fk_FKindID_TFood foreign key (FKindID) references TFoodKind(ID),
)
go
create table TOFood
(
	ID int IDENTITY(1,1) Primary Key,
	OTableID int Null,
	FoodID int Not Null,
	Quantity int Not Null,
	Total int Not Null,
	constraint fk_FoodID_TOFood foreign key (FoodID) references TFood(ID),
)
go
------------------------------------------------------------------------
--ĐẶT BÀN
------------------------------------------------------------------------
create table TOTable
(
	ID int IDENTITY(1,1) Primary Key,
	TableID int Not Null,
	CustomerID int Not Null,
	OBook datetime Not Null,
	OTake datetime Not Null,
	IsPay bit Null,
	IsCanel bit Null,
	OFoodID int Not null
	constraint fk_TableID_TOTable foreign key (TableID) references TTable(ID),
	constraint fk_CustomerID_TOTable foreign key (CustomerID) references TCustomer(ID),
	constraint fk_TOFoodID_TOTable foreign key (OFoodID) references TOFood(ID)
)
go