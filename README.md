# sitecore-fxm-provider-patch

Sitecore versions before 8.2 update 5 have a bug where any site definition that is missing cache size information,
and which also starts with a number throws an XPathException due to how Sitecore resolves the cache sizes.

Developers can easily avoid this when defining sites within include patch files. FXM, however, allows marketers and 
editors to create site definitions within Sitecore. If these site definitions start with a number then Sitecore will 
throw an exception whenever it attempts to handle a request making the entire site, including the Sitecore client 
and admin, inaccessible.

This custom provider gets around the problem by initializing the FXM site definitions with cache size information so that
Sitecore will not attempt to resolve it through other means.

There's no known hotfix for this issue but Sitecore Support says it is fixed in 8.2 update 5.

## Usage

1. Add a reference to Sitecore.FXM.dll (or Sitecore.FXM.NoRef if you're using the Sitecore nuget repository)
2. Include source files in project
3. Include App_Config file
4. Update FXMPatch.config with the correct assembly name (and namespaces if you change them)