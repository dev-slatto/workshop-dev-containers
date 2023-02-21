# Example files for Development Containers
**Welcome to the workshop files for working with development containers!👋🏻**

This repository was created for [Security Champions Norway's meetup #3](https://sikkerhet.bouvet.no/security_champion/meetup_scnorge_3/) at Bouvet, and the keynote `Cloud Development: Secure your endpoints with containerised development environments`.

If you find this repository valuable, feel free to give it a star ⭐️

This project is structured with the main branch containing four different example applications in different languages (C#, Java, Typescript & Python) exposing a web server. On the branch `complete` you will find the same files, but now with a config for running development containers for the different applications. If you want to contribute to these files or want examples for other languages, please have a look at [CONTRIBUTING.md](CONTRIBUTING.md)

## What is Develpoment Containers?
A Development Container (or Dev Container for short) allows you to use a container as a full-featured development environment. It can be used to run an application, to separate tools, libraries, or runtimes needed for working with a codebase, and to aid in continuous integration and testing. Dev containers can be run locally or remotely, in a private or public cloud.

One of the big benefits with development containers is that your work environment will work the same way both on Github Codespaces, as well as locally on your machine. This makes it possible to work on the Codespaces (online) by default, but also having the workspace locally if you need to work offline. 

For development containers to work you would need to have a `.devcontainer` folder in your repository with a `devcontainer.json` file. To see the definition of the json file, navigate to the [documentation](https://github.com/microsoft/vscode-dev-containers/tree/main/containers) for development containers. 

## Local development with containers
In this workshop we'll use Virtual Studio Code as our editor for working with the development containers. For this to work, you will have to download the VSCode [Dev Containers](https://marketplace.visualstudio.com/items?itemName=ms-vscode-remote.remote-containers) plugin. 

This will help you spin up repositories with existing configs, and even better - help you configure new repositories with a step-by-step guide. 

Note that you need to have Docker installed locally as the plugin utilises this under the hood.

## Using Github Codespaces
If you want to use Github Codespaces you first of all need to configure your repository with a Codespace. For guides on how you can configure this, please the the [official documentation](https://docs.github.com/en/codespaces/developing-in-codespaces/creating-a-codespace-for-a-repository).

A Github Codespace is a development environment that’s hosted in the cloud. Codespaces run on a variety of VM-based compute options hosted by GitHub.com, which you can configure from 2 core machines up to 32 core machines. You can connect to your codespaces from the browser or locally using Visual Studio Code.

## Security in Development Containers
Using development containers also opens up for some pretty nice features when it comes to security. In your traditional local development you install some local dependencies to make applications work, mix it with some application dependencies and suddenly you have a lot of installed artifacts that all can introduce security vulnerabilities. Some developers may also contribute on open source projects as well, introducing unknown application dependencies to be installed on your corporate device. 

When using development containers you can scan and maintain your development environment with the same tools as you would with your application containers. Combine this with a CI/CD workflow and Snyk you can get build and vulnerability reports whenever there is a pull request that introduces new dependencies into the development environment, or you can run it periodically. To take it one step further you can also combine your development containers with tools like dependabot and get automated pull request against your development environment, as well as your application whenever there is a security update or a new version of a dependency.   

## Working with external resources
When working with development containers you can configure some atributes regarding port forwarding. Port forwarding is nessesary from your container to communicate with the ports your application exposes. One of the option in the `devcontainer.json` file is to automatically expose all ports from the container to the local host. When working with secure development we tend to not do this but rather define what port we need exposed. One of the big benefits with this is that you can have a QA or staging connection open on your local machine to a DB, but your development environment can't reach it as the port isn't exposed. This can be of great value if you forget that you have an open connection on a default port, say 5432 for PostgeSQL, so that a DB migration set to run on application boot dosen't modify the database unintentionally. 

Another great feature with development containers is that you can install the dependencies and CLI's you would need to develop the application without it having to conflict with existing versions on your local machine. Let's say that you're working with an application running on AWS, then you can install the exact version of the CLI that's needed for that application. You can then also choose to define some configurations for the CLI, so say that your organisation have adopted the multi-account best practices from AWS, you can then have a dedicated container configured with AWS config for that account without it affecting your local configuration of the CLI.  

Another feature that's worth highlighting is the benefits of working with secrets in the development containers. Say that your team has adopted a secrets manager like Vault or AWS Secrets Manager to store environment variables for your application, and that this is the case for all environments - including local development. You can then either combine this with the point above regarding CLI's configured to dedicated environments, or you can utilise the sections in `devcontainer.json` that allows you to run scripts on either the local machine or the remote container. This way the application can have the same configuration across environments without the need for multiple environment files, but your configuration file for the container has defined what the environment should be. 


## Guides and Documentation
- [Official docs for Development Containers](https://containers.dev/)
- [Github Org. for Development Containers](https://github.com/devcontainers)
- [Starter Template for Develpoment Containers](https://github.com/devcontainers/template-starter)
- [Security Champions Norway](https://securitychampions.no/)
