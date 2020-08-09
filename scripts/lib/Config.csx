#r "nuget: YamlDotNet, 8.1.0"

using System.Linq;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

public IEnumerable<ConfigLookupEntry> ReadConfig(string configFilePath)
{
    Config config;
    using (var input = File.OpenText(configFilePath))
    {
        var deserializer = new DeserializerBuilder()
            .Build();

        config = deserializer.Deserialize<Config>(input);
    }

    var lookupTable = config.Categories.SelectMany(cat => cat.Services.Select(service => new ConfigLookupEntry
    {
        Category = cat.Name,
        ServiceSource = service.Source,
        ServiceTarget = service.Target
    }));

    return lookupTable;
}

public void WriteConfig(IEnumerable<ConfigLookupEntry> configLookup, string fileName)
{
    var categories = configLookup.Select(o => o.Category).Distinct().ToList();

    // build the config object
    Config config = new Config();
    config.Categories = new List<AzureCategory>();

    foreach (string category in categories)
    {
        AzureCategory azureCategory = new AzureCategory { Name = category };
        azureCategory.Services = new List<AzureService>();

        IEnumerable<ConfigLookupEntry> serviceItems = configLookup.Where(o => o.Category == category);

        foreach (ConfigLookupEntry item in serviceItems)
        {
            azureCategory.Services.Add(new AzureService { Source = item.ServiceSource, Target = item.ServiceTarget });
        }

        config.Categories.Add(azureCategory);
    }

    using (StreamWriter streamWriter = new StreamWriter(fileName, false, Encoding.UTF8))
    {
        var serializer = new SerializerBuilder().WithNamingConvention(PascalCaseNamingConvention.Instance).Build();
        serializer.Serialize(streamWriter, config);
    }

}

public class ConfigLookupEntry
{
    public string Category { get; set; }

    public string ServiceSource { get; set; }
    
    public string ServiceTarget { get; set; }
}

private class Config
{
    public List<AzureCategory> Categories { get; set; }
}

private class AzureCategory
{
    public string Name { get; set; }

    public List<AzureService> Services { get; set; }
}

private class AzureService
{
    public string Source { get; set; }

    public string Target { get; set; }
}