--DECLARE @empid INT;
DECLARE @grandsalary INT;
DECLARE employ_cursor CURSOR 
FOR 
SELECT @grandsalary FROM Persons ORDER BY PersonID;
OPEN employ_cursor;
FETCH NEXT FROM employ_cursor INTO @empid;
WHILE @@FETCH_STATUS=0
BEGIN
FETCH NEXT FROM employ_cursor INTO @empid;
END
CLOSE employ_cursor;
DEALLOCATE employ_cursor;