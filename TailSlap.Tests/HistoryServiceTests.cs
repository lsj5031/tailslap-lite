using System;
using System.Collections.Generic;
using Xunit;

public class HistoryServiceTests
{
    [Fact]
    public void HistoryService_CreatesInstance()
    {
        // Arrange & Act
        var service = new HistoryService();

        // Assert
        Assert.NotNull(service);
    }

    [Fact]
    public void ReadAll_ReturnsValidList()
    {
        // Arrange
        var service = new HistoryService();

        // Act
        var history = service.ReadAll();

        // Assert
        Assert.NotNull(history);
        Assert.IsType<List<(DateTime, string, string, string)>>(history);
    }

    [Fact]
    public void ReadAllTranscriptions_ReturnsValidList()
    {
        // Arrange
        var service = new HistoryService();

        // Act
        var history = service.ReadAllTranscriptions();

        // Assert
        Assert.NotNull(history);
        Assert.IsType<List<(DateTime, string, int)>>(history);
    }

    [Fact]
    public void ClearAll_DoesNotThrow()
    {
        // Arrange
        var service = new HistoryService();

        // Act & Assert - should not throw
        service.ClearAll();
    }

    [Fact]
    public void Append_ValidInputs_DoesNotThrow()
    {
        // Arrange
        var service = new HistoryService();

        // Act & Assert - should not throw
        service.Append("original text", "refined text", "gpt-4o");
    }

    [Fact]
    public void Append_EmptyInputs_DoesNotThrow()
    {
        // Arrange
        var service = new HistoryService();

        // Act & Assert - should not throw
        service.Append("", "", "gpt-4o");
    }

    [Fact]
    public void AppendTranscription_ValidInputs_DoesNotThrow()
    {
        // Arrange
        var service = new HistoryService();

        // Act & Assert - should not throw
        service.AppendTranscription("transcribed text", 5000);
    }

    [Fact]
    public void AppendTranscription_EmptyText_DoesNotThrow()
    {
        // Arrange
        var service = new HistoryService();

        // Act & Assert - should not throw
        service.AppendTranscription("", 0);
    }
}
