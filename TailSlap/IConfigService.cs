public interface IConfigService
{
    AppConfig LoadOrDefault();
    void Save(AppConfig cfg);
    string GetConfigPath();
    AppConfig CreateValidatedCopy();
    event System.Action? ConfigChanged;
}
