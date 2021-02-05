# FizzBuzzAPI

A .Net core web API application to expose FizzBuzz endpoints. 
- The application uses ORM framework - Entity Framework core and SQL server for database backend. 

The API exposes one operation - FizzBuzz with two json items - id and value.

## Back-end Setup

- The application uses sql server connection string setting and points to the local workspace, Update `appsettings.json` file with the correct connection string.
- On the initial startup, the application will create a database named: ***FizzBuzzDB*** and a table named: ***FizzBuzzStoretbl*** on Sql server database. 
- The application populates values in the table on the following conditions: 
  * numbers **1** to **100** will be added to the table, where the word ***Fizz*** will be updated for any number which is a multiple of 3,
  * the word ***Buzz*** will be updated for multiples of 5 and,
  * the word ***FizzBuzz*** will be updated for multiples of both 3 and 5.

The application ideally runs in ssl port no: 44358
