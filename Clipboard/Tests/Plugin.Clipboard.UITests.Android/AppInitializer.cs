using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;

namespace Plugin.Clipboard.UITests.Android
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
#if DEBUG
                string config = "Debug";
#else
                string config = "Release";
#endif

                return ConfigureApp
                    .Android
                    .ApkFile($@"..\..\..\..\TestProjects\Plugin.Clipboard.Tests.Android\bin\{config}\Plugin.Clipboard.Tests.Android.apk")
                    .StartApp();
            }

            return ConfigureApp
                .iOS
                .StartApp();
        }
    }
}
