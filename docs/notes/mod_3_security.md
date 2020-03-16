# Security
* `Salting` is a concept to add to a password with a random addition to the password store per user. This is used to help make easy passwords more complex.

# Token Authentication
Tokens will allow users to not have to maintain a consistent connection to our API.
A concept with token validation is that the server does not need to go back to the DB to validate the user. It needs to validat the token itself without hitting a data store.

* `JSON Web Tokens`
  * Using this as it's an industry standard for tokens.
  * Self contained piece of data including:
    * Credentials
    * Claims
    * Other info.
  * `JWT Structure` This is just a file.
    * __Header__
      * Metadata about this file
    * __Payload__
      * The meaningful data of the file.
      * This will be human readable, so concern must be taken with what data is stored here.
    * __Secret__
      * Used to encode/hash the header and the algorithm (a separate value). 
      * The secret is stored on the server and never is sent to the client. 
        * The client sends THIS WHOLE TOKEN to the server, and the server would then use this secret to validate the Token it recieved. 
    * The client is able to decode the Header and Payload without needing the _secret_. If the _secret_ does not match what is on the server, then it won't pass validation on the server, and a user that tried to invent the token without the server will fail validation.
    * The `JWT` will be stored locally on the client after authenticating with the server. Any further requests after recieving the Token will have the client sending the Token along for every further request that requires authentication. 
      * By sending the token, the server can verify the user based on the _secret_. The server will do this based on any request it wants.

## Resources
* jwt.io is a website to dump the token from a successful Login's response Body (found in the bottom of Postman). You can copy and paste the Encoded `JWToken`, and you can see the decoded content in the website. 
  * An extra reason to not put anything important in the Token as it can be easily decoded!

## Using Authentication Required Call
1. Get the token via the Auth login endpoint we created. Copy that token. 
1. Go your query for an authentication required call.
    1. In the Header:
        * Key: `Authorization`
        * Value: `Bearer <copied_key>`

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

## `dotnet user-secrets`
* `dotnet user-secrets` allows us to store secrets for DEVELOPMENT ONLY. This does not apply to Production.
While this is cool, for the Production environment, we almost certainly want to use Environment variables.
### How to Setup `user-secrets`
1. `dotnet user-secrets init`
1. `dotnet user-secrets set "Category:Token" "my value"`
1. `dotnet user-secrets list`

# Angular

# Chrome Debugging

