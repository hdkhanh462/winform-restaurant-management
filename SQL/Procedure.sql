------------------------------------------------------------------------
--THỦ TỤC
------------------------------------------------------------------------
create proc PLogin --Đăng nhập
@u varchar(50),
@p varchar(50) as

	select * from TAccount
	where AUsername = @u and APassword = @p
go
------------------------------------------------------------------------
--MÓN ĂN
------------------------------------------------------------------------
create proc PFoodAdd --1Thêm
@Name nvarchar(50),
@Price int, 
@Image image as

	insert into TFood values(@Name,@Price,@Image)
go
create proc PFoodShowWithImage --1Xem
as
	select FImage, FName, FPrice, ID 
	from TFood
go
create proc PFoodFineByID --1Tìm theo ID
@Id int as

	select FImage,FName,FPrice,ID 
	from TFood 
	where ID = @Id
go
create proc PFoodDelByID --1Xóa
@Id int as

	delete TFood
	where ID = @Id
go
create proc PFoodEditByID --1Sửa
@Id int,
@Name nvarchar(50),
@Price int,
@Img image as

	update TFood 
	set FName = @Name, FPrice = @Price,FImage = @Img
	where ID = @Id
go
------------------------------------------------------------------------
--TÀI KHOẢN
------------------------------------------------------------------------
create proc PAccountAdd --1Thêm
@u varchar(50),
@p nvarchar(50) as

	insert into TAccount values(@u,@p)
go
create proc PAccountEdit --1Sửa
@u varchar(50),
@p nvarchar(50) as

	update TAccount
	set APassword = @p
	where AUsername = @u
go
create proc PAccountShow --1Xem
as
	select * 
	from TAccount
	where AUsername <> ''
go
create proc PAccountDel --1Xóa
@u varchar(50) as

	delete TAccount
	where AUsername = @u
go
------------------------------------------------------------------------
--KHÁCH HÀNG
------------------------------------------------------------------------
create proc PCustomerAdd --1Thêm
@Name nvarchar(50),
@CCCD nvarchar(50),
@Address nvarchar(50),
@Phone nvarchar(50) as

	insert into TCustomer values(@Name,@CCCD,@Address,@Phone)	
go
create proc PCustomerEdit --1Sửa
@ID int,
@Name nvarchar(50),
@CCCD nvarchar(50),
@Address nvarchar(50),
@Phone nvarchar(50) as

	update TCustomer
	set CName = @Name, CCCD = @CCCD, CAddress = @Address, CPhone = @Phone
	where ID = @ID
go
create proc PCustomerShow --1Xem
as
	select * 
	from TCustomer
	where ID <> 1
go
create proc PCustomerDelByID --1Xóa
@ID int as

	delete TCustomer
	where ID = @ID
go

create proc PShowCustomerByOTableID
@OTableID int as
	select *
	from TCustomer
	where ID = (select CustomerID from TOTable where ID = @OTableID)
go
------------------------------------------------------------------------
--CHỨC VỤ
------------------------------------------------------------------------
create proc PRegencyAdd --1Thêm
@Name nvarchar(50),
@Salary int as

	insert into TRegency values(@Name,@Salary)
go
------------------------------------------------------------------------
--BÀN ĂN
------------------------------------------------------------------------
create proc PTableAdd --1THÊM
@Name nvarchar(50),
@Chair int,
@Kind int as

	insert into TTable values(@Name,@Chair,@Kind,1)	
go
create proc PTableShow --1XEM
as
	select *
	from TTable
	ORDER BY TName ASC
go
create proc PTableFindByID --1TÌM THEO ID
@ID int as

	select *
	from TTable
	where ID = @ID
	ORDER BY TName ASC
go
create proc PTableDel --1XÓA THEO ID
@ID int as

	delete TTable
	where ID = @ID
go
------------------------------------------------------------------------
--ĐẶT BÀN ĂN
------------------------------------------------------------------------
create proc PEmptyTableShow --1Kèm Trạng thái
as  
	select *
	from VEmptyTable
	ORDER BY TName ASC
go
create proc PEmptyTableFindByKind --1Sort theo Loại
@Kind nvarchar(50) as

	select *
	from VEmptyTable
	where  TKind = @Kind
	ORDER BY TName ASC
go
create proc PEmptyTableSearch --1Tìm theo Tên & Loại
@Search nvarchar(50) as

	select *
	from VEmptyTable
	where TKind like @Search or TName like @Search
	ORDER BY TName ASC
go

create proc POrderedTableShow --1Kèm Trạng thái
as
	select *
	from VOrderedTable
	ORDER BY TName ASC
go
create proc POrderedTableFindByKind --1Sort theo Loại
@Kind nvarchar(50) as

	select *
	from VOrderedTable
	where TKind like @Kind
	ORDER BY TName ASC
go
create proc POrderedTableSearch --1Tìm kiếm
@Search nvarchar(50) as

	select *
	from VOrderedTable
	where TName like @Search 
			or TKind like @Search 
			or CustomerName like @Search 
			or (select '%' + convert(varchar,OTake,105) + ' ' + convert(varchar,OTake,8) + '%') like @Search
	ORDER BY TName ASC
go

create proc POrderedTableTodayShow --1Kèm Trạng thái
as
	select *
	from VOrderedTableToday
	ORDER BY TName ASC
