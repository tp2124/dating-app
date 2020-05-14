# Useful Commands
## Angular
* `ng serve` in the directory boots up the Angular Application.
* `npm install` to install fresh from the `packages.json` dependencies.
* Extension Hotkeys:
    * Mac: `shift + option + [u,i,o]` will shift between a components: `.ts`, `.html`, and `.css`
    * Windows: `alt + [u,o,p]` for the hotkeys above.
    * type: `div.my-div-name` and hit Enter. This will then create the HTML tag and do all the awkward character typing for you.
    * In a component .html, type `a-ngmodel` then Enter, this will substitute the `[(ngModel)]="vairable"`. This saves the odd character typing.
    * `a-routerlink` will expand to include all the router link element of an html.

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

### How to Hit API Endpoint with Auth
1. Get auth token from logging in via `api/auth/login`
    1. This needs `username` and `password` set.
1. Copy the return string value from `token` in the response.
1. Go to your protected endpoint.
1. Add to your Header:
    1. `Key`: `Authorization`
    1. `Value`: `Bearer <copied_token_value>`

# Debugging
## VS Code
* Attaching to a running instance of your web API.
    * When using `.NET Core Attach`, attach to `<name_of_project>.exe`.
    * If that doesn't exist, you want to attach to the `<name_of_project>.dll` instance of `dotnet`.