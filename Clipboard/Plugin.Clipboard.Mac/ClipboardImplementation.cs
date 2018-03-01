using Plugin.Clipboard.Abstractions;
using System;
using System.Threading.Tasks;
using AppKit;
using Foundation;

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

        private readonly string[] pboardTypes = { "NSStringPboardType" };

        private string GetTextInternal()
        {
            var pasteboard = NSPasteboard.GeneralPasteboard;
            return pasteboard.GetStringForType(pboardTypes[0]);
        }


        public void SetText(string data)
        {
            var pasteboard = NSPasteboard.GeneralPasteboard;
            pasteboard.DeclareTypes(pboardTypes, null);
            pasteboard.SetStringForType(data, pboardTypes[0]);
        }

       
    }
}