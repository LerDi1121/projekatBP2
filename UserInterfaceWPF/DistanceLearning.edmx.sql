
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/25/2021 15:23:18
-- Generated from EDMX file: C:\Users\banes\source\repos\projekatBP2\UserInterfaceWPF\DistanceLearning.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DataBase2];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Messages'
CREATE TABLE [dbo].[Messages] (
    [Id_Message] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Posting_date] datetime  NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [User_Id_User] int  NOT NULL
);
GO

-- Creating table 'Receives'
CREATE TABLE [dbo].[Receives] (
    [Id_Receives] int IDENTITY(1,1) NOT NULL,
    [Date_of_deletion] datetime  NOT NULL,
    [Date_of_reading] datetime  NOT NULL,
    [Users_Id_User] int  NOT NULL,
    [Messages_Id_Message] int  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id_User] int IDENTITY(1,1) NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Surname] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Role] int  NOT NULL,
    [eMail] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Courses'
CREATE TABLE [dbo].[Courses] (
    [Id_Course] int IDENTITY(1,1) NOT NULL,
    [Course_name] nvarchar(max)  NOT NULL,
    [Course_status] int  NOT NULL,
    [Teacher_Id_User] int  NOT NULL
);
GO

-- Creating table 'Registereds'
CREATE TABLE [dbo].[Registereds] (
    [Id_Registered] int IDENTITY(1,1) NOT NULL,
    [Application_date] datetime  NOT NULL,
    [Student_Id_User] int  NULL,
    [Course_Id_Course] int  NULL
);
GO

-- Creating table 'Teaching_topic'
CREATE TABLE [dbo].[Teaching_topic] (
    [Id_Teaching_topic] int IDENTITY(1,1) NOT NULL,
    [Topic_name] nvarchar(max)  NOT NULL,
    [Serial_number] int  NOT NULL,
    [Course_Id_Course] int  NOT NULL
);
GO

-- Creating table 'Test'
CREATE TABLE [dbo].[Test] (
    [Id_Test] int IDENTITY(1,1) NOT NULL,
    [Test_Name] nvarchar(max)  NOT NULL,
    [Points] int  NOT NULL,
    [Course_Id_Course] int  NOT NULL
);
GO

-- Creating table 'Questions'
CREATE TABLE [dbo].[Questions] (
    [Id_Question] int IDENTITY(1,1) NOT NULL,
    [Tekst] nvarchar(max)  NOT NULL,
    [Level] int  NOT NULL,
    [Total_points] int  NOT NULL
);
GO

-- Creating table 'Answers'
CREATE TABLE [dbo].[Answers] (
    [Id_Answers] int IDENTITY(1,1) NOT NULL,
    [Tekst] nvarchar(max)  NOT NULL,
    [Correct] bit  NOT NULL,
    [Question_Id_Question] int  NOT NULL
);
GO

-- Creating table 'Takes'
CREATE TABLE [dbo].[Takes] (
    [Id_Takes] int IDENTITY(1,1) NOT NULL,
    [Won_points] int  NOT NULL,
    [Start_time] datetime  NOT NULL,
    [Completion_time] datetime  NOT NULL,
    [Date_of_taking] datetime  NOT NULL,
    [Test_Id_Test] int  NULL,
    [Registered_Id_Registered] int  NULL,
    [Marks_Id_Mark] int  NULL
);
GO

-- Creating table 'Mark'
CREATE TABLE [dbo].[Mark] (
    [Id_Mark] int IDENTITY(1,1) NOT NULL,
    [Description_of_mark] nvarchar(max)  NOT NULL,
    [Value_of_Mark] int  NOT NULL
);
GO

-- Creating table 'Users_Teacher'
CREATE TABLE [dbo].[Users_Teacher] (
    [Id_Teacher] int IDENTITY(1,1) NOT NULL,
    [Proession] nvarchar(max)  NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Id_User] int  NOT NULL
);
GO

-- Creating table 'Users_Student'
CREATE TABLE [dbo].[Users_Student] (
    [Id_Student] int IDENTITY(1,1) NOT NULL,
    [Class] nvarchar(max)  NOT NULL,
    [Id_User] int  NOT NULL
);
GO

-- Creating table 'ConsistsOf'
CREATE TABLE [dbo].[ConsistsOf] (
    [Tests_Id_Test] int  NOT NULL,
    [Questions_Id_Question] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id_Message] in table 'Messages'
ALTER TABLE [dbo].[Messages]
ADD CONSTRAINT [PK_Messages]
    PRIMARY KEY CLUSTERED ([Id_Message] ASC);
GO

-- Creating primary key on [Id_Receives] in table 'Receives'
ALTER TABLE [dbo].[Receives]
ADD CONSTRAINT [PK_Receives]
    PRIMARY KEY CLUSTERED ([Id_Receives] ASC);
GO

