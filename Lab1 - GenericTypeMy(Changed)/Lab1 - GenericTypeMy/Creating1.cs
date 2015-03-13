// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Creating1.cs" company="GRSU">
//   LAB 1
// </copyright>
// <summary>
//   Defines the Creating1 type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Lab1___GenericTypeMy
{
    /// <summary>
    /// Create the car.
    /// </summary>
    public class Creating1 : IDescriptor1<Car>
    {
        /// <summary>
        /// The create car.
        /// </summary>
        /// <returns>
        /// The <see cref="Car"/>.
        /// </returns>
        public Car CreateCar()
        {
            return new Car();
        }
    }
}
