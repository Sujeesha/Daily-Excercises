DECLARE @salary money;
DECLARE @grand_salary money;
DECLARE @total int;
SET @total=0;
DECLARE salary_cursor CURSOR
FOR
SELECT salary from EmpSalary;
OPEN orders_cursor
FETCH NEXT FROM salary_cursor into @salary
WHILE @@FETCH_STATUS=0
BEGIN
EXECUTE @total @salary,
@total output
SET @grand_salary=@grand_salary+@salary
FETCH NEXT FROM salary_cursor
INTO @grandsalary;
Begin
Print 'total salary='+@grandsalary;
CLOSE salary_cursor;
DEALLOCATE salary_cursor;