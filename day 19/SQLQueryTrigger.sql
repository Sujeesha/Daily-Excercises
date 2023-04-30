CREATE TRIGGER new_trigger ON EmpSalary
AFTER INSERT
AS
SELECT 'Row Created';