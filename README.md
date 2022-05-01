# EmailConsole
 A test/demonstration console app for my EmailHandler DLL

## How to build
 1. Follow the instructions for building the EmailHandler DLL found here: https://github.com/cdnworks/EmailHandler

 2. Clone this repo with:
 ```
 git clone --recursive https://github.com/cdnworks/EmailConsole.git
 ```
 3. Open the .sln with Visual Studio 2019 or newer and make sure your path to the EmailHandler DLL is set properly.
 4. Build the project

## Build Troubleshooting
 
 If MailKit isnt included when loading the solution, run nuget CLI and use the following command:
 ```
 Install-Package MailKit
 ```
 Ensure you've filled the fields of the App.config file
 
## Usage
 1. After cloning the repo, fill out the fields in the App.TEMPLATE.config file
 2. Create a copy/Rename the template file to App.config
 3. After building the project from the solution, you can either run it in debug or run the .exe.
 4. The console will prompt the user to enter a destination email address, after which it'll send a test message. Use an email you have access to!
 5. Check the destination email inbox to view your message!
 
### App.config settings
```
    <add key="host" value="smtp server address"/>
    <add key="port" value="smtp server port"/>
    <add key="userName" value="user name"/>
    <add key="userEmail" value= "user email"/>
    <add key="userPass" value="SMTP auth password"/>
```

## References
 More info on my EmailHandler DLL can be found here: https://github.com/cdnworks/EmailHandler
 More info on MailKit can be found here: https://github.com/jstedfast/MailKit
 
## Contribution
 Feel free to make a PR if you would like to add or change anything.
