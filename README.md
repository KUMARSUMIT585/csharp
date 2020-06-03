# csharp
# Project Set Up & Executions

    Install Visual Studio Code (https://code.visualstudio.com/download)
    
    Git clone the project https://github.com/KUMARSUMIT585/csharp
    
    Pre requisite (has to be edited further,it is a draft version) -  dotnet core should be installed 
    To download -   https://dotnet.microsoft.com/download
    (Post installation - To verify enter in command line dotnet --vesion , output should be '3.1.101')
        
    Command Line Execution (currently it executes all tests in the steps folder)
    How to clean >>>>  dotnet clean 
    How to build >>>>  dotnet build
    How to test  >>>>  dotnet test    (it will execute the tests present in the steps folder, or the step definitions)  
    
    Want to write a new test??
        >> create a new feature file within the 'features' folder, create a corresponding step definition class in 'steps' folder & you have a new test ready .

# Features built so far
    Rest Api Sample Test + Specflow
    Web App Sample Test + Specflow
    Extent Reports

# Dependencies 
    chromedriver version will depedn on the chrome versio on local machine

# Extensions To Be Installed in VS Code
    will update this section on consistent basis
    
    
# Debt so far 
    will have to solve Nuget dependency issues , tests are executing but dotnet build is failing ( probably due to dotnet framework version and dependencies )

created by kumar sumit 
