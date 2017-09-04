using System;
using System.Threading.Tasks;

namespace Plugin.Clipboard.Abstractions
{
  /// <summary>
  /// Interface for Clipboard
  /// </summary>
  public interface IClipboard
  {
        /// <summary>
        /// Set's the clipboard text.
        /// </summary>
        /// <param name="text"></param>
        void SetText(string text);

        /// <summary>
        /// Gets the clipboard's text.
        /// </summary>
        /// <returns></returns>
        [Obsolete("Use the GetTextAsync() method")]
        string GetText();

        /// <summary>
        /// Gets the clipboard's text.
        /// </summary>
        /// <returns></returns>
        Task<string> GetTextAsync();
  }
}
