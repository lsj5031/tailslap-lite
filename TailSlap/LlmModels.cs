using System.Collections.Generic;
using System.Text.Json.Serialization;

public sealed class ChatRequest
{
    public string Model { get; set; } = "";
    public List<Msg> Messages { get; set; } = new();
    public double Temperature { get; set; }

    [JsonPropertyName("max_tokens")]
    public int? MaxTokens { get; set; }
}

public sealed class Msg
{
    public string Role { get; set; } = "";
    public string Content { get; set; } = "";
}

public sealed class ChatResponse
{
    public List<Choice> Choices { get; set; } = new();

    public sealed class Choice
    {
        public ChoiceMsg Message { get; set; } = new();
    }

    public sealed class ChoiceMsg
    {
        public string Role { get; set; } = "";
        public string Content { get; set; } = "";
    }
}
