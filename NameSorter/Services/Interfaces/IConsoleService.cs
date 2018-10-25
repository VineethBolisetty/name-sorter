using System;

namespace NameSorter.Services.Interfaces
{
    /// <summary>
    /// Interface for read and write operations on console
    /// </summary>
    interface IConsoleService
    {
        /// <summary>
        /// Reads the key.
        /// </summary>
        /// <returns>The key.</returns>
        ConsoleKeyInfo ReadKey();

        /// <summary>
        /// Reads the line from console.
        /// </summary>
        /// <returns>The line.</returns>
        string ReadLine();

        /// <summary>
        /// Write the specified text to console.
        /// </summary>
        /// <param name="text">Text.</param>
        void Write(string text);

        /// <summary>
        /// Writes the line to the console.
        /// </summary>
        /// <param name="text">Text.</param>
        void WriteLine(string text);
    }
}
