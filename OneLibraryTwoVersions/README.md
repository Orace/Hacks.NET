# OneLibraryTwoVersions
How to compile and run a project that contains two version of the same library.

For a detailled description of the steps see https://stackoverflow.com/a/58951998/361177

## Steps

 - Add the two dll's as content items
 - Enable local copy for both
 - Add the two dll's in the project as references
 - Disable local copy for both
 - Add differents Aliases for both references
 - Reference the library with `extern alias *referenceAlias*;`
 - Disable automatic binding redirection
   see https://docs.microsoft.com/en-us/dotnet/framework/configure-apps/how-to-enable-and-disable-automatic-binding-redirection
 - Edit app.config
