using Plugin.Clipboard.Abstractions;
using System;

namespace Plugin.Clipboard
{
    /// <summary>
    /// Cross platform Clipboard implemenations
    /// </summary>
    public class CrossClipboard
    {
        static Lazy<IClipboard> Implementation = new Lazy<IClipboard>(() => CreateClipboard(), System.Threading.LazyThreadSafetyMode.PublicationOnly);

        /// <summary>
        /// Current settings to use
        /// </summary>
        public static IClipboard Current
        {
            get
            {
                var ret = Implementation.Value;
                if (ret == null)
                {
                    throw NotImplementedInReferenceAssembly();
                }
                return ret;
            }
            set
            {
                Implementation = new Lazy<IClipboard>(() => value, System.Threading.LazyThreadSafetyMode.PublicationOnly);
            }
        }

        static IClipboard CreateClipboard()
        {
#if NETSTANDARD1_0
            return null;
#else
        return new ClipboardImplementation();
#endif
        }

        internal static Exception NotImplementedInReferenceAssembly()
        {
            return new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
        }
    }
}
