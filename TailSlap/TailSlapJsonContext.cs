using System.Text.Json.Serialization;

[JsonSourceGenerationOptions(
    WriteIndented = true,
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
)]
[JsonSerializable(typeof(AppConfig))]
[JsonSerializable(typeof(HistoryEntry))]
[JsonSerializable(typeof(TranscriptionHistoryEntry))]
[JsonSerializable(typeof(ChatRequest))]
[JsonSerializable(typeof(ChatResponse))]
internal partial class TailSlapJsonContext : JsonSerializerContext { }
