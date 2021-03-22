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
  - Copy the whole project folder to the folder that IIS Server specifies.
3. Using Jenkins:
  - For 1st time release, create a Jenkins workflow. This workflow get the source code 
