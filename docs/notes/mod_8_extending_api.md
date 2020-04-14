# ASP.NET Core
* `ReferentialAction.Cascade` in the migration script will mean that when the `User` is deleted, the `Photo`'s referenced by the `User` will also be deleted.
## How to recover in SQLIte from Applied Migration
__Normal flows__
1. use `dotnet ef database update <nameOfMigration>`

__SQLite flow__
SQLite should only be used for local and early development. With this mentality, we will drop the entire DB and re-create it with proper seeding.
1. `dotnet ef database drop` then confirm.
1. This will now work: `dotnet ef migrations remove`
1. `dotnet ef database update` This will result in the DB that is empty but has the schema before the last migration.

## Seeind Data to DB.

# Angular

# Chrome Debugging
