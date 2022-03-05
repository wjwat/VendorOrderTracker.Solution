# Vendor & Order Tracker

#### By [Will W.](https://wjwat.com/)

#### Implement a vendor & order tracker for Pierre's Bakery.

## :computer: Technologies Used

* C#
* .NET 5.0
* ASP.NET Core
* Razor
* dotnet script REPL
* MSTest
* HTML
* CSS
* Sparkling water & a song in my heart.

## :memo: Description

Pierre was so in love with the last project we made for him he decided to ask
for another. This project covers the lessons we learned at Epicodus over using
C# & ASP.Net to build a RESTful application.

## :gear: Setup/Installation & Usage Instructions

- [Clone this
  repository](https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository)
  to your device
- [Install the .NET 5 SDK](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net)
- [Using your
  terminal](https://www.freecodecamp.org/news/how-you-can-be-more-productive-right-now-using-bash-29a976fb1ab4/)
  navigate to the directory where you have cloned this repo.
- Run `dotnet build VendorOrderTracker` in the top level directory of this repo.
- Run `dotnet run --project VendorOrderTracker` to get the program running, and the site hosted locally.
- Visit `http://localhost:5000` to try the site out.
  - Please make sure to look at your terminal to determine the port number you should be visting in your browser. It may change between runs.
  - Ex:
    ```shell
    $ dotnet run --project VendorOrderTracker
      Hosting environment: Production
      Content root path: /path/to/VendorOrder/Tracker/VendorOrderTracker
      Now listening on: http://localhost:5000
      Now listening on: https://localhost:5001
      Application started. Press Ctrl+C to shut down.
    ```
- If you'd like to run the tests please run `dotnet test VendorOrderTracker.Tests` in the top level directory.

## :world_map: Roadmap

* [ ] Be able to delete specific vendors
* [ ] Be able to delete specific orders from vendors
* [ ] Be more consistent with styling
* [ ] A better overall UX
* [ ] Handle edge cases
* [ ] Custom 404

## :lady_beetle: Known Bugs

* If any are found please feel free to open an issue or email me at wjwat at
  onionslice dot org

## :warning: License

MIT License

Copyright (c) 2022 Will W.
