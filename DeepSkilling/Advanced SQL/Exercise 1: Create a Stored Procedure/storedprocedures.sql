USE SalesDB;
GO

-- =============================================
-- STORED PROCEDURE 1
-- Get all employees from a specific department
-- Just like asking chef for a specific dish!
-- =============================================
CREATE PROCEDURE GetEmployeesByDepartment
    @DepartmentName VARCHAR(50)  -- This is our INPUT (like ordering biryani)
AS
BEGIN
    SELECT 
        EmployeeId,
        EmployeeName,
        Department,
        Salary
    FROM Employees
    WHERE Department = @DepartmentName
    ORDER BY Salary DESC;
END;
GO

-- =============================================
-- STORED PROCEDURE 2
-- Get employees with salary greater than amount
-- =============================================
CREATE PROCEDURE GetHighEarners
    @MinSalary DECIMAL(10,2)
AS
BEGIN
    SELECT 
        EmployeeId,
        EmployeeName,
        Department,
        Salary
    FROM Employees
    WHERE Salary > @MinSalary
    ORDER BY Salary DESC;
END;
GO

-- =============================================
-- STORED PROCEDURE 3
-- Add a new employee
-- =============================================
CREATE PROCEDURE AddNewEmployee
    @EmployeeId INT,
    @EmployeeName VARCHAR(50),
    @Department VARCHAR(50),
    @Salary DECIMAL(10,2),
    @JoiningDate DATE
AS
BEGIN
    INSERT INTO Employees 
    VALUES (@EmployeeId, @EmployeeName, @Department, @Salary, @JoiningDate);
    
    PRINT 'Employee added successfully! ✅';
END;
GO