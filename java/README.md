# Example project for development containers using Java

This is a simple Java application using Spring Boot intended to provide a working API.

The application has configurations to work with both Maven and Gradle to make it easy to use with what adopters are familiar with.

This application has one endpoint exposed at the `/greeting` path with the default port being 8080. 

This application also have a Dockerfile for containerised builds and can be built with the command `docker build -t java16-docker .`

Example API call:
- http://localhost:8080/greeting

### Run the app
Run the command `mvn spring-boot:run` in the java folder of the repo.