using Plugin.Clipboard.Abstractions;
using System.Threading.Tasks;

namespace Plugin.Clipboard
{
    /// <summary>
    /// Implementation for Clipboard
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

        public void SetText(string text)
        {
            System.Windows.Clipboard.SetText(text);
        }

        private string GetTextInternal()
        {
            if (System.Windows.Clipboard.ContainsText()) return System.Windows.Clipboard.GetText();
            else return null;
        }
    }
}
