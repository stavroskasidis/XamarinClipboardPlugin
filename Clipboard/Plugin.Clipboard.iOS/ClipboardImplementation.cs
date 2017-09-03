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

        public async Task<string> GetText()
        {
            return await Task.Run(() => GetClipboard());
        }
        public string GetClipboard()
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