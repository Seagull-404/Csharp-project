public class EnvVarConfigService : IConfigReader
{
    public string GetValue(string name)
    {
        return Environment.GetEnvironmentVariable(name);
    }
}