# BoxManager

Application made to control the content of boxes and items within them. The  main objective is to apply
some design patterns, pratice good programming skills in a project and on database. Any tips, suggestion or
corrections are welcome :) 

## Getting Started

At the moment this application use SQL Server as database, so it's mandatory.
The (micro)ORM Dapper it's utilized with Dapper.Contrib to create cleaner an highly performatic connection with database.

To run the application, first execute the database.sql on the SQL Server instance, then set the password on the
connection string on app.config file. If your sql server instance isn't on localhost, then it's needed to set too.

### Patterns

Until now, it's utilized these patterns

```
MVC
Repository
Dependency Injection
```

And in future commits


```
Factory
Unit Of Work
Decorator
Chain of Responsibility
Services
```

And some good pratices, as variable nomenclature, use of Generics to evade code repetition, etc

## Using

* [Dapper](https://github.com/StackExchange/Dapper) - The (micro)ORM used
* [Dapper.Contrib](https://github.com/StackExchange/Dapper/tree/master/Dapper.Contrib) - Used to make a more cleaner use of Dapper
* [Nuget](https://www.nuget.org/) - Dependency Management
