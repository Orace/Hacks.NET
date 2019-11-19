# OneLibraryTwoVersions
How to compile and run a project that contains two version of the same library

## Steps

 - Add the two dll's as content items
 - Enable local copy for both
 - Add the two dll's in the project as references
 - Disable local copy for both
 - Add differents Aliases for both references
 - Reference the library with `extern alias *referenceAlias*;`
 - Disable automatic linq redirection
 - Edit app.config
