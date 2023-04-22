USE [PIS]
GO

DROP PROCEDURE [dbo].[spPIS_UpsertCFS]
GO

/****** Object:  StoredProcedure [dbo].[spPIS_UpsertCFS]    Script Date: 22/4/2023 3:38:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spPIS_UpsertCFS] 

	@id int,
	@cfs_no varchar(15),
	@shipper_id int,
	@discharge_port_id int,
	@final_port_id int,
	@vessel_id int,
	@qty int,
	@unit_id smallint,
	@weight decimal(10,3),
	@volume decimal(10,3),
	@marking varchar(100),
	@cargo_desc varchar(200),
	@reference_no varchar(100),
	@remarks varchar(200),
	@date_receive smalldatetime,
	@time_receive smalldatetime,
	@receive_by varchar(50),
	@location varchar(50),
	@uuser tinyint

AS
BEGIN

	SET NOCOUNT ON;

	IF EXISTS(SELECT * FROM [dbo].[CFS] WHERE id = @id)
	BEGIN

		UPDATE [dbo].[CFS] SET
			cfs_no = @cfs_no,
			shipper_id = @shipper_id,
			discharge_port_id = @discharge_port_id,
			final_port_id = @final_port_id,
			vessel_id = @vessel_id,
			qty = @qty,
			unit_id = @unit_id,
			[weight] = @weight,
			volume = @volume,
			marking = @marking,
			cargo_desc = @cargo_desc,
			reference_no = @reference_no,
			remarks = @remarks,
			date_receive = @date_receive,
			time_receive = @time_receive,
			receive_by = @receive_by,
			location = @location,
			uuser = @uuser,
			udate = GETDATE()
		WHERE
			id = @id

	END
	ELSE
	BEGIN

		INSERT INTO [dbo].[CFS](
			cfs_no,
			shipper_id,
			discharge_port_id,
			final_port_id,
			vessel_id,
			qty,
			unit_id,
			[weight],
			volume,
			marking,
			cargo_desc,
			reference_no,
			remarks,
			date_receive,
			time_receive,
			receive_by,
			location,
			cdate,
			udate,
			cuser,
			uuser
		)VALUES(
			@cfs_no,
			@shipper_id,
			@discharge_port_id,
			@final_port_id,
			@vessel_id,
			@qty,
			@unit_id,
			@weight,
			@volume,
			@marking,
			@cargo_desc,
			@remarks,
			@reference_no,
			@date_receive,
			@time_receive,
			@receive_by,
			@location,
			GETDATE(),
			GETDATE(),
			@uuser,
			@uuser
		)

	END

END



GO


