# Contacts
## Table of Contents
1. [General Info](#general-info)
2. [Technologies](#technologies)
3. [Installation](#installation)

### General Info
***
Api made whit Repository Pattern C#, for educational purposes
### Screenshot
![image]
## Technologies
***
* [.NETFrameworkCore](https://dotnet.microsoft.com/download/dotnet/5.0)
* [MySql](https://www.mysql.com/)
* [Blazor]()
* [Docker](https://www.docker.com/)
## Installation
***

dotnetcore ef CLI
```
$ dotnet tool install --global dotnet-ef
$ dotnet tool update --global dotnet-ef
$ dotnet add package Microsoft.EntityFrameworkCore.Design
$ dotnet add package MySql.EntityFrameworkCore
```
Query
```
CREATE TABLE `Contacts` (  
`Id` int (11) AUTO_INCREMENT,  
`FirstName` nvarchar (50) NOT NULL,  
`LastName` nvarchar (50) NOT NULL,
`Phone` nvarchar (50) DEFAULT NULL,
`Address` nvarchar (250) DEFAULT NULL,
PRIMARY KEY (`Id`)
);
```

SDK Ubuntu
```
$ git clone https://github.com/josuecaleb6482/
$ sudo apt-get update; \
$ sudo apt-get install -y apt-transport-https && \
$ sudo apt-get update && \
$ sudo apt-get install -y dotnet-sdk-5.0
$ nano .env
```

Run the app
```
$ docker-compose run -d
$ dotnet watch run
```
Project made with Blazor wasm connecting to a mysql database mounted on an image with docker, mudblazor was used for the Ui. This aplication is made in Ubuntu but u can run it in Windows or Mac, you can also uncouple the repository and data classes in another library classes proyects for better maintenance.
Remember to write the .env file that had the environment variables.
If you find an issue with this library feel free to open an issue here on GitHub🙂.

![image](https://user-images.githubusercontent.com/20881963/130384334-6a3aeeed-1566-4293-bca3-b223e7ae2b7a.png)
![image](https://user-images.githubusercontent.com/20881963/130384365-097486ff-601f-489c-8096-58ddda77f81c.png)

