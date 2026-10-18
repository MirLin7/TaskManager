# Task Manager 📝

**This is my very first project, both in C# and on GitHub.**

A simple console-based application for managing daily tasks, created as a learning project to practice C# fundamentals and Object-Oriented Programming.

## Features
*   **Add Tasks:** Create tasks with a detailed description, a short name, and the option to mark them as a favourite.
*   **Smart Sorting:** Favourite tasks are automatically sorted to the top of the list for quick access.
*   **Task Management:** View all tasks, read full descriptions, edit task details, or delete tasks.
*   **Status Tracking:** Mark tasks as "Done" or "Not Done".
*   **Timestamps:** Every task automatically records its creation date and time.

## Architecture & Purpose
This project was built to practice core C# concepts. The code is logically separated into three classes to keep responsibilities clear:
*   `Task.cs`: The data model. Stores task details (name, description, status, and creation date).
*   `Manager.cs`: The logic controller. Handles the list of tasks, sorting, editing, and deleting.
*   `Program.cs`: The user interface. Handles console inputs and outputs.

## Tech Stack
*   C#
*   .NET Console Application

## How to Run
1. Clone this repository or download the source code.
2. Open the `.sln` file (or the project folder) in Visual Studio 2022.
3. Press `F5` to build and run the project.
4. Follow the on-screen instructions in the console to manage your tasks.
