# showbuddy
A TV show tracker for friends

### Prereqs to develop this project

C#
.NET 8
.NET MAUI

You'll need to get an API key from omdbapi, see instructions at https://www.omdbapi.com/
Create a file called ".env" without the quotes in the directory ShowBuddy/Resources/Raw/
Once you have a file ShowBuddy/Resources/Raw/.env, open it and add this line:
```
OMDB_API_KEY={your api key}
```

with {your api key} replaced with the one you got from omdbapi.com

---

### Build process

Clone this repository
Change into the directory
Start the application

```sh
git clone https://github.com/Usarneme/showbuddy
cd showbuddy/ShowBuddy
dotnet run
```

---

Copyright (c) 2024 github.com/Usarneme
