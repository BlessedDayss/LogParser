namespace Log_Parser_App.Models;

public record PackageLogEntry : LogEntry
{
    public string PackageId { get; init; } = string.Empty;
    public string Version { get; init; } = string.Empty;
    public string Status { get; init; } = string.Empty;
    public string Dependencies { get; init; } = string.Empty;
    public string Operation { get; init; } = string.Empty;
    
}