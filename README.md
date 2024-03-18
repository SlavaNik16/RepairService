# RepairService

![image](https://github.com/SlavaNik16/RepairService/assets/70444635/169650a5-4093-4b53-ba8a-340fc2bfd08d)

---
Enum RoleType - тип перечисления, так как он не как не участвуют в моем Application Domain, и я ему не должен делать матрицу компетенций. 

Это делает код более быстрым и читаемым!!!

Enum Status - тип перечисления, он сделан не в виде отдельной таблицы, по той-же причине.


```
USE [RepairServiceDB]
GO
SET IDENTITY_INSERT [dbo].[BrokenTypes] ON 

INSERT [dbo].[BrokenTypes] ([Id], [Title]) VALUES (1, N'Test1')
INSERT [dbo].[BrokenTypes] ([Id], [Title]) VALUES (2, N'Test2')
INSERT [dbo].[BrokenTypes] ([Id], [Title]) VALUES (3, N'Test3')
INSERT [dbo].[BrokenTypes] ([Id], [Title]) VALUES (4, N'Test4')
SET IDENTITY_INSERT [dbo].[BrokenTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Surname], [Name], [Patronymic], [Login], [Password], [RoleType]) VALUES (1, N'Николаев ', N'Вячеслав', N'Алексеевич', N'123', N'123', 2)
INSERT [dbo].[Users] ([Id], [Surname], [Name], [Patronymic], [Login], [Password], [RoleType]) VALUES (2, N'Test', N'Test', N'Test', N'Test', N'Test', 0)
INSERT [dbo].[Users] ([Id], [Surname], [Name], [Patronymic], [Login], [Password], [RoleType]) VALUES (3, N'Бажин', N'Кирилл', N'', N'1', N'1', 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[EquipmentTypes] ON 

INSERT [dbo].[EquipmentTypes] ([Id], [Title]) VALUES (1, N'Yes1')
INSERT [dbo].[EquipmentTypes] ([Id], [Title]) VALUES (2, N'Yes2')
INSERT [dbo].[EquipmentTypes] ([Id], [Title]) VALUES (3, N'Yes3')
INSERT [dbo].[EquipmentTypes] ([Id], [Title]) VALUES (4, N'Yes4')
SET IDENTITY_INSERT [dbo].[EquipmentTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Equipments] ON 

INSERT [dbo].[Equipments] ([Id], [Title], [SerialNumber], [EquipmentType_Id]) VALUES (1, N'Холодильник', N'45hd', 1)
INSERT [dbo].[Equipments] ([Id], [Title], [SerialNumber], [EquipmentType_Id]) VALUES (2, N'Стиральная машина', N'dsrg4355', 2)
INSERT [dbo].[Equipments] ([Id], [Title], [SerialNumber], [EquipmentType_Id]) VALUES (3, N'Фен', N'3534gre', 3)
INSERT [dbo].[Equipments] ([Id], [Title], [SerialNumber], [EquipmentType_Id]) VALUES (4, N'Яйца', N'rdfgfd54', 4)
INSERT [dbo].[Equipments] ([Id], [Title], [SerialNumber], [EquipmentType_Id]) VALUES (5, N'Машина', N'sdfsdf', 4)
INSERT [dbo].[Equipments] ([Id], [Title], [SerialNumber], [EquipmentType_Id]) VALUES (6, N'Холодильник', N' wefwfew', 3)
SET IDENTITY_INSERT [dbo].[Equipments] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [CreatedAt], [ClientId], [EquipmentId], [BrokenTypeId], [Description], [Priority], [Status]) VALUES (1, CAST(N'2023-10-03T00:00:00.0000000+03:00' AS DateTimeOffset), 1, 1, 1, N'', N'1', 0)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [ClientId], [EquipmentId], [BrokenTypeId], [Description], [Priority], [Status]) VALUES (2, CAST(N'2023-10-03T00:00:00.0000000+03:00' AS DateTimeOffset), 2, 3, 3, N'dsfsfsefs', N'123', 1)
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Reports] ON 

INSERT [dbo].[Reports] ([Id], [OrderId], [Price], [CreatedAt]) VALUES (1, 1, CAST(123.00 AS Decimal(18, 2)), CAST(N'2023-10-11T00:00:00.0000000+03:00' AS DateTimeOffset))
INSERT [dbo].[Reports] ([Id], [OrderId], [Price], [CreatedAt]) VALUES (2, 2, CAST(5464.00 AS Decimal(18, 2)), CAST(N'2023-12-01T00:00:00.0000000+03:00' AS DateTimeOffset))
INSERT [dbo].[Reports] ([Id], [OrderId], [Price], [CreatedAt]) VALUES (3, 1, CAST(2342.00 AS Decimal(18, 2)), CAST(N'2045-10-01T00:00:00.0000000+03:00' AS DateTimeOffset))
SET IDENTITY_INSERT [dbo].[Reports] OFF
GO
INSERT [dbo].[UserOrders] ([User_Id], [Order_Id]) VALUES (1, 1)
INSERT [dbo].[UserOrders] ([User_Id], [Order_Id]) VALUES (2, 1)
INSERT [dbo].[UserOrders] ([User_Id], [Order_Id]) VALUES (2, 2)
GO
SET IDENTITY_INSERT [dbo].[SparesTypes] ON 

INSERT [dbo].[SparesTypes] ([Id], [Title]) VALUES (1, N'No1')
INSERT [dbo].[SparesTypes] ([Id], [Title]) VALUES (2, N'No2')
INSERT [dbo].[SparesTypes] ([Id], [Title]) VALUES (3, N'No3')
INSERT [dbo].[SparesTypes] ([Id], [Title]) VALUES (4, N'No4')
SET IDENTITY_INSERT [dbo].[SparesTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[SparesCounts] ON 

INSERT [dbo].[SparesCounts] ([Id], [Count], [SparesTypeId]) VALUES (1, 10, 1)
INSERT [dbo].[SparesCounts] ([Id], [Count], [SparesTypeId]) VALUES (2, 3, 2)
INSERT [dbo].[SparesCounts] ([Id], [Count], [SparesTypeId]) VALUES (3, 43, 4)
INSERT [dbo].[SparesCounts] ([Id], [Count], [SparesTypeId]) VALUES (4, 23, 1)
INSERT [dbo].[SparesCounts] ([Id], [Count], [SparesTypeId]) VALUES (5, 43, 3)
SET IDENTITY_INSERT [dbo].[SparesCounts] OFF
GO
```
