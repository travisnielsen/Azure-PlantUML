# Generating the  distro

If you want to have customized builds and/or experiment with Azure-PlantUML, you can generate the Azure-PlantUML distro yourself.

## Prerequisites

The following software must be installed in your environment:

* [dotnet script](https://github.com/filipw/dotnet-script) for executing the scripts
* [PlantUML](https://chocolatey.org/packages/plantuml)
* [Inkscape](https://inkscape.org/)
* [rsvg-convert](https://chocolatey.org/packages/rsvg-convert#individual)

## Configure

Download the [Azure Architecture Icons](https://docs.microsoft.com/en-us/azure/architecture/icons) and copy all folders from `Azure_Public_Service_Icons` to the [source/official](../source/official) directory.

Place any .svg files that are not included in the Architecture Center icon distribution into the [source/manual](../source/manual) directory. Be sure to group these files into folders that match the structure of the `official` directory.

Ensure the following variables at the beginning of `main.csx` are correct configured for your system:

```csharp
var plantUmlPath = @"C:\ProgramData\chocolatey\lib\plantuml\tools\plantuml.jar";
var inkScapePath = @"C:\Program Files\Inkscape\inkscape.exe";
static string rsvgConvertPath = @"C:\ProgramData\chocolatey\bin\rsvg-convert.exe";
```

From the `scripts` folder, generate the `Config.yaml` file by executing:

```powershell
dotnet script config.csx
```

The contents of this file is based on the directory structure in `/source`. This file defines which sprites will be added to the disro and how they are grouped. Edit this file to remove redundant icons and re-organize groupings as necessary.

## Build

Create the distro by running the following command:

```powershell
dotnet script main.csx
```

From a logical point of view, the following happens:

1. All files and directories from `dist` folder are deleted
2. AzureCommon.puml is copied to `dist`
3. For all configured services in `Config.yaml` the SVG is loaded
    * The `source/manual` folder is used to supplement the original SVGs from Microsoft
    * A monochrome SVG is generated (necessary for PlantUML support)
4. From colored SVG a PNG is generated
5. From the monochrome SVG a PNG with white background is generated. This is needed for PlantUML sprite generation
6. A PlantUML sprite is generated
7. In a second round a PNG without background is generated from the monochrome SVG

    > During this process, it is ensured that the max size of length and width do not exeed `targetMaxSize`.

8. In addition to single Azure services PUML files, also a combined PUML file per category is generated
9. A markdown table with all Azure services, their colored and monochrom symbols and the PUML files is generated
10. VSCode snippets for all Azure services for their PlantUML usage are generated

## Update Azure Symbols file

Copy the contents from `table.md` into the table section of the [AzureSymbols](../AzureSymbols.md) file.
