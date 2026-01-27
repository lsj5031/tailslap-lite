public interface ILoggerService
{
    void Log(string message);
    void LogVerbose(string message);
    void Flush();
    void Shutdown();
}
