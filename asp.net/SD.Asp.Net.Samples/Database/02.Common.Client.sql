IF OBJECT_ID('Common.Client', 'U') IS NOT NULL
  DROP TABLE Common.Client
GO

CREATE TABLE Common.Client
(
  Id int NOT NULL IDENTITY(1, 1),
  IsDeleted int NOT NULL default 0,
  CreatedById int NOT NULL default 1,
  CreatedOn datetime NOT NULL default GetUTCDate(),
  UpdatedById int,
  UpdatedOn datetime,
 
  Name nvarchar(255),
  Code nvarchar(25),
  Note  nvarchar(500)
 
 
)
GO