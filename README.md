<h1 align="center">Testing Enrolment System using Azure </h1>

## Introduction

This repository contains a testing system implemented using Azure services and Windows Communication Foundation (WCF). The system is designed to facilitate testing scenarios, and it includes various components implemented using Azure, Visual Studio, and WCF services.


## Project Overview

This project is comprised of the following testing services:

- **Enrolment Service:**
  . Enrol Student
  . View Enrolments
  . Find Enrolments by Course ID

- **Student Service:** 
  . View Students
  . View Student Timetable
  . Enrol New Student
  
- **Course Service:**
  . Add New Course
  . View Courses
  . Display Bill

## Diagram 

<!--Insert Diagram or GIF here (if applicable). !-->
Examples of some WCF Tests:
![image](https://github.com/ILoveThrumbos/Azure-Testing-Legacy-Enrolment-System/assets/139453924/d66248c5-2b9b-40f6-9b34-e78d596705fc)
![image](https://github.com/ILoveThrumbos/Azure-Testing-Legacy-Enrolment-System/assets/139453924/e12b753d-a1da-4a38-9a8b-64a25da76015)
![image](https://github.com/ILoveThrumbos/Azure-Testing-Legacy-Enrolment-System/assets/139453924/31d8c9b3-279b-45ef-a750-a1c3c6fcc363)
![image](https://github.com/ILoveThrumbos/Azure-Testing-Legacy-Enrolment-System/assets/139453924/48752262-009c-4ef7-83cc-0ee4656a9c18)



## Installation and Usage Instructions

### Prerequisites

Before getting started, ensure you have the following installed:

- [Visual Studios 2019 and later](https://visualstudio.microsoft.com/vs/older-downloads/)
- [.Net Framework 4.8](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48)
- [Access to Azure (and know the basics).](https://azure.microsoft.com/en-au)
- Azure ASP .NET MVC with a pre-established database/connection


### Steps to Run the Project

1. **Clone the Repository:**

   ```bash
   git clone https://github.com/ILoveThrumbos/Azure-Testing-Legacy-Enrolment-System
2. Launch Visual Studios and create new project (Choose WCF with target framework 4.8).
3. Right click the Project in the solution explorer and Add "New Project" and select the "Azure-Testing-Legacy-Enrolment-System-main" project.
4. Create a SQL database in Azure and ASP .NET MVC app to connect to the cloud database.
5. In the Server Explorer connect to the created newly created MVC app (may have to config connection in the Web.config)
6. Run the project and run select through the .svc options
7. Test the application
8. If you wish to run this project in Visual Studios Windows Form click here for the [template](https://github.com/ILoveThrumbos/Windows-Form-Template-Enrolment-System.git)

### Known Issues
   - Currently no known issues.
     
     

## Support and Contributions
If you encounter any issues or have suggestions for improvement, please create an issue on the GitHub repository. Contributions are welcome, so feel free to submit pull requests to enhance the functionality or fix bugs.

Thank you for using the Java Bookstore! Happy reading!
