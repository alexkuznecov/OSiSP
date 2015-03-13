// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDescriptor.cs" company="GRSU">
//   LAB 1
// </copyright>
// <summary>
//   Defines the IDescriptor type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Lab1___GenericTypeMy
{
    /// <summary>
    /// The Descriptor interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface IDescriptor<in T>
        where T : Car
    {
        /// <summary>
        /// The get description.
        /// </summary>
        /// <param name="deskr">
        /// The deskr.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        int GetDescription(T deskr);
    }
}
