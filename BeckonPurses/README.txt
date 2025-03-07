﻿CYB 206 Web Application Security  
Team THETA  
Team Members  
- Austin Albaloo  
- Christina Joseph  
- Milin Vaniyawala  

2025-02-12-09-15-00  
- Team Meeting  
- Decide Properties  
- Properties are  
	- Material  
	- Size  
	- Shape  
	- Color  
	- Texture  
	- Closure Type  
	- Price  

2025-02-12-09-23-00  
- Looking for Purse Brand Name  
- Found the name "Beckon Purses"  

2025-02-12-09-34-00  
- VS Version: VS Community 2022 17.12.0  
- .NET SDK 8.0.404  
- Created a Project in Microsoft Visual Studio  

2025-02-12-09-35-00  
- Run the Project and Check if it works  

2025-02-12-09-37-00  
- Application Runs Successfully  

2025-02-12-09-47-00  
- Got the Logo (Christina Created) for Our Product  

2025-02-12-09-50-00  
- Creating a README.txt  

2025-02-12-09-59-00  
- Merged Code With GitHub  

2025-02-12-10-00-00  
- Got a Logo for our Team (Christina Created)  

2025-02-12-10-13-00  
- Sent Request to Team Members to join GitHub for code access  

2025-02-19-01-25-00  
- Created HelloWorldController  
	- Added 2 methods (Index and Welcome)  

2025-02-19-01-30-00  
- Ran and Tested the application, works properly  

2025-02-19-01-32-00  
- Updated the Welcome Method in Controller (added parameters: name and numTimes)  

2025-02-19-01-37-00  
- Tested Updated Method, did some additional code testing  

2025-02-19-01-40-00  
- Updated the Welcome Method in Controller (parameters: name and ID)  

2025-02-19-01-43-00  
- Tested the updated method and confirmed it works  

2025-02-19-01-47-00  
- Created New Folder in Views - HelloWorld, added Index.cshtml inside  

2025-02-19-02-03-00  
- Modified the Index file in Views -> HelloWorld  

2025-02-19-02-05-00  
- Modified the Welcome method in Controller  

2025-02-19-02-10-00  
- Created a new Welcome.cshtml file in Views -> HelloWorld  

2025-02-19-02-11-00  
- Checked the code in the browser  

2025-02-19-09-36-00  
- Modified layout.cshtml (Changes in title, navbar, and footer)  

2025-02-19-09-40-00  
- Ran the application and checked if the code was working  

2025-02-19-09-43-00  
- Yes, it's working successfully  

2025-02-19-09-45-00  
- Created a Model file called Purse  

2025-02-19-09-50-00  
- Created Purse pages using the Scaffolding tool  

2025-02-19-10-02-00  
- Started migration  
- Encountered issues due to two DbContext (authentication and purse)  
- ERROR: More than one DbContext was found. Specify the context using:  
	- Add-Migration "MigrationName" -Context BeckonPursesContext  
	- Update-Database -Context BeckonPursesContext  
- Found the solution on StackOverflow:  
  https://stackoverflow.com/questions/52311053/more-than-one-dbcontext-was-found  

2025-02-19-11-24-00  
- Ran the application and checked if the code was working  

2025-02-19-11-25-00  
- Yes, it's working successfully  

2025-02-19-11-35-00  
- Pushed the updated code to GitHub  

2025-02-20-14-30-00  
- Cloned the repo  

2025-02-20-14-35-00  
- Ran the data and added SeedData  

2025-02-20-14-45-00  
- Ran the code and checked functionality  

2025-02-20-14-50-00  
- Everything works successfully  

2025-02-20-15-20-00  
- Added images to the file directory  

2025-02-20-15-50-00  
- Worked with Christina to add the SeedData file  

2025-02-20-16-30-00  
- Seeded the database  

2025-02-20-16-45-00  
- Started working on the About Us page  

2025-02-20-17-00-00  
- Added the necessary MVC components to the project  

2025-02-20-17-30-00  
- Finished writing the paragraphs for the page  

2025-02-20-17-45-00  
- Added the image to replace the title on the navbar  

2025-02-20-18-12-00  
- Added Theta_logo.jpeg to the About Us page  

2025-02-20-18-30-00  
- Finished the README.md  

2025-02-20-18-50-00  
- Updated the README.txt  

2025-02-20-19-30-00  
- Fixed a few typos  

2025-02-20-23-40-00
- Merge the Code From Dev to Main

2025-02-20-23-52-00
- Clean, Build And Runs the code.

2025-03-05
0950
1>------ Clean started: Project: BeckonPurses, Configuration: Debug Any CPU ------
========== Clean: 1 succeeded, 0 failed, 0 skipped ==========
========== Clean completed at 09:50 AM and took 02.772 seconds ==========
0951
1>------ Build started: Project: BeckonPurses, Configuration: Debug Any CPU ------
Restored F:\St. Clair College\Sem 2\CYB 206\BeckonPurses\BeckonPurses\BeckonPurses.csproj (in 517 ms).
1>BeckonPurses -> F:\St. Clair College\Sem 2\CYB 206\BeckonPurses\BeckonPurses\bin\Debug\net8.0\BeckonPurses.dll
========== Build: 1 succeeded, 0 failed, 0 up-to-date, 0 skipped ==========
========== Build completed at 09:51 AM and took 06.503 seconds ==========
0959
- Also run and check the code

2025-03-07
0051
- In Program.cs write code for role base and define default user for admin and users
0115
- Also run and check the code
0132
- In Purse Controller did changes accordingly for RBAC
0147
- run and check the code
0221
- Modify Index View of Purse Directory to hide Create,Edit and Delete Option for user admin have access.
0238
- run and check the code
0254
- All Functionality working completely.

=======================================================
Credentials

Admin User

ID: milin@myscc.ca
Pass: Admin@1234

Guest User

User 1
ID: austin@myscc.ca
Pass: User@1234

User 2
ID: christina@myscc.ca
Pass: User@5678