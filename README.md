# TFL_Automation

Clone the git repo
$ git clone https://github.com/SaikumarKayati/TransportForLondon.git

#Install Visual Studio and .NET Core
(1) Install Visual Studio 2022
(2) .NET Core
(3) Start Visual Studio.
(4) On the menu bar, choose File, Open, Project/Solution.

#How to Run the Tests:
1) Navigate to the TFL_Automation\TFL_Automation\TransportForLondon project folder and open TransportForLondon.sln in Visual Studio

2) Right click the solution in VS and select Restore NuGetpackages

3) Select Extensions options in the VS and select Manage extensions and Install Specflow.

#Key Design Elements:
Architecture Layers include Tests, Framework, Selenium Page Objects, Feature files, Step definitions and Browser.

Page Object Pattern - clear separation of pages versus test cases and representative of the application.

Base Class which can be extended to handle Initializations before Test Suites are executed.
Ideal for tracing Events such as realtime reporting of test case failure with wiating for full test run completion.

To Use:
Required:
Chrome installed

Steps to execute:
Note: All selenium dependencies are included in the solution.

* Change the Test file report location in the ReportManager.cs file which says string directory

* Select test explorer from Test option in the VS or ctrl+E

* Select tests to run
* Click Run

Current Versions/dependencies:
* Visual Studio: 2022
* Selenium WebDriver: 4.15.0
* Selenium WebDriver.ChromeDriver: 119.0.6045
* Selenium.Support: 4.15.0
* ExtentReports: 4.1.0
* MSTest.TestFramework: 2.2.10
* SpecFlow.MsTest: 3.9.74
* SpecFlow: 3.9.74
