## Clipboard Plugin for Xamarin and Windows

Simple cross platform plugin to read and write to the clipboard.

### Setup
* Available on NuGet: https://www.nuget.org/packages/Xamarin.Plugins.Clipboard/
* Install into your PCL project and Client projects.


### Supports
* Xamarin.Android
* Xamarin.iOS
* Windows 10 UWP

### API Usage

Call **CrossClipboard.Current** from any project or PCL to gain access to APIs.

```csharp

//To set the clipboard
CrossClipboard.Current.SetText("my clipboard text");

//To read the clipboard
string clipboardText = CrossClipboard.Current.GetText();

```

### Using in unit tests

```C#
//Create mock with LightMock (https://github.com/seesharper/LightMock)
var mockClipboardContext = new MockContext<IClipboard>();
var mockClipboard = new CrossClipboardMock(mockClipboardContext);

CrossClipboard.Current = mockClipboard;
```

