#! "netcoreapp3.1"
#load "Config.csx"

/*
    This script generates a new Config.yaml file based on the folder structre based on the contents of the /source/official and /source/manual directories.
    The folders within these directories are used as "categories" in the Config.yaml file
*/

using System.Collections.Generic;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

private string sourceDir;

private string targetDir;

private string  originalSourceFolder;

private string manualSourceFolder; 

List<ConfigLookupEntry> configList;

// Main();

public bool CreateConfig(string srcDir, string trgDir, string configFileName)
{
    sourceDir = srcDir;
    originalSourceFolder = Path.Combine(sourceDir, "official");
    manualSourceFolder = Path.Combine(sourceDir, "manual");
    
    targetDir = trgDir;
    
    configList = new List<ConfigLookupEntry>();
    ProcessDirectory(originalSourceFolder);
    ProcessDirectory(manualSourceFolder);
    WriteConfig(configList, configFileName);
    return true;
}

private void ProcessDirectory(string dir)
{
    // Process the list of files found in the directory.
    string [] fileEntries = Directory.GetFiles(dir);
    foreach(string fileName in fileEntries)
        ProcessFile(fileName);

    // Recurse into subdirectories of this directory.
    string [] subdirectoryEntries = Directory.GetDirectories(dir);
    foreach(string subdirectory in subdirectoryEntries)
        ProcessDirectory(subdirectory);

}

private void ProcessFile(string path) 
{
    string fileName = Path.GetFileName(path);
    if (fileName == "README.md") return;

    string fileNameNoExt = fileName.Split(".")[0];

    string serviceName = "";

    if (path.Contains("official"))
    {
        serviceName = fileName.Substring(19).Split(".")[0].Replace("-", "");
    }
    else
    {
        serviceName = fileName.Split(".")[0].Replace("-", "");
    }

    string serviceCategory = System.IO.Directory.GetParent(path).Name.Replace(" ", "").Replace("+", "");

    configList.Add(new ConfigLookupEntry { Category = serviceCategory, ServiceSource = fileNameNoExt, ServiceTarget = serviceName });
}