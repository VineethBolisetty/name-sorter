namespace NameSorter.Models.Interfaces
{
    /// <summary>
    /// Name of a person.
    /// </summary>
    interface IName
    {
        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        string LastName { get; set; }

        /// <summary>
        /// Gets or sets the given names.
        /// </summary>
        /// <value>The given names.</value>
        string GivenNames { get; set; }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:NameSorter.Models.Interfaces.IName"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:NameSorter.Models.Interfaces.IName"/>.</returns>
        string ToString();
    }
}
