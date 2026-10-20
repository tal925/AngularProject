# Event Ideas Management System

A full-stack web application for managing ideas for events. The front end is built with Angular and the back end is an ASP.NET Core (.NET 8) Web API.

## Features

- Table of event ideas showing ID, title, activity type, target audience, duration (in minutes) and status
- Add a new idea with a form and delete an existing idea
- Form validation on the client: the title must be at least 3 characters and the duration must be a positive number
- Activity type and target audience are chosen from predefined dropdown lists (no free text)
- New ideas get the default status "pending approval"
- REST API with endpoints to get, add, update and delete ideas; the server assigns each new idea an ID
- Swagger UI for exploring the API in development

## Tech Stack

| Layer | Technologies |
|-------|--------------|
| Front end | Angular 21, TypeScript, template-driven forms, `HttpClient` |
| Back end | .NET 8, ASP.NET Core Web API, C#, Swagger |

## API Endpoints

| Method | Route | Description |
|--------|-------|-------------|
| GET | `/api/ideas` | Get all ideas |
| GET | `/api/ideas/{id}` | Get one idea (404 if not found) |
| POST | `/api/ideas` | Add an idea |
| PUT | `/api/ideas/{id}` | Update an idea (404 if not found) |
| DELETE | `/api/ideas/{id}` | Delete an idea (404 if not found) |

## Project Structure

```
AngularProject/
├── Client/project/       # Angular front end
└── Server/Server/Server/ # ASP.NET Core Web API
```

## Getting Started

### Prerequisites

- Node.js and npm
- .NET 8 SDK

### Run the server

From `Server/Server/Server`:

```bash
dotnet run --launch-profile https
```

The API listens on `https://localhost:7197` (and `http://localhost:5137`). Swagger is available at `https://localhost:7197/swagger`.

### Run the client

From `Client/project`:

```bash
npm ci
npm start
```

Open `http://localhost:4200` in your browser. The client sends requests to `https://localhost:7197/api/ideas`.

## Known Limitations

- Ideas are stored in a static in-memory list on the server, so the data is reset whenever the server restarts
- The API supports updating an idea, but the UI does not have an edit form yet
- Validation is done in the UI only; the API does not validate the data
- Unique idea names and admin-only status changes are not implemented
