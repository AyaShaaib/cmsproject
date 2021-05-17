USE [Test website]
GO

/****** Object:  StoredProcedure [dbo].[Proc_AddUser]    Script Date: 1/5/2021 3:41:20 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Proc_AddUser]
    @Fname NVARCHAR(255),
    @Lname NVARCHAR(255),
	@Email NVARCHAR(255),
	@PhoneNumber NVARCHAR(50),
	@PasswordHash NVARCHAR(MAX),
    @responseMessage NVARCHAR(250) OUTPUT
AS
IF NOT EXISTS(SELECT * FROM Users WHERE Email =@Email)   
BEGIN
    SET NOCOUNT ON

    DECLARE @salt UNIQUEIDENTIFIER=NEWID()
    BEGIN TRY
		INSERT INTO Users (salt,Fname,Lname,Email, PasswordHash,PhoneNumber)
        VALUES( @salt, @Fname,@Lname,@Email,HASHBYTES('SHA2_512', @PasswordHash+CAST(@salt AS NVARCHAR(36))),@PhoneNumber)

       SET @responseMessage='Success'

    END TRY
    BEGIN CATCH
        SET @responseMessage=ERROR_MESSAGE() 
    END CATCH
	
END
ELSE
	set @responseMessage='email already exists'


GO

