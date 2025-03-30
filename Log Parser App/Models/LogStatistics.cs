using System;

namespace Log_Parser_App.Models;

public record LogStatistics
{
    public int TotalEntries { get; set; }
    public int ErrorCount { get; set; }
    public int WarningCount { get; set; }
    public int InfoCount { get; set; }
    public int OtherCount { get; set; }
    
    public double ErrorPercentage => TotalEntries > 0 ? Math.Round((double)ErrorCount / TotalEntries * 100, 1) : 0;
    public double WarningPercentage => TotalEntries > 0 ? Math.Round((double)WarningCount / TotalEntries * 100, 1) : 0;
    public double InfoPercentage => TotalEntries > 0 ? Math.Round((double)InfoCount / TotalEntries * 100, 1) : 0;
    public double OtherPercentage => TotalEntries > 0 ? Math.Round((double)OtherCount / TotalEntries * 100, 1) : 0;
    
}