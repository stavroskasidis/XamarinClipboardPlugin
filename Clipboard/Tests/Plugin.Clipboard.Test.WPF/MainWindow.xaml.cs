using System;
using System.Windows;

namespace Plugin.Clipboard.Test.WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var expected = "clipboard text";
            CrossClipboard.Current.SetText(expected);
            var actual = CrossClipboard.Current.GetTextAsync().Result;
            if (actual != expected) throw new Exception($"Expected '{expected}', actual '{actual}'");
        }
    }
}
