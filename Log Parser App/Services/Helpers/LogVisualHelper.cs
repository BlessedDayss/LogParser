namespace Log_Parser_App.Services.Helpers;

public class LogVisualHelper
{
    public static string GetIcon(string level) => level.ToUpperInvariant() switch
    {   
        //TODO: Check if the log level is valid
        "ERROR" => "❌",
        "WARNING" => "⚠️",
        "INFO" => "ℹ️",
        "DEBUG" => "🐞",
        _ => "ℹ️"
    };

    public static string GetBackground(string level) => level.ToUpperInvariant() switch
    {   
        //TODO: Check if the log level is valid
        "ERROR" => "#FF0000",
        "WARNING" => "#FFA500",
        "INFO" => "#00FF00",
        "DEBUG" => "#0000FF",
        _ => "#FFFFFF"
    };

    public string GetStatusIcon(int statusCode) => statusCode switch
    {   
        //TODO: Add more status codes and their corresponding icons
        200 => "✅",
        404 => "❌",
        500 => "❌",
        _ => "ℹ️"
    };
    
    public string GetOperationIcon(string operation) => operation.ToUpperInvariant() switch
    {   
        //TODO: Add more operations and their corresponding icons
        "INSTALL" => "📦",
        "UNINSTALL" => "🗑️",
        "UPDATE" => "🔄",
        _ => "ℹ️"
    };
}