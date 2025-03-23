# MVC Grades Management System

This is an ASP.NET Core MVC project that manages subjects and their related activities using Entity Framework Core with MySQL.

## Prerequisites

Before running the project, make sure you have the following installed:
- Dotnet
- MySQL or MariaDB

## Setup Instructions

### 1. Clone the Repository
```sh
git clone https://github.com/Leon-Supr/mvc-grades.git
cd mvc-grades
```

### 2. Configure Database Connection
Modify `appsettings.json` to match your MySQL connection settings:
```json
"ConnectionStrings": {
    "DefaultConnection": "server=localhost;database=dbgrades;user=root;password=yourpassword;"
}
```

### 3. Install Dependencies
```sh
dotnet restore
```

### 4. Apply Migrations
Run the following command to create the database schema:
```sh
dotnet ef database update
```

### 5. Run the Application
```sh
dotnet run
```
The application should now be accessible at `http://localhost:5072/`.

## Usage
- Navigate to `/Home/ViewSubjects` to see the list of subjects.
- Click on "View Details" to see activities for a specific subject.
- Use the "Create", "Modify", and "Delete" options to manage subjects. (add the id to the end of url on Modify and Delete, Ex: .../Modify/2)
