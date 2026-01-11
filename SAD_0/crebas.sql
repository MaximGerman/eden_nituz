/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     12/05/2014 21:30:09                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"Order"') and o.name = 'FK_ORDER_ASSOCIATI_WORKER')
alter table "Order"
   drop constraint FK_ORDER_ASSOCIATI_WORKER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"Order"')
            and   name  = 'Association1_FK'
            and   indid > 0
            and   indid < 255)
   drop index "Order".Association1_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"Order"')
            and   type = 'U')
   drop table "Order"
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Worker')
            and   type = 'U')
   drop table Worker
go

if exists(select 1 from systypes where name='Title')
   execute sp_unbindrule Title
go

if exists(select 1 from systypes where name='Title')
   drop type Title
go

if exists (select 1 from sysobjects where id=object_id('R_Title') and type='R')
   drop rule  R_Title
go

create rule R_Title as
      @column in ('manager','senior','junior')
go

/*==============================================================*/
/* Domain: Title                                                */
/*==============================================================*/
create type Title
   from char(7)
go

execute sp_bindrule R_Title, Title
go

/*==============================================================*/
/* Table: "Order"                                               */
/*==============================================================*/
create table "Order" (
   workerId             char(20)             null,
   orderId              int                  not null,
   orderDate            date                 null,
   orderTotalPrice      int                  null,
   constraint PK_ORDER primary key (orderId)
)
go

/*==============================================================*/
/* Index: Association1_FK                                       */
/*==============================================================*/
create index Association1_FK on "Order" (
workerId ASC
)
go

/*==============================================================*/
/* Table: Worker                                                */
/*==============================================================*/
create table Worker (
   workerId             char(20)             not null,
   workerName           char(20)             null,
   workerTitle          Title                null,
   constraint PK_WORKER primary key (workerId)
)
go

alter table "Order"
   add constraint FK_ORDER_ASSOCIATI_WORKER foreign key (workerId)
      references Worker (workerId)
go

