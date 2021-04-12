using RaaLabs.Edge.Modules.Configuration;


namespace RaaLabs.Edge.ModuleTemplate
{
    [Name("configuration.json")]
    public class ModuleTemplateConfiguration : IConfiguration
    {
        public int SampleConfigValue { get; }
    }
}
