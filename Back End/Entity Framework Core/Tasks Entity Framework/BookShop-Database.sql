-------------------------------------------------------------------
-- This script will create a sample database "BookShop" in        --
-- MS SQL Server and will populate sample data in its tables.    --
-------------------------------------------------------------------
USE master
GO

CREATE DATABASE BookShop
GO

USE BookShop
GO

CREATE TABLE [Authors](
	[AuthorId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED 
(
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Books](
	[BookId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](1000) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[AuthorId] [int] NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [Authors] ON 

INSERT [Authors] ([AuthorId], [FirstName], [LastName]) VALUES (1, N'Nayden', N'Vitanov')
INSERT [Authors] ([AuthorId], [FirstName], [LastName]) VALUES (2, N'Deyan', N'Tanev')
INSERT [Authors] ([AuthorId], [FirstName], [LastName]) VALUES (3, N'Desislav', N'Petkov')
INSERT [Authors] ([AuthorId], [FirstName], [LastName]) VALUES (4, N'Dyakon', N'Hristov')
SET IDENTITY_INSERT [Authors] OFF
GO
SET IDENTITY_INSERT [Books] ON 

INSERT [Books] ([BookId], [Title], [Description], [Price], [AuthorId]) VALUES (1, N'Absalom', N'The rise and fall of Thomas Sutpen, a white man born into poverty in West Virginia who moves to Mississippi with the complementary aims of gaining wealth and becoming a powerful family patriarch.', CAST(15.31 AS Decimal(18, 2)), 1)
INSERT [Books] ([BookId], [Title], [Description], [Price], [AuthorId]) VALUES (2, N'Beneath the Bleeding', N'Tony Hill, criminal profiler and hero of TV''s Wire in the Blood, is back in a terrifying psychological thriller from bestselling author Val McDermid.', CAST(23.83 AS Decimal(18, 2)), 4)
INSERT [Books] ([BookId], [Title], [Description], [Price], [AuthorId]) VALUES (3, N'Behold the Man', N'In the novel, Moorcock weaves an existentialist tale about Karl Glogauer, a man who travels from the year 1970 in a time machine to 28 AD, where he hopes to meet the historical Jesus of Nazareth.', CAST(18.01 AS Decimal(18, 2)), 4)
INSERT [Books] ([BookId], [Title], [Description], [Price], [AuthorId]) VALUES (4, N'A Time to Kill', N'In this searing courtroom drama, best-selling author John Grisham probes the savage depths of racial violence as he delivers a compelling tale of uncertain justice in the small southern town of Clanton, Mississippi.', CAST(20.21 AS Decimal(18, 2)), 4)
INSERT [Books] ([BookId], [Title], [Description], [Price], [AuthorId]) VALUES (5, N'As I Lay Dying', N'It is the story of the death of Addie Bundren and her poor, rural family''s quest and motivations-noble or selfish-to honor her wish to be buried in her hometown of Jefferson, Mississippi.', CAST(25.81 AS Decimal(18, 2)), 3)
INSERT [Books] ([BookId], [Title], [Description], [Price], [AuthorId]) VALUES (6, N'Arms and the Man', N'Is a comedy written by George Bernard Shaw, and was first produced in 1894 and published in 1898, and has become one of the most popular plays of George Bernard Shaw.', CAST(24.40 AS Decimal(18, 2)), 3)
INSERT [Books] ([BookId], [Title], [Description], [Price], [AuthorId]) VALUES (7, N'An Evil Cradling', N'Keenan here unveils a tale of resistance, Irish style, incorporating many of the nonviolent methods that Irish patriots have used over the years-fasting and ''''going on the blanket,'''' i.e., choosing to remain naked rather than wear prison clothes.', CAST(3.30 AS Decimal(18, 2)), 3)
INSERT [Books] ([BookId], [Title], [Description], [Price], [AuthorId]) VALUES (8, N'Antic Hay', N'Novel by Aldous Huxley, published in 1923. A satire of post-World War I London intellectuals, the work follows Theodore Gumbril, Jr., the protagonist, and his bohemian friends as they drift aimlessly through their lives in search of happiness.', CAST(38.51 AS Decimal(18, 2)), 3)
INSERT [Books] ([BookId], [Title], [Description], [Price], [AuthorId]) VALUES (9, N'An Acceptable Time', N'Marketed as part of the author''s Time Quintet, An Acceptable Time connects Polly''s adventures with those of her parents, Meg Murry and Calvin O''Keefe, which take place a generation earlier.', CAST(34.64 AS Decimal(18, 2)), 3)
INSERT [Books] ([BookId], [Title], [Description], [Price], [AuthorId]) VALUES (10, N'Wide Sea', N'The book is set during the second world war, and Arthur, an orphaned child, is separated from his beloved sister and sent to the other side of the world.', CAST(24.37 AS Decimal(18, 2)), 2)
INSERT [Books] ([BookId], [Title], [Description], [Price], [AuthorId]) VALUES (11, N'Alone on a Wide', N'A book by Michael Morpurgo, first published in 2006 by HarperCollins. It was inspired by the history of English orphans transported to Australia after World War II. ', CAST(14.99 AS Decimal(18, 2)), 2)
INSERT [Books] ([BookId], [Title], [Description], [Price], [AuthorId]) VALUES (12, N'All the King''s Men', N'All the King''s Men is one of American literature''s definitive political novels, as well as a profound study of human fallibility in politics.', CAST(45.60 AS Decimal(18, 2)), 2)
INSERT [Books] ([BookId], [Title], [Description], [Price], [AuthorId]) VALUES (13, N'All Passion Spent', N'In 1860, as a young girl of 17, Lady Slane nurtures a secret, burning ambition—to become an artist. She becomes, instead, the wife of a great statesman and the mother of six children. ', CAST(7.18 AS Decimal(18, 2)), 2)
INSERT [Books] ([BookId], [Title], [Description], [Price], [AuthorId]) VALUES (14, N'The Alien CornÂ (short story)', N'Included in Maugham''s short-story collection, Six Stories Written in the First Person Singular (1931), and is a telling story in terms of what it reveals about the author''s values and concerns.', CAST(34.56 AS Decimal(18, 2)), 2)
INSERT [Books] ([BookId], [Title], [Description], [Price], [AuthorId]) VALUES (15, N'Alien CornÂ (play)', N'(Original, Play, Broadway) opened in New York City Feb 20, 1933 and played through May 1933.', CAST(5.69 AS Decimal(18, 2)), 1)
INSERT [Books] ([BookId], [Title], [Description], [Price], [AuthorId]) VALUES (16, N'Wilderness!', N'Wilderness is the story of Abel, now an old and ailing man, and his heroic final journey over the snowbound Olympic Mountains.', CAST(5.26 AS Decimal(18, 2)), 1)
INSERT [Books] ([BookId], [Title], [Description], [Price], [AuthorId]) VALUES (17, N'Ah', N'In this richly layered compendium, Aliki, the beloved creator of many award-winning books for children, shares her keen insight about music and all its themes and variations.', CAST(23.71 AS Decimal(18, 2)), 1)
INSERT [Books] ([BookId], [Title], [Description], [Price], [AuthorId]) VALUES (18, N'After Many a Summer Dies the Swan', N'The novel is Huxley''s examination of American culture, particularly what he saw as its narcissism, superficiality, and obsession with youth.', CAST(35.56 AS Decimal(18, 2)), 1)
INSERT [Books] ([BookId], [Title], [Description], [Price], [AuthorId]) VALUES (19, N'Beyond the Mexique Bay', N'In it, he describes his experiences traveling through the Caribbean to Guatemala and southern Mexico in 1933.', CAST(45.45 AS Decimal(18, 2)), 4)
INSERT [Books] ([BookId], [Title], [Description], [Price], [AuthorId]) VALUES (20, N'Blithe Spirit', N'Written in 1941, Blithe Spirit remained the longest-running comedy in British Theatre for years.', CAST(16.68 AS Decimal(18, 2)), 4)
SET IDENTITY_INSERT [Books] OFF
GO

CREATE NONCLUSTERED INDEX [IX_Books_AuthorId] ON [Books]
(
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Authors_AuthorId] FOREIGN KEY([AuthorId])
REFERENCES [Authors] ([AuthorId])
ON DELETE CASCADE
GO
ALTER TABLE [Books] CHECK CONSTRAINT [FK_Books_Authors_AuthorId]
GO
USE [master]
GO
ALTER DATABASE [BookShop] SET  READ_WRITE 
GO