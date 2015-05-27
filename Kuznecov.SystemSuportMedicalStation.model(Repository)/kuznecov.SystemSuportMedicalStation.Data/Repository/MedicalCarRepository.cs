// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MedicalCarRepository.cs" company="GRSU">
//   System Support Medical Station
// </copyright>
// <summary>
//   Defines the MedicalCarRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace kuznecov.SystemSuportMedicalStation.Data.Repository
{
    using kuznecov.SystemSuportMedicalStation.model;
    using kuznecov.SystemSuportMedicalStation.model.Repository;

    /// <summary>
    /// The medical car repository.
    /// </summary>
    public class MedicalCarRepository : BaseRepository<MedicalCar>, IMedicalCarRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MedicalCarRepository"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public MedicalCarRepository(DataContext context)
            : base(context)
        {
        }
    }
}
