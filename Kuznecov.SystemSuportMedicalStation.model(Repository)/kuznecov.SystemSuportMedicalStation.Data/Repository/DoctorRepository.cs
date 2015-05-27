// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DoctorRepository.cs" company="GRSU">
//   System Support Medical Station
// </copyright>
// <summary>
//   Defines the DoctorRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace kuznecov.SystemSuportMedicalStation.Data.Repository
{
    using kuznecov.SystemSuportMedicalStation.model;
    using kuznecov.SystemSuportMedicalStation.model.Repository;

    /// <summary>
    /// The doctor repository.
    /// </summary>
    public class DoctorRepository : BaseRepository<Doctor>, IDoctorRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DoctorRepository"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public DoctorRepository(DataContext context)
            : base(context)
        {
        }
    }
}
