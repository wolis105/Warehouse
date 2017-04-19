--增加管理员
create procedure sp_AdminAdd
@WAID nvarchar(50),
@WALojinID nvarchar(20),
@WAPassword nvarchar(20),
@WAName nvarchar(10),
@WASex char(2),
@WACardID CHAR(18),
@WAphone varchar(15),
@WhName NVARCHAR(50)
as
insert into WarehouseAdmin(WAID,WALojinID,WAPassword,WAName,WASex,WACardID,WAphone,WhID) values(@WAID,@WALojinID,@WAPassword,@WAName,@WASex,@WACardID,@WAphone,(select WhID from Warehouse where WhName=@WhName))
go

create procedure sp_WarehouseName
as
select WhName from Warehouse
GO

--修改管理员
create procedure sp_AdminUpdate
@WAID nvarchar(50),
@WALojinID nvarchar(20),
@WAName nvarchar(10),
@WASex char(2),
@WACardID CHAR(18),
@WAphone varchar(15),
@WhName NVARCHAR(50)
as
update WarehouseAdmin set WALojinID=@WALojinID,WAName=@WAName,WASex=@WASex,WACardID=@WACardID,WAphone=@WAphone,WhID=(select WhID from Warehouse where WhName=@WhName)  where WAID=@WAID
GO

create procedure sp_AdminUpdateLoad
@WAID nvarchar(50)
as
select WALojinID,WAName,WASex,WACardID,WAphone,WhName from WarehouseAdmin left join Warehouse on WarehouseAdmin.WhID=Warehouse.WhID  where WAID=@WAID
go

--删除管理员
create procedure sp_AdminDelete
@WAID nvarchar(50)
as
delete from WarehouseAdmin where WAID=@WAID
go



--修改密码
create procedure sp_UpdatePassword
@WAID nvarchar(50)
as
select WAPassword from WarehouseAdmin where  WAID=@WAID
go

create procedure sp_UpdateAdminPassword
@WAID nvarchar(50),
@WAPassword nvarchar(20)
as
update WarehouseAdmin set WAPassword=@WAPassword where WAID=@WAID
go



--查询管理员
create procedure sp_SelectAdmin
@WAName nvarchar(10)
as
select WALojinID,WAName,WASex,WACardID,WAphone,WhName from WarehouseAdmin left join Warehouse on WarehouseAdmin.WhID=Warehouse.WhID  where WAName=@WAName
go


create procedure sp_SelectWAID
@WAName nvarchar(10)
as
select WAID from WarehouseAdmin where WAName=@WAName
go

--管理员登录
create procedure sp_AdminLogin
@WALojinID nvarchar(20)
as
select WAPassword from WarehouseAdmin where WALojinID=@WALojinID
go

--增加仓库信息
create procedure sp_WarehouseInsert
@WhID nvarchar(50),
@WhName nvarchar(10),
@WhAdress text,
@WhExplain text
as
insert into Warehouse(WhID,WhName,WhAdress,WhExplain) values(@WhID,@WhName,@WhAdress,@WhExplain)
go

--查询仓库的名称
create procedure sp_WarehouseLoad
as
select WhName from Warehouse
go

--修改仓库信息
create procedure sp_WarehouseUpdate
@WhID nvarchar(50),
@WhName nvarchar(10),
@WhAdress text,
@WhExplain text
as
update Warehouse set WhName=@WhName,WhAdress=@WhAdress,WhExplain=@WhExplain  where WhID=@WhID
go

create procedure sp_UpdateLoad
@WhID nvarchar(50)
as
select * from Warehouse where WhID=@WhID
go

--删除仓库信息
create procedure sp_WarehouseDelete
@WhID nvarchar(50)
as
delete from Warehouse  where WhID=@WhID
go

--查询所有仓库信息
create procedure sp_SelectAllWarehouse
as
select * from Warehouse
go

--按名称查询
create procedure sp_SelectByName
@WhName nvarchar(10)
as
select * from Warehouse where WhName=@WhName
go

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
select ShName from Shop where ShID=(select ShID from Extract where EtID=(select EtID from ExtractDetail where GdID=(Select GdID from Goods where GdName=@GdName))) 
go

create procedure sp_SelectOnly
@GdName nvarchar(10)
as
Select WhName from Warehouse where WhID=(select WhID from Extract where EtID=(select EtID from ExtractDetail where GdID=(Select GdID from Goods where GdName=@GdName)))
go

create procedure sp_Count
@GdName nvarchar(10)
as
Select PDCount=SUM(PDCount) from PurchaseDetail where GdID=(Select GdID from Goods where GdName=@GdName)
go

