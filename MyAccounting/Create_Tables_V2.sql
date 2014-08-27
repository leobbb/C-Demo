/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     8/27/2014 7:55:32 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Item') and o.name = 'FK_ITEM_REFERENCE_CATEGORY')
alter table Item
   drop constraint FK_ITEM_REFERENCE_CATEGORY
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Item') and o.name = 'FK_ITEM_LISHU2_CATEGORY')
alter table Item
   drop constraint FK_ITEM_LISHU2_CATEGORY
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('List') and o.name = 'FK_LIST_REFERENCE_CATEGORY')
alter table List
   drop constraint FK_LIST_REFERENCE_CATEGORY
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('List') and o.name = 'FK_LIST_REFERENCE_ITEM')
alter table List
   drop constraint FK_LIST_REFERENCE_ITEM
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('List') and o.name = 'FK_LIST_LISHU3_ITEM')
alter table List
   drop constraint FK_LIST_LISHU3_ITEM
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('List') and o.name = 'FK_LIST_SHUYU1_CATEGORY')
alter table List
   drop constraint FK_LIST_SHUYU1_CATEGORY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Category')
            and   type = 'U')
   drop table Category
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Item')
            and   name  = 'lishu2_FK'
            and   indid > 0
            and   indid < 255)
   drop index Item.lishu2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Item')
            and   type = 'U')
   drop table Item
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('List')
            and   name  = 'lishu3_FK'
            and   indid > 0
            and   indid < 255)
   drop index List.lishu3_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('List')
            and   name  = 'shuyu1_FK'
            and   indid > 0
            and   indid < 255)
   drop index List.shuyu1_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('List')
            and   type = 'U')
   drop table List
go

/*==============================================================*/
/* Table: Category                                              */
/*==============================================================*/
create table Category (
   CId                  int                  not null,
   CategoryName         varchar(30)          not null,
   IsPayout             tinyint              not null,
   constraint PK_CATEGORY primary key nonclustered (CId)
)
go

/*==============================================================*/
/* Table: Item                                                  */
/*==============================================================*/
create table Item (
   ItemId               int                  not null,
   CId                  int                  not null,
   ItemName             varchar(30)          not null,
   CategoryId           int                  not null,
   constraint PK_ITEM primary key nonclustered (ItemId)
)
go

/*==============================================================*/
/* Index: lishu2_FK                                             */
/*==============================================================*/
create index lishu2_FK on Item (
CId ASC
)
go

/*==============================================================*/
/* Table: List                                                  */
/*==============================================================*/
create table List (
   LId                  int                  not null,
   CId                  int                  not null,
   ItemId               int                  not null,
   TradeDate            datetime             not null,
   Explain              varchar(100)         null,
   constraint PK_LIST primary key nonclustered (LId)
)
go

/*==============================================================*/
/* Index: shuyu1_FK                                             */
/*==============================================================*/
create index shuyu1_FK on List (
CId ASC
)
go

/*==============================================================*/
/* Index: lishu3_FK                                             */
/*==============================================================*/
create index lishu3_FK on List (
ItemId ASC
)
go

alter table Item
   add constraint FK_ITEM_REFERENCE_CATEGORY foreign key (CId)
      references Category (CId)
go

alter table Item
   add constraint FK_ITEM_LISHU2_CATEGORY foreign key (CId)
      references Category (CId)
go

alter table List
   add constraint FK_LIST_REFERENCE_CATEGORY foreign key (CId)
      references Category (CId)
go

alter table List
   add constraint FK_LIST_REFERENCE_ITEM foreign key (ItemId)
      references Item (ItemId)
go

alter table List
   add constraint FK_LIST_LISHU3_ITEM foreign key (ItemId)
      references Item (ItemId)
go

alter table List
   add constraint FK_LIST_SHUYU1_CATEGORY foreign key (CId)
      references Category (CId)
go
