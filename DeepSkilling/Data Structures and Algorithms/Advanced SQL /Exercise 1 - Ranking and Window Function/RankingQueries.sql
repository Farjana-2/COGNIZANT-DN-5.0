USE SalesDB;
GO

-- ALL THREE RANKINGS SIDE BY SIDE
-- Watch the difference between RANK and DENSE_RANK!
SELECT 
    EmployeeName,
    Department,
    Salary,
    ROW_NUMBER() OVER (ORDER BY Salary DESC) AS RowNumber,
    RANK()       OVER (ORDER BY Salary DESC) AS RankNumber,
    DENSE_RANK() OVER (ORDER BY Salary DESC) AS DenseRankNumber
FROM Employees
ORDER BY Salary DESC;
GO