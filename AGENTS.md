# AGENTS.md

## Build & Run Commands

- **Build Release**: `dotnet build -c Release` (from TailSlap directory)
- **Publish**: `dotnet publish -c Release` → output in `TailSlap\bin\Release\net9.0-windows\win-x64\publish\`
- **Run**: `TailSlap\bin\Release\net9.0-windows\win-x64\publish\TailSlap.exe`
- **Self-contained build** (single file, ~80MB): `dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true`

## Architecture

- **Single WinForms desktop app** (.NET 9, net9.0-windows)
- **Tray-only UI**: Hidden main form, runs as system tray icon with context menu
- **Core Services**:
  - `TextRefiner`: OpenAI-compatible LLM HTTP client with retry logic (2 attempts, 1s backoff)
  - `ClipboardService`: Clipboard operations via Win32 P/Invoke
  - `ConfigService`: JSON config in `%APPDATA%\TailSlap\` with validation
  - `Dpapi`: Windows DPAPI encryption for API keys
  - `AutoStartService`: Registry-based Windows startup
  - `Logger`: File logging to `%APPDATA%\TailSlap\app.log`
- **Single-instance mutex** prevents multiple app instances
- **Global hotkey registration** (default Ctrl+Alt+R)
- **Animated tray icon** (3-frame animation) during LLM processing

## Code Style & Conventions

- **Language**: C# 12 (.NET 9) with nullable reference types enabled (`<Nullable>enable</Nullable>`)
- **Implicit usings** enabled (`<ImplicitUsings>enable</ImplicitUsings>`)
- **Naming**: PascalCase for public members, `_camelCase` for private fields
- **Classes**: Sealed by default (`sealed class`), internal statics where appropriate
- **JSON**: System.Text.Json with `PropertyNamingPolicy.CamelCase`
- **Error handling**: Explicit try-catch blocks with graceful fallbacks; avoid null refs
- **Async**: Prefer `async/await` with `ConfigureAwait(false)` for UI deadlock safety
- **P/Invoke**: Declared in MainForm and ClipboardService with `DllImport` attributes
- **Validation**: Static helper methods in ConfigService (IsValidUrl, IsValidTemperature, etc.)
- **Logging**: Wrap all logging in try-catch to prevent crashes if log write fails
- **No external NuGet dependencies**: Only built-in .NET libraries
