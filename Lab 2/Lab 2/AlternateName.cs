// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AlternateName.cs" company="GRSU">
//   Lab2
// </copyright>
// <summary>
//   Defines the AlternateName type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Lab_2
{
    using System;

    /// <summary>
    /// The attribute for alternate name.
    /// </summary>
    public class AlternateName : Attribute
    {
        /// <summary>
        /// Gets or sets the name of attribute.
        /// </summary>
        public string Name { get; set; }
    }
}
