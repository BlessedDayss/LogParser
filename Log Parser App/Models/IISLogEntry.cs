namespace Log_Parser_App.Models;

public record IISLogEntry : LogEntry
{
    public string ClientIp { get; init; }
    public string UserName { get; init; }
    public string Method { get; init; }
    public string UriStem { get; init; }
    public string UriQuery { get; init; }
    public string HttpStatus { get; init; }
    public string UserAgent { get; init; }
    public string Referer { get; init; }
    public int StatusCode { get; init; }
    public int Port { get; init; }
    public int TimeTaken { get; init; }
}