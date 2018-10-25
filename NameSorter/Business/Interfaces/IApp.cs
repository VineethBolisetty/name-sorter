using System.Collections.Generic;
using NameSorter.Models.Interfaces;

namespace NameSorter.Business.Interfaces
{
    /// <summary>
    /// The App.
    /// </summary>
    interface IApp
    {
        /// <summary>
        /// Reads the names from file.
        /// </summary>
        /// <returns>The names from file.</returns>
        /// <param name="filePath">File path.</param>
        IEnumerable<IName> ReadNamesFromFile(string filePath);

        /// <summary>
        /// Writes the names to file.
        /// </summary>
        /// <param name="filePath">File path.</param>
        /// <param name="names">Names.</param>
        void WriteNamesToFile(string filePath, IEnumerable<IName> names);

        /// <summary>
        /// Sorts the names by last name and then by given names.
        /// </summary>
        /// <returns>The names sorted by last name and then by given names.</returns>
        /// <param name="names">Names.</param>
        IEnumerable<IName> SortNamesByLastNameAndThenByGivenNames(IEnumerable<IName> names);

        /// <summary>
        /// Run the App by reading lines from file, sort and then write to console ans file
        /// </summary>
        /// <param name="unsortedNamesFilePath">Unsorted names file path.</param>
        /// <param name="sortedNamesFilePath">Sorted names file path.</param>
        void Run(string unsortedNamesFilePath, string sortedNamesFilePath);
    }
}
