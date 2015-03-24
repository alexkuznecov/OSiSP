// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Car.cs" company="GRSU">
//   LAB 2
// </copyright>
// <summary>
//   The class for car.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Lab_2
{
    /// <summary>
    /// The class for car.
    /// </summary>
    [AlternateName(Name = "CA")]
    public class Car : IHaveEngine
    {
        /// <summary>
        /// The cylinder count.
        /// </summary>
        private readonly int cylinderCount;

        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="cylinderCount">
        /// The cylinder count.
        /// </param>
        public Car(int cylinderCount)
        {
            this.cylinderCount = cylinderCount;
        }

        /// <summary>
        /// Get cylinders count.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int GetCylindersCount()
        {
            return this.cylinderCount;
        }
    }
}
