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