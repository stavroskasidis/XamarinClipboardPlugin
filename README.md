## Clipboard Plugin for Xamarin, Windows & Gtk2

Simple cross platform plugin to read and write to the clipboard.

### Setup
* Available on NuGet: https://www.nuget.org/packages/Xamarin.Plugins.Clipboard/
* Install into your .NET Standard libraries and Client projects.


### Supports
* Xamarin.Android
* Xamarin.iOS
* Xamarin.Mac
* Windows 10 UWP
* Gtk# 2.12


### API Usage

Call **Plugin.Clipboard.CrossClipboard.Current** from any project or .NET Standard library to gain access to APIs.

```csharp
using Plugin.Clipboard;

...

//To set the clipboard
CrossClipboard.Current.SetText("my clipboard text");

//To read the clipboard
string clipboardText = await CrossClipboard.Current.GetTextAsync();

```

### Using in unit tests

```C#
//Create mock with LightMock (https://github.com/seesharper/LightMock)
var mockClipboardContext = new MockContext<IClipboard>();
var mockClipboard = new CrossClipboardMock(mockClipboardContext);

CrossClipboard.Current = mockClipboard;
```

