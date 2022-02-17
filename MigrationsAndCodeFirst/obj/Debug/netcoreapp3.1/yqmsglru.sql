IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Teachers] (
    [TeacherId] int NOT NULL IDENTITY,
    [TeacherName] nvarchar(max) NULL,
    CONSTRAINT [PK_Teachers] PRIMARY KEY ([TeacherId])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220216064506_AddTeacherMigration', N'3.1.0');

GO

CREATE TABLE [StudentMaster] (
    [StudentId] int NOT NULL IDENTITY,
    [StudentName] nvarchar(20) NULL,
    CONSTRAINT [PK_StudentMaster] PRIMARY KEY ([StudentId])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220216070158_AddStudentMigration', N'3.1.0');

GO

