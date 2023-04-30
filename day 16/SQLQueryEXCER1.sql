--Q1 and Q2

CREATE TABLE JOBS(job_id int,job_title varchar,min_salary money,max_salary money);
CREATE TABLE EMPLOYEES(employee_id int primary key,first_name varchar,last_name varchar,email varchar,phone_number numeric,hire_date date,
job_id int foreign key(job_id) references JOBS(job_id),salary money,commission_pct varchar,manager_id int,
department_id int foreign key(department_id) references departments(department_id));
create table regions(region_id int primary key not null,region_name varchar(20));
create table countries(country_id int primary key not null,country_name varchar(20),region_id int ,foreign key(region_id) references regions(region_id));
create table locations(location_id int primary key not null,street_address varchar(20),postal_code int,city varchar(20),state_province varchar(20),country_id int,
foreign key(country_id) references countries(country_id));
create table departments(department_id int primary key not null,department_name varchar(20),manager_id int ,location_id int,foreign key(location_id) references locations(location_id),);
create table Employees(employee_id int primary key not null,first_name varchar(20),last_name varchar(20),email varchar(20),phone_number numeric,hire_date date,job_id int,
salary money,commition_pct money,manager_id int,department_id int,foreign key(job_id) references Jobs(job_id),foreign key(department_id) references departments(department_id),);
create table job_history(employee_id int,start_date date,end_date date,job_id int,department_id int,foreign key(job_id) references jobs(job_id),
foreign key(employee_id) references employees(employee_id),foreign key(department_id) references departments(department_id));
--Q3
insert into regions values (3001,'Asia');
insert into countries values(2001,'india',3001);
insert into locations values(1001,'Aluva',684567,'Ernakulam','kerala','2001');
insert into jobs values(4001,'trainee',23000,28000);
insert into Employees values(4001,'John ','Smith','abc@gmail.com',98543322,'2023-02-02',23456,23000,5000,456,201);
insert into job_history values(4001,'2023-02-02','2034-02-02',23456,201);
/*Evaluate this SQL statement:
 SELECT ename, sal, 12*sal+100 FROM emp;
The SAL column stores the monthly salary of the employee. Which change must be made to the above
syntax to calculate the annual compensation as "monthly salary plus a monthly bonus of $100, multiplied by12"? */

 select first_name,salary,12*(salary+100) from Employees;

 --In EMP table phno column have 6 digits, change it to 7 digits. Update rows by adding 2 as prefix to each phone number

 update Employees set phone_number='2'+REPLICATE('0',7-len('2'+phone_number))+phone_number
 where len(phone_number)=5;

/*Evaluate this DELETE statement:
 DELETE employee_id, salary, job_id FROM employees WHERE dept_id = 90;
Why does the DELETE statement fail when you execute it? */

 delete from Employees where department_id=90;

--Which statement produces the number of different departments that have employees with last name Smith?

 select distinct(department_id) from Employees where last_name='Smith';

/*You query the database with this SQL statement:
 SELECT empname,hire_date HIREDATE, salary FROM EMP ORDER BY hire_date;
How will the results be sorted? */

 select first_name,last_name,hire_date,salary from Employees order by hire_date asc;

 --The result is stored in ascending order based on the hire date column.This means employees with earliest hire date will appear first in the results.
/*The STUDENT_GRADES table has these columns:
STUDENT_ID NUMBER(12)
SEMESTER_END DATE
GPA NUMBER(4,3)
The registrar requested a report listing the students' grade point averages (GPA) sorted from highest grade
point average to lowest. Write Query. */
 
 select student_id,semester_end,gpa from student_grades order by semester_end,gpa desc;

--You need to display the employees who have not been assigned to any department.

 select first_name from Employees where department_id not in(select department_id from departments);

/*The CUSTOMERS table has these columns:
CUSTOMER_ID NUMBER(4) NOT NULL
CUSTOMER_NAME VARCHAR2(100) NOT NULL
CUSTOMER_ADDRESS VARCHAR2(150)
CUSTOMER_PHONE VARCHAR2(20)
You need to produce output that states "Dear Customer customer_name, ". The customer_name data values come from the CUSTOMER_NAME column in the CUSTOMERS table. */

 select concat('Dear Customer',customer_name,' .') from customers;

 /*A. Consider an EMP table having id, name, sal, comm_pct, pf, hra, tearn, tded, net. Complete insert into command by leaving pf, hra, tearn, tded and net columns.
 Insert into emp values(…
 B. Fill records by calculating…
 1. pf = 10% of sal
 2. hra = 12% of Sal
 3. tearn = sal+hra
 4. tded = pf + 4% of sal
 5. net = tearn – tded*/

 insert into Emp(id,name,sal,comm_pct,pf)
 values
 (1,'John Doe',50000,0.05,5000),
 (2,'Jane Smith',60000,0.1,6000),
 (3,'Bob',75000,0.15,7500);
 update Emp set
 hra=0.12*sal,tearn=sal+hra,tded=0.04*sal,net=tearn-tded;
