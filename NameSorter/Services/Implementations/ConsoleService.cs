using System;
using NameSorter.Services.Interfaces;

namespace NameSorter.Services.Implementations
{
    /// <summary>
    /// Interface for read and write operations on console
    /// </summary>
    class ConsoleService : IConsoleService
    {
        /// <summary>
        /// Reads the key.
        /// </summary>
        /// <returns>The key.</returns>
        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }

        /// <summary>
        /// Reads the line from console.
        /// </summary>
        /// <returns>The line.</returns>
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        /// <summary>
        /// Write the specified text to console.
        /// </summary>
        /// <param name="text">Text.</param>
        public void Write(string text)
        {
            Console.Write(text);
        }

        /// <summary>
        /// Writes the line to the console.
        /// </summary>
        /// <param name="text">Text.</param>
        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
