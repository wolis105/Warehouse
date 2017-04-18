--���Ӳֿ���Ϣ
create procedure sp_WarehouseInsert
@WhID nvarchar(50),
@WhName nvarchar(10),
@WhAdress text,
@WhExplain text
as
insert into Warehouse(WhID,WhName,WhAdress,WhExplain) values(@WhID,@WhName,@WhAdress,@WhExplain)
go

--��ѯ�ֿ������
create procedure sp_WarehouseLoad
as
select WhName from Warehouse
go

--�޸Ĳֿ���Ϣ
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

--ɾ���ֿ���Ϣ
create procedure sp_WarehouseDelete
@WhID nvarchar(50)
as
delete from Warehouse  where WhID=@WhID
go

--��ѯ���вֿ���Ϣ
create procedure sp_SelectAllWarehouse
as
select * from Warehouse
go