
# Product Management

This repository contains an example of a project using Clean Architecture in .NET 8. It demonstrates a simple CRUD for Product Management with the use of the CQRS and Mediator patterns, as well as a Dockerized MSSQL Server. The API and the UI are built with Angular.

# Project Structure
The project is structured following the principles of Clean Architecture, with separate projects for the Domain, Application, Infrastructure, and Presentation layers.

# CQRS and Mediator Pattern
The Command Query Responsibility Segregation (CQRS) pattern is used to separate the read and write operations of the application. The Mediator pattern is implemented using the MediatR library, allowing loose coupling between objects by having these objects communicate indirectly.


## Authors

- [@Chiyaco](https://github.com/Chiyaco)


## Acknowledgements

 - [Awesome Readme .NET8 news](https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-8/overview)
 - [Angular](https://angular.io/)
 - [How to Dockerise](https://www.docker.com/)


## Tech Stack

**Client:** Angular, Type script

**Server:** .NET8, C#, Entity Framework Core, Clean Architecture, MediatR, CQRS, Docker

**Database:** MSSQL Server


## Run Locally

Clone the project

```bash
  git clone https://link-to-project
```

Go to the project directory

```bash
  cd my-project
```

Install dependencies

```bash
  npm install
```

Run the docker-compose.yml to run the back-end

```bash
docker-compose UP -d
```

to run the UI go to the folder of Project's UI

```bash
  ng serve --open
```

