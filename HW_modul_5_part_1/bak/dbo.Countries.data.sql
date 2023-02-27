SET IDENTITY_INSERT [dbo].[Countries] ON
INSERT INTO [dbo].[Countries] ([Id], [Name], [Area], [PartOfWorld]) VALUES (1, N'Россия', CAST(17125193.00 AS Decimal(18, 2)), 1)
INSERT INTO [dbo].[Countries] ([Id], [Name], [Area], [PartOfWorld]) VALUES (2, N'Канада', CAST(9984670.00 AS Decimal(18, 2)), 4)
INSERT INTO [dbo].[Countries] ([Id], [Name], [Area], [PartOfWorld]) VALUES (3, N' Китай', CAST(9598962.00 AS Decimal(18, 2)), 2)
INSERT INTO [dbo].[Countries] ([Id], [Name], [Area], [PartOfWorld]) VALUES (4, N'rthtrh', CAST(6.00 AS Decimal(18, 2)), 4)
SET IDENTITY_INSERT [dbo].[Countries] OFF
