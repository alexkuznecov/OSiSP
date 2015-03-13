// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDescriptor1.cs" company="GRSU">
//   LAB 1
// </copyright>
// <summary>
//   Defines the IDescriptor1 type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Lab1___GenericTypeMy
{
    /// <summary>
    /// The Descriptor1 interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface IDescriptor1<out T>
        where T : Car
    {
        /// <summary>
        /// The create car.
        /// </summary>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        T CreateCar();
    }
}
