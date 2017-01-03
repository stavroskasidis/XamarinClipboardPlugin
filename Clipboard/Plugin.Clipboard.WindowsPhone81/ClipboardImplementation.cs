using Plugin.Clipboard.Abstractions;
using System;


namespace Plugin.Clipboard
{
  /// <summary>
  /// Implementation for Clipboard
  /// </summary>
  public class ClipboardImplementation : IClipboard
  {
        public string GetText()
        {
            var dataPackage = Windows.ApplicationModel.DataTransfer.Clipboard.GetContent();
            return dataPackage.GetTextAsync().GetResults();
        }

        public void SetText(string data)
        {
            var dataPackage = new DataPackage();
            dataPackage.SetText(data);
            Windows.ApplicationModel.DataTransfer.Clipboard.SetContent(dataPackage);
        }
    }
}