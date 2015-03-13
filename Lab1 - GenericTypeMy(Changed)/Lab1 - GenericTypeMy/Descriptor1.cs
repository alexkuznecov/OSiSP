// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Descriptor1.cs" company="GRSU">
//   LAB 1
// </copyright>
// <summary>
//   Defines the Descriptor1 type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Lab1___GenericTypeMy
{
    /// <summary>
    /// The descriptor 1.
    /// </summary>
    public class Descriptor1 : IDescriptor<Car>
    {
        /// <summary>
        /// Get description.
        /// </summary>
        /// <param name="car">
        /// For car.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int GetDescription(Car car)
        {
            return car.Model;
        }
    }
}
