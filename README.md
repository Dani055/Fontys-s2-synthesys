# DuelSys
A .Net C# project for the 2nd semester assessment in Fontys.
Project was made in a very short notice (4 weeks) with everything learned from https://github.com/Dani055/Fontys-s2-watchedit

Projects consists of a desktop **WinForms** app and a **ASP.NET Razor pages** website that share the same back-end and functionalities.

For very thorough info about the project, check out the **Documentation** folder.

You can also check out screenshots of the apps in the Screenshots folder.

## How to run project 
(In case you want to check it out for yourself)
- Project is made in .Net 5
- You would need to have **Visual Studio installed with ASP.NET extention**
- App requires a **MySQL database** to function. You can find the connection string in **DuelSys/DAL/DBSettings.cs** and replace it with your own database.
- Required **database structure** is in the documentation folder
* You need two roles in the Role table. One with ID 1 and value "Staff" and one with ID 2 and value "Player". **Roles are case sensitive**


### Fulfilled Major/Minor requirements:
	- FR-06: Support multiple tournament systems 
	- FR-09: Support leader board
	- FR-10: Generate player profile

### Release info:
	- Desktop application for DuelSys Staff employees
	- Web application for tournament participation
	
