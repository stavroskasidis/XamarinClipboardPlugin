using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;
using System.Threading.Tasks;
using System.Reflection;

namespace Plugin.Clipboard.UITests.Android
{
    [TestFixture]
    public class Tests
    {
        IApp _app;


        [SetUp]
        public void BeforeEachTest()
        {
#if DEBUG
            string config = "Debug";
#else
            string config = "Release";
#endif
            var assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            _app = ConfigureApp
                .Android
                .ApkFile(Path.Combine(assemblyFolder, $@"..\..\..\..\TestProjects\Plugin.Clipboard.Tests.Android\bin\{config}\Plugin.Clipboard.Tests.Android.apk"))
                .StartApp();
        }

        [Test]
        public async Task Android_SetGetClipboard_RoundtripCase_ResultIsCorrect()
        {
            _app.Tap(x => x.Text("Run Tests"));
            await Task.Delay(5000);
            var query = _app.Query(x => x.Text("Passed"));

            Assert.Greater(query.Length, 0, "Tests not passed");
        }
    }
}

