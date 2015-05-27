// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataContext.cs" company="GRSU">
//   System Support Medical Station
// </copyright>
// <summary>
//   Defines the DataContext type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace kuznecov.SystemSuportMedicalStation.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Linq;

    using kuznecov.SystemSuportMedicalStation.model;

    /// <summary>
    /// The data context.
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// Gets or sets the calls.
        /// </summary>
        public DbSet<Call> Calls { get; set; }

        /// <summary>
        /// Gets or sets the doctors.
        /// </summary>
        public DbSet<Doctor> Doctors { get; set; }

        /// <summary>
        /// Gets or sets the medical cars.
        /// </summary>
        public DbSet<MedicalCar> MedicalCars { get; set; }

        /// <summary>
        /// Gets or sets the patients.
        /// </summary>
        public DbSet<Patient> Patients { get; set; }

        /// <summary>
        /// Gets or sets the waybills.
        /// </summary>
        public DbSet<Waybill> Waybills { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataContext"/> class.
        /// </summary>
        public DataContext()
            : base("SSMSDataBase")
        {
        }

        /// <summary>
        /// The on model creating.
        /// </summary>
        /// <param name="modelBuilder">
        /// The model builder.
        /// </param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Type[] types =
                GetType()
                    .Assembly.GetTypes()
                    .Where(
                        x =>
                        x.BaseType != null && x.BaseType.IsGenericType
                        && x.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>))
                    .ToArray();
            foreach (var type in types)
            {
                dynamic obj = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(obj);
            }    
            base.OnModelCreating(modelBuilder);
        }
    }
}
