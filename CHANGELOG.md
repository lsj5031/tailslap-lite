# Changelog

All notable changes to TailSlap will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [1.6.3] - 2026-01-03

### Fixed
- Real-time streaming: optimize memory usage and improve type safety
- WebSocket streaming: stabilize transport logic and text synchronization
- Voice Activity Detection: improve reliability and accuracy
- Code formatting across multiple files for consistency

### Changed
- Updated documentation with real-time transcription and VAD details

## [1.6.2] - 2025-12-25

### Fixed
- Build configuration and deployment issues
- Updated project dependencies and build scripts

## [1.6.1] - 2025-12-20

### Changed
- Improved hotkey defaults for better user experience
- Enhanced configuration handling and validation
- Updated user interface elements for better usability

## [1.6.0] - 2025-12-19

### Changed
- Updated AGENTS.md with modernized architecture details
- Improved documentation structure and clarity

## [1.5.0] - 2025-12-19

### Added
- Enhanced system tray functionality
- Improved configuration management
- Better error handling and user feedback

## [1.4.1] - 2025-12-19

### Fixed
- Animation table corrected to match 8 frames with 8 columns
- Icon loading improvements for better visual consistency
- Documentation updates for animation system

### Changed
- Improved code formatting for better readability
- Enhanced TryLoadIco method calls with proper line breaks

## [1.3.4] - 2025-12-18

### Changed
- Major code style and documentation cleanup across all services
- Improved code organization and consistency

## [1.3.3] - 2025-12-18

### Added
- Transcription history support with encrypted storage
- Enhanced history management features

### Changed
- Improved transcription workflow and user experience

## [1.3.2] - 2025-12-18

### Fixed
- Resolved AudioRecorder syntax errors
- Implemented proper audio recording loop
- Enhanced audio recording stability and error handling

## [1.3.1] - 2025-12-17

### Added
- Audio transcription support with configurable hotkey (Ctrl+Alt+T)
- Real-time streaming transcription with WebSocket support (Ctrl+Alt+Y)
- Remote transcription service integration (OpenAI-compatible endpoints)
- Audio recording functionality using Windows Multimedia API (WinMM)
- Voice Activity Detection (VAD) with configurable silence threshold
- Transcription history form for viewing and managing transcribed audio
- Microphone recording with 16-bit mono, 16kHz WAV output
- Configurable transcription endpoint and API key settings
- Transcription history management with clear functionality
- WebSocket streaming with 500ms buffer aggregation for optimal performance
- Microphone device selection support

### Fixed
- AudioRecorder.cs syntax errors and proper recording loop implementation
- Enhanced audio recording stability and error handling

## [1.3.0] - 2025-12-16

### Added
- Real-time WebSocket streaming transcription client
- Enhanced audio recording with Voice Activity Detection
- Configurable silence detection threshold (default: 2000ms)
- Microphone device selection and management
- 500ms audio buffer aggregation for streaming optimization
- Separate hotkey for streaming transcription (Ctrl+Alt+Y)
- WebSocket URL auto-construction from HTTP endpoints
- Enhanced error handling for audio recording failures

## [1.1.0] - 2025-12-16

### Added
- Single-file EXE distribution with embedded icons
- Continuous tray icon animation during text processing (8 frames, 75ms intervals)
- Enhanced clipboard handling with Ctrl+C fallback mechanism
- UI Automation stability improvements with timeout and cleanup
- Dependency injection container with service registration
- HTTP Client Factory with connection pooling and compression
- SHA256 fingerprinting for secure logging
- ETW diagnostics integration for performance monitoring

## [1.0.2] - 2025-12-18

### Added
- Transcription history support (same as v1.3.3)

## [1.0.1] - 2025-12-17

### Added
- Audio transcription features (same as v1.3.1)

## [1.0.0] - 2025-11-24

### Added
- System tray integration with animated context menu
- Global hotkey registration for three functions (Refinement, Transcription, Streaming)
- Text refinement via OpenAI-compatible LLM endpoints with retry logic
- Support for local (Ollama) and cloud (OpenAI, OpenRouter, etc.) LLM providers
- Automatic clipboard capture with intelligent fallback mechanisms
- Customizable hotkey configuration with validation
- Windows startup integration via registry (auto-start on boot)
- JSON configuration file support with hot reloading (`%APPDATA%\TailSlap\config.json`)
- Windows DPAPI encryption for API keys and history data
- Retry logic with exponential backoff (2 attempts, 1s backoff)
- Configurable timeout for LLM requests (30 seconds default)
- Smooth animated tray icon during processing (8 frames, 75ms intervals)
- Secure file logging with SHA256 fingerprinting (`%APPDATA%\TailSlap\app.log`)
- Balloon tip notifications for success/error/warning feedback
- Single-instance mutex to prevent multiple app instances
- No external NuGet dependencies (built-in .NET libraries only)
- High DPI awareness with PerMonitorV2 support
- Global exception handling for UI and non-UI exceptions

### Technical Details
- Built with .NET 9, Windows Forms, and WPF support
- Targets Windows 10 and later with high DPI awareness
- Framework-dependent distribution (~156 KB executable)
- Self-contained build available (~80 MB single file)
- Dependency Injection with Microsoft.Extensions.DependencyInjection
- HTTP Client Factory with connection pooling (5 min lifetime) and automatic compression
- Windows DPAPI encryption with DataProtectionScope.CurrentUser
- WinMM API integration for professional audio recording
- WebSocket client for real-time bi-directional streaming
- ETW EventSource with 14 events across 7 diagnostic categories
- 8-frame tray icon animation with 75ms intervals and 300ms tooltip pulses

## Future Considerations

### Potential Additions
- Refinement history with search and export capabilities
- Multiple hotkey profiles for different workflows
- Custom system prompts and template management
- Batch refinement for multiple text selections
- Cross-platform support (Linux/macOS via .NET MAUI)
- Plugin architecture for custom LLM providers
- Voice commands for hands-free operation
- Advanced audio processing (noise reduction, echo cancellation)
- Real-time collaboration features
- Cloud synchronization for settings and history
