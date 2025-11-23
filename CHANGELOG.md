# Changelog

All notable changes to TailSlap will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [1.0.0] - 2025-11-23

### Added
- System tray integration with context menu
- Global hotkey registration (default: Ctrl+Alt+R)
- Text refinement via OpenAI-compatible LLM endpoints
- Support for local (Ollama) and cloud (OpenAI, OpenRouter, etc.) LLM providers
- Automatic clipboard capture and paste
- Customizable hotkey configuration
- Windows startup integration (auto-start on boot)
- Configuration file support (`%APPDATA%\TailSlap\config.json`)
- Windows DPAPI encryption for API keys
- Retry logic with exponential backoff (2 attempts, 1s backoff)
- 30-second timeout for LLM requests
- Animated tray icon during processing
- File logging to `%APPDATA%\TailSlap\app.log`
- Balloon notifications for success/error feedback
- Single-instance mutex to prevent multiple app instances
- No external NuGet dependencies (built-in .NET only)

### Technical Details
- Built with .NET 9 and WinForms
- Targets Windows 10 and later
- Framework-dependent distribution (156 KB executable)
- Optional self-contained build available (80 MB single file)

## Future Considerations

### Potential Additions
- Refinement history with save/load
- Multiple hotkey support
- Custom system prompts
- Batch refinement
- Cross-platform support (WPF backend)