go
create proc POrderedTableTodayFindByKind --1Sort theo Loại
@Kind nvarchar(50) as

	select *
	from VOrderedTableToday
	where TKind = @Kind
	ORDER BY TName ASC
go
create proc POrderedTableTodaySearch --1Tìm theo Tên & Loại
@Search nvarchar(50) as

	select *
	from VOrderedTableToday
	where TName like @Search 
			or TKind like @Search 
			or CustomerName like @Search 
			or (select '%' + convert(varchar,OTake,105) + ' ' + convert(varchar,OTake,8) + '%') like @Search
	ORDER BY TName ASC
go

create proc PEmptyAOrderedTable --1SỬA TRẠNG THÁI BÀN ĂN
@TableID int,
@OrderID int as

	update TOrderTable
	set OIsTakeOrCancel = 2
	where ID = @OrderID
	
	update TTable
	set TStatus = N'Bàn Trống'
	where ID = @TableID
go
create proc POTable --1THÊM ĐẶT BÀN
@TableID int,
@CustomerID int,
@Book varchar(20),
@Take varchar(20) as

	declare @Date1 datetime,@Date2 datetime
	set @Date1 = (select convert(datetime,@Book,105))
	set @Date2 = (select convert(datetime,@Take,105))
	
	insert into TOTable values(@TableID,@CustomerID,@Date1,@Date2,1,1)
	update TTable
	set TStatus = 2
	where ID = @TableID
go
------------------------------------------------------------------------
--NHÂN VIÊN
------------------------------------------------------------------------
create proc PStaffAdd --1Thêm
@Name nvarchar(50),
@CCCD varchar(12),
@Phone varchar(10), 
@Image image,
@Regency nvarchar(50),
@Account varchar(50) as

	declare @RegencyID int
	set @RegencyID = (select ID from TRegency where RName like @Regency)
	
	insert into TStaff values(@Name,@CCCD,@Phone,@Image,@RegencyID,@Account)
go
create proc PStaffShow --1Xem
as
	select *
	from VStaff
go
create proc PStaffFindByUsername --1Tìm theo tên tài khoản
@u varchar(50) as

	select ID
	from VStaff
	where UserName like @u
go
create proc PStaffFindByID --1Tìm theo ID
@ID int as

	select SImage, SName,CCCD, SPhone,UserName,RName as 'Regency' 
	from TStaff Ts, TRegency Tr
	where Tr.ID = Ts.RegencyID and Ts.ID = @ID
go
create proc PStaffEdit --1Sửa
@ID int,
@Name nvarchar(50),
@CCCD varchar(15),
@Phone varchar(10), 
@Regency nvarchar(50),
@Account varchar(50),
@Img image as

	declare @RegencyID int
	set @RegencyID = (select ID from TRegency where RName like @Regency)
	
	update TStaff
	set SName = @Name,CCCD = @CCCD, sPhone = @Phone,RegencyID = @RegencyID,UserName = @Account,SImage = @Img
	where ID = @ID
go
create proc PStaffDel --1Xóa
@ID int as

	delete TStaff
	where ID = @ID
go
------------------------------------------------------------------------
--HÓA ĐƠN
------------------------------------------------------------------------
create proc PBillAdd -- 1Thêm
@FoodID int, 
@isBank int,
@StaffID int,
@CustomerID int as

	declare @BillID varchar(50),@BillDate varchar(50)
	set @BillID = (select replace(convert(varchar, getdate(),5),'-','') + replace(convert(varchar, getdate(),8),':','') )
	set @BillDate = (select CONVERT(datetime,GETDATE()))

	insert into TBill values(@BillID,@BillDate,@isBank,@FoodID,@StaffID,@CustomerID)
go
create proc PBillAddMoreFood --Thêm món ăn vào hóa đơn
@BillID varchar(14),
@BillDate varchar(25),
@FoodID int, 
@StaffID int,
@CustomerID int,
@isBank int as

	declare @Date datetime
	set @Date = (select CONVERT(datetime,@BillDate))

	insert into TBill values(@BillID,@Date,@isBank,@FoodID,@StaffID,@CustomerID)
go
create proc PBillShow --1Xem
as
	select *
	from VBill
	ORDER BY BillID DESC
go
create proc PBillEdit
@BillID varchar(14),
@IsBank int as
	update TBill
	set BIsBank = @IsBank
go

create proc PBillShowIDDetail
@BillID varchar(14) as
select StaffID,CustomerID,BIsBank
from TBill
where BillID like @BillID
group by StaffID,CustomerID,BIsBank
go
create proc PBillDel --Xóa
@BillID varchar(50) as

	delete TBill
	where BillID like @BillID
go
create proc PBillDetailFindByID --Tìm theo ID
@BillID varchar(50) as

	select FoodID, FName, FPrice, COUNT(FoodID) as Quantity, SUM(FPrice) as Total 
	from TBill Tt, TFood Tf
	where FoodID = Tf.ID and BillID like @BillID
	group by FoodID, FName, FPrice
go
create proc PBillDetailDel --Xóa chi tiết hóa đơn theo ID
@Id int, @billID varchar(50) as

	delete TBill
	where FoodID = @Id and BillID = @billID
go
------------------------------------------------------------------------