# CompanyManagementAPI

## Task
For this ASP.NET project the aim was to create a simple API manager for a company.

## Description
Firstly, CompanyManagementAPI is an API which allows the user to manage employees, departments, and projects given an SQL database (more details below)
Some features which this API has is the ability to use CRUD operations for employees and also the ability to associate given employees with departments and projects.

## Prerequisites
In order to ensure that this program can run as expected the following steps are needed:
1) Ensure that SQL Server Express is installed and running on your machine.
2) Install .NET SDK
3) Have an IDE installed on your machine (Visual Studio, Visual Studio Code, Rider etc)

## Run
In order to run the application you need to open terminal in the IDE of your choice and execute the following command
```
dotnet run
```
This will start the application and will promp you the local host site (for example: http://localhost:5157/swagger).
Now you can see the 5 GRUD operations mentioned above:
* GET /api/employee – List all employees. 
* GET /api/employee/{id} – Get details of a specific employee.
* POST /api/employee – Create a new employee.
* PUT /api/employee/{id} – Update an existing employee.
* DELETE /api/employee/{id} – Delete an employee.

## Test
To test the API you can either choose an API tool like Postman or you can directly interact with the SwaggerUI from the local host website mentioned above.
