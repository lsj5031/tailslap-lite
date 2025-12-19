using System;

public sealed class HistoryEntry
{
    public DateTime Timestamp { get; set; }
    public string Model { get; set; } = "";
    public string OriginalCiphertext { get; set; } = "";
    public string RefinedCiphertext { get; set; } = "";
}

public sealed class TranscriptionHistoryEntry
{
    public DateTime Timestamp { get; set; }
    public string TextCiphertext { get; set; } = "";
    public int RecordingDurationMs { get; set; }
}
