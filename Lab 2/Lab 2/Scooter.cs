// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Scooter.cs" company="GRSU">
//   LAB 2
// </copyright>
// <summary>
//   The class for scooter.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Lab_2
{
    /// <summary>
    /// The class for scooter.
    /// </summary>
    [AlternateName(Name = "SC")]
    public class Scooter : Bicycle, IHaveEngine
    {
        /// <summary>
        /// The cylinder count.
        /// </summary>
        private readonly int cylinderCount;

        /// <summary>
        /// Initializes a new instance of the <see cref="Scooter"/> class.
        /// </summary>
        /// <param name="cylinderCount">
        /// The cylinder count.
        /// </param>
        public Scooter(int cylinderCount)
        {
            this.cylinderCount = cylinderCount;
        }

        /// <summary>
        /// Gets or sets the light count.
        /// </summary>
        public int LightCount { get; set; }

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
