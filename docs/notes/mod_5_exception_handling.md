# ASP.NET Core
## How to Start Application Not In Developer Mode
* See `src\DatingApp.API\Properties\launchSettings.json` "DatingApp.API" : { "environmentVariables" : { "ASPNETCORE_ENVIRONMENT": __PRODUCTION__}}

# Angular

# Chrome Debugging
* __500 Error__ Is always based on the Server Application (Not Angular). You should start by checking the terminal from the ASP.NET Core logs.
    * To get output in Prod, you can return `new StatusCode` from the Controller with a message. This will be displayed in both Dev and Prod environments as the endpoint is being specific about the error to return.
## User Messages
![Where to find in the Debugger](notes_images/user_messages_chrome_debugger.png)
User messages can come from the Nav components. This will show errors in a more meaningful way of what's being passed back in exceptions.

## When an Exception is Thrown in Client App
1. General exception being thrown can be seen in the Console tab of Chrome.
    1. In the __Network__ tab, you can see the more meaningful Exception Callstack.