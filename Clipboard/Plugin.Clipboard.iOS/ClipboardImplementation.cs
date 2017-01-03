using Plugin.Clipboard.Abstractions;
using System;
using UIKit;

namespace Plugin.Clipboard
{
    /// <summary>
    /// Implementation for Clipboard
    /// </summary>
    public class ClipboardImplementation : IClipboard
    {
        public string GetText()
        {
            UIPasteboard clipboard = UIPasteboard.General;
            return clipboard.String;
        }

        public void SetText(string data)
        {
            UIPasteboard clipboard = UIPasteboard.General;
            clipboard.String = data;
        }
    }
}