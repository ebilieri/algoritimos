﻿CREATE TABLE [dbo].[FAMILIES]
(
	[ID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [NAME] VARCHAR(50) NOT NULL, 
    [BILL_ID] UNIQUEIDENTIFIER NOT NULL 
)