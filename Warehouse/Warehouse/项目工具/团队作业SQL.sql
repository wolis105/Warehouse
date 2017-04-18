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
@WAPassword nvarchar(20),
@WAName nvarchar(10),
@WASex char(2),
@WACardID CHAR(18),
@WAphone varchar(15),
@WhName NVARCHAR(50)
as
update WarehouseAdmin set WALojinID=@WALojinID,WAPassword=@WAPassword,WAName=@WAName,WASex=@WASex,WACardID=@WACardID,WAphone=@WAphone,WhID=(select WhID from Warehouse where WhName=@WhName)  where WAID=@WAID
GO

CREATE PROCEDURE sp_AdminUpdateLoad
@WAID nvarchar(50)
as
select WAID,WALojinID,WAPassword,WAName,WASex,WACardID,WAphone,WhName from WarehouseAdmin left join Warehouse on WarehouseAdmin.WhID=Warehouse.WhID  where WAID=@WAID
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


--查询管理员
create procedure sp_SelectAdmin
@WAName nvarchar(10)
as
select WALojinID,WAName,WASex,WACardID,WAphone,WhName from WarehouseAdmin left join Warehouse on WarehouseAdmin.WhID=Warehouse.WhID  where WAName=@WAName
go






