USE [Test website]
GO

/****** Object:  StoredProcedure [dbo].[Proc_AddSettings]    Script Date: 1/5/2021 3:41:59 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Proc_AddSettings]
    @SenderEmail NVARCHAR(255),
    @RecieverEmail NVARCHAR(255),
	@FacebookLink NVARCHAR(255),
	@TwitterLink NVARCHAR(255),
	@InstagramLink NVARCHAR(255),
	@YoutubeLink NVARCHAR(255),
	@Smtp NVARCHAR(50),
	@SenderPassword NVARCHAR(255),
    @responseMessage NVARCHAR(250) OUTPUT
AS
BEGIN
    SET NOCOUNT ON

    DECLARE @salt UNIQUEIDENTIFIER=NEWID()
    BEGIN TRY

        INSERT INTO Settings(salt,SenderEmail,RecieverEmail,FacebookLink, TwitterLink,InstagramLink,YoutubeLink,Smtp,SenderPassword)
        VALUES( @salt, @SenderEmail,@RecieverEmail,@FacebookLink,@TwitterLink,@InstagramLink,@YoutubeLink,@Smtp,HASHBYTES('SHA2_512', @SenderPassword+CAST(@salt AS NVARCHAR(36))))

       SET @responseMessage='Success'

    END TRY
    BEGIN CATCH
        SET @responseMessage=ERROR_MESSAGE() 
    END CATCH

END


GO

