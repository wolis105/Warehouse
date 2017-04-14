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
as
select EDID,EtDate,EDCount, GdName,GdType,GdSpecification,ShName,WhName 
from Goods as G inner join ExtractDetail as D on(G.GdID=D.GdID)
inner join Extract as E on(E.EtID=D.EtID)
inner join Shop as S on(S.ShID=E.ShID)
inner join Warehouse as W on(W.WhID=E.WhID)
go


create procedure sp_SelectOne
@GdName nvarchar(10)
as
select ShName from Shop where ShID=(select ShID from Extract where EtID=(select EtID from ExtractDetail where GdID=(Select GdID from Goods where GdName=@GdName))) 
go

create procedure sp_SelectOnly
@GdName nvarchar(10)
as
Select WhName from Warehouse where WhID=(select WhID from Extract where EtID=(select EtID from ExtractDetail where GdID=(Select GdID from Goods where GdName=@GdName)))
go



