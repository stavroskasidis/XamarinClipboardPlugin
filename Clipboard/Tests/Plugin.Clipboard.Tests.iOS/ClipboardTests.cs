using System;
using System.Threading.Tasks;
using NUnit.Framework;
using Foundation;

namespace Plugin.Clipboard.Tests.iOS
{
    [TestFixture]
    public class ClipboardTests
    {
        
        [Test]
        public void SetGetClipboard_RoundtripCase_ResultIsCorrect()
        {
            var invoker = new NSObject();
            invoker.InvokeOnMainThread(() =>
            {
                // Arrange
                var text = "test string";

                // Act
                CrossClipboard.Current.SetText(text);
                var actual = CrossClipboard.Current.GetTextAsync().Result;

                // Assert
                Assert.AreEqual(text, actual);
            });
        }
    }
}