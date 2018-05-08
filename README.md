# DotNet-WhatsMyFramework
Insetad of checking your exact .NET Version via your registery ([As Microsoft documentation describes](https://docs.microsoft.com/en-us/dotnet/framework/migration-guide/how-to-determine-which-versions-are-installed),
This exe tool let's you know easily which .NET version you have installed.

<img src="http://i.imgur.com/HSJasxU.png" height="90">


## How it works
Simply run the execution file, and retrieve both Environment and .NET Framework versions.

Make sure you run this application as **Administrator** (since Registery access is required).

## Behind the scenes
This project is based on .NET Console application.
Your registery **SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\** path is accessed on execution and version mapping applies.

## Output

![Output screenshot](http://i.imgur.com/tvIYYzg.jpg)

Note: Each execution generates a unique random ASCII Art drawing.

### Enjoy :)