-- Creating primary key on [Id_User] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id_User] ASC);
GO

-- Creating primary key on [Id_Course] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [PK_Courses]
    PRIMARY KEY CLUSTERED ([Id_Course] ASC);
GO

-- Creating primary key on [Id_Registered] in table 'Registereds'
ALTER TABLE [dbo].[Registereds]
ADD CONSTRAINT [PK_Registereds]
    PRIMARY KEY CLUSTERED ([Id_Registered] ASC);
GO

-- Creating primary key on [Id_Teaching_topic] in table 'Teaching_topic'
ALTER TABLE [dbo].[Teaching_topic]
ADD CONSTRAINT [PK_Teaching_topic]
    PRIMARY KEY CLUSTERED ([Id_Teaching_topic] ASC);
GO

-- Creating primary key on [Id_Test] in table 'Test'
ALTER TABLE [dbo].[Test]
ADD CONSTRAINT [PK_Test]
    PRIMARY KEY CLUSTERED ([Id_Test] ASC);
GO

-- Creating primary key on [Id_Question] in table 'Questions'
ALTER TABLE [dbo].[Questions]
ADD CONSTRAINT [PK_Questions]
    PRIMARY KEY CLUSTERED ([Id_Question] ASC);
GO

-- Creating primary key on [Id_Answers] in table 'Answers'
ALTER TABLE [dbo].[Answers]
ADD CONSTRAINT [PK_Answers]
    PRIMARY KEY CLUSTERED ([Id_Answers] ASC);
GO

-- Creating primary key on [Id_Takes] in table 'Takes'
ALTER TABLE [dbo].[Takes]
ADD CONSTRAINT [PK_Takes]
    PRIMARY KEY CLUSTERED ([Id_Takes] ASC);
GO

-- Creating primary key on [Id_Mark] in table 'Mark'
ALTER TABLE [dbo].[Mark]
ADD CONSTRAINT [PK_Mark]
    PRIMARY KEY CLUSTERED ([Id_Mark] ASC);
GO

-- Creating primary key on [Id_User] in table 'Users_Teacher'
ALTER TABLE [dbo].[Users_Teacher]
ADD CONSTRAINT [PK_Users_Teacher]
    PRIMARY KEY CLUSTERED ([Id_User] ASC);
GO

-- Creating primary key on [Id_User] in table 'Users_Student'
ALTER TABLE [dbo].[Users_Student]
ADD CONSTRAINT [PK_Users_Student]
    PRIMARY KEY CLUSTERED ([Id_User] ASC);
GO

-- Creating primary key on [Tests_Id_Test], [Questions_Id_Question] in table 'ConsistsOf'
ALTER TABLE [dbo].[ConsistsOf]
ADD CONSTRAINT [PK_ConsistsOf]
    PRIMARY KEY CLUSTERED ([Tests_Id_Test], [Questions_Id_Question] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Users_Id_User] in table 'Receives'
ALTER TABLE [dbo].[Receives]
ADD CONSTRAINT [FK_ReceiveUser]
    FOREIGN KEY ([Users_Id_User])
    REFERENCES [dbo].[Users]
        ([Id_User])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReceiveUser'
CREATE INDEX [IX_FK_ReceiveUser]
ON [dbo].[Receives]
    ([Users_Id_User]);
GO

-- Creating foreign key on [Messages_Id_Message] in table 'Receives'
ALTER TABLE [dbo].[Receives]
ADD CONSTRAINT [FK_MessageReceive]
    FOREIGN KEY ([Messages_Id_Message])
    REFERENCES [dbo].[Messages]
        ([Id_Message])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MessageReceive'
CREATE INDEX [IX_FK_MessageReceive]
ON [dbo].[Receives]
    ([Messages_Id_Message]);
GO

-- Creating foreign key on [User_Id_User] in table 'Messages'
ALTER TABLE [dbo].[Messages]
ADD CONSTRAINT [FK_Sends]
    FOREIGN KEY ([User_Id_User])
    REFERENCES [dbo].[Users]
        ([Id_User])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Sends'
CREATE INDEX [IX_FK_Sends]
ON [dbo].[Messages]
    ([User_Id_User]);
GO

-- Creating foreign key on [Teacher_Id_User] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [FK_Creates]
    FOREIGN KEY ([Teacher_Id_User])
    REFERENCES [dbo].[Users_Teacher]
        ([Id_User])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Creates'
CREATE INDEX [IX_FK_Creates]
ON [dbo].[Courses]
    ([Teacher_Id_User]);
GO

-- Creating foreign key on [Student_Id_User] in table 'Registereds'
ALTER TABLE [dbo].[Registereds]
ADD CONSTRAINT [FK_RegisteredStudent]
    FOREIGN KEY ([Student_Id_User])
    REFERENCES [dbo].[Users_Student]
        ([Id_User])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RegisteredStudent'
