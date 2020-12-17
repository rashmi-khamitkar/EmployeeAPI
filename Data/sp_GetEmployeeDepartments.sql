SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetEmployeeDepartments]
AS
BEGIN
    SELECT e.EmployeeID, e.FirstName,e.LastName,sd.SubDepartmentName,e.Bio, e.ProfileImage,
    e.FbProfileLink, e.TwitterProfileLink, d.DepartmentName
    FROM Employee e JOIN SubDepartment sd
    ON e.SubDepartmentID = sd.SubDepartmentID
    JOIN Department d ON sd.DepartmentID = d.DepartmentID 
    WHERE e.Deleted = 0 AND sd.Deleted = 0 AND d.Deleted = 0
END

GO