CREATE TABLE [dbo].[Orders]
(
	[OrderId] INT NOT NULL PRIMARY KEY IDENTITY,
	[CustId] INT NOT NULL,
	[DroneId] INT NOT NULL,
	CONSTRAINT [FK_Orders_Inventory] FOREIGN KEY ([DroneId]) REFERENCES [Inventory]([DroneId]),
	CONSTRAINT [FK_Orders_Customers] FOREIGN KEY ([CustId]) REFERENCES [dbo].[Customers]([CustId]),

)