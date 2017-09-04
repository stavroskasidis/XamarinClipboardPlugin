using Plugin.Clipboard.Abstractions;
using System;
using UIKit;
using System.Threading.Tasks;

namespace Plugin.Clipboard
{
    /// <summary>
    /// Implementation for Clipboard
    /// </summary>
    public class ClipboardImplementation : IClipboard
    {
        public Task<string> GetTextAsync()
        {
            return Task.FromResult(GetTextInternal());
        }

        public string GetText()
        {
            return GetTextInternal();
        }

        private string GetTextInternal()
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