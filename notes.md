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

### General Concepts
* Angular CLI handles running minifier, WebPack, on all the code and bundles it. It also injects the javascript files into index.html. This will set up the html to be ready to handle the `<app-root></app-root>` instance.
  * No WebPack config, but `angular.json` is there that defines where the javascript will be injected to (at "index").
* `.spec.ts` is a file that can be used with testing.
* `Observable` = a stream of data to get from an API. 
  * It will have notifications that will be triggered when data comes in. To utilizes these notifications, code must `subscribe` to the Observable.

### Types
* `any` = `var` in C# or just any generic object can be assigned to this variable.

### Useful Commands
* `ng serve` in the directory boots up the Angular Application.

### Shortcuts with Extensions
* `shift + option + [u,i,o]` will shift between a components: `.ts`, `.html`, and `.css`

# TODO
[ ] Change VSCode Settings to accept current file spacing techniques.