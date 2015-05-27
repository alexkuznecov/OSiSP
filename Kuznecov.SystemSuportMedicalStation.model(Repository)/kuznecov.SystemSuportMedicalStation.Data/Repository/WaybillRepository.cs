// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WaybillRepository.cs" company="GRSU">
//   System Support Medical Station
// </copyright>
// <summary>
//   Defines the WaybillRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace kuznecov.SystemSuportMedicalStation.Data.Repository
{
    using kuznecov.SystemSuportMedicalStation.model;
    using kuznecov.SystemSuportMedicalStation.model.Repository;

    /// <summary>
    /// The waybill repository.
    /// </summary>
    public class WaybillRepository : BaseRepository<Waybill>, IWaybillRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WaybillRepository"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public WaybillRepository(DataContext context)
            : base(context)
        {
        }
    }
}
