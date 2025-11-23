# TailSlap

<div align="center">
  <img src="TailSlap/Icons/TailSlap.ico" alt="TailSlap Logo" width="128" height="128">
  
  **A Windows utility that enhances your clipboard and text refinement experience with AI-powered processing.**
  
  TailSlap runs in the system tray and allows you to quickly refine selected text using LLM services.
</div>

## Features

- **Text Refinement**: Process and enhance selected text with a hotkey
- **Clipboard Integration**: Automatically paste refined text back into your applications
- **Customizable Hotkeys**: Set your preferred keyboard shortcut for text refinement
- **History**: View and manage your refinement history
- **System Tray Integration**: Runs quietly in the background
- **Auto-start Option**: Launch on Windows startup

## Installation

1. Download the latest release from the [releases page](https://github.com/tailslap/TailSlap/releases)
2. Extract the portable version or run the self-contained executable
3. The application will start automatically and appear in your system tray

### Requirements

- **Windows 10 or later**
- **.NET 9 Runtime** (download from [dotnet.microsoft.com](https://dotnet.microsoft.com/download/dotnet/9.0)) - not needed if using self-contained build
- **Internet connection** for LLM processing (local Ollama doesn't require internet)

## Usage

1. Select text in any application
2. Press the configured hotkey (default: `Ctrl+Alt+R`)
3. The text will be processed and automatically pasted back (if enabled)

### System Tray Menu

Right-click the TailSlap icon in the system tray to access:
- **Refine Now**: Process the currently selected text immediately
- **Auto Paste**: Toggle automatic pasting of refined text to your clipboard
- **Change Hotkey**: Set a custom keyboard shortcut (interactive capture)
- **Settings...**: Configure LLM endpoint, model, temperature, and other preferences
- **Open Logs...**: View application logs for debugging
- **History...**: View and clear your refinement history
- **Start with Windows**: Toggle automatic startup with Windows
- **Quit**: Exit the application

## Configuration

Configuration is stored in a JSON file located at:
`%APPDATA%\TailSlap\config.json`

You can edit this file directly or use the Settings dialog in the system tray menu.

## Logs

Application logs are stored at:
`%APPDATA%\TailSlap\app.log`

## Animation

TailSlap uses a cute animated icon that cycles through different "chewing" frames while processing text:

| Idle | Processing 1 | Processing 2 | Processing 3 | Processing 4 |
|------|--------------|--------------|--------------|--------------|
| ![Idle](TailSlap/Icons/TailSlap.ico) | ![Chew1](TailSlap/Icons/Chewing1.ico) | ![Chew2](TailSlap/Icons/Chewing2.ico) | ![Chew3](TailSlap/Icons/Chewing3.ico) | ![Chew4](TailSlap/Icons/Chewing4.ico) |

The animation plays with pulsing text ("TailSlap - Processing...") during LLM requests to give you visual feedback.

## Building from Source

1. Clone the repository: `git clone https://github.com/tailslap/TailSlap.git`
2. Install [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
3. Build: `dotnet build -c Release`
4. Publish: `dotnet publish -c Release`

Output: `TailSlap\bin\Release\net9.0-windows\win-x64\publish\TailSlap.exe`

For a self-contained single-file build (~80MB):
```bash
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
```

See [AGENTS.md](AGENTS.md) for detailed architecture and development guidelines.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contributing

Contributions are welcome! Please see [CONTRIBUTING.md](CONTRIBUTING.md) for guidelines on:
- How to report issues
- How to submit pull requests
- Code style and conventions
- Development setup

## Support

- **Issues**: [GitHub Issues](https://github.com/tailslap/TailSlap/issues)
- **Discussions**: [GitHub Discussions](https://github.com/tailslap/TailSlap/discussions)
- **Logs**: Check `%APPDATA%\TailSlap\app.log` for debugging

## Build Status

![Build](https://github.com/tailslap/TailSlap/actions/workflows/build.yml/badge.svg)

All commits and pull requests are automatically built and tested via GitHub Actions.

## Acknowledgments

Built with [.NET 9](https://dotnet.microsoft.com/) and [Windows Forms](https://docs.microsoft.com/windows-forms/)
