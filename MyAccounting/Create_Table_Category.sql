if exists (select 1
            from  sysobjects
           where  id = object_id('Category')
            and   type = 'U')
   drop table Category
go


CREATE TABLE [dbo].[Category] (
    [Id]           INT       IDENTITY (1, 1) NOT NULL,
    [CategoryName] CHAR (20) NOT NULL,
	[CategoryItem] CHAR(20) NOT NULL ,
    [IsPayout]     BIT       DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

