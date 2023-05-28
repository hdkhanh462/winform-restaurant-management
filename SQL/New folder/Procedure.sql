------------------------------------------------------------------------
--PROCEDURE
------------------------------------------------------------------------
create proc POTable --1THÊM ĐẶT BÀN
@TableID int,
@CustomerID int,
@Book varchar(20),
@Take varchar(20) as

	declare @Date1 datetime,@Date2 datetime
	set @Date1 = (select convert(datetime,@Book,105))
	set @Date2 = (select convert(datetime,@Take,105))
	
	insert into TOTable values(@TableID,@CustomerID,@Date1,@Date2,0,0,1)
	update TTable
	set TStatus = 2
	where ID = @TableID
go

create proc PShowCustomerByOTableID
@OTableID int as
	select *
	from TCustomer
	where ID = (select CustomerID from TOTable where ID = @OTableID)
go

create proc PTableAdd --1THÊM
@Name nvarchar(50),
@Chair int,
@Kind int as

	insert into TTable values(@Name,@Chair,@Kind,1)	
go