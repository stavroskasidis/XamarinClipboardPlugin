using Plugin.Clipboard.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.DataTransfer;

namespace Plugin.Clipboard
{
    /// <summary>
    /// Implementation for Feature
    /// </summary>
    public class ClipboardImplementation : IClipboard
    {
        public string GetText()
        {
            return GetTextInternal().Result;
        }

        public Task<string> GetTextAsync()
        {
            return GetTextInternal();
        }

        private Task<string> GetTextInternal()
        {
            var dataPackageView = Windows.ApplicationModel.DataTransfer.Clipboard.GetContent();
            if (dataPackageView.Contains(StandardDataFormats.Text))
            {
                return dataPackageView.GetTextAsync().AsTask();
            }
            return null;
        }

        public void SetText(string data)
        {
            var dataPackage = new DataPackage();
            dataPackage.SetText(data);
            Windows.ApplicationModel.DataTransfer.Clipboard.SetContent(dataPackage);
        }

       
    }
}