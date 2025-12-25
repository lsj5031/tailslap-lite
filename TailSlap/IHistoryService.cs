using System;
using System.Collections.Generic;

public interface IHistoryService
{
    void Append(string original, string refined, string model);
    List<(DateTime Timestamp, string Model, string Original, string Refined)> ReadAll();
    void AppendTranscription(string text, int recordingDurationMs);
    List<(DateTime Timestamp, string Text, int RecordingDurationMs)> ReadAllTranscriptions();
    void ClearRefinementHistory();
    void ClearTranscriptionHistory();
    void ClearAll();
}
