-- use hr_db;

-- Display first name and last name after converting the first letter of each name to upper case and
-- the rest to lower case.

-- SELECT UPPER(SUBSTRING(LAST_NAME,1,1))+ LOWER(SUBSTRING(FIRST_NAME,2, LEN(FIRST_NAME)-1)) AS FIRST_NAME,
-- UPPER(SUBSTRING(LAST_NAME,1,1)) + LOWER(SUBSTRING(LAST_NAME,2, LEN(LAST_NAME)-1)) AS LAST_NAME FROM employees;

-- Display the first word in job title.

--SELECT * FROM employees;
-- SELECT SUBSTRING(JOB_TITLE ,1,charindex(' ',JOB_TITLE)-1) FROM jobs;

-- Display the length of first name for employees where last name contain character ‘b’ after 3rd
-- position.

-- SELECT LEN(FIRST_NAME) FROM employees
-- WHERE LAST_NAME LIKE '__b%';

-- Display first name in upper case and email address in lower case for employees where the first
-- name and email address are same irrespective of the case.

-- SELECT UPPER(FIRST_NAME), LOWER(EMAIL) FROM employees
-- WHERE UPPER(FIRST_NAME) = EMAIL;

-- Display first name, salary, and round the salary to thousands.

-- SELECT FIRST_NAME, SALARY, ROUND(SALARY,-3) AS ROUND_SALARY FROM employees;

-- Display employee ID and the date on which he ended his previous job.

--SELECT EMPLOYEE_ID,END_DATE FROM job_history;

-- Display first name and date of first salary of the employees.

-- SELECT FIRST_NAME, DATEADD(MONTH,1,HIRE_DATE) AS FIRST_SALARY_DATE
-- FROM employees;

-- Display first name and experience of the employees.

-- SELECT * FROM employees;
-- SELECT FIRST_NAME, DATEDIFF(YY,HIRE_DATE,getdate()) FROM employees;

-- Display first name of employees who joined in 2001.

-- Display employees who joined in the current year.

-- Display the number of days between system date and 1st January 2011.

-- Display number of employees joined after 15th of the month.

-- Display third highest salary of employees.