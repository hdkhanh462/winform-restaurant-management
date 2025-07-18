------------------------------------------------------------------------
--TẠO BẢNG
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
	FImage image Null,
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
--TÀI KHOẢN
------------------------------------------------------------------------
create table TAccount
(
	AUsername varchar(50) Primary Key,
	APassword varchar(50) Not Null,
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
	IsMale tinyint Null,
)
go
------------------------------------------------------------------------
--CHỨC VỤ
------------------------------------------------------------------------
create table TRegency
(
	ID int IDENTITY(1,1) Primary Key,
	RName nvarchar(50) Not Null,
	RSalary int Null,
)
go
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
--ĐẶT BÀN
------------------------------------------------------------------------
create table TOTable
(
	ID int IDENTITY(1,1) Primary Key,
	TableID int Not Null,
	CustomerID int Not Null,
	OBook datetime Not Null,
	OTake datetime Not Null,
	OIsTakeOrCancel tinyint Not Null,
	TOFoodID int Not null
	constraint fk_TableID_TOTable foreign key (TableID) references TTable(ID),
	constraint fk_CustomerID_TOTable foreign key (CustomerID) references TCustomer(ID),
	constraint fk_TOFoodID_TOTable foreign key (TOFoodID) references TOFood(ID)
)
go
------------------------------------------------------------------------
--NHÂN VIÊN
------------------------------------------------------------------------
create table TStaff
(
	ID int IDENTITY(1,1) Primary Key,
	SName nvarchar(50) Not Null,
	CCCD varchar(12) Not Null,
	SPhone varchar(10) Not Null,
	SImage image Not Null,
	RegencyID int Not Null,
	UserName varchar(50) Null,
	constraint fk_RegencyID foreign key (RegencyID) references TRegency(ID),
	constraint fk_UserName foreign key (UserName) references TAccount(AUsername),
)
go
------------------------------------------------------------------------
--HÓA ĐƠN
------------------------------------------------------------------------
create table TBill
(
	DetailID int IDENTITY(1,1) Primary Key,
	BillID varchar(14) Not Null,
	BDate datetime Not Null,
	BIsBank int Not Null,
	FoodID int Not Null,
	StaffID int Not Null,
	CustomerID int Not Null,
	TableID int not null
	constraint fk_FoodID_TBill foreign key (FoodID) references TFood(ID),
	constraint fk_StaffID foreign key (StaffID) references TStaff(ID),
	constraint fk_CustomerID_TBill foreign key (CustomerID) references TCustomer(ID),
	constraint fk_TableID_TBill foreign key (TableID) references TTable(ID),
)
go
------------------------------------------------------------------------
--VIEW
------------------------------------------------------------------------
create view VEmptyTable --BÀN TRỐNG
as 
	select *
	from TTable
	where TStatus = N'Bàn Trống'
go
------------------------------------------------------------------------
create view VOTable --BÀN ĐÃ ĐƯỢC ĐẶT
as
	select t.*, c.CName,ot.OBook,ot.OTake,ot.OIsTakeOrCancel,ot.ID as OID
	from TTable t,TOTable ot, TCustomer c
	where ot.CustomerID = c.ID 
			and t.ID = TableID 
			and t.ID not in (select ID from TTable where TStatus = 1) 
			and ot.OIsTakeOrCancel = 1
go
------------------------------------------------------------------------
create view VOrderedTableToday --BÀN ĐÃ ĐƯỢC ĐẶT CÓ NGÀY NHẬN LÀ HÔM NAY
as
	select *
	from VOrderedTable
	where	OIsTakeOrCancel = 1
			and (select '%' + CONVERT(varchar,OTake,105) + '%') like (select '%' + CONVERT(varchar,GETDATE(),105) + '%')
go
------------------------------------------------------------------------
create view VStaff --Xem
as
	select Ts.*,Tr.RName as 'Regency' 
	from TStaff Ts, TRegency Tr
	where Tr.ID = Ts.RegencyID
go
------------------------------------------------------------------------
create view VBill --View
as
	select BillID,BDate, SUM(FPrice) as Total,Ts.SName as StaffName,Tc.CName as CustomerName,BIsBank
	from TBill Tb, TFood Tf, TStaff Ts,TCustomer Tc
	where FoodID = Tf.ID 
			and Ts.Id = Tb.StaffID 
			and Tc.ID = Tb.CustomerID
			
	group by BillID, BDate, BIsBank
go
------------------------------------------------------------------------
