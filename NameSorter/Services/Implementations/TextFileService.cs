using System.Collections.Generic;
using System.IO;
using NameSorter.Services.Interfaces;

namespace NameSorter.Services.Implementations
{
    /// <summary>
    /// Implementation of operations on text file
    /// </summary>
    class TextFileService : ITextFileService
    {
        /// <summary>
        /// Read lines from a text file
        /// </summary>
        /// <returns>The lines.</returns>
        /// <param name="filePath">File path.</param>
        public IEnumerable<string> ReadLines(string filePath)
        {
            return File.ReadAllLines(filePath);
        }

        /// <summary>
        /// Write the text to the specified text file at filePath.
        /// Overrides the file if already exists
        /// </summary>
        /// <param name="filePath">File path.</param>
        /// <param name="text">Text.</param>
        public void Write(string filePath, string text)
        {
            using(var fileStream = File.OpenWrite(filePath))
            using(var writer = new StreamWriter(fileStream))
            {
                writer.Write(text);
            }
        }

        /// <summary>
        /// Writes the lines of text to the specified text file at filePath.
        /// Overrides the file if already exists
        /// </summary>
        /// <param name="filePath">File path.</param>
        /// <param name="lines">Lines.</param>
        public void WriteLines(string filePath, IEnumerable<string> lines)
        {
            using(var fileStream = File.OpenWrite(filePath))
            using(var writer = new StreamWriter(fileStream))
            {
                foreach(var line in lines)
                    writer.WriteLine(line);
            }
        }
    }
}
