using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Log_Parser_App.Models;

public record ErrorRecommendation
{
    [JsonPropertyName("error_pattern")]
    public string ErrorPattern { get; init; } = string.Empty;
    
    [JsonPropertyName("error_type")]
    public string ErrorType { get; init; } = string.Empty;
    
    [JsonPropertyName("description")]
    public string Description { get; init; } = string.Empty;

    [JsonPropertyName("recommendation")] 
    public List<string> Recommendation { get; init; } = new List<string>();
    
}