﻿CREATE TABLE [dbo].[accountTbl] (
    [id]       INT          NOT NULL,
    [fName]    VARCHAR (30) NOT NULL,
    [lName]    VARCHAR (30) NOT NULL,
    [password] VARCHAR (30) NOT NULL,
    [email]    VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[categoryTbl] (
    [id]          INT NOT NULL,
    [measurement] INT NOT NULL,
    [mill]        INT NOT NULL,
    [lathe]       INT NOT NULL,
    [handTool]    INT NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[inUseTbl] (
    [id]        INT  NOT NULL,
    [toolId]    INT  NOT NULL,
    [accountId] INT  NOT NULL,
    [date]      DATE NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_inUseTbl_accountTbl] FOREIGN KEY ([accountId]) REFERENCES [dbo].[accountTbl] ([id]),
    CONSTRAINT [FK_inUseTbl_toolTbl] FOREIGN KEY ([toolId]) REFERENCES [dbo].[toolTbl] ([id])
);

CREATE TABLE [dbo].[programTbl] (
    [id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[toolTbl] (
    [id]         INT          NOT NULL,
    [name]       VARCHAR (50) NOT NULL,
    [imperial]   FLOAT (53)   NULL,
    [metric]     FLOAT (53)   NULL,
    [qty]        INT          NULL,
    [categoryId] INT          NULL,
    [programId]  INT          NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_toolTbl_categoryTbl] FOREIGN KEY ([categoryId]) REFERENCES [dbo].[categoryTbl] ([id]),
    CONSTRAINT [FK_toolTbl_programTbl] FOREIGN KEY ([programId]) REFERENCES [dbo].[programTbl] ([id])
);

