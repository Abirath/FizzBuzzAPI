# FizzBuzzAPI

A .Net core web API application to expose FizzBuzz endpoints. 
- The application is built using ORM framework - Entity Framework core code first approach and SQL server for database backend. 
- The API exposes one operation - FizzBuzz which is a list with two json items - id and value.
- The API is documented using swagger ui

This API serves as data provider for the frontend application [fizzbuzz-ui](https://github.com/Abirath/fizzbuzz-ui) developed using Reactjs.

## Back-end Setup

- The application uses sql server connection string setting and points to the local workspace, Update `appsettings.json` file with the correct connection string.
- On the initial startup, the application will create a database named: ***FizzBuzzDB*** and a table named: ***FizzBuzzStoretbl*** on Sql server database. 
- The application populates values in the table on the following conditions: 
  * numbers **1** to **100** will be added to the table, where the word ***Fizz*** will be updated for any number which is a multiple of **3**,
  * the word ***Buzz*** will be updated for multiples of **5** and,
  * the word ***FizzBuzz*** will be updated for multiples of both **3** and **5**.

The application ideally runs on ssl port no: **44358**
