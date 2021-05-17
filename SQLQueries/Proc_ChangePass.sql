USE [Test website]
GO

/****** Object:  StoredProcedure [dbo].[Proc_ChangePass]    Script Date: 1/5/2021 3:41:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Proc_ChangePass]
    @UserId int,
	@PasswordHash NVARCHAR(MAX),
    @responseMessage NVARCHAR(250) OUTPUT
AS
BEGIN
    SET NOCOUNT ON

    DECLARE @salt UNIQUEIDENTIFIER=NEWID()
	 BEGIN TRY
	 Update Users  SET salt=@salt,PasswordHash=HASHBYTES('SHA2_512', @PasswordHash+CAST(@salt AS NVARCHAR(36)))
	 WHERE UserId=@UserId
    SET @responseMessage='Success'

    END TRY
    BEGIN CATCH
        SET @responseMessage=ERROR_MESSAGE() 
    END CATCH

END


GO

