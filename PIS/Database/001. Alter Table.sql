USE PIS;

ALTER TABLE [dbo].[CFS] ALTER COLUMN reference_no VARCHAR(100);

ALTER TABLE [dbo].[CP] ALTER COLUMN booking_ref VARCHAR(100);

ALTER TABLE [dbo].[M_CompanyInfo] ALTER COLUMN email NVARCHAR(100);