using System;
using Plugin.Clipboard;
using AppKit;
using Foundation;

namespace Plugin.Clipboard.Tests.Mac
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
            CrossClipboard.Current.SetText("test !!");
            var result = CrossClipboard.Current.GetTextAsync().Result;
            if(result != "test !!")
            {
                throw new Exception();
            }
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}
