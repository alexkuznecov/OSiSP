// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MountainBike.cs" company="GRSU">
//   LAB 2
// </copyright>
// <summary>
//   Class for mountain bike.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Lab_2
{
    /// <summary>
    /// Class for mountain bike.
    /// </summary>
    [AlternateName(Name = "MB")]
    public class MountainBike : Bicycle
    {
        /// <summary>
        /// Gets or sets the shock absorber count.
        /// </summary>
        public int ShockAbsorberCount { get; set; }
    }
}
