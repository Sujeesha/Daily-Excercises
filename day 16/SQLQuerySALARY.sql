CREATE or ALTER PROCEDURE sp_getSalary
@empid INT,@sal money output
as
Begin
select @sal=salary from EmpSalary where empid=@empid;
End;