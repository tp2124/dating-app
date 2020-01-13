## To run Production instead of Development
* Open `launchSettings.json`, "profiles" { "<proj_name>" : {"environmentVariables" : {"ASPNETCORE_ENVIRONMENT" = ---->__"Production"__<------}}}

## Useful commands
* `dotnet watch run`
  * This will watch for any code changes and re-compile and build

## Angular
### Useful Files
* `app.module.ts` is required
* `package.json` stores all the module and version dependencies.
* "Components" are responsible for providing the data to the template Urls (HTML) that will be able to display the content.
  * The data in the view can be interpolated and replaced inside the HTML.
* the "module" will bootstrap a component. 
  * The module will be bootstrapped by `main.ts` at the root.
  * As we are only building a single page, we only need to bootstrap one thing.

### Useful Commands
* `ng serve` in the directory boots up the Angular Application.

# TODO
[ ] Change VSCode Settings to accept current file spacing techniques.