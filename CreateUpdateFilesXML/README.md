# CreateUpdateFilesXML
CreateUpdateFilesXML is a tool to create the `AutoupdateService.xml` file for [AutoUpdater](../AutoUpdater) 

# How to use?

you should set `publishUrl` variable as your publish url in the Code.

After run this console application,you can get right `AutoupdateService.xml` file.

You can reference this project in your publish project, and then `Open Project Properties`→ `Build Events`→Add **CreateUpdateFilesXML.exe** in `Post-build event command line:`

So,`AutoupdateService.xml` will be automatically created whenever you build your project.

