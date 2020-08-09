#! "netcoreapp3.1"

#load "lib/Config.csx"

using System.Collections.Generic;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

var sourceFolder = @"../source";

var originalSourceFolder = Path.Combine(sourceFolder, "official");

var manualSourceFolder = Path.Combine(sourceFolder, "manual");

var targetFolder = @"../dist";

List<ConfigLookupEntry> configList;

Main();

public void Main()
{
    configList = new List<ConfigLookupEntry>();
    ProcessDirectory(originalSourceFolder);
    WriteConfig(configList, "Config-new.yaml");
}

private void ProcessDirectory(string targetDirectory)
{
    // Process the list of files found in the directory.
    string [] fileEntries = Directory.GetFiles(targetDirectory);
    foreach(string fileName in fileEntries)
        ProcessFile(fileName);

    // Recurse into subdirectories of this directory.
    string [] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
    foreach(string subdirectory in subdirectoryEntries)
        ProcessDirectory(subdirectory);

}

public void ProcessFile(string path) 
{
    string fileName = Path.GetFileName(path);
    if (fileName == "README.md") return;
    
    string fileNameNoExt = fileName.Split(".")[0];
    string serviceName = fileName.Substring(19).Split(".")[0].Replace("-", "");
    string serviceCategory = System.IO.Directory.GetParent(path).Name.Replace(" ", "").Replace("+", "");

    configList.Add(new ConfigLookupEntry { Category = serviceCategory, ServiceSource = fileNameNoExt, ServiceTarget = serviceName });
}