--修改表Category 的属性CategoryName 的数据类型为nchar(20)
ALTER TABLE [Category]
ALTER COLUMN [CategoryName] nchar(20);
GO

ALTER TABLE [Category]
ALTER COLUMN [CategoryItem] nchar(20);
GO 