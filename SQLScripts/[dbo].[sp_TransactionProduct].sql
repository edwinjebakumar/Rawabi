USE [Rawabi]
GO
/****** Object:  StoredProcedure [dbo].[sp_TransactionProduct]    Script Date: 8/15/2022 11:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[sp_TransactionProduct]
	-- Add the parameters for the stored procedure here
	@ProductId int,
	@Quantity int,
	@TranType nvarchar(50),
	@TranDate datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[Transaction]
           (
           [TranType]
           ,[ProductId]
           ,[Quantity]
           ,[TranDate])
     VALUES
           (
           @TranType
           ,@ProductId
           ,@Quantity
           ,@TranDate)
END
