# Example project for development containers using .NET

This is a simple .NET application intended to provide a working API.

This application has several endpoints exposed with the default port being 5088. 

This application also have a Dockerfile for containerised builds and can be built with the command `docker build -t java16-docker .`

Example API call:
- http://localhost:8080/greeting

### Run the app
Run the command `dotnet run` in the dotnet folder of the repo.

**Paths**
- https://localhost:5088/swagger.
- https://localhost:5088/weatherforecast
- https://localhost:5088/securitychampions

