# OneLibraryTwoVersions
How to compile and run a project that contains two version of the same library

## Steps

 - Add the two dll's in the project references.
 - Disable local copy for both
 - Add some Alias
 - Reference the librarty with `extern alias *referenceAlias*;`
 - Disable automatic linq redirection
 - Edit app.config
