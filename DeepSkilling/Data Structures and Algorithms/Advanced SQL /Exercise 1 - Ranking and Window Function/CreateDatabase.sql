-- Step 1: Create our database
CREATE DATABASE SalesDB;
GO

-- Step 2: Use it
USE SalesDB;
GO

-- Step 3: Create Employees table
CREATE TABLE Employees (
    EmployeeId INT PRIMARY KEY,
    EmployeeName VARCHAR(50),
    Department VARCHAR(50),
    Salary DECIMAL(10,2),
    JoiningDate DATE
);
GO

-- Step 4: Add some data
INSERT INTO Employees VALUES (1, 'Farjana', 'IT', 75000, '2020-01-15');
INSERT INTO Employees VALUES (2, 'Aziz', 'IT', 82000, '2019-03-20');
INSERT INTO Employees VALUES (3, 'Ibrahim', 'HR', 65000, '2021-06-10');
INSERT INTO Employees VALUES (4, 'Bhavana', 'HR', 65000, '2020-11-05');
INSERT INTO Employees VALUES (5, 'Pranathi', 'Finance', 90000, '2018-07-22');
INSERT INTO Employees VALUES (6, 'Neha', 'Finance', 88000, '2019-09-14');
INSERT INTO Employees VALUES (7, 'Pavani', 'IT', 75000, '2022-02-28');
INSERT INTO Employees VALUES (8, 'Divya', 'HR', 70000, '2020-04-17');
GO

-- Step 5: Check data is inserted
SELECT * FROM Employees;
GO