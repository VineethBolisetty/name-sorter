using System.Linq;
using NameSorter.Models.Interfaces;

namespace NameSorter.Models.Implementations
{
    /// <summary>
    /// Name of person.
    /// </summary>
    class Name : IName
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:NameSorter.Models.Implementations.Name"/> class.
        /// </summary>
        /// <param name="name">Name.</param>
        public Name(string name)
        {
            var nameParts = name.Split(' ');
            LastName = nameParts.Last();
            GivenNames = string.Join(' ', nameParts.Take(nameParts.Length - 1));
        }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the given names.
        /// </summary>
        /// <value>The given names.</value>
        public string GivenNames { get; set; }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:NameSorter.Models.Implementations.Name"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:NameSorter.Models.Implementations.Name"/>.</returns>
        public new string ToString()
        {
            return $"{GivenNames} {LastName}";
        }
    }
}
