USE SalesDB;
GO

-- =============================================
-- EXECUTE METHOD 1
-- Get IT department summary
-- =============================================
EXEC GetDepartmentSummary @Department = 'IT';
GO

EXEC GetDepartmentSummary @Department = 'HR';
GO

EXEC GetDepartmentSummary @Department = 'Finance';
GO

-- =============================================
-- EXECUTE METHOD 2
-- Get employee count using OUTPUT parameter
-- =============================================
DECLARE @Count INT;  -- Variable to store the returned value

EXEC GetEmployeeCount 
    @Department = 'IT',
    @TotalCount = @Count OUTPUT;

PRINT 'Total IT Employees: ' + CAST(@Count AS VARCHAR);
GO

-- =============================================
-- EXECUTE METHOD 3
-- Check if employee exists
-- =============================================
EXEC CheckEmployeeExists @EmployeeId = 1;  -- Exists!
GO

EXEC CheckEmployeeExists @EmployeeId = 99;  -- Doesn't exist!
GO