using System;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Plugin.Clipboard.Tests.Android
{
    [TestFixture]
    public class ClipboardTests
    {
        
        [Test]
        public void SetGetClipboard_RoundtripCase_ResultIsCorrect()
        {
            // Arrange
            var text = "test string";

            // Act
            CrossClipboard.Current.SetText(text);
            var actual = CrossClipboard.Current.GetTextAsync().Result;
            
            // Assert
            Assert.AreEqual(text, actual);
        }

    }
}