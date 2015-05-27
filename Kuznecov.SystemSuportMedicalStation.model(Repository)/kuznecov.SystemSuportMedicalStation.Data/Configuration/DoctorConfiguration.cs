// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DoctorConfiguration.cs" company="GRSU">
//   System Support Medical Station
// </copyright>
// <summary>
//   Defines the DoctorConfiguration type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace kuznecov.SystemSuportMedicalStation.Data.Configuration
{
    using System.Data.Entity.ModelConfiguration;

    using kuznecov.SystemSuportMedicalStation.model;

    /// <summary>
    /// The doctor configuration.
    /// </summary>
    public class DoctorConfiguration : EntityTypeConfiguration<Doctor>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DoctorConfiguration"/> class.
        /// </summary>
        public DoctorConfiguration()
        {
            HasKey(d => d.Id).Property(d => d.Id).HasColumnName("DoctorId");

            Property(d => d.Name).HasMaxLength(30);

            Property(d => d.Surname).HasMaxLength(30);

            Property(d => d.Position).HasMaxLength(30);

            HasMany(d => d.Patients).WithRequired(d => d.Doctor).Map(p => p.MapKey("DoctorId")).WillCascadeOnDelete(false);

            HasMany(d => d.Car)
                .WithMany(d => d.Doctors)
                .Map(d => d.ToTable("DoctorMedicalCar").MapLeftKey("DoctorId").MapRightKey("MedicalCarId"));
        }
    }
}
