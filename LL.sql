create procedure sp_Insert
@EtID nvarchar(50),
@EtDate datetime,
@WhName nvarchar(10),
@ShName nvarchar(10),
@EDID nvarchar(50),
@EDCount int,
@GdName nvarchar(10)
as
insert into Extract(EtID,EtDate,WhID,ShID) values(@EtID,@EtDate,(select WhID from Warehouse where WhName=@WhName),(select ShID from Shop where ShName=@ShName))
insert into ExtractDetail(EDID,EDCount,EtID,GdID) values(@EDID,@EDCount,@EtID,(select GdID from Goods where GdName=@GdName))
go