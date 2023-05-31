# BlazorIMS

## Demo on Azure
https://blazorims.azurewebsites.net/

---
### Inventory Management System with:
* Blazor Server-side (.Net 6)
* C#
* Bootstrap
* Sql Server
* Identity (Cookie-based)
* EPPlus
* QrCoderNetCore
* ReactorBlazorQRCodeScanner

---

# Quick Start  
## Prerequisites  
1. [Copy the code](https://github.com/KnowitIZ/BlazorIMS/archive/refs/heads/master.zip)
1. Download & Install [Visual Studio 2022 Community edition](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&passive=false&cid=2030)  
	Make sure to select the "ASP.NET and web development" package during installation. 
1. Always run Visual Studio as administrator. It should say ADMIN in the top right corner when it is correctly run as admin. ![image](https://github.com/KnowitIZ/iz-kista-BlazorIMS/assets/58624466/395e00e0-59c8-4e2a-9278-6614ecd36c53)


## To run
1. Open the project in Visual Studio by selecting File ->  Open -> Project/Solution -> iz-kista-BlazorIMS/BlazorIMS.sln
2. Run the project in debug mode by selecting the solid green colored play button for BlazorIMS. This will open the webpage and run the server.

### Errors  
* If you get a "Microsoft Visual Studio Offline Packages not found" error that mentions the nuget packages: 
	1. Got to Debug -> Options -> NuGet Package Manager -> Package Sources and click on the green plus sign in the top right corner. 
	2. Edit the Name for the new entry from "Package Source" to "nuget.org"
	3. Edit the Source for the new entry from "https://packagesource" to "https://api.nuget.org/v3/index.json"
	4. Click "Update" and then "OK". Restart Visual Studio if necessary. 


---
# What the program does

* 2 roles seeded (Admins & Employees) 
* one admin user
* 2 employees
* register
* Login
* read excel
* Inventory CRUD
* QR code for each inventory item
* Qr scanner
* Checkout
* Checkin
* History

---
# Tasks  
	
## Done  
1. Checkout request logic - remove request and make a user able to checkout directly via either clicking a request button or scanning a QR code. 
1. Checked out items: show "Checked out by <email address>" even on user side
1. Add "Item details" to user view. 
1. Search on enter  
1. Searching "2y0" results in error, searching in general. 
1. New feature: "Separate" QR code scanner that takes you to the correct item for both check in and check out. (e.g. you do not have to have selected the correct tiem to checkout or check in, instead it takes the QR code and maybe prompts a confirmation with the name. )  
1. Camera window in phone mode is larger than the window.
1. Users edit possibilities on items should only be on comment. User should be able to add comment (but not change other fields)
1. If checked out, it should show in the details of the item as well. (Instead of LastModified presumeably), or keep LastModifiedby and add CheckedOut by when relevant. 
1. Functionality of the QR code checkin and checkout reader. 
	1. Scanning a QR code results in nothing. 
	1. Have a confirmation of the QR code being scanned and checked in/checked out.
	
## To Do  
1. Update Naming from Checked in to Return
1. Integrate with Azure Active Directory
1. Deployed/Launched




---
# Tutorial/Resources  

Guide to setup Blazor: https://dotnet.microsoft.com/en-us/learn/aspnet/blazor-tutorial/intro
Good book to learn Blazor: Pro ASP.NET Core 6 by Adam Freeman
	
---

kourosh.salahshoor-asbagh@knowit.se

@Knowit Connectivity IZ (Linköping-Sweden) - 2023
