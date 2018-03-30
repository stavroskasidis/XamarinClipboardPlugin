using System;
using System.Diagnostics;
using Gtk;
using Plugin.Clipboard;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();

        var expected = "clipboard text";
        CrossClipboard.Current.SetText(expected);
        var actual = CrossClipboard.Current.GetTextAsync().Result;
        if (actual != expected) throw new Exception($"Expected '{expected}', actual '{actual}'");
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
