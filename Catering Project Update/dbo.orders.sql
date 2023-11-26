CREATE TABLE [dbo].[orders] (
    [orderID]     INT           IDENTITY (1, 1) NOT NULL,
    [customerID]  INT           NOT NULL,
    [menuID]      INT           NOT NULL,
    [itemName]    VARCHAR (50)  NOT NULL,
    [qty]         INT           DEFAULT ((1)) NOT NULL,
    [dateOrdered] DATE          NOT NULL,
    [datePickUp]  DATE          NOT NULL,
    [Notes]       VARCHAR (150) NULL,
    PRIMARY KEY CLUSTERED ([orderID] ASC)
);

