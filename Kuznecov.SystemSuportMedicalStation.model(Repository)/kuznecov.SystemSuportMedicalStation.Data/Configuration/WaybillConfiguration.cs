// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WaybillConfiguration.cs" company="GRSU">
//   System Support Medical Station
// </copyright>
// <summary>
//   Defines the WaybillConfiguration type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace kuznecov.SystemSuportMedicalStation.Data.Configuration
{
    using System.Data.Entity.ModelConfiguration;

    using kuznecov.SystemSuportMedicalStation.model;

    /// <summary>
    /// The waybill configuration.
    /// </summary>
    public class WaybillConfiguration : EntityTypeConfiguration<Waybill>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WaybillConfiguration"/> class.
        /// </summary>
        public WaybillConfiguration()
        {
            HasKey(w => w.Id).Property(w => w.Id).HasColumnName("WaybillId");
        }
    }
}
