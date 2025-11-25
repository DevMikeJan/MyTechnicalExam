This repository contains two separate projects:
  1.CustomAPI
  2.EmployeeInfo

Before Running
  1.Create a database 'Any DB Name' (MSSQL)
  2.Then Create a table
    *CREATE TABLE EMPLOYEE (
            	empID NVARCHAR(100),
            	empFName NVARCHAR(50),
            	empMName NVARCHAR(50),
            	empLName NVARCHAR(50),
            	empAdd NVARCHAR(50),
            	empAge INTEGER,
            	empGender NVARCHAR(1)

	            PRIMARY KEY (empID)
    )

Steps to Run
  1.Run the CustomAPI project first.
    *This must be running because EmployeeInfo depends on it.
  2.After the API is running, start the EmployeeInfo project.
