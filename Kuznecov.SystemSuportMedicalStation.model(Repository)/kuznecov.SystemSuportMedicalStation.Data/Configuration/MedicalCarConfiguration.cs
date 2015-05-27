// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MedicalCarConfiguration.cs" company="GRSU">
//   System Support Medical Station
// </copyright>
// <summary>
//   Defines the MedicalCarConfiguration type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace kuznecov.SystemSuportMedicalStation.Data.Configuration
{
    using System.Data.Entity.ModelConfiguration;

    using kuznecov.SystemSuportMedicalStation.model;

    /// <summary>
    /// The medical car configuration.
    /// </summary>
    public class MedicalCarConfiguration : EntityTypeConfiguration<MedicalCar>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MedicalCarConfiguration"/> class.
        /// </summary>
        public MedicalCarConfiguration()
        {
            HasKey(m => m.Id).Property(m => m.Id).HasColumnName("MedicalCarId");

            Property(m => m.Model).HasMaxLength(40);

            Property(m => m.Vin).HasMaxLength(12);

            HasMany(m => m.Waybills).WithRequired(m => m.Car).WillCascadeOnDelete(false);
        }
    }
}
