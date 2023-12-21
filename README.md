# TaskTimeManager

TaskTimeManager is a desktop application built with WPF (Windows Presentation Foundation) and C#. It allows users to manage tasks effectively, supporting operations like adding, editing, and deleting tasks.

## Features

- Add new tasks with details such as name, due date, priority, and status.
- Edit existing tasks to update their details.
- Delete tasks from the list.
- View a list of all tasks in a simple, user-friendly interface.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

What things you need to install the software:

- [Visual Studio](https://visualstudio.microsoft.com/) with the .NET Desktop Development workload
- SQL Server (or any other compatible database system) for data storage

### Installing

A step-by-step guide to getting a development environment running:

1. Clone the repository to your local machine:
   ```bash
   git clone https://github.com/yourusername/TaskTimeManager.git

2. Open the solution file (TaskTimeManager.sln) in Visual Studio.

Restore NuGet packages:

Update-Package -Reinstall
Set up the database connection:

Update the connection string in TaskContext.cs to point to your SQL Server instance.
Build and run the application:

Press F5 or click Start in Visual Studio.

### Built With
WPF - The UI framework
C# - Programming language
Entity Framework - ORM for database operations
