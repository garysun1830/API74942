# This web application is a REST API Server. It provides the REST API for the web application that find the Health Authority Area. 
- ## this web application is created with Visual Studio 2019 on Windows.
- ## this web application uses ASP.Net, Entity Framework, and SQL Server.
- ## this web application runs on IIS.
- ## the API methods is defined in APIController.cs.
- ## the API parameters in defined in web.config.
# Server envrionment
- ## This web application runs on Windows IIS Server V10 or above.
- ## The IIS Server is hosted on Windows 10 or above.
# Release from Dev to the Test and Production environment
1. Using Visual Studio:
  -  Create a publish profile.
  -  Publish using the "publish" button.
2. Copy files:
  - Build the solution.
  - Copy the whole solution folder to the folder that IIS Server specifies on the server.
3. Using Jenkins:
  - For 1st time release:
    - Install Visual Studio 2019 on the Jenkins server.
    - Ceate a Jenkins workflow. 
    - This workflow configures to get the source code from this Github repository to the Jenkins Workspace.
    - The workflow configures to trigger Visual Studio 2019 to publish the solution in the Workspace to the folder that IIS Server specifies on the server.
  - Run Workflow/Build using the "Build" button.
