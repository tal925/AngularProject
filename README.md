# Event Ideas Management System

A full-stack web application for managing ideas for events, built with Angular on the front end and a .NET C# Web API on the back end.

## Features

- Table view of all event ideas, showing: idea ID, idea name, activity type, target audience, duration (in minutes) and idea status
- Add, edit and delete ideas
- Form validation:
  - All fields are required
  - Duration must be a positive number
  - Idea name must be at least 3 characters
  - Idea ID and idea name must be unique (no duplicates)
- Activity type and target audience are chosen from predefined lists (no free text)
- Each idea has a status: Pending Approval (default), Approved or Rejected
- Only an admin can change an idea's status

## Tech Stack

| Layer | Technologies |
|-------|--------------|
| Front end | Angular, TypeScript |
| Back end | .NET, C#, Web API |

## Project Structure

```
AngularProject/
├── Client/          # Angular front end
└── Server/Server/   # .NET C# Web API
```

## Getting Started

### Prerequisites

- Node.js and the Angular CLI
- .NET SDK

### Server

```bash
cd Server/Server
dotnet run
```

### Client

```bash
cd Client
npm install
ng serve
```

Then open `http://localhost:4200` in your browser.
