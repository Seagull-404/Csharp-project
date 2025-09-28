public class LayeredConfigService : IConfigReader
{
    private readonly IConfigReader[] _readers;

    public LayeredConfigService(params IConfigReader[] readers)
    {
        _readers = readers;
    }

    public string GetValue(string name)
    {
        foreach (var reader in _readers)
        {
            var value = reader.GetValue(name);
            if (!string.IsNullOrEmpty(value))
                return value;
        }
        return null;
    }
}