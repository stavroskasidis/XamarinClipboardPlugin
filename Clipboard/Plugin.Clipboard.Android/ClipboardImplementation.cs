using Android.App;
using Android.Content;
using Plugin.Clipboard.Abstractions;
using System;


namespace Plugin.Clipboard
{
    /// <summary>
    /// Implementation for Feature
    /// </summary>
    public class ClipboardImplementation : IClipboard
    {
        public string GetText()
        {
            var clipboardManager = (ClipboardManager) Application.Context.GetSystemService(Context.ClipboardService);
            return clipboardManager.Text;
        }

        public void SetText(string data)
        {
            var clipboardManager = (ClipboardManager)Application.Context.GetSystemService(Context.ClipboardService);
            clipboardManager.Text = data;
        }
    }
}