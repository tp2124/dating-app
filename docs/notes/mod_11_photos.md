# General Backend
## Photo Storage Options
* What storage should we use for photos? 
    * In DB as BLOBs? 
        * +Easy to program and it can be authenticated easily.
        * -Is inefficient to access and with it's storage. Takes up space directly on the server. Hard to scale.
    * In a File System? 
        * +Efficient with space and made to handle files.
        * -Can be expensive and takes up space on the server. Hard to scale. Storage can be expensive.
    * __In a Cloud Service?__
        * +This allows us to scale and use the storage type solutions.
        * -This will have added complexity with our code to be able to ensure authentication, storing references instead of data directly.

For this, we will be using Cloud Storage and using __Cloudinary__ due to it's great free tier. It also supports API Keys and API Secrets.

## Testing Photos Controller
![Testing Photos Controller](images/testingPhotosController.png)
1 = This string must match what the name of the paramter of the `IFormFile` in the Creation Dto

### Flow Diagram
![Data Flow](images/photoStorageFlow.png)

## Uploading File in Angular
* Install notes are at: https://valor-software.com/ng2-file-upload/ .

## Displaying the Main Photo of Logged in User in NavBar
* Should attempt to avoid, even though it'd be easy, to call the repository to GetUsersMainPhoto in order to avoid the extra network call.
* Could have the photoURL passed in the Login() Token in `AuthController.cs`, but this token is passed with every single call. It'd be best to keep this as small as possible. This is also problematic when a user changes their Main Photo. This would require getting a new token from the API everytime the MainPhoto is changed as wel...
* We are passing down the User Information, alongside the token not in it, when a user Logs in. 

## Any to Any Component Communication
* `BehaviorSubject` is a type of observable we will use in our AuthService that all components that want the photo can reference.
![AnyToAnyComponent](images/AnyToAnyComponentSetup.png)

# ASP.NET Core
* Running `dotnet ef migrations add AddedPublicId` to generate migration for new property in `Photo`
* Using NuGet plugin to install `CloudinaryDotNet`. `dotnet restore` after this to ensure the package is retrieved. 

## Delete Photo
* Need to clear from both
    * Cloudinary
    * DB Reference to Cloudinary URL
* How to handle photos from both Cloudinary and random photo API.

# Angular

# Chrome Debugging
