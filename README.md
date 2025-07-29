# TaskSchedulerApp: A Web-Based Task Management Solution

`TaskSchedulerApp` is a modern web application built with ASP.NET Core MVC, designed to provide a robust and intuitive platform for managing and scheduling tasks. It offers a clear demonstration of full-stack web development principles using Microsoft technologies.

## Features

-   **Task Creation & Management:** Easily create, view, update, and delete tasks.
-   **Task Scheduling:** (Assumed based on name) Ability to set due dates, reminders, or recurring tasks.
-   **User Interface:** A responsive web interface for seamless interaction.
-   **Database Integration:** Utilizes Entity Framework Core for efficient data persistence.
-   **Scalable Architecture:** Built on the MVC pattern for clear separation of concerns.

## Technologies Used

-   **ASP.NET Core MVC:** Web framework for building robust web applications.
-   **.NET 8.0:** The latest version of the .NET platform.
-   **C#:** The primary programming language.
-   **Entity Framework Core:** Object-Relational Mapper (ORM) for database interaction.
    -   Configured for **SQL Server** (for production/development) and **In-Memory Database** (for testing/quick starts).
-   **HTML, CSS, JavaScript:** For front-end development.
-   **Bootstrap (Assumed):** For responsive and modern UI components.

## Getting Started

Follow these instructions to get a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

-   [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
-   [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/) (Community Edition is free) or [Visual Studio Code](https://code.visualstudio.com/) with C# extension.
-   (Optional) [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or a local SQL Server instance if you plan to use a persistent database.

### Installation

1.  **Clone the repository:**
    ```bash
    git clone https://github.com/MemaroX/TaskSchedulerApp.git
    cd TaskSchedulerApp
    ```

2.  **Navigate to the project directory:**
    ```bash
    cd TaskSchedulerApp
    ```

3.  **Restore NuGet packages:**
    ```bash
    dotnet restore
    ```

4.  **Apply database migrations:**
    If you are using SQL Server, ensure your connection string in `appsettings.json` is correct.
    ```bash
    dotnet ef database update
    ```
    *(Note: If you prefer to use the in-memory database for quick testing, you might need to adjust `Startup.cs` or `Program.cs` to use `AddDbContext<YourDbContext>(options => options.UseInMemoryDatabase("TaskDb"));` instead of SQL Server.)*

### Running the Application

1.  **From the project directory (`TaskSchedulerApp/TaskSchedulerApp`):**
    ```bash
    dotnet run
    ```

2.  **Open in browser:**
    The application will typically launch in your default web browser at `https://localhost:7000` or `http://localhost:5000` (check the console output for the exact URL).

## Project Structure

```
TaskSchedulerApp/
├── TaskSchedulerApp.sln             # Visual Studio Solution file
└── TaskSchedulerApp/                # Main project directory
    ├── Controllers/                 # Handles incoming HTTP requests and user input
    ├── Data/                        # Database context and data access logic
    ├── Migrations/                  # Entity Framework Core database migration files
    ├── Models/                      # Data models and business entities
    ├── Properties/                  # Project properties
    ├── Views/                       # UI templates (Razor views)
    ├── wwwroot/                     # Static files (CSS, JS, images)
    ├── appsettings.json             # Application configuration
    ├── appsettings.Development.json # Development-specific configuration
    ├── Program.cs                   # Application entry point (.NET 6+ minimal APIs)
    ├── Startup.cs                   # Application startup configuration (for older .NET Core versions or if explicitly used)
    └── TaskSchedulerApp.csproj      # Project file (defines dependencies, target framework)
```

## Contributing

Contributions are welcome! If you have suggestions for improvements, bug fixes, or new features, please feel free to:

1.  Fork the repository.
2.  Create a new branch (`git checkout -b feature/YourFeatureName`).
3.  Make your changes.
4.  Commit your changes (`git commit -m 'Feat: Add YourFeature'`).
5.  Push to the branch (`git push origin feature/YourFeatureName`).
6.  Open a Pull Request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact

MemaroX - [Your GitHub Profile Link](https://github.com/MemaroX)
