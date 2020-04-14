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
* `https://www.json-generator.com/` Below is an example format for generating the women data (3 minor changes were made and then generated again to create men):
<details>
  <summary>Example Generate Format</summary>
[
  '{{repeat(5)}}',
  {
    Username: '{{firstName("female")}}',
    Gender: 'female',
    DateOfBirth: '{{date(new Date(1950,0,1), new Date(1999, 11, 31), "YYYY-MM-dd")}}',
    Password: 'password',
    KnownAs: function(){ return this.Username; },
    Created: '{{date(new Date(2017,0,1), new Date(2017, 7, 31), "YYYY-MM-dd")}}',
    LastActive: function(){return this.Created; },
    Introduction: '{{lorem(1, "paragraphs")}}',
    LookingFor: '{{lorem(1, "paragraphs")}}',
    Interests: '{{lorem(1, "sentences")}}',
    City: '{{city()}}',
    Country: '{{country()}}',
    Photos: [
        {
          url: function(num) {
          return 'https://randomuser.me/api/portraits/women/' + num.integer(1,99) + '.jpg';
        },
        isMain: true,
        description: '{{lorem()}}'
      }
    ]
  }
]
</details>



