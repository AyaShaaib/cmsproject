USE [Test website]
GO

/****** Object:  StoredProcedure [dbo].[Proc_UserLogin]    Script Date: 1/5/2021 3:40:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Proc_UserLogin]
    @Email NVARCHAR(254),
    @Password NVARCHAR(50),
    @responseMessage int OUTPUT
AS
BEGIN

    SET NOCOUNT ON

    DECLARE @userID INT

    IF EXISTS (SELECT TOP 1 UserID FROM Users WHERE Email=@Email)
		BEGIN
			SET @userID=(SELECT UserID FROM Users WHERE Email=@Email AND PasswordHash=HASHBYTES('SHA2_512',@Password+CAST(salt AS NVARCHAR(36))))

		IF(@userID IS NULL)
           SET @responseMessage= 0
		ELSE 
           SET @responseMessage= 1
		    END
    ELSE
       SET @responseMessage= -1
END
GO