CREATE INDEX [IX_FK_RegisteredStudent]
ON [dbo].[Registereds]
    ([Student_Id_User]);
GO

-- Creating foreign key on [Course_Id_Course] in table 'Registereds'
ALTER TABLE [dbo].[Registereds]
ADD CONSTRAINT [FK_RegisteredCourse]
    FOREIGN KEY ([Course_Id_Course])
    REFERENCES [dbo].[Courses]
        ([Id_Course])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RegisteredCourse'
CREATE INDEX [IX_FK_RegisteredCourse]
ON [dbo].[Registereds]
    ([Course_Id_Course]);
GO

-- Creating foreign key on [Course_Id_Course] in table 'Teaching_topic'
ALTER TABLE [dbo].[Teaching_topic]
ADD CONSTRAINT [FK_Contains]
    FOREIGN KEY ([Course_Id_Course])
    REFERENCES [dbo].[Courses]
        ([Id_Course])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Contains'
CREATE INDEX [IX_FK_Contains]
ON [dbo].[Teaching_topic]
    ([Course_Id_Course]);
GO

-- Creating foreign key on [Course_Id_Course] in table 'Test'
ALTER TABLE [dbo].[Test]
ADD CONSTRAINT [FK_TestCourse]
    FOREIGN KEY ([Course_Id_Course])
    REFERENCES [dbo].[Courses]
        ([Id_Course])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TestCourse'
CREATE INDEX [IX_FK_TestCourse]
ON [dbo].[Test]
    ([Course_Id_Course]);
GO

-- Creating foreign key on [Test_Id_Test] in table 'Takes'
ALTER TABLE [dbo].[Takes]
ADD CONSTRAINT [FK_TakesTest]
    FOREIGN KEY ([Test_Id_Test])
    REFERENCES [dbo].[Test]
        ([Id_Test])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TakesTest'
CREATE INDEX [IX_FK_TakesTest]
ON [dbo].[Takes]
    ([Test_Id_Test]);
GO

-- Creating foreign key on [Question_Id_Question] in table 'Answers'
ALTER TABLE [dbo].[Answers]
ADD CONSTRAINT [FK_HasTheAnswer]
    FOREIGN KEY ([Question_Id_Question])
    REFERENCES [dbo].[Questions]
        ([Id_Question])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HasTheAnswer'
CREATE INDEX [IX_FK_HasTheAnswer]
ON [dbo].[Answers]
    ([Question_Id_Question]);
GO

-- Creating foreign key on [Registered_Id_Registered] in table 'Takes'
ALTER TABLE [dbo].[Takes]
ADD CONSTRAINT [FK_TakesRegistered]
    FOREIGN KEY ([Registered_Id_Registered])
    REFERENCES [dbo].[Registereds]
        ([Id_Registered])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TakesRegistered'
CREATE INDEX [IX_FK_TakesRegistered]
ON [dbo].[Takes]
    ([Registered_Id_Registered]);
GO

-- Creating foreign key on [Marks_Id_Mark] in table 'Takes'
ALTER TABLE [dbo].[Takes]
ADD CONSTRAINT [FK_GetsAGrade]
    FOREIGN KEY ([Marks_Id_Mark])
    REFERENCES [dbo].[Mark]
        ([Id_Mark])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GetsAGrade'
CREATE INDEX [IX_FK_GetsAGrade]
ON [dbo].[Takes]
    ([Marks_Id_Mark]);
GO

-- Creating foreign key on [Tests_Id_Test] in table 'ConsistsOf'
ALTER TABLE [dbo].[ConsistsOf]
ADD CONSTRAINT [FK_ConsistsOf_Test]
    FOREIGN KEY ([Tests_Id_Test])
    REFERENCES [dbo].[Test]
        ([Id_Test])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Questions_Id_Question] in table 'ConsistsOf'
ALTER TABLE [dbo].[ConsistsOf]
ADD CONSTRAINT [FK_ConsistsOf_Question]
    FOREIGN KEY ([Questions_Id_Question])
    REFERENCES [dbo].[Questions]
        ([Id_Question])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsistsOf_Question'
CREATE INDEX [IX_FK_ConsistsOf_Question]
ON [dbo].[ConsistsOf]
    ([Questions_Id_Question]);
GO

-- Creating foreign key on [Id_User] in table 'Users_Teacher'
ALTER TABLE [dbo].[Users_Teacher]
ADD CONSTRAINT [FK_Teacher_inherits_User]
    FOREIGN KEY ([Id_User])
    REFERENCES [dbo].[Users]
        ([Id_User])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id_User] in table 'Users_Student'
ALTER TABLE [dbo].[Users_Student]
ADD CONSTRAINT [FK_Student_inherits_User]
    FOREIGN KEY ([Id_User])
    REFERENCES [dbo].[Users]
        ([Id_User])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------