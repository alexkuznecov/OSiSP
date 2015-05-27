// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CallConfiguration.cs" company="GRSU">
//   System Support Medical Station
// </copyright>
// <summary>
//   Defines the CallConfiguration type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace kuznecov.SystemSuportMedicalStation.Data.Configuration
{
    using System.Data.Entity.ModelConfiguration;

    using kuznecov.SystemSuportMedicalStation.model;

    /// <summary>
    /// The call configuration.
    /// </summary>
    public class CallConfiguration : EntityTypeConfiguration<Call>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallConfiguration"/> class.
        /// </summary>
        public CallConfiguration()
        {
            HasKey(c => c.Id).Property(p => p.Id).HasColumnName("CallId");

            HasMany(c => c.Patient).WithRequired(c => c.Call).WillCascadeOnDelete(false);

            HasRequired(c => c.Waybill).WithMany(c => c.Calls).WillCascadeOnDelete(false);
            
        }
    }
}
