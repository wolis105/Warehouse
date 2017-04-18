create procedure sp_Insert
@EtID nvarchar(50),
@EtDate datetime,
@WhName nvarchar(10),
@ShName nvarchar(10),
@EDID nvarchar(50),
@EDCount int,
@ESID nvarchar(50),
@GdName nvarchar(10)
as
insert into Extract(EtID,EtDate,WhID,ShID) values(@EtID,@EtDate,(select WhID from Warehouse where WhName=@WhName),(select ShID from Shop where ShName=@ShName))
insert into ExtractDetail(EDID,EDCount,EtID,GdID) values(@EDID,@EDCount,@ESID,(select GdID from Goods where GdName=@GdName))
go


create procedure sp_SelectAll
@GdName nvarchar(10)
as
select EDID,EtDate,EDCount, GdName,GdType,GdSpecification,ShName,WhName 
from Goods as G inner join ExtractDetail as D on(G.GdID=D.GdID)
inner join Extract as E on(E.EtID=D.EtID)
inner join Shop as S on(S.ShID=E.ShID)
inner join Warehouse as W on(W.WhID=E.WhID) where (CHARINDEX(@GdName,GdName)>0 or len(@GdName)=0) 
go


create procedure sp_SelectOne
@GdName nvarchar(10)
as
select ShName from Shop where ShID in(select ShID from Extract where EtID in(select EtID from ExtractDetail where GdID in(Select GdID from Goods where GdName=@GdName))) 
go

create procedure sp_SelectOnly
@GdName nvarchar(10)
as
Select WhName from Warehouse where WhID in(select WhID from Extract where EtID in(select EtID from ExtractDetail where GdID in(Select GdID from Goods where GdName='Æ»¹û')))
go


create procedure sp_Number
@eDCount int,
@pDCount int,
@sDCount int,
@dlCount int,
@number int,
@gdID nvarchar(50),
@GdName nvarchar(10)
as
set @gdID=(select GdID from Goods where GdName=@GdName)
set @eDCount=(select sum(EDCount) from ExtractDetail where GdID=@gdID)
set @pDCount=(select sum(PDCount) from PurchaseDetail where GdID=@gdID)
set @sDCount=(select sum(SDCount) from SalesDetail where GdID=@gdID)
set @dlCount=(select sum(DlCount) from Deliver where GdID=@gdID)
go


create procedure sp_Count
@GdName nvarchar(10)
as
select PDCount=SUM(PDCount) from PurchaseDetail where GdID=(select GdID from Goods where GdName=@GdName)
go

