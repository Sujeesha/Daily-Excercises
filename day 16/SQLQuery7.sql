CREATE OR ALTER PROCEDURE ShowEmpWithId(@empid int)
AS
BEGIN
    SELECT * FROM Table_3 WHERE PersonId=@empid;
END

exec ShowEmpWithId i