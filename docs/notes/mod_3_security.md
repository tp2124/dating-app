# Security
* `Salting` is a concept to add to a password with a random addition to the password store per user. This is used to help make easy passwords more complex.

# ASP.NET Core
## EF Core
* When adding a new model, be sure to update the DataContext.cs in order to be able to have that data represented in the DB.
  * A migration will also need to happen to update the DB table and convert any existing data. Done via the following CLI cmds:
    1. `dotnet ef migrations add AddedUserEntity`
    1. `dotnet ef database update`
    1. Check in DB browser that the `.db` file, `datingapp.db`, has been updated with the expected tables/data.

## Useful commands

# Angular
### Useful Files

### General Concepts

### Types

### Useful Commands

### Shortcuts with Extensions

# Chrome Debugging

