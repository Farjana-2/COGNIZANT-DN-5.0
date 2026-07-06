USE SalesDB;
GO

-- =============================================
-- 1. ROW_NUMBER() - Unique rank, no ties
-- Ranks ALL employees by salary
-- =============================================
SELECT 
    EmployeeName,
    Department,1
    Salary,
    ROW_NUMBER() OVER (ORDER BY Salary DESC) AS RowNumber
FROM Employees;
GO

-- =============================================
-- 2. RANK() - Same rank for ties, but SKIPS next
-- Watch what happens with equal salaries!
-- =============================================
SELECT 
    EmployeeName,
    Department,
    Salary,
    RANK() OVER (ORDER BY Salary DESC) AS RankNumber
FROM Employees;
GO

-- =============================================
-- 3. DENSE_RANK() - Same rank for ties, NO skip
-- =============================================
SELECT 
    EmployeeName,
    Department,
    Salary,
    DENSE_RANK() OVER (ORDER BY Salary DESC) AS DenseRankNumber
FROM Employees;
GO

-- =============================================
-- 4. PARTITION BY - Rank WITHIN each department
-- Like ranking students within each class!
-- =============================================
SELECT 
    EmployeeName,
    Department,
    Salary,
    RANK() OVER (PARTITION BY Department ORDER BY Salary DESC) 
        AS RankInDepartment
FROM Employees
ORDER BY Department, RankInDepartment;
GO