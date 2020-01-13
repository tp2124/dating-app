# Security
* `Salting` is a concept to add to a password with a random addition to the password store per user. This is used to help make easy passwords more complex.

# ASP.NET Core
## Dependency Injection
* 3 Notable types of ways to add services to the IServiceCollection:
  1. `AddSingleton()` This creates a single instance of the class, and it will reuse it in all following calls. 
    * Can cause issues with concurrent requests as all calls are using the same instance. Really bad for Authentication (login information switching mid call)
  1. `AddTransient()` This is created everytime a new request comes in. Useful for lightweight stateless services.
  1. `AddScoped()` This services will be created once per request in the scope. 1 for each HTTP request. Re-used when being used within the same web requests.

## EF Core
* When adding a new model, be sure to update the DataContext.cs in order to be able to have that data represented in the DB.
  * A migration will also need to happen to update the DB table and convert any existing data. Done via the following CLI cmds:
    1. `dotnet ef migrations add AddedUserEntity`
    1. `dotnet ef database update`
    1. Check in DB browser that the `.db` file, `datingapp.db`, has been updated with the expected tables/data.

## Repository Pattern
* Basic concepts are creating an interface for the client to utilize without having to worry about the implementation. It's the basic definition of using an interface to keep code isolated.

# Angular

# Chrome Debugging

