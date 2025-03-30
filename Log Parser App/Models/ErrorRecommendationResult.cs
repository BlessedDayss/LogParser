using System.Collections.Generic;

namespace Log_Parser_App.Models;

public class ErrorRecommendationResult
{
    public string ErrorType { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public List<string> Recommendation { get; init; } = new List<string>();
}