IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230904030411_Initial')
BEGIN
    CREATE TABLE [Contacts] (
        [ContactId] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [Phone] bigint NOT NULL,
        [Address] nvarchar(max) NOT NULL,
        [Note] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Contacts] PRIMARY KEY ([ContactId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230904030411_Initial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ContactId', N'Address', N'Name', N'Note', N'Phone') AND [object_id] = OBJECT_ID(N'[Contacts]'))
        SET IDENTITY_INSERT [Contacts] ON;
    EXEC(N'INSERT INTO [Contacts] ([ContactId], [Address], [Name], [Note], [Phone])
    VALUES (1, N''2637 Kinsey Ave.'', N''Trevor Steart'', N''C# Student'', CAST(15154025466 AS bigint)),
    (2, N''1234 Nunya Bidniss Ln.'', N''Amber Lang'', N''Cousin'', CAST(15154025466 AS bigint)),
    (3, N''2345 Wrogn Direksun Blvd.'', N''Amy Cole'', N''Cousin'', CAST(15154025466 AS bigint))');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ContactId', N'Address', N'Name', N'Note', N'Phone') AND [object_id] = OBJECT_ID(N'[Contacts]'))
        SET IDENTITY_INSERT [Contacts] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230904030411_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230904030411_Initial', N'7.0.10');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230905150438_Azure')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230905150438_Azure', N'7.0.10');
END;
GO

COMMIT;
GO

