using System;

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
        string GetText();
  }
}
