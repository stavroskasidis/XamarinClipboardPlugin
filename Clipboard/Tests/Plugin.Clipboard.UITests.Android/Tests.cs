using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;
using System.Threading.Tasks;

namespace Plugin.Clipboard.UITests.Android
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp _app;
        Platform _platform;
        public Tests(Platform platform)
        {
            _platform = platform;
        }


        [SetUp]
        public void BeforeEachTest()
        {
            _app = AppInitializer.StartApp(_platform);
        }

        [Test]
        public async Task SetGetClipboard_RoundtripCase_ResultIsCorrect()
        {
            _app.Tap(x => x.Text("Run Tests"));
            await Task.Delay(1000);
            var query = _app.Query(x => x.Text("Passed"));

            Assert.Greater(query.Length, 0, "Tests not passed");
        }
    }
}

