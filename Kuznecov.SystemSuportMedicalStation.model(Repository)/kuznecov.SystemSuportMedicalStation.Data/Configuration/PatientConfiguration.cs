// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PatientConfiguration.cs" company="GRSU">
//   System Support Medical Station
// </copyright>
// <summary>
//   Defines the PatientConfiguration type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace kuznecov.SystemSuportMedicalStation.Data.Configuration
{
    using System.Data.Entity.ModelConfiguration;

    using kuznecov.SystemSuportMedicalStation.model;

    /// <summary>
    /// The patient configuration.
    /// </summary>
    public class PatientConfiguration : EntityTypeConfiguration<Patient>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientConfiguration"/> class.
        /// </summary>
        public PatientConfiguration()
        {
            HasKey(p => p.Id).Property(p => p.Id).HasColumnName("PatientId");

            Property(p => p.Name).HasMaxLength(30);

            Property(p => p.Surname).HasMaxLength(30);

            Property(p => p.PassportData).HasMaxLength(10);

            Property(p => p.PhoneNumber).HasMaxLength(10);
        }
    }
}
