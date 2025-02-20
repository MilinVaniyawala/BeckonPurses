﻿CYB 206 Web Application Security
Team THETA
Team Members
- Austin Albaloo
- Christina Joseph
- Milin Vaniyawala

2025-02-12
0915
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

0923
- Looking for Purse Brand Name
- Find the name "Beckon Purses"

0934
- VS Version: VS Community 2022 17.12.0
- .NET SDK 8.0.404
- Created a Project in Microsoft Visual Studio

0935
- Run the Project and Check is that works or not
0937
- Application Runs Successfully
0947
- We got the Logo (Christina Created) For Our Product
0950
- Creating a README.txt
0959
- Merge Code With Github
1000
- We also get Logo for our Team (Christina Created)
1013
- Send Request to Team Members to join on github and they can easily access the code

2025-02-19
0125
-Created HelloWorldController
	- Add 2 methods (Index and Welcome)
0130
- Run and Test the application, however it's works properly
0132
- In Controller Updated the Welcome Method (two paramters:name and numTimes
0137
- Tested Updated Method, Also did some code testing with my own values
0140
- In Controller Update the Welcome Method (two parameters:name and ID)
0143
- Also Testing the created method and confirm it works.
0147
- Created New Folder in View - HelloWorld, Created Index.cshtml inside this folder
0203
- Modify the Index file in view->HelloWorld directory
0205
- Modify the Welcome method in controller
0210
- Created new file in HelloWorld View -> Welcome file added
0211
- Check the code in browser
0936
- Modifying the layout.cshtml (Changes in title,navbar and footer)
0940
- Runs the application and check the code is working or not.
0943
- Yes, It's working successfully
0945 
- Creating a Model file call Purse
0950
- Create Purses Pages using Scaffolding tool
1002
- Starting the migration
- Having issues with migration because here we have two context, one is authentication and another one is our purse one. So now whenever I need to add migration we also need to define context.
- ERROR: More than one DbContext was found. Specify which one to use. Use the '-Context' parameter for PowerShell commands and the '--context' parameter for dotnet commands.
- So, here please note down the command.
	- Add-Migration "name of migration" -Context BeckonPursesContext
	- Update-Database -Context BeckonPursesContext
- However, I got the answer from the stackoverflow.
- Here is the link: https://stackoverflow.com/questions/52311053/more-than-one-dbcontext-was-found
- 20250219161823_InitialCreate.cs
1124
- Runs the application and check the code is working or not.
1125
- Yes, It's working successfully
1135
- Push The Updated Code On Git.

2025-02-20
1430
- Clone the repo
1435
- run the data and added SeedData
1445
- Run the code and check
1450
- It works successfully