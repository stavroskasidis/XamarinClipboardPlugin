using Plugin.Clipboard.Abstractions;
using System;
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

        private readonly Gdk.Atom clipboardAtom = Gdk.Atom.Intern("CLIPBOARD", false);

        private string GetTextInternal()
        {
            var clipboard = Gtk.Clipboard.Get(clipboardAtom);
            return clipboard.WaitForText();
        }

        public void SetText(string data)
        {
            var clipboard = Gtk.Clipboard.Get(clipboardAtom);
            clipboard.Text = data;
        }
    }
}