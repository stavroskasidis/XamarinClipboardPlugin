using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using Windows.UI.Core;

namespace Plugin.Clipboard.Tests.UWP
{
    [TestClass]
    public class ClipboardTests
    {

        [TestMethod]
        public void UWP_SetGetClipboard_RoundtripCase_ResultIsCorrect()
        {
            Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                 // Arrange
                 var text = "test string";

                 // Act
                 CrossClipboard.Current.SetText(text);
                 var actual = CrossClipboard.Current.GetTextAsync().Result;

                 // Assert
                 Assert.AreEqual(text, actual);
            }).AsTask().Wait();
        }
    }
}