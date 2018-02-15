# AspNetCoreLocalization

This is sample solution for my blog post [ASP.NET Core: Simple localization and language based URL-s](http://gunnarpeipman.com/2017/03/aspnet-core-simple-localization/). I have got many requests to publish working sample and here it is.

## Some notes

* Current language and redirect to default language are handled in BaseController class
* Startup class initializes localization support, don't skip it
* Check the Index view of Home controller to see how view is localized
* About view shows how to use custom localizer
* Contacts view shows how to use culture based views
* Check layout page to see how to define routes with language token