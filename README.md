# Selenium.NET Framework by Implementing Page Object Design Pattern

# Project Stucture:
1. **Config : This Folder Contains the App.config file which is required for configuration**
2. **CustomException : This Folder Contains the Custom Exception Class**
3. **Interfaces : This folder contains all interface class**
4. **Logs : This Folder Contains all logs**
5. **Pages : This Folder is Divided into Two Sub Folders**
    1. *Actions : This folder contains actions class of every page*
    2. *Locators: This folder contains locators class of every page*
    3. *BaseClass: This folder contains base class class*
6. **Setting : This Folder Contains Basic Setting class**
8. **TestCase : This Folder Contains All Unittest class**
9. **TestContextClass : This Folder Contains TextClassContext Class**
10. **TestData: This Folder Contains All TestData**
11. **TestReports : This Folder Contains all TestReports**
12. **Utilities : This Folder Contains the utility class**

# All logs are generated in Logs folder which contains the file FilleLogger.log and RollingFileLogger.log.

# Steps to run the framework :
1. **Import the project into visual studio**
2. **Right click on Project in Solution Explorer**
3. **Click on Build Solutions**
4. **Click on Test in Menu Options**
5. **Click on Test explorer**
6. **In the Test explorer select the test case to run a single test case or Click on Run All Tests to run all tests**

# In order to send test reports on mail fill all required details in constants.cs file in config folder and uncomment the code in TestClassContext.cs in TestContextClass folder.

# Html test reports will be generated in TestReports Folder.
