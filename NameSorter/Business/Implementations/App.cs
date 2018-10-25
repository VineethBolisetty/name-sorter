using System.Collections.Generic;
using System.Linq;
using NameSorter.Business.Interfaces;
using NameSorter.Models.Implementations;
using NameSorter.Models.Interfaces;
using NameSorter.Services.Interfaces;

namespace NameSorter.Business.Implementations
{
    /// <summary>
    /// The App.
    /// </summary>
    class App : IApp
    {
        /// <summary>
        /// The text file service.
        /// </summary>
        private readonly ITextFileService _textFileService;

        /// <summary>
        /// The console service.
        /// </summary>
        private readonly IConsoleService _consoleService;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:NameSorter.Business.Implementations.App"/> class.
        /// </summary>
        /// <param name="textFileService">Text file service.</param>
        /// <param name="consoleService">Console service.</param>
        public App(ITextFileService textFileService, IConsoleService consoleService)
        {
            _textFileService = textFileService;
            _consoleService = consoleService;
        }

        /// <summary>
        /// Reads the names from file.
        /// </summary>
        /// <returns>The names from file.</returns>
        /// <param name="filePath">File path.</param>
        public IEnumerable<IName> ReadNamesFromFile(string filePath)
        {
            var names = _textFileService.ReadLines(filePath)
                                    .Select(line => new Name(line));
            return names;
        }

        /// <summary>
        /// Writes the names to file.
        /// </summary>
        /// <param name="filePath">File path.</param>
        /// <param name="names">Names.</param>
        public void WriteNamesToFile(string filePath, IEnumerable<IName> names)
        {
            var nameLines = names.Select(name => name.ToString());
            _textFileService.WriteLines(filePath, nameLines);
        }

        /// <summary>
        /// Sorts the names by last name and then by given names.
        /// </summary>
        /// <returns>The names sorted by last name and then by given names.</returns>
        /// <param name="names">Names.</param>
        public IEnumerable<IName> SortNamesByLastNameAndThenByGivenNames(IEnumerable<IName> names)
        {
            return names.OrderBy(name => name.LastName)
                .ThenBy(name => name.GivenNames);
        }

        /// <summary>
        /// Run the App by reading lines from file, sort and then write to console ans file
        /// </summary>
        /// <param name="unsortedNamesFilePath">Unsorted names file path.</param>
        /// <param name="sortedNamesFilePath">Sorted names file path.</param>
        public void Run(string unsortedNamesFilePath, string sortedNamesFilePath)
        {
            var unsortedNames = ReadNamesFromFile(unsortedNamesFilePath);
            var sortedNames = SortNamesByLastNameAndThenByGivenNames(unsortedNames);
            WriteNamesToFile(sortedNamesFilePath, sortedNames);
        }
    }
}
