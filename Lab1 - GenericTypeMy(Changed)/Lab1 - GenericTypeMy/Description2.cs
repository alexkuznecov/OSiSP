// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Description2.cs" company="GRSU">
//   LAB 1
// </copyright>
// <summary>
//   Defines the Description2 type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Lab1___GenericTypeMy
{
    /// <summary>
    /// The description 2.
    /// </summary>
    public class Description2 : IDescriptor<Hatchback>
    {
        /// <summary>
        /// Get description.
        /// </summary>
        /// <param name="hatchback">
        /// For hatchback.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int GetDescription(Hatchback hatchback)
        {
            return hatchback.Model + hatchback.WipersCount;
        }
    }
}
