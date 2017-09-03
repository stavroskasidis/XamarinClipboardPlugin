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

        public async Task<string> GetText()
        {
            return await Task.Run(() => GetClipboard());
        }
        public string GetClipboard()
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