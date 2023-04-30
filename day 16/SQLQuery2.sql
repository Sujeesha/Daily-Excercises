CREATE OR ALTER PROCEDURE ShowEmpWithId(@empid int)
AS
BEGIN
    SELECT * FROM [EMPDB].[dbo].[Persons] WHERE PersonId=@empid;
END

exec ShowEmpWithId i