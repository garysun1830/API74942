# This web application is a REST API Server. It provides the REST API for the web application that find the Health Authority Area. 
- ## this web application is created with Visual Studio 2019 on Windows.
- ## this web application uses ASP.Net, Entity Framework, and SQL Server.
- ## this web application runs on IIS.
- ## the API methods is defined in APIController.cs.
- ## the API parameters in defined in web.config.
# Server envrionment
- ## This web application runs on Windows IIS Server V10 or above.
- ## The IIS Server is hosted on Windows 10 or above.
# Release Code from Dev to the Test and Production environment
1. Using Visual Studio:
  - In the development evironment.
  - Create each publish profile for Test and Production.
  - Publish each profile, using the "publish" button, accordingly.
2. Copy files:
  - In the development evironment.
  - Build the solution.
  - Copy the whole solution folder to the folder that IIS Server specifies on the server, accordingly.
3. Using Jenkins:
  - For 1st time release:
    - Install Visual Studio 2019 on the Jenkins server.
    - Ceate each Jenkins workflow for Test and Production.
    - This workflow configures to get the source code from this Github repository to the Jenkins Workspace.
    - The workflow configures to trigger Visual Studio 2019 to publish the solution in the Workspace to the folder that IIS Server specifies on the server,  accordingly.
  - Run Workflow/Build using the "Build" button, accordingly.
# Release SQL Server from Dev to the Test and Production environment
  - For 1st time release:
    - DBA copies the SQL Server databases to the Test and Production SQL Server databases,  accordingly.
  - DBA create the SQL scripts to bring in all the changes, for schema and data
  - DBA run the SQL scripts on the the Test and Production SQL Server databases,  accordingly.
# Continiously Release  
  - Create Jenkins Workflows
  - Configure the Workflows to trigger building by the repository changes, or with schedules
