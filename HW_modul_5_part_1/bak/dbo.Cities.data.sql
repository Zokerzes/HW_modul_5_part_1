SET IDENTITY_INSERT [dbo].[Cities] ON
INSERT INTO [dbo].[Cities] ([Id], [Name], [Population], [IsCapital], [CountryId]) VALUES (1, N'Москва', 12600000, 1, 1)
INSERT INTO [dbo].[Cities] ([Id], [Name], [Population], [IsCapital], [CountryId]) VALUES (3, N'Пекин', 21500000, 1, 3)
SET IDENTITY_INSERT [dbo].[Cities] OFF
