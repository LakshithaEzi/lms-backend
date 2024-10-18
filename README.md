1. Clone the Repository
Open your terminal or command prompt.
Navigate to the directory where you want to clone the project.
Run the following command to clone the repository:
bash
Copy code
git clone https://github.com/LakshithaEzi/lms-backend.git

2. Open the Project in Visual Studio
Open Visual Studio.
Click on "Open a project or solution".
Navigate to the cloned repository's folder and open the .sln (solution) file.

4. Restore Dependencies
Once the solution is loaded in Visual Studio, you need to restore the NuGet packages. This can usually be done automatically, but if not:
Open the Package Manager Console in Visual Studio (Tools > NuGet Package Manager > Package Manager Console).
Run the following command:
PowerShell
Copy code
Update-Package -reinstall

6. Set the Startup Project
In the Solution Explorer, right-click on the project you want to set as the startup project.
Select "Set as Startup Project".

8. Configure the appsettings.json (if necessary)
Check the appsettings.json file in your project to ensure that any required configurations (e.g., connection strings) are correct for your environment.
9. Run the Application
Click the Start button (or press F5) in Visual Studio to run the application. The app should build, and the server should start.
