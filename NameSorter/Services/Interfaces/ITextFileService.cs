using System.Collections.Generic;

namespace NameSorter.Services.Interfaces
{
    /// <summary>
    /// Interface for operations on text file
    /// </summary>
    interface ITextFileService
    {
        /// <summary>
        /// Read lines from a text file
        /// </summary>
        /// <returns>The lines.</returns>
        /// <param name="filePath">File path.</param>
        IEnumerable<string> ReadLines(string filePath);

        /// <summary>
        /// Write the text to the specified text file at filePath.
        /// Overrides the file if already exists
        /// </summary>
        /// <param name="filePath">File path.</param>
        /// <param name="text">Text.</param>
        void Write(string filePath, string text);

        /// <summary>
        /// Writes the lines of text to the specified text file at filePath.
        /// Overrides the file if already exists
        /// </summary>
        /// <param name="filePath">File path.</param>
        /// <param name="lines">Lines.</param>
        void WriteLines(string filePath, IEnumerable<string> lines);
    }
}
