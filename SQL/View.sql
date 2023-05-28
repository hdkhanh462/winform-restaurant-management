------------------------------------------------------------------------
--VIEW
------------------------------------------------------------------------
create view VOTable --BÀN ĐÃ ĐƯỢC ĐẶT
as
	select t.*, CName,OBook,OTake,IsPay,IsCanel,ot.ID as OrderID
	from TTable t,TOTable ot, TCustomer c
	where CustomerID = c.ID 
			and t.ID = TableID 
			and t.ID not in (select ID from TTable where TStatus = 1) 
			and IsPay = 0 and IsCanel = 0
go