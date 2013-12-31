# ProjectTemplate
The goal of this project is to provide a default and well structured C# project template.

## Front End
//TODO:

## BackEnd
The BackEnd is split into four different layers
1. API Layer: it contains the entry point of the backend. 
	- It should act as a Dummy caller for the services.
2. Services Layer: It contains the main logic of the application.
3. ServiceDependencies Layer: All the services or the logic of the application will contain some dependencies. You should reference those dependencies here.
	- Dependencies are not meant to be tested. 
4. Data Layer: It contains access to the database
	- Currently is using `entity framework` and `mysql` but it can be changed very easily. 
	

## Unit Test
The application contains Unit Tests on the services and for the testable classes in the API layer.

Note: the service dependencies layer should not be tested. 

## Integration Test
TODO:


## Dependencies
The project uses [Railway Oriented Programming](https://github.com/ElectNewt/EjemploRop) as a structure for the error handling.

It also uses [Netmentor.DiContainer](https://github.com/ElectNewt/Netmentor.DiContainer) as Dependency injection container.



## Contribute
If you are interested in helping, do not hesitate and send a PR or submit an issue with your ideas!