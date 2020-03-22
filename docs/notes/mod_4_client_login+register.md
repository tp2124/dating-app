# ASP.NET Core
## API Defaults
* The default `content-type` is `application/json`. This will be used if nothing is provided in a `post` header.

# Angular
## Shortcuts
* Creating component: use the right click in the Solution Explorer `Create Component` and this will stub in the required changes and referneces.

## Concepts
### Component
The main goal of a component is to be plain old data. Keep Components as simple as possible!
The job of a component is to provide data to the HTML template.
* A service is a great to stop components from duplicating requests to gather data. Components can then interface with the service instead of writing queries explicitly.
    * There is a `Generate Service` with all the Angular extensions we installed.
    * This is similar to the `repository` on the API code.
Components are automatically `@Injectable`. That is why you won't see them explicitly tagged, but they will be in services.
#### Parent to Child Component Communication
We are sending data down in this example and share data amongst components.
* `Input` in the child, will have the parent communicate data to the child.
* `Output` in the child, will have the child communicate data to the parent.
    * `Output`s will be event emitters that will be monitored/listened to by the parent.

### Forms
Forms can support 2 way bindings from the template (HTML) to the form.
* `name=<string>` is required by Angular to designate form controls.
There are 2 types of ANGULAR forms:
* `Template` - Meant to be simpler
    * `#loginForm="ngForm"` into the `<form>` tag.
    * `#registerForm="ngForm"`
* `Reactive` 
#### States
* Valid: Successfully meeting all validation criteria. This is dictated by other attribtes. Example: `[disabled]`
* Touched: Something has been typed and focus has left the form.
* Dirtied: Something has been typed into the form.

### Structural Directive
Structural Directives will directly change the DOM. 
`*ngIf=` This Structural Directive is denoted due to the `*`. This will completely remove this tag, and it's children, from the DOM if it fails.

# Chrome Debugging
In the Inspector (F12), you can use the Network tab to see what calls have gone out from the client application.