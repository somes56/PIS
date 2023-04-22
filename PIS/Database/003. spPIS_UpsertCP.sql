USE [PIS]
GO

DROP PROCEDURE [dbo].[spPIS_UpsertCP]
GO

/****** Object:  StoredProcedure [dbo].[spPIS_UpsertCP]    Script Date: 22/4/2023 3:47:06 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spPIS_UpsertCP] 

	@id int,
	@pkg_type tinyint,
	@cust_id int,
	@voyage_id int,
	@eta smalldatetime,
	@closing_time smalldatetime,
	@booking_ref varchar(100),
	@dest_id int,
	@container_no varchar(20),
	@size_id int,
	@ship_type tinyint,
	@location varchar(50),
	@opr_id int,
	@vgm tinyint,
	@gang tinyint,
	@terminal tinyint,
	@seal_no varchar(10),
	@k8_no varchar(20),
	@mt_point_id int,
	@ledger_acc tinyint,
	@pack_date smalldatetime,
	@cargo_pack_by varchar(50),
	@tally_pack_by varchar(50),
	@check_by varchar(50),
	@issue_invoice tinyint,
	@uuser smallint

AS
BEGIN

	SET NOCOUNT ON;

	DECLARE @CPID int = 0;

	IF EXISTS(SELECT * FROM [dbo].[CP] WHERE id = @id)
	BEGIN

		UPDATE [dbo].[CP] SET
			pkg_type = @pkg_type,
			cust_id = @cust_id,
			voyage_id = @voyage_id,
			eta = @eta,
			closing_time = @closing_time,
			booking_ref = @booking_ref,
			dest_id = @dest_id,
			container_no = @container_no,
			size_id = @size_id,
			ship_type = @ship_type,
			location = @location,
			opr_id = @opr_id,
			vgm = @vgm,
			gang = @gang,
			terminal = @terminal,
			seal_no = @seal_no,
			k8_no = @k8_no,
			mt_point_id = @mt_point_id,
			ledger_acc = @ledger_acc,
			pack_date = @pack_date,
			cargo_pack_by = @cargo_pack_by,
			tally_pack_by = @tally_pack_by,
			check_by = @check_by,
			issue_invoice = @issue_invoice,
			udate = GETDATE(),
			uuser = @uuser
		WHERE
			id = @id

		SELECT @CPID = @id

	END
	ELSE
	BEGIN

		INSERT INTO [dbo].[CP](
			pkg_type,
			cust_id,
			voyage_id,
			eta,
			closing_time,
			booking_ref,
			dest_id,
			container_no,
			size_id,
			ship_type,
			location,
			opr_id,
			vgm,
			gang,
			terminal,
			seal_no,
			k8_no,
			mt_point_id,
			ledger_acc,
			pack_date,
			cargo_pack_by,
			tally_pack_by,
			check_by,
			issue_invoice,
			cdate,
			udate,
			cuser,
			uuser
		)VALUES(
			@pkg_type,
			@cust_id,
			@voyage_id,
			@eta,
			@closing_time,
			@booking_ref,
			@dest_id,
			@container_no,
			@size_id,
			@ship_type,
			@location,
			@opr_id,
			@vgm,
			@gang,
			@terminal,
			@seal_no,
			@k8_no,
			@mt_point_id,
			@ledger_acc,
			@pack_date,
			@cargo_pack_by,
			@tally_pack_by,
			@check_by,
			@issue_invoice,
			GETDATE(),
			GETDATE(),
			@uuser,
			@uuser
		)

		SELECT @CPID = SCOPE_IDENTITY()

	END

	SELECT @CPID AS CPID

END


GO


