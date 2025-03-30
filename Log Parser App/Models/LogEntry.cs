using System;

namespace Log_Parser_App.Models;

public record LogEntry
{
    public DateTime Timestamp { get; set; }
    public string Level { get; set; }
    public string Source { get; set; }
    public string Message { get; set; }
    public string RawData { get; set; }
}