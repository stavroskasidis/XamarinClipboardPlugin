using Android.App;
using Android.Content;
using Plugin.Clipboard.Abstractions;
using System;
using System.Threading.Tasks;


namespace Plugin.Clipboard
{
    /// <summary>
    /// Implementation for Feature
    /// </summary>
    public class ClipboardImplementation : IClipboard
    {

        public string GetText()
        {
            return GetTextInternal();
        }

        public Task<string> GetTextAsync()
        {
            return Task.FromResult(GetTextInternal());
        }

        private string GetTextInternal()
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