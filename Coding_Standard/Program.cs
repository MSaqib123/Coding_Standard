
//_______________________ Naming Conventions __________________________
// Classes
public class MyClass { }

// Methods and Properties
public class Example
{
    public int ItemCount { get; set; }

    public void GetItems() { }
}

// Variables
//int myVariable = 42;

// Constants
//const int MAX_ITEMS = 100;

// Namespace
namespace MyApp.Services { }

//_______________________ Naming Conventions __________________________
/*
 1. Introduction

This document outlines coding standards and best practices for the development of the .NET Core Web API project. Adhering to these standards will ensure consistency, maintainability, and readability of the codebase.

 2. General Guidelines

Naming Conventions

- **Classes:** Use PascalCase for class names (e.g., `MyClass`).
- **Methods and Properties:** Use PascalCase for methods and properties (e.g., `GetItems`, `ItemCount`).
- **Variables:** Use camelCase for variables (e.g., `myVariable`).
- **Constants:** Use uppercase with underscores for constants (e.g., `MAX_ITEMS`).
- **Namespace:** Use meaningful and clear namespaces reflecting the project structure.

File Organization

- Organize files logically within folders to represent different components of the application.
- Group related files together, such as controllers, models, services, etc.

Code Formatting

- Follow the default code formatting conventions of Visual Studio.
- Use four spaces for indentation.
- Keep line lengths reasonable, preferably within 120 characters.

3. C# Language Guidelines

Classes and Structs

- Keep classes focused on a single responsibility (Single Responsibility Principle).
- Use concise and meaningful names for classes.

Methods

- Keep methods short and focused on a single task.
- Use meaningful names that describe the action performed by the method.

Properties

- Use auto-implemented properties where possible.
- Avoid exposing public fields; prefer properties.

Variables and Parameters

- Use meaningful and descriptive names for variables and parameters.
- Avoid using abbreviations unless they are well-known and widely understood.

Enums

- Use singular form for enum types and camelCase for values.



4. ASP.NET Core Web API Guidelines

Controllers

- Follow RESTful conventions for endpoint naming.
- Keep controllers focused on a specific resource or feature.
- Use attribute routing for defining routes.

Models

- Use Data Transfer Objects (DTOs) for input and output models.
- Keep models simple and avoid business logic in models.

 Middleware

- Use middleware for cross-cutting concerns.
- Keep middleware simple and focused on a single concern.

Repository
-Most of the time try to use the SQL Procedure for database interactions.
-If the Query is simple & sort we can use the LINQ with Lambda expressions.
-We should not write any inline query.
-For any parameter we should use the SQLParameter object so that we can avoid SQL injection attack.

 Routing

- Use attribute routing for controller actions.
- Use route templates that are meaningful and reflect the resource being accessed.

 5. Documentation

Code Comments
XML Documentation Comments

- Use comments sparingly and only when necessary.
- Write comments that add value and explain why the code is doing something, not what it is doing.

- Provide XML documentation comments for public members.
- Include information about parameters, return values, and exceptions.

 6. Security

Input Validation

- Validate and sanitize input parameters to prevent injection attacks.
- Implement input validation at both client and server sides.

Authentication and Authorization

- Use a robust authentication mechanism such as JWT (JSON Web Tokens).
- Implement proper authorization checks based on roles and claims.

7. Logging

- Use the NLog library for logging Errors & Informations.

 8. Error Handling

- Error handling should be used centrally

 

9. Performance

- Profile and optimize critical sections of the code.
- Use asynchronous programming for I/O-bound operations.
- Implement caching where appropriate.

 10. Versioning

- Implement versioning for your APIs, such as using API versioning middleware.
- Clearly communicate breaking changes and provide migration paths.

 11. Best Practices

 Dependency Injection

- Use dependency injection for managing dependencies.
- Favor constructor injection over property injection.

 Async Programming

- Use `async` and `await` for asynchronous programming.
- Follow the async method naming convention (e.g., `GetItemsAsync`).

Configuration Management

- Use the Configuration API for managing application settings.
- Store sensitive information securely, such as using Azure Key Vault.

 
12. Conclusion

Following these coding standards will contribute to the creation of a maintainable, scalable, and robust .NET Core Web API project. Consistency in coding practices is crucial for collaboration among team members and long-term project success.

 References

- [Microsoft C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)
- [ASP.NET Core Documentation](https://docs.microsoft.com/en-us/aspnet/core/)
- [RESTful API Design Guidelines](https://restfulapi.net/)
 
 */