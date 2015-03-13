// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Creating2.cs" company="GRSU">
//   LAB 1
// </copyright>
// <summary>
//   Defines the Creating2 type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Lab1___GenericTypeMy
{
    /// <summary>
    /// Create the hatchback.
    /// </summary>
    public class Creating2 : IDescriptor1<Hatchback>
    {
        /// <summary>
        /// Create hatchback.
        /// </summary>
        /// <returns>
        /// The <see cref="Hatchback"/>.
        /// </returns>
        public Hatchback CreateCar()
        {
            return new Hatchback();
        }
    }
}
