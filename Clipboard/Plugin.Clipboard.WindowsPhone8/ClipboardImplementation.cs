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
            return System.Windows.Clipboard.GetText();
        }

        public void SetText(string text)
        {
            System.Windows.Clipboard.SetText(text);
        }
    }
}