
# Useful Commands
## Angular
* `ng serve` in the directory boots up the Angular Application.
* `npm install` to install fresh from the `packages.json` dependencies.
* Extension Hotkeys:
    * Mac: `shift + option + [u,i,o]` will shift between a components: `.ts`, `.html`, and `.css`
    * Windows: `alt + [u,o,p]` for the hotkeys above.
    * type: `div.my-div-name` and hit Enter. This will then create the HTML tag and do all the awkward character typing for you.
    * In a component .html, type `a-ngmodel` then Enter, this will substitute the `[(ngModel)]="vairable"`. This saves the odd character typing.

## .NET
* `dotnet user-secrets`
    * `dotnet user-secrets init`
    * `dotnet user-secrets set "Category:Token" "my value"`
    * `dotnet user-secrets list`
* `dotnet ef`
    * `dotnet ef migrations`
        * `dotnet ef migrations add <name>`
        * `dotnet ef migrations remove <name>`
        * `dotnet ef database update`
* `dotnet watch run`
* `dotnet tool install --global dotnet-ef`
