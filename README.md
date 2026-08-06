# Wikipedia Search Application

A multi-project ASP.NET Core application that allows users to search Wikipedia articles through a clean MVC user interface and a custom Web API.

---

## Project Overview

This project demonstrates how to build a real-world ASP.NET Core application using a layered architecture.

Users enter a search term in the MVC application, which sends a request to a custom ASP.NET Core Web API. The API then communicates with the Wikipedia API, processes the response, and returns the results to the UI.

---

## Architecture

User
↓

MVC WebUI
↓
ASP.NET Core Web API
↓
Wikipedia Service
↓
Wikipedia External API

---

## Solution Structure

WikipediaSearch
│
├── Wikipedia.WebUI
│   ├── Controllers
│   ├── Views
│   └── Models
│
├── Wikipedia.Api
│   ├── Controllers
│   ├── Services
│   └── API Endpoints
│
└── Wikipedia.Shared
    └── DTOs

---

## Features

- Search Wikipedia articles
- ASP.NET Core MVC Frontend
- ASP.NET Core Web API Backend
- Shared DTO Library
- Dependency Injection
- HttpClientFactory
- Swagger Integration
- External API Consumption
- Clean Service Layer Architecture

---

## Technologies Used

- ASP.NET Core 9
- C#
- MVC
- Web API
- Razor Views
- Swagger
- HttpClientFactory
- Dependency Injection
- Visual Studio 2022

---

## API Endpoint

### Search Wikipedia

POST

/api/wikipedia/search

Request

{
  "searchText": "india"
}

Response

[
  {
    "title": "India",
    "description": "",
    "url": "https://en.wikipedia.org/wiki/India"
  }
]

---

## Learning Outcomes

Through this project I learned:

- Multi-project solution architecture
- MVC and Web API integration
- Dependency Injection
- HttpClientFactory usage
- Consuming external APIs
- JSON Serialization/Deserialization
- DTO design
- Swagger API testing
- Error handling and debugging

---

## Challenges Faced

### HTTP 403 Forbidden

Wikipedia API was rejecting requests.

Solution:
Added a User-Agent header and URL encoding.

### OpenAPI / Swagger Issues

Resolved package compatibility issues and configured Swagger correctly.

### Windows Security Blocking DLL Files

Adjusted Windows Security settings and exclusions to allow development builds.

---

## Future Enhancements

- Entity Framework Core
- Authentication & Authorization
- Logging with Serilog
- Caching
- AutoMapper
- FluentValidation
- Unit Testing
- Docker Support
- Clean Architecture

---

## Author

Rahul Chauhan

Software Developer | ASP.NET Developer | C# Developer

LinkedIn:
(Add your LinkedIn profile URL)

GitHub:
(Add your GitHub profile URL)
